namespace ОболочкаЭС
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbxDomains = new System.Windows.Forms.ListBox();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.lbxValues = new System.Windows.Forms.ListBox();
            this.btnDeleteValue = new System.Windows.Forms.Button();
            this.btnChangeDomain = new System.Windows.Forms.Button();
            this.btnChangeValue = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDomain = new System.Windows.Forms.Button();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxVariables = new System.Windows.Forms.ListBox();
            this.btnDeleteVariable = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.gbVar = new System.Windows.Forms.GroupBox();
            this.btnAddDomainCtx = new System.Windows.Forms.Button();
            this.lbxVarDomain = new System.Windows.Forms.ListBox();
            this.btnChangeVariable = new System.Windows.Forms.Button();
            this.gbQuest = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.rbQD = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbQ = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVarDomain = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelVariable = new System.Windows.Forms.Button();
            this.btnSaveVariable = new System.Windows.Forms.Button();
            this.tbVarName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChangeRule = new System.Windows.Forms.Button();
            this.lbxRules = new System.Windows.Forms.ListBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbRule = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbxThen = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbxIF = new System.Windows.Forms.ListBox();
            this.tbReasoning = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelRule = new System.Windows.Forms.Button();
            this.btnSaveRule = new System.Windows.Forms.Button();
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.открытьПоследниеРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDomain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbVar.SuspendLayout();
            this.gbQuest.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbRule.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1041, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьToolStripMenuItem,
            this.открытьПоследниеРезультатыToolStripMenuItem});
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.начатьToolStripMenuItem.Text = "Начать";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 480);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxDomains);
            this.tabPage1.Controls.Add(this.gbDomain);
            this.tabPage1.Controls.Add(this.btnDeleteDomain);
            this.tabPage1.Controls.Add(this.btnAddDomain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1044, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Домены";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxDomains
            // 
            this.lbxDomains.FormattingEnabled = true;
            this.lbxDomains.ItemHeight = 16;
            this.lbxDomains.Location = new System.Drawing.Point(11, 7);
            this.lbxDomains.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDomains.Name = "lbxDomains";
            this.lbxDomains.Size = new System.Drawing.Size(393, 388);
            this.lbxDomains.TabIndex = 17;
            this.lbxDomains.SelectedIndexChanged += new System.EventHandler(this.lbxDomains_SelectedIndexChanged);
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.lbxValues);
            this.gbDomain.Controls.Add(this.btnDeleteValue);
            this.gbDomain.Controls.Add(this.btnChangeDomain);
            this.gbDomain.Controls.Add(this.btnChangeValue);
            this.gbDomain.Controls.Add(this.btnAddValue);
            this.gbDomain.Controls.Add(this.tbDomainName);
            this.gbDomain.Controls.Add(this.label1);
            this.gbDomain.Location = new System.Drawing.Point(413, 7);
            this.gbDomain.Margin = new System.Windows.Forms.Padding(4);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Padding = new System.Windows.Forms.Padding(4);
            this.gbDomain.Size = new System.Drawing.Size(555, 432);
            this.gbDomain.TabIndex = 7;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Информация о домене";
            // 
            // lbxValues
            // 
            this.lbxValues.FormattingEnabled = true;
            this.lbxValues.ItemHeight = 16;
            this.lbxValues.Location = new System.Drawing.Point(23, 64);
            this.lbxValues.Margin = new System.Windows.Forms.Padding(4);
            this.lbxValues.Name = "lbxValues";
            this.lbxValues.Size = new System.Drawing.Size(297, 324);
            this.lbxValues.TabIndex = 17;
            this.lbxValues.SelectedIndexChanged += new System.EventHandler(this.lbxValues_SelectedIndexChanged);
            this.lbxValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxValues_MouseDown);
            this.lbxValues.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxValues_MouseMove);
            this.lbxValues.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbxValues_MouseUp);
            // 
            // btnDeleteValue
            // 
            this.btnDeleteValue.Location = new System.Drawing.Point(328, 360);
            this.btnDeleteValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteValue.Name = "btnDeleteValue";
            this.btnDeleteValue.Size = new System.Drawing.Size(202, 28);
            this.btnDeleteValue.TabIndex = 9;
            this.btnDeleteValue.Text = "Удалить значение";
            this.btnDeleteValue.UseVisualStyleBackColor = true;
            this.btnDeleteValue.Click += new System.EventHandler(this.btnDeleteValue_Click);
            // 
            // btnChangeDomain
            // 
            this.btnChangeDomain.Location = new System.Drawing.Point(413, 20);
            this.btnChangeDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeDomain.Name = "btnChangeDomain";
            this.btnChangeDomain.Size = new System.Drawing.Size(133, 28);
            this.btnChangeDomain.TabIndex = 16;
            this.btnChangeDomain.Text = "Переименовать";
            this.btnChangeDomain.UseVisualStyleBackColor = true;
            this.btnChangeDomain.Click += new System.EventHandler(this.btnChangeDomain_Click);
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.Location = new System.Drawing.Point(328, 324);
            this.btnChangeValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(202, 28);
            this.btnChangeValue.TabIndex = 8;
            this.btnChangeValue.Text = "Редактировать значение";
            this.btnChangeValue.UseVisualStyleBackColor = true;
            this.btnChangeValue.Click += new System.EventHandler(this.btnChangeValue_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(328, 288);
            this.btnAddValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(201, 28);
            this.btnAddValue.TabIndex = 7;
            this.btnAddValue.Text = "Добавить значение";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(135, 23);
            this.tbDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.ReadOnly = true;
            this.tbDomainName.Size = new System.Drawing.Size(256, 22);
            this.tbDomainName.TabIndex = 1;
            this.tbDomainName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDomainName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя домена";
            // 
            // btnDeleteDomain
            // 
            this.btnDeleteDomain.Location = new System.Drawing.Point(245, 411);
            this.btnDeleteDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDomain.Name = "btnDeleteDomain";
            this.btnDeleteDomain.Size = new System.Drawing.Size(113, 28);
            this.btnDeleteDomain.TabIndex = 6;
            this.btnDeleteDomain.Text = "Удалить";
            this.btnDeleteDomain.UseVisualStyleBackColor = true;
            this.btnDeleteDomain.Click += new System.EventHandler(this.btnDeleteDomain_Click);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Location = new System.Drawing.Point(77, 411);
            this.btnAddDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(116, 28);
            this.btnAddDomain.TabIndex = 1;
            this.btnAddDomain.Text = "Добавить";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxVariables);
            this.tabPage2.Controls.Add(this.btnDeleteVariable);
            this.tabPage2.Controls.Add(this.btnAddVariable);
            this.tabPage2.Controls.Add(this.gbVar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1044, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Переменные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxVariables
            // 
            this.lbxVariables.FormattingEnabled = true;
            this.lbxVariables.ItemHeight = 16;
            this.lbxVariables.Location = new System.Drawing.Point(17, 11);
            this.lbxVariables.Margin = new System.Windows.Forms.Padding(4);
            this.lbxVariables.Name = "lbxVariables";
            this.lbxVariables.Size = new System.Drawing.Size(415, 388);
            this.lbxVariables.TabIndex = 10;
            this.lbxVariables.SelectedIndexChanged += new System.EventHandler(this.lbxVariables_SelectedIndexChanged);
            // 
            // btnDeleteVariable
            // 
            this.btnDeleteVariable.Location = new System.Drawing.Point(245, 412);
            this.btnDeleteVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteVariable.Name = "btnDeleteVariable";
            this.btnDeleteVariable.Size = new System.Drawing.Size(152, 28);
            this.btnDeleteVariable.TabIndex = 9;
            this.btnDeleteVariable.Text = "Удалить";
            this.btnDeleteVariable.UseVisualStyleBackColor = true;
            this.btnDeleteVariable.Click += new System.EventHandler(this.btnDeleteVariable_Click);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.Location = new System.Drawing.Point(36, 412);
            this.btnAddVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(168, 28);
            this.btnAddVariable.TabIndex = 8;
            this.btnAddVariable.Text = "Добавить";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // gbVar
            // 
            this.gbVar.Controls.Add(this.btnAddDomainCtx);
            this.gbVar.Controls.Add(this.lbxVarDomain);
            this.gbVar.Controls.Add(this.btnChangeVariable);
            this.gbVar.Controls.Add(this.gbQuest);
            this.gbVar.Controls.Add(this.rbQD);
            this.gbVar.Controls.Add(this.rbD);
            this.gbVar.Controls.Add(this.rbQ);
            this.gbVar.Controls.Add(this.label5);
            this.gbVar.Controls.Add(this.cmbVarDomain);
            this.gbVar.Controls.Add(this.label4);
            this.gbVar.Controls.Add(this.btnCancelVariable);
            this.gbVar.Controls.Add(this.btnSaveVariable);
            this.gbVar.Controls.Add(this.tbVarName);
            this.gbVar.Controls.Add(this.label3);
            this.gbVar.Location = new System.Drawing.Point(455, 7);
            this.gbVar.Margin = new System.Windows.Forms.Padding(4);
            this.gbVar.Name = "gbVar";
            this.gbVar.Padding = new System.Windows.Forms.Padding(4);
            this.gbVar.Size = new System.Drawing.Size(501, 432);
            this.gbVar.TabIndex = 7;
            this.gbVar.TabStop = false;
            this.gbVar.Text = "Информация о переменной";
            // 
            // btnAddDomainCtx
            // 
            this.btnAddDomainCtx.Location = new System.Drawing.Point(316, 62);
            this.btnAddDomainCtx.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDomainCtx.Name = "btnAddDomainCtx";
            this.btnAddDomainCtx.Size = new System.Drawing.Size(175, 28);
            this.btnAddDomainCtx.TabIndex = 11;
            this.btnAddDomainCtx.Text = "Добавить домен";
            this.btnAddDomainCtx.UseVisualStyleBackColor = true;
            this.btnAddDomainCtx.Click += new System.EventHandler(this.btnAddDomainCtx_Click);
            // 
            // lbxVarDomain
            // 
            this.lbxVarDomain.FormattingEnabled = true;
            this.lbxVarDomain.ItemHeight = 16;
            this.lbxVarDomain.Location = new System.Drawing.Point(12, 98);
            this.lbxVarDomain.Margin = new System.Windows.Forms.Padding(4);
            this.lbxVarDomain.Name = "lbxVarDomain";
            this.lbxVarDomain.Size = new System.Drawing.Size(479, 100);
            this.lbxVarDomain.TabIndex = 16;
            // 
            // btnChangeVariable
            // 
            this.btnChangeVariable.Location = new System.Drawing.Point(316, 30);
            this.btnChangeVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeVariable.Name = "btnChangeVariable";
            this.btnChangeVariable.Size = new System.Drawing.Size(176, 28);
            this.btnChangeVariable.TabIndex = 15;
            this.btnChangeVariable.Text = "Переименовать";
            this.btnChangeVariable.UseVisualStyleBackColor = true;
            this.btnChangeVariable.Click += new System.EventHandler(this.btnChangeVariable_Click);
            // 
            // gbQuest
            // 
            this.gbQuest.Controls.Add(this.tbQuestion);
            this.gbQuest.Location = new System.Drawing.Point(0, 294);
            this.gbQuest.Margin = new System.Windows.Forms.Padding(4);
            this.gbQuest.Name = "gbQuest";
            this.gbQuest.Padding = new System.Windows.Forms.Padding(4);
            this.gbQuest.Size = new System.Drawing.Size(491, 94);
            this.gbQuest.TabIndex = 13;
            this.gbQuest.TabStop = false;
            this.gbQuest.Text = "Вопрос";
            this.toolTip1.SetToolTip(this.gbQuest, "Вопрос, который будет задан пользователю при запросе переменной");
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(8, 23);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(479, 62);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // rbQD
            // 
            this.rbQD.AutoSize = true;
            this.rbQD.Location = new System.Drawing.Point(163, 267);
            this.rbQD.Margin = new System.Windows.Forms.Padding(4);
            this.rbQD.Name = "rbQD";
            this.rbQD.Size = new System.Drawing.Size(207, 21);
            this.rbQD.TabIndex = 12;
            this.rbQD.TabStop = true;
            this.rbQD.Tag = "1";
            this.rbQD.Text = "Выводимо-запрашиваемая";
            this.rbQD.UseVisualStyleBackColor = true;
            this.rbQD.CheckedChanged += new System.EventHandler(this.rbQD_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(163, 239);
            this.rbD.Margin = new System.Windows.Forms.Padding(4);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(104, 21);
            this.rbD.TabIndex = 11;
            this.rbD.TabStop = true;
            this.rbD.Tag = "1";
            this.rbD.Text = "Выводимая";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // rbQ
            // 
            this.rbQ.AutoSize = true;
            this.rbQ.Location = new System.Drawing.Point(163, 210);
            this.rbQ.Margin = new System.Windows.Forms.Padding(4);
            this.rbQ.Name = "rbQ";
            this.rbQ.Size = new System.Drawing.Size(137, 21);
            this.rbQ.TabIndex = 10;
            this.rbQ.TabStop = true;
            this.rbQ.Tag = "1";
            this.rbQ.Text = "Запрашиваемая";
            this.rbQ.UseVisualStyleBackColor = true;
            this.rbQ.CheckedChanged += new System.EventHandler(this.rbQ_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип переменной";
            // 
            // cmbVarDomain
            // 
            this.cmbVarDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVarDomain.FormattingEnabled = true;
            this.cmbVarDomain.Location = new System.Drawing.Point(141, 65);
            this.cmbVarDomain.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVarDomain.Name = "cmbVarDomain";
            this.cmbVarDomain.Size = new System.Drawing.Size(165, 24);
            this.cmbVarDomain.TabIndex = 8;
            this.cmbVarDomain.SelectedIndexChanged += new System.EventHandler(this.cmbVarDomain_SelectedIndexChanged);
            this.cmbVarDomain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDomainName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Домен";
            // 
            // btnCancelVariable
            // 
            this.btnCancelVariable.Location = new System.Drawing.Point(249, 396);
            this.btnCancelVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelVariable.Name = "btnCancelVariable";
            this.btnCancelVariable.Size = new System.Drawing.Size(176, 28);
            this.btnCancelVariable.TabIndex = 6;
            this.btnCancelVariable.Text = "Отменить изменения";
            this.btnCancelVariable.UseVisualStyleBackColor = true;
            this.btnCancelVariable.Click += new System.EventHandler(this.lbxVariables_SelectedIndexChanged);
            // 
            // btnSaveVariable
            // 
            this.btnSaveVariable.Location = new System.Drawing.Point(47, 396);
            this.btnSaveVariable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveVariable.Name = "btnSaveVariable";
            this.btnSaveVariable.Size = new System.Drawing.Size(176, 28);
            this.btnSaveVariable.TabIndex = 5;
            this.btnSaveVariable.Text = "Сохранить изменения";
            this.btnSaveVariable.UseVisualStyleBackColor = true;
            this.btnSaveVariable.Click += new System.EventHandler(this.btnSaveVariable_Click);
            // 
            // tbVarName
            // 
            this.tbVarName.Location = new System.Drawing.Point(141, 33);
            this.tbVarName.Margin = new System.Windows.Forms.Padding(4);
            this.tbVarName.Name = "tbVarName";
            this.tbVarName.ReadOnly = true;
            this.tbVarName.Size = new System.Drawing.Size(165, 22);
            this.tbVarName.TabIndex = 1;
            this.tbVarName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDomainName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя переменной";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbRule);
            this.tabPage3.Controls.Add(this.btnChangeRule);
            this.tabPage3.Controls.Add(this.lbxRules);
            this.tabPage3.Controls.Add(this.btnDeleteRule);
            this.tabPage3.Controls.Add(this.btnAddRule);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1044, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Правила";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChangeRule
            // 
            this.btnChangeRule.Location = new System.Drawing.Point(391, 416);
            this.btnChangeRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeRule.Name = "btnChangeRule";
            this.btnChangeRule.Size = new System.Drawing.Size(176, 28);
            this.btnChangeRule.TabIndex = 15;
            this.btnChangeRule.Text = "Редактировать";
            this.btnChangeRule.UseVisualStyleBackColor = true;
            this.btnChangeRule.Click += new System.EventHandler(this.btnChangeRule_Click);
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.ItemHeight = 16;
            this.lbxRules.Location = new System.Drawing.Point(11, 7);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(4);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(408, 404);
            this.lbxRules.TabIndex = 14;
            this.lbxRules.SelectedIndexChanged += new System.EventHandler(this.lbxRules_SelectedIndexChanged);
            this.lbxRules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxRules_MouseDown);
            this.lbxRules.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxRules_MouseMove);
            this.lbxRules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbxRules_MouseUp);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(575, 416);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(176, 28);
            this.btnDeleteRule.TabIndex = 13;
            this.btnDeleteRule.Text = "Удалить";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(216, 416);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(167, 28);
            this.btnAddRule.TabIndex = 12;
            this.btnAddRule.Text = "Добавить";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 518);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(529, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Добро пожаловать! Чтобы начать работу, откройте или создайте новый файл";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Бинарный файл | *.bin\"";
            // 
            // gbRule
            // 
            this.gbRule.Controls.Add(this.groupBox6);
            this.gbRule.Controls.Add(this.groupBox5);
            this.gbRule.Controls.Add(this.tbReasoning);
            this.gbRule.Controls.Add(this.label6);
            this.gbRule.Controls.Add(this.btnCancelRule);
            this.gbRule.Controls.Add(this.btnSaveRule);
            this.gbRule.Controls.Add(this.tbRuleName);
            this.gbRule.Controls.Add(this.label8);
            this.gbRule.Location = new System.Drawing.Point(427, 7);
            this.gbRule.Margin = new System.Windows.Forms.Padding(4);
            this.gbRule.Name = "gbRule";
            this.gbRule.Padding = new System.Windows.Forms.Padding(4);
            this.gbRule.Size = new System.Drawing.Size(558, 390);
            this.gbRule.TabIndex = 16;
            this.gbRule.TabStop = false;
            this.gbRule.Text = "Параметры правила";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbxThen);
            this.groupBox6.Location = new System.Drawing.Point(5, 242);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(569, 118);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Заключение";
            // 
            // lbxThen
            // 
            this.lbxThen.FormattingEnabled = true;
            this.lbxThen.ItemHeight = 16;
            this.lbxThen.Location = new System.Drawing.Point(11, 23);
            this.lbxThen.Margin = new System.Windows.Forms.Padding(4);
            this.lbxThen.Name = "lbxThen";
            this.lbxThen.Size = new System.Drawing.Size(549, 84);
            this.lbxThen.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbxIF);
            this.groupBox5.Location = new System.Drawing.Point(5, 52);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(569, 183);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Посылка";
            // 
            // lbxIF
            // 
            this.lbxIF.FormattingEnabled = true;
            this.lbxIF.ItemHeight = 16;
            this.lbxIF.Location = new System.Drawing.Point(11, 23);
            this.lbxIF.Margin = new System.Windows.Forms.Padding(4);
            this.lbxIF.Name = "lbxIF";
            this.lbxIF.Size = new System.Drawing.Size(549, 148);
            this.lbxIF.TabIndex = 17;
            // 
            // tbReasoning
            // 
            this.tbReasoning.Location = new System.Drawing.Point(107, 388);
            this.tbReasoning.Margin = new System.Windows.Forms.Padding(4);
            this.tbReasoning.Name = "tbReasoning";
            this.tbReasoning.Size = new System.Drawing.Size(460, 22);
            this.tbReasoning.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Объяснение";
            // 
            // btnCancelRule
            // 
            this.btnCancelRule.Location = new System.Drawing.Point(277, 434);
            this.btnCancelRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelRule.Name = "btnCancelRule";
            this.btnCancelRule.Size = new System.Drawing.Size(167, 28);
            this.btnCancelRule.TabIndex = 6;
            this.btnCancelRule.Text = "Отменить";
            this.btnCancelRule.UseVisualStyleBackColor = true;
            // 
            // btnSaveRule
            // 
            this.btnSaveRule.Location = new System.Drawing.Point(95, 434);
            this.btnSaveRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveRule.Name = "btnSaveRule";
            this.btnSaveRule.Size = new System.Drawing.Size(175, 28);
            this.btnSaveRule.TabIndex = 5;
            this.btnSaveRule.Text = "Сохранить";
            this.btnSaveRule.UseVisualStyleBackColor = true;
            // 
            // tbRuleName
            // 
            this.tbRuleName.Location = new System.Drawing.Point(113, 20);
            this.tbRuleName.Margin = new System.Windows.Forms.Padding(4);
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.ReadOnly = true;
            this.tbRuleName.Size = new System.Drawing.Size(271, 22);
            this.tbRuleName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Имя правила";
            // 
            // открытьПоследниеРезультатыToolStripMenuItem
            // 
            this.открытьПоследниеРезультатыToolStripMenuItem.Name = "открытьПоследниеРезультатыToolStripMenuItem";
            this.открытьПоследниеРезультатыToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.открытьПоследниеРезультатыToolStripMenuItem.Text = "Открыть последние результаты";
            this.открытьПоследниеРезультатыToolStripMenuItem.Click += new System.EventHandler(this.открытьПоследниеРезультатыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 539);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Экспертная система";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDomain.ResumeLayout(false);
            this.gbDomain.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbVar.ResumeLayout(false);
            this.gbVar.PerformLayout();
            this.gbQuest.ResumeLayout(false);
            this.gbQuest.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbRule.ResumeLayout(false);
            this.gbRule.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button btnAddDomain;
        public System.Windows.Forms.Button btnDeleteDomain;
        public System.Windows.Forms.GroupBox gbDomain;
        public System.Windows.Forms.Button btnDeleteValue;
        public System.Windows.Forms.Button btnChangeValue;
        public System.Windows.Forms.Button btnAddValue;
        public System.Windows.Forms.Button btnChangeDomain;
        public System.Windows.Forms.Button btnDeleteVariable;
        public System.Windows.Forms.Button btnAddVariable;
        public System.Windows.Forms.GroupBox gbVar;
        public System.Windows.Forms.TextBox tbVarName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbVarDomain;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gbQuest;
        public System.Windows.Forms.TextBox tbQuestion;
        public System.Windows.Forms.RadioButton rbQD;
        public System.Windows.Forms.RadioButton rbD;
        public System.Windows.Forms.RadioButton rbQ;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnChangeVariable;
        public System.Windows.Forms.Button btnDeleteRule;
        public System.Windows.Forms.Button btnAddRule;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelVariable;
        public System.Windows.Forms.Button btnSaveVariable;
        public System.Windows.Forms.ListBox lbxDomains;
        public System.Windows.Forms.ListBox lbxValues;
        public System.Windows.Forms.ListBox lbxVariables;
        public System.Windows.Forms.ListBox lbxRules;
        private System.Windows.Forms.ListBox lbxVarDomain;
        public System.Windows.Forms.Button btnChangeRule;
        public System.Windows.Forms.Button btnAddDomainCtx;
        public System.Windows.Forms.GroupBox gbRule;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.ListBox lbxThen;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ListBox lbxIF;
        public System.Windows.Forms.TextBox tbReasoning;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnCancelRule;
        public System.Windows.Forms.Button btnSaveRule;
        public System.Windows.Forms.TextBox tbRuleName;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem открытьПоследниеРезультатыToolStripMenuItem;
    }
}

