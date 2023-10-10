namespace LabStationsProblem
{
    partial class OptimalListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Rank = new System.Windows.Forms.ColumnHeader();
            this.Width = new System.Windows.Forms.ColumnHeader();
            this.Profit = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Rank,
            this.Width,
            this.Profit});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Title";
            //this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            //listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(354, 299);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Название";
            this.Title.Width = 150;
            // 
            // Rank
            // 
            this.Rank.Text = "Ранг";
            // 
            // Width
            // 
            this.Width.Text = "Ширина";
            // 
            // Profit
            // 
            this.Profit.Text = "Ценность";
            this.Profit.Width = 80;
            // 
            // OptimalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 299);
            this.Controls.Add(this.listView1);
            this.Name = "OptimalListForm";
            this.Text = "Оптимальный список";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader Title;
        private ColumnHeader Rank;
        private ColumnHeader Width;
        private ColumnHeader Profit;
    }
}