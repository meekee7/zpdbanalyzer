using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace WikiaInsertionBrowser
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private EpisodeList episodes;

        public MainPage()
        {
            this.InitializeComponent();
            this.WebView.NavigationStarting += (sender, args) =>
            {
                this.UrlBox.Text = args.Uri.ToString();
                this.ProgressRing.IsActive = true;
            };
            this.UrlBox.KeyDown += async (sender, args) =>
            {
                if (args.Key == VirtualKey.Enter)
                    await this.navigateByURLBox();
            };
            this.gotobtn.Click += async (sender, args) => await this.navigateByURLBox();
            this.WebView.NavigationCompleted += (sender, args) => this.ProgressRing.IsActive = false;
            this.WebView.NavigationFailed += (sender, args) => this.ProgressRing.IsActive = false;
            this.ForwardBtn.Click += (sender, args) => this.WebView.GoForward();
            this.BackBtn.Click += (sender, args) => this.WebView.GoBack();
            this.copybtn.Click += (sender, args) =>
            {
                var dp = new DataPackage();
                dp.SetText(this.textBox.Text);
                Clipboard.SetContent(dp);
            };
            this.nlcbtn.Click += (sender, args) => this.nlc();

            this.listBox.SelectionChanged += (sender, args) =>
            {
                this.updateLoadedItem(args.AddedItems[0] as Episode);
                this.listBox.ScrollIntoView(args.AddedItems[0]);
            };
            this.episodes = (EpisodeList) IO.serializer.Deserialize(new StringReader(Data.rawdata));
            this.listBox.ItemsSource = this.episodes.episodes;
            this.prevbtn.Click +=
                (sender, args) => this.listBox.SelectedIndex = Math.Max(0, this.listBox.SelectedIndex - 1);
            this.nextbtn.Click +=
                (sender, args) => this.listBox.SelectedIndex = Math.Min(this.listBox.Items.Count - 1, this.listBox.SelectedIndex + 1);
            this.loadbtn.Click += (sender, args) => this.loadSelected();
            this.infobtn.Click += (sender, args) =>
            {
                var dp = new DataPackage();
                dp.SetText("Navbox");
                Clipboard.SetContent(dp);
            };
           
            this.WebView.Source = new Uri("http://zeropunctuation.wikia.com");
        }

        public async Task navigateByURLBox()
        {
            try
            {
                this.WebView.Navigate(new Uri(this.UrlBox.Text));
            }
            catch (UriFormatException e)
            {
                await new MessageDialog("Uri-Exception: " + e, "URI Exception").ShowAsync();
            }
        }

        public void updateLoadedItem(Episode ep)
        {
            this.textBox.Text = ep.toWikiaInfobox() + "\n" + ep.teaser+"\n";
        }

        public void nlc()
        {
            if (this.listBox.SelectedIndex == this.listBox.Items.Count - 1)
                return;

            this.listBox.SelectedIndex++;
            
            this.loadSelected();
        }

        public void loadSelected()
        {
            Episode ep = this.listBox.SelectedItems[0] as Episode;
            DataPackage dp = new DataPackage();
            dp.SetText(ep.toWikiaInfobox() + "\n" + ep.teaser + "\n");
            //Clipboard.SetContent(dp);

            this.WebView.Navigate(new Uri("http://zeropunctuation.wikia.com/wiki/"
                                          + ep.name.Replace(" ", "_")
                                          + "?veaction=edit"));
        }
    }
}
