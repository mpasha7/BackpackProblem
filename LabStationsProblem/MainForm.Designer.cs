namespace LabStationsProblem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numRank = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblSumWidth = new System.Windows.Forms.Label();
            this.numSumWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSumWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 128);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(101, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(19, 131);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Название:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(19, 172);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(92, 15);
            this.lblRank.TabIndex = 1;
            this.lblRank.Text = "Ранг (от 1 до 5):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(19, 213);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(114, 15);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Ширина (в метрах):";
            // 
            // numRank
            // 
            this.numRank.Location = new System.Drawing.Point(141, 170);
            this.numRank.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRank.Name = "numRank";
            this.numRank.Size = new System.Drawing.Size(101, 23);
            this.numRank.TabIndex = 2;
            this.numRank.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 эксперимент";
            // 
            // numWidth
            // 
            this.numWidth.DecimalPlaces = 2;
            this.numWidth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numWidth.Location = new System.Drawing.Point(141, 211);
            this.numWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(101, 23);
            this.numWidth.TabIndex = 5;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(19, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 34);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(142, 257);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 34);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblSumWidth
            // 
            this.lblSumWidth.AutoSize = true;
            this.lblSumWidth.Location = new System.Drawing.Point(19, 54);
            this.lblSumWidth.Name = "lblSumWidth";
            this.lblSumWidth.Size = new System.Drawing.Size(86, 15);
            this.lblSumWidth.TabIndex = 7;
            this.lblSumWidth.Text = "Ширина стола";
            // 
            // numSumWidth
            // 
            this.numSumWidth.DecimalPlaces = 2;
            this.numSumWidth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numSumWidth.Location = new System.Drawing.Point(163, 52);
            this.numSumWidth.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSumWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSumWidth.Name = "numSumWidth";
            this.numSumWidth.Size = new System.Drawing.Size(79, 23);
            this.numSumWidth.TabIndex = 8;
            this.numSumWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 311);
            this.Controls.Add(this.numSumWidth);
            this.Controls.Add(this.lblSumWidth);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRank);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "MainForm";
            this.Text = "Эксперименты";
            ((System.ComponentModel.ISupportInitialize)(this.numRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSumWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitle;
        private Label lblTitle;
        private Label lblRank;
        private Label lblWidth;
        private NumericUpDown numRank;
        private Label label1;
        private NumericUpDown numWidth;
        private Button btnOK;
        private Button btnEnd;
        private Label lblSumWidth;
        private NumericUpDown numSumWidth;
    }
}