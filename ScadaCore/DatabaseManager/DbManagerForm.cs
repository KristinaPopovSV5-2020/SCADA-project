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
            listViewTags.View = View.Details;

            listViewTags.Columns.Add("Tag ID", listViewTags.Size.Width, HorizontalAlignment.Left);


            //List<Tag> listedTags = service.GetOutputTags();

            //foreach (Tag tag in listedTags) listViewTags.Items.Add(new ListViewItem(tag.TagName) { Tag = tag });
        }

        private void addTag_Click(object sender, EventArgs e)
        {
            AddTagForm newForm = new AddTagForm();
            newForm.Show();
        }

        private void DbManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void DbManagerForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
