namespace ОболочкаЭС
{
    partial class AddFact
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
            this.button17 = new System.Windows.Forms.Button();
            this.valName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.varName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(380, 34);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(24, 28);
            this.button17.TabIndex = 9;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // valName
            // 
            this.valName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valName.FormattingEnabled = true;
            this.valName.Location = new System.Drawing.Point(228, 36);
            this.valName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valName.Name = "valName";
            this.valName.Size = new System.Drawing.Size(143, 24);
            this.valName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "=";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(171, 36);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(24, 28);
            this.button16.TabIndex = 6;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // varName
            // 
            this.varName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.varName.FormattingEnabled = true;
            this.varName.Location = new System.Drawing.Point(15, 37);
            this.varName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.varName.Name = "varName";
            this.varName.Size = new System.Drawing.Size(147, 24);
            this.varName.TabIndex = 5;
            this.varName.SelectedIndexChanged += new System.EventHandler(this.varName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя переменной";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Значение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 124);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.valName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.varName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFact";
            this.Text = "Добавить/изменить факт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox valName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ComboBox varName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}