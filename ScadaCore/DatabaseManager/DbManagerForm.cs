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
    public partial class DbManagerForm : Form
    {
        static ServiceReference1.DbManagerClient service = new ServiceReference1.DbManagerClient();

        public DbManagerForm()
        {

            InitializeComponent();
            buttonAlarms.Enabled = false;
            listViewTags.View = View.Details;
            listViewInputTags.View = View.Details;
            listViewAlarms.View = View.Details;

            listViewTags.Columns.Add("Tag ID");
            listViewTags.Columns.Add("Value");

            listViewInputTags.Columns.Add("Tag ID");
            listViewInputTags.Columns.Add("Scan");

            listViewAlarms.View = View.Details;

            listViewAlarms.Columns.Add("Alarm ID");
            listViewAlarms.Columns.Add("Type");
            listViewAlarms.Columns.Add("Priority");


            loadInputTags();
            loadOutputTags();
                 
        }

        private void addTag_Click(object sender, EventArgs e)
        {
            AddTagForm newForm = new AddTagForm();
            newForm.Show();
        }

        private void DbManagerForm_Load_1(object sender, EventArgs e)
        {

        }

        private void deleteTagBtn_Click(object sender, EventArgs e)
        {
            if (listViewTags.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTags.SelectedItems[0];

                string tagId = selectedItem.SubItems[0].Text;
                service.DeleteTag(tagId);
                listViewTags.Items.Remove(selectedItem);

            }
            listViewTags.Items.Clear();
            loadOutputTags();
        }

        private void onOffBtn_Click(object sender, EventArgs e)
        {
            if (listViewInputTags.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewInputTags.SelectedItems[0];

                string tagId = selectedItem.SubItems[0].Text;
                service.OnOffScan(tagId);
                hint.Text = tagId;
            }
            listViewInputTags.Items.Clear();
            loadInputTags();

        }

        private void loadOutputTags()
        {
            List<AnalogOutput> listedTags1 = service.GetAnalogOutputTags();
            List<DigitalOutput> listedTags2 = service.GetDigitalOutputTags();
            foreach (AnalogOutput tag in listedTags1)
            {
                string[] arr = new string[2];
                ListViewItem item;
                arr[0] = tag.TagName;
                arr[1] = tag.InitialValue.ToString();

                item = new ListViewItem(arr) { Tag = tag };
                listViewTags.Items.Add(item);
            }
            foreach (DigitalOutput tag in listedTags2)
            {
                string[] arr = new string[2];
                ListViewItem item;
                arr[0] = tag.TagName;
                arr[1] = tag.InitialValue.ToString();

                item = new ListViewItem(arr) { Tag = tag };
                listViewTags.Items.Add(item);
            }
        }

        private void loadInputTags()
        {
            List<AnalogInput> listedTags3 = service.GetAnalogInputTags();
            List<DigitalInput> listedTags4 = service.GetDigitalInputTags();


            foreach (AnalogInput tag in listedTags3)
            {
                string[] arr = new string[2];
                ListViewItem item;
                arr[0] = tag.TagName;
                arr[1] = tag.Scan.ToString();

                item = new ListViewItem(arr) { Tag = tag };
                listViewInputTags.Items.Add(item);
            }
            foreach (DigitalInput tag in listedTags4)
            {
                string[] arr = new string[2];
                ListViewItem item;
                arr[0] = tag.TagName;
                arr[1] = tag.Scan.ToString();

                item = new ListViewItem(arr) { Tag = tag };
                listViewInputTags.Items.Add(item);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listViewTags.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTags.SelectedItems[0];

                string tagId = selectedItem.SubItems[0].Text;
                hint.Text = tagId;
                service.UpdateValue(tagId, 6969);

            }
            listViewTags.Items.Clear();
            loadOutputTags();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewAlarm_Click(object sender, EventArgs e)
        {
            AddNewAlarm newForm = new AddNewAlarm(tagNameAlarm.Text);
            newForm.Show();
            listViewAlarms.Items.Clear();

            tagNameAlarm.Text = listViewInputTags.SelectedItems[0].SubItems[0].Text;

            buttonNewAlarm.Enabled = true;

            List<Alarm> found = service.findAlarm(listViewInputTags.SelectedItems[0].SubItems[0].Text);
            foreach (Alarm alarm in found)
            {
                ListViewItem item = new ListViewItem(alarm.AlarmId);
                item.SubItems.Add(alarm.Type.ToString());
                item.SubItems.Add(alarm.Priority);

                listViewAlarms.Items.Add(item);
            }

        }

    


        private void buttonAlarms_Click(object sender, EventArgs e)
        {
            if (listViewInputTags.SelectedItems.Count > 0)
            {
                listViewAlarms.Items.Clear();

                tagNameAlarm.Text = listViewInputTags.SelectedItems[0].SubItems[0].Text;

                buttonNewAlarm.Enabled = true;

                List<Alarm> found = service.findAlarm(listViewInputTags.SelectedItems[0].SubItems[0].Text);
                foreach (Alarm alarm in found)
                {
                    ListViewItem item = new ListViewItem(alarm.AlarmId);
                    item.SubItems.Add(alarm.Type.ToString());
                    item.SubItems.Add(alarm.Priority);

                    listViewAlarms.Items.Add(item);
                }

            }
        }

        private void buttonDeleteAlarm_Click(object sender, EventArgs e)
        {
            if (listViewAlarms.SelectedItems.Count > 0)
            {
                string alarmId = listViewAlarms.SelectedItems[0].SubItems[0].Text;
                service.deleteAlarm(alarmId);
                listViewAlarms.Items.Clear();

                tagNameAlarm.Text = listViewInputTags.SelectedItems[0].SubItems[0].Text;

                buttonNewAlarm.Enabled = true;

                List<Alarm> found = service.findAlarm(listViewInputTags.SelectedItems[0].SubItems[0].Text);
                foreach (Alarm alarm in found)
                {
                    ListViewItem item = new ListViewItem(alarm.AlarmId);
                    item.SubItems.Add(alarm.Type.ToString());
                    item.SubItems.Add(alarm.Priority);

                    listViewAlarms.Items.Add(item);
                }


            }
        }

        private void listViewInputTags_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            buttonNewAlarm.Enabled = false;
            buttonDeleteAlarm.Enabled = false;

            if (listViewInputTags.SelectedItems.Count > 0)
            {
                Tag selectedTag = listViewInputTags.SelectedItems[0].Tag as Tag;

                if (selectedTag is AnalogInput)
                {
                    buttonAlarms.Enabled = true;
                    
                }
                else
                {
                    buttonAlarms.Enabled = false;
                }
            }
            else
            {
                buttonAlarms.Enabled = false;
            }
        }

        private void listViewAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAlarms.SelectedItems.Count > 0)
            {
                buttonDeleteAlarm.Enabled = true;
                buttonNewAlarm.Enabled = true;
            }
            else
            {
                buttonDeleteAlarm.Enabled = false;
                buttonNewAlarm.Enabled = false;

            }
        }

        private void deleteInputTag_Click(object sender, EventArgs e)
        {
            if (listViewInputTags.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewInputTags.SelectedItems[0];

                string tagId = selectedItem.SubItems[0].Text;
                service.DeleteTag(tagId);
                listViewInputTags.Items.Remove(selectedItem);
            }
            listViewInputTags.Items.Clear();
            loadInputTags();
        }
    }
}
