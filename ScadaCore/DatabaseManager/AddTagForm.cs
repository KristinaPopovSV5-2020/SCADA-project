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
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Tag tag = CreateTagFromInputs();
            service.AddTag(tag, realTimeDriverOn.Checked);
        }

        private void AddTagForm_Load(object sender, EventArgs e)
        {

        }

        private Tag CreateTagFromInputs()
        {
            Tag tag = null;
            Guid uuid = Guid.NewGuid();
            string uuidString = uuid.ToString();
            switch (typeComboBox.SelectedItem.ToString())
            {
                case "Analog Input":
                    tag = new AnalogInput(uuidString, description.Text,
                        address.Text, null, int.Parse(scanTime.Text),
                        scanOn.Checked, null,
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
    }
}
