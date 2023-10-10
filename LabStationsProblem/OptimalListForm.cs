using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabStationsProblem
{
    public partial class OptimalListForm : Form
    {
        private List<Experiment>? Experiments = null;

        public OptimalListForm(List<Experiment> experiments)
        {
            InitializeComponent();
            Experiments = experiments;
            FillListView();
        }

        private void FillListView()
        {
            foreach (var exp in Experiments)
            {
                ListViewItem item = new ListViewItem(exp.Title);
                item.SubItems.Add(exp.Rank.ToString());
                item.SubItems.Add(exp.Width.ToString());
                item.SubItems.Add(exp.Profit.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
