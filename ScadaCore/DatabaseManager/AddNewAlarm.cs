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
    public partial class AddNewAlarm : Form
    {
        private string tagName;
        static ServiceReference1.DbManagerClient service = new ServiceReference1.DbManagerClient();

        public AddNewAlarm(object tagName)
        {
            InitializeComponent();
            this.tagName = (string)tagName;
            labelAlarmAdded.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Guid uuid = Guid.NewGuid();
            string uuidString = uuid.ToString();
            string selectedItem = comboBoxType.SelectedItem.ToString();
            TypeOfAlarm selectedType = TypeOfAlarm.High; 
            if (comboBoxType.SelectedItem != null)
            { 
                if (selectedItem == "High")
            {
                selectedType = TypeOfAlarm.High;
            }
            else if (selectedItem == "Medium")
            {
                selectedType = TypeOfAlarm.Med;
            }
            else if (selectedItem == "Low")
            {
                selectedType = TypeOfAlarm.Low;
            }
            else
            {
                // Handle invalid selection
            }
                Alarm alarm = new Alarm(uuidString, tagName, selectedType, double.Parse(textBoxLimit.Text), comboBoxPriority.Text);
                service.newAlarm(alarm);
                labelAlarmAdded.Visible = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
            
           
             
        }
    }
}
