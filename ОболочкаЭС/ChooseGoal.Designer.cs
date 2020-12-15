namespace ОболочкаЭС
{
    partial class ChooseGoal
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
            this.OKbtn = new System.Windows.Forms.Button();
            this.cmbVar = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(69, 54);
            this.OKbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(100, 28);
            this.OKbtn.TabIndex = 0;
            this.OKbtn.Text = "ОК";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // cmbVar
            // 
            this.cmbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVar.FormattingEnabled = true;
            this.cmbVar.Location = new System.Drawing.Point(16, 15);
            this.cmbVar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVar.Name = "cmbVar";
            this.cmbVar.Size = new System.Drawing.Size(345, 24);
            this.cmbVar.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(205, 54);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 28);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ChooseGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 97);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.cmbVar);
            this.Controls.Add(this.OKbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseGoal";
            this.Text = "Выберите цель";
            this.Load += new System.EventHandler(this.ChooseGoal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.ComboBox cmbVar;
        private System.Windows.Forms.Button CancelBtn;
    }
}