namespace ОболочкаЭС
{
    partial class ConsultResults
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_workMemory = new System.Windows.Forms.ListBox();
            this.lbl_goal = new System.Windows.Forms.Label();
            this.lbl_explain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tview_steps = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_workMemory);
            this.groupBox1.Location = new System.Drawing.Point(7, 401);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1193, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рабочая память";
            // 
            // lbx_workMemory
            // 
            this.lbx_workMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_workMemory.FormattingEnabled = true;
            this.lbx_workMemory.ItemHeight = 16;
            this.lbx_workMemory.Location = new System.Drawing.Point(4, 19);
            this.lbx_workMemory.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_workMemory.Name = "lbx_workMemory";
            this.lbx_workMemory.Size = new System.Drawing.Size(1185, 143);
            this.lbx_workMemory.TabIndex = 0;
            // 
            // lbl_goal
            // 
            this.lbl_goal.AutoSize = true;
            this.lbl_goal.Location = new System.Drawing.Point(17, 338);
            this.lbl_goal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_goal.Name = "lbl_goal";
            this.lbl_goal.Size = new System.Drawing.Size(46, 17);
            this.lbl_goal.TabIndex = 2;
            this.lbl_goal.Text = "label1";
            // 
            // lbl_explain
            // 
            this.lbl_explain.AutoSize = true;
            this.lbl_explain.Location = new System.Drawing.Point(17, 368);
            this.lbl_explain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_explain.Name = "lbl_explain";
            this.lbl_explain.Size = new System.Drawing.Size(46, 17);
            this.lbl_explain.TabIndex = 3;
            this.lbl_explain.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Развернуть все узлы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tview_steps);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1191, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сработавшие правила";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tview_steps
            // 
            this.tview_steps.Location = new System.Drawing.Point(4, 4);
            this.tview_steps.Margin = new System.Windows.Forms.Padding(4);
            this.tview_steps.Name = "tview_steps";
            this.tview_steps.Size = new System.Drawing.Size(1177, 285);
            this.tview_steps.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // ConsultResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_explain);
            this.Controls.Add(this.lbl_goal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultResults";
            this.Text = "Результаты консультации";
            this.Load += new System.EventHandler(this.ConsultResults_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lbx_workMemory;
        private System.Windows.Forms.Label lbl_goal;
        private System.Windows.Forms.Label lbl_explain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TreeView tview_steps;
        private System.Windows.Forms.TabControl tabControl1;
    }
}