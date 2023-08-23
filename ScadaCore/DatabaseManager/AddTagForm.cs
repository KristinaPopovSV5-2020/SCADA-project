using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace DatabaseManager
{
    public partial class AddTagForm : Form
    {
        static ServiceReference1.DbManagerClient service = new ServiceReference1.DbManagerClient();

        public AddTagForm()
        {
            InitializeComponent();
            scanOn.Enabled = false;
            scanTime.Enabled = false;
            realTimeDriverOn.Enabled = false;
            lowLimit.Enabled = false;
            highLimit.Enabled = false;
            units.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Tag tag = CreateTagFromInputs();
            bool saved = service.AddTag(tag, realTimeDriverOn.Checked);
            if (saved)
            {
                response.Text = "Tag added.";
            } else
            {
                response.Text = "Tag not added.";
            }
        }

        private void AddTagForm_Load(object sender, EventArgs e)
        {

        }

        private Tag CreateTagFromInputs()
        {
            Tag tag = null;
            string uuidString = tagName.Text.ToString();
            switch (typeComboBox.SelectedItem.ToString())
            {
                case "Analog Input":
                    tag = new AnalogInput(uuidString, description.Text,
                        address.Text, null, int.Parse(scanTime.Text),
                        scanOn.Checked, new List<Alarm>(),
                        double.Parse(lowLimit.Text), double.Parse(highLimit.Text),
                        units.Text, 0);
                    break;

                case "Analog Output":
                    tag = new AnalogOutput(uuidString, description.Text,
                        address.Text, 0,
                        double.Parse(lowLimit.Text), double.Parse(highLimit.Text),
                        units.Text);
                    break;

                case "Digital Input":
                    tag = new DigitalInput(uuidString, description.Text,
                        address.Text, null, int.Parse(scanTime.Text),
                        scanOn.Checked, 0);
                    break;

                case "Digital Output":
                    tag = new DigitalOutput(uuidString, description.Text,
                        address.Text, 0);
                    break;

            }
            return tag;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = typeComboBox.SelectedItem.ToString();

            if (selectedType == "Analog Input")
            {
                scanOn.Enabled = true;
                scanTime.Enabled = true;
                realTimeDriverOn.Enabled = true;
                lowLimit.Enabled = true;
                highLimit.Enabled = true;
                units.Enabled = true;
            }
            else if (selectedType == "Analog Output")
            {
                scanOn.Enabled = false;
                scanTime.Enabled = false;
                realTimeDriverOn.Enabled = false;
                lowLimit.Enabled = true;
                highLimit.Enabled = true;
                units.Enabled = true;

            }
            else if (selectedType == "Digital Input")
            {
                scanOn.Enabled = true;
                scanTime.Enabled = true;
                realTimeDriverOn.Enabled = true;
                lowLimit.Enabled = false;
                highLimit.Enabled = false;
                units.Enabled = false;

            }
            else
            {
                scanOn.Enabled = false;
                scanTime.Enabled = false;
                realTimeDriverOn.Enabled = false;
                lowLimit.Enabled = false;
                highLimit.Enabled = false;
                units.Enabled = false;
            }
        }

        
    }
}
