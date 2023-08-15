using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trending
{
    public partial class TrendingForm : Form, ServiceReference1.ITrendingCallback
    {


        static ServiceReference1.TrendingClient service;
        public Dictionary<string, double> tags = new Dictionary<string, double>();
        public TrendingForm()
        {
            InitializeComponent();

            InstanceContext ic = new InstanceContext(this);
            service = new ServiceReference1.TrendingClient(ic);
            service.initTrending();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Value", "Value");


        }

        public void addTagValue(string tagName, double value)
        {
            prikazi.Text = tagName + value;
            prikazi.Text = "bla bla";
            if (!tags.ContainsKey(tagName))
            {
                dataGridView1.Rows.Add(tagName, value);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

            tags[tagName] = value;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells["Name"];

                if (cell.Value != null && cell.Value.ToString() == tagName)
                {
                    row.Cells["Value"].Value = value;
                    break;
                }
            }
        }

        private void TrendingForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
