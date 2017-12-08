using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Path = System.IO.Path;
using EscapistFetch;
using MessageBox = System.Windows.MessageBox;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace EscapistVideoSiphonerGUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CancellationTokenSource ctokensource = new CancellationTokenSource();
        private readonly PauseTokenSource ptokensource = new PauseTokenSource();
        private List<string> urls = new List<string>();
        private string targetpath;

        public MainWindow()
        {
            this.InitializeComponent();
            this.targetpath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\Escapist";
            this.targetdirtxtbx.Text = this.targetpath;
        }

        public void setLockdown(bool locked)
        {
            this.openlistbtn.IsEnabled = locked;
            this.urllist.IsEnabled = locked;
            this.startspin.IsEnabled = locked;
            this.resmp4360.IsEnabled = locked;
            this.resmp4480.IsEnabled = locked;
            this.reswebm360.IsEnabled = locked;
            this.reswebm480.IsEnabled = locked;
            this.targetdirbtn.IsEnabled = locked;
            this.targetdirtxtbx.IsEnabled = locked;
            this.endspin.IsEnabled = locked;
            this.startbtn.IsEnabled = locked;
            this.pausebtn.IsEnabled = !locked;
            this.cancelbtn.IsEnabled = !locked;
        }

        private async void startbtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.endspin.Value - this.startspin.Value > 500)
            {
                int min = Math.Min(this.startspin.Value.Value + 499, this.urls.Count);
                MessageBox.Show("The selection has more than 500 elements. It is cut down to 500 elements. New end is " + min, "Selection to big");
                this.endspin.Value = min;
            }
            string targetdir = this.targetdirtxtbx.Text;
            if (!Directory.Exists(targetdir))
            {
                MessageBox.Show("Error: The target directory does not exist.");
                return;
            }

            if (new DriveInfo("" + targetdir[0]).TotalFreeSpace < 20_000_000_000)
            {
                MessageBox.Show("Error: Less than 20GB of free space available. Refusing to start siphoning.");
                return;
            }

            var res = (resmp4360.IsChecked.Value || reswebm360.IsChecked.Value) ? ParsingRequest.RESOLUTION.R_360P : ParsingRequest.RESOLUTION.R_480P;
            var cont = (resmp4360.IsChecked.Value || resmp4480.IsChecked.Value) ? ParsingRequest.CONTAINER.C_MP4 : ParsingRequest.CONTAINER.C_WEBM;


            this.setLockdown(false);

            int start = this.startspin.Value.Value - 1;
            int end = this.endspin.Value.Value - 1;

            await Siphoner.siphon(this.urls, start, end,
                (received, total) =>
                {
                    double progress = ((double)received / total) * 100;
                    this.vidprogbar.Value = progress;
                    this.vidprogbar.IsIndeterminate = false;
                    this.vidproglabel.Content = "Download running - " + (int)progress + " % ( "
                                        + Grabber.ByteSize(received) + " / "
                                        + Grabber.ByteSize(total) + " )";
                }, //Update
                (s, b) =>
                {
                    this.vidprogbar.IsIndeterminate = false;
                    this.vidprogbar.Value = 0.0;
                }, //Finish
                () => { }, //Cancel
                ctokensource.Token, ptokensource.Token, res, cont, targetdir,
                () =>
                {
                    this.vidproglabel.Content = "Loading website";
                    this.vidprogbar.IsIndeterminate = true;
                }, //HTML
                () =>
                {
                    this.vidproglabel.Content = "Loading video data";
                    this.vidprogbar.IsIndeterminate = true;
                }, //JSON
                (success, failure, remainder) =>
                {
                    double progress = (success + failure) * 100.0 / (success + failure + remainder);
                    this.taskbar.ProgressState = TaskbarItemProgressState.Normal;
                    this.taskbar.ProgressValue = progress;
                    this.totalprogbar.Value = progress;
                    this.totalproglabel.Content =
                        "Success: " + success + " Failure: " + failure + " Remainder: " + remainder;
                    this.urllist.SelectedIndex = start + success + failure;
                }
            );

            this.setLockdown(true);
            this.taskbar.ProgressValue = 0.0;
            this.taskbar.ProgressState = TaskbarItemProgressState.None;
            this.vidprogbar.IsIndeterminate = false;
            this.vidprogbar.Value = 0.0;
            this.totalprogbar.IsIndeterminate = false;
            this.totalprogbar.Value = 0.0;
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            ctokensource.Cancel();
        }

        private void openlistbtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {

            };
            var show = dialog.ShowDialog();
            if (show.HasValue && show.Value)
            {
                this.urls = URLLoader.loadURLsFromFile(dialog.FileName);
                this.urllist.Items.Clear();
                for (var i = 0; i < this.urls.Count; i++)
                    this.urllist.Items.Add(new ListBoxItem()
                    {
                        Content = "" + (i + 1) + ". " +
                                  this.urls[i].Replace("http://www.escapistmagazine.com/videos/view/", "")
                    });


                this.startspin.Maximum = this.urls.Count;
                this.endspin.Maximum = this.urls.Count;
            }
        }

        private void continuebtn_Click(object sender, RoutedEventArgs e)
        {
            this.ptokensource.Pause();
            this.taskbar.ProgressState = TaskbarItemProgressState.Paused;
        }

        private void pausebtn_Click(object sender, RoutedEventArgs e)
        {
            this.ptokensource.Resume();
            this.taskbar.ProgressState = TaskbarItemProgressState.Normal;
        }

        private void targetdirbtn_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.targetpath = fbd.SelectedPath;
                    this.targetdirtxtbx.Text = this.targetpath;
                }
            }
        }
    }
}
