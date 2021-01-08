using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace MSGCompare
{
    public class XMLPropertyReader
    {
        private string _sourceFile;
        private string _xmlFile;

        public XMLPropertyReader(string File)
        {
            _sourceFile = File;
            _xmlFile = Path.GetTempFileName();
            string xml = System.IO.File.ReadAllText(_sourceFile);
            xml = xml.Replace("<Other Names>", "<OtherNames>");
            xml = xml.Replace("</Other Names>", "</OtherNames>");
            System.IO.File.WriteAllText(_xmlFile, xml);
        }

        ~XMLPropertyReader()
        {
            File.Delete(_xmlFile);
        }

        public MSG Msg
        {
            get
            {
                MSG msg = new MSG();
                if (File.Exists(_xmlFile))
                    ReadXML(msg);
                return msg;
            }
        }

        public void ReadXML(MSG TargetMSG)
        {
            // Read/parse the XML and add all the properties to the MSG
            //XmlTextReader oReader=new XmlTextReader(_xmlFile);
            XmlReaderSettings oXmlSettings = new XmlReaderSettings();
            oXmlSettings.CheckCharacters = false;
            oXmlSettings.ValidationFlags = System.Xml.Schema.XmlSchemaValidationFlags.None;
            oXmlSettings.ValidationType = ValidationType.None;

            XmlReader oReader = XmlReader.Create(_xmlFile, oXmlSettings);
            
            while (oReader.Read())
            {
                switch (oReader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (oReader.Name=="property")
                        {
                            MAPIProperty oProperty=new MAPIProperty();
                            // Read the property - first of all, the tag
                            while (oReader.MoveToNextAttribute())
                            {
                                switch (oReader.Name)
                                {
                                    case "tag":
                                        oProperty.TagString=oReader.Value;
                                        break;

                                    default: // Do nothing
                                        break;
                                }
                            }

                            // Now read the property information
                            bool bReadComplete=false;
                            string sElement="";
                            while (!bReadComplete)
                            {
                                bool bReadSuccess = false;
                                try
                                {
                                    oReader.Read();
                                    bReadSuccess = true;
                                }
                                catch
                                {
                                    bReadComplete = true;
                                }

                                if (bReadSuccess)
                                {
                                    switch (oReader.NodeType)
                                    {
                                        case XmlNodeType.EndElement:
                                            if (oReader.Name == "property") bReadComplete = true;
                                            sElement = "";
                                            break;

                                        case XmlNodeType.Element: // Read the element
                                            sElement = oReader.Name;
                                            break;

                                        case XmlNodeType.CDATA: // Commonly used for PT_STRING8
                                            switch (sElement)
                                            {
                                                case "Value":
                                                    if (String.IsNullOrEmpty(oProperty.StringValue))
                                                        oProperty.StringValue = oReader.Value;
                                                    break;

                                                case "AltValue":
                                                    if (String.IsNullOrEmpty(oProperty.AltValue))
                                                        oProperty.AltValue = oReader.Value;
                                                    break;

                                                default:
                                                    break;
                                            }
                                            break;

                                        case XmlNodeType.Text: // Read the value
                                            if (!String.IsNullOrEmpty(sElement))
                                            {
                                                switch (sElement)
                                                {
                                                    case "ExactNames":
                                                        AddExactNames(oProperty, oReader.Value);
                                                        break;

                                                    case "OtherNames":
                                                        AddPartialNames(oProperty, oReader.Value);
                                                        break;

                                                    case "NamedPropName":
                                                        oProperty.NamedPropName = oReader.Value;
                                                        break;

                                                    case "Name":
                                                        AddExactNames(oProperty, oReader.Value);
                                                        break;

                                                    case "PartialNames":
                                                        AddPartialNames(oProperty, oReader.Value);
                                                        break;

                                                    case "Value":
                                                        oProperty.StringValue = oReader.Value;
                                                        break;

                                                    case "AltValue":
                                                        oProperty.AltValue = oReader.Value;
                                                        break;

                                                    default: // Do nothing
                                                        break;
                                                }
                                            }
                                            break;

                                        default: // Do nothing
                                            break;
                                    }
                                }
                            }
                            TargetMSG.Properties.Add(oProperty);
                        }
                        break;

                    default: // Do nothing
                        break;
                }
            }

        }

        private void AddExactNames(MAPIProperty Property, string ExactNames)
        {
            string[] aNames = ExactNames.Split(',');
            foreach (string sName in aNames)
            {
                Property.ExactNames.Add(sName.Trim());
            }
        }

        private void AddPartialNames(MAPIProperty Property, string PartialNames)
        {
            string[] aNames = PartialNames.Split(',');
            foreach (string sName in aNames)
            {
                Property.PartialNames.Add(sName.Trim());
            }
        }
    }
}
