namespace LabStationsProblem
{
    public partial class MainForm : Form
    {
        private List<Experiment> Experiments = new List<Experiment>();
        private int nums = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text))
            {
                Experiment exp = new Experiment();
                exp.Title = txtTitle.Text;
                exp.Rank = (int)numRank.Value;
                exp.Width = (double)numWidth.Value;
                Experiments.Add(exp);
                label1.Text = (Experiments.Count + 1).ToString() + label1.Text.Substring(nums);
                if (Experiments.Count == 9)
                    nums = 2;
                txtTitle.Clear();
                numRank.Value = 5;
                numWidth.Value = 1M;
            }
            else
            {
                MessageBox.Show("Введите название эксперимента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            Solution solution = new Solution(Experiments, (double)numSumWidth.Value);
            OptimalListForm form = new OptimalListForm(solution.GetOptimalList());
            form.Show();
        }
    }
}