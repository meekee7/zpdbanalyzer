using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZPDBProject
{
    namespace YTTranscript
    {
        public static class IO
        {
            public static readonly XmlSerializer serializer = new XmlSerializer(typeof(transcript));

            public static transcript readFile(string filename)
            {
                using (StreamReader sr = File.OpenText(filename))
                    return (transcript)IO.serializer.Deserialize(sr);
            }
        }

        // 
        // Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.1055.0.
        // 


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class transcript
        {

            private transcriptText[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("text")]
            public transcriptText[] text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transcriptText
        {

            private float startField;

            private bool startFieldSpecified;

            private float durField;

            private bool durFieldSpecified;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float start
            {
                get
                {
                    return this.startField;
                }
                set
                {
                    this.startField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool startSpecified
            {
                get
                {
                    return this.startFieldSpecified;
                }
                set
                {
                    this.startFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float dur
            {
                get
                {
                    return this.durField;
                }
                set
                {
                    this.durField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool durSpecified
            {
                get
                {
                    return this.durFieldSpecified;
                }
                set
                {
                    this.durFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

    }
}
