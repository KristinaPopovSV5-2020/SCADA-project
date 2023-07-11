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
    public partial class Form1 : Form, ServiceReference1.ITrendingCallback
    {
        static ServiceReference1.TrendingClient service;
        public Dictionary<string, double> tags = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();

            InstanceContext ic = new InstanceContext(this);
            service = new ServiceReference1.TrendingClient(ic);
            service.initTrending();

            tagsGridView.Columns.Add("Name", "Name");
            tagsGridView.Columns.Add("Value", "Value");


        }

        public void addTagValue(string tagName, double value)
        {
            if (!tags.ContainsKey(tagName))
            {
                tagsGridView.Rows.Add(tagName, value);
            }

            tags[tagName] = value;

            foreach (DataGridViewRow row in tagsGridView.Rows)
            {
                DataGridViewCell cell = row.Cells["Name"];

                if (cell.Value != null && cell.Value.ToString() == tagName)
                {
                    row.Cells["Value"].Value = value;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}