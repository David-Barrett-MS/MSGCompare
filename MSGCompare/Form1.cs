using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MSGCompare
{
    public partial class Form1 : Form
    {
        private MSG _msg1 = new MSG();
        private MSG _msg2 = new MSG();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseFile1_Click(object sender, EventArgs e)
        {
            BrowseForFile(textBoxFile1);
        }

        private void buttonBrowseFile2_Click(object sender, EventArgs e)
        {
            BrowseForFile(textBoxFile2);
        }

        private void BrowseForFile(TextBox FileLocationTextbox)
        {
            string sFile = FileLocationTextbox.Text;
            OpenFileDialog oDialog = new OpenFileDialog();
            if (!String.IsNullOrEmpty(sFile))
            {
                oDialog.InitialDirectory = Path.GetDirectoryName(sFile);
            }
            oDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            oDialog.FilterIndex = 1;
            oDialog.RestoreDirectory = true;
            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocationTextbox.Text = oDialog.FileName;
            }
        }

        private void textBoxFile1_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxFile1.Text))
                return;

            _msg1 = new MSG();
            _msg1.ParseFromXML(textBoxFile1.Text);
        }

        private void textBoxFile2_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxFile2.Text))
                return;

            _msg2 = new MSG();
            _msg2.ParseFromXML(textBoxFile2.Text);
        }

        private void comboBoxComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxComparison.SelectedIndex)
            {
                case 0:
                    ShowPropertiesInFile1ButNotFile2();
                    break;

                case 1:
                    ShowPropertiesInFile2ButNotFile1();
                    break;

                case 2:
                    ShowPropertiesThatDiffer();
                    break;

                case 3:
                    ShowPropertiesThatAreIdentical();
                    break;

                default:
                    listBoxProperties.Items.Clear();
                    break;
            }
        }

        private void ShowPropertiesInFile1ButNotFile2()
        {
            listBoxProperties.Items.Clear();
            foreach (MAPIProperty oProperty in _msg1.Properties)
            {
                if (!_msg2.ContainsProperty(oProperty.Tag))
                {
                    // Add this property to the listbox
                    listBoxProperties.Items.Add(oProperty);
                }
            }
        }

        private void ShowPropertiesInFile2ButNotFile1()
        {
            listBoxProperties.Items.Clear();
            foreach (MAPIProperty oProperty in _msg2.Properties)
            {
                if (!_msg1.ContainsProperty(oProperty.Tag))
                {
                    // Add this property to the listbox
                    listBoxProperties.Items.Add(oProperty);
                }
            }
        }

        private void ShowPropertiesThatDiffer()
        {
            listBoxProperties.Items.Clear();

            // Work out the differences
            foreach (MAPIProperty oProperty in _msg1.Properties)
            {
                if (_msg2.ContainsProperty(oProperty.Tag))
                {
                    MAPIProperty oProperty2 = _msg2.Property(oProperty.Tag);
                    if (!oProperty.StringValue.Equals(oProperty2.StringValue))
                    {
                        string prop1 = oProperty.StringValue;
                        string prop2 = oProperty2.StringValue;
                        listBoxProperties.Items.Add(oProperty);
                    }
                }
            }
        }

        private void ShowPropertiesThatAreIdentical()
        {
            listBoxProperties.Items.Clear();

            // Work out the identical properties
            foreach (MAPIProperty oProperty in _msg1.Properties)
            {
                if (_msg2.ContainsProperty(oProperty.Tag))
                {
                    MAPIProperty oProperty2 = _msg2.Property(oProperty.Tag);
                    if (oProperty.StringValue == oProperty2.StringValue)
                    {
                        listBoxProperties.Items.Add(oProperty);
                    }
                }
            }
        }

        private void listBoxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the selected property
            MAPIProperty oProperty = (MAPIProperty)listBoxProperties.SelectedItem;

            if (oProperty == null)
                return;

            // Show property definition
            textBoxTag.Text = oProperty.TagString;
            textBoxType.Text = oProperty.StringType;
            textBoxNamedPropName.Text = oProperty.NamedPropName;

            // Show exact names
            listBoxExactNames.Items.Clear();
            foreach (string sExactName in oProperty.ExactNames)
            {
                listBoxExactNames.Items.Add(sExactName.Trim());
            }

            // Show partial names
            listBoxPartialNames.Items.Clear();
            foreach (string sPartialName in oProperty.PartialNames)
            {
                listBoxPartialNames.Items.Add(sPartialName.Trim());
            }

            // Show value
            textBoxValue1.Text = "";
            textBoxValue2.Text = "";

            if (_msg1.ContainsProperty(oProperty.Tag))
            {
                // Show comparitive property value
                textBoxValue1.Text = _msg1.Property(oProperty.Tag).StringValue;
            }
            if (_msg2.ContainsProperty(oProperty.Tag))
            {
                // Show comparitive property value
                textBoxValue2.Text = _msg2.Property(oProperty.Tag).StringValue;
            }

        }
    }
}
