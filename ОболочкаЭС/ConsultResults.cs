using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ОболочкаЭС
{
    public partial class ConsultResults : Form
    {
        public ConsultResults()
        {
            InitializeComponent();
        }

        public void FillForms(BaseOfKnowledge kbase, Variable var)
        {
            lbl_goal.Text = "Цель консультации: " + var.name + " = " +
            kbase.valuableVariable.Find(delegate(VarsWithValue v) { return v.var.name == var.name; }).value;
            if (kbase.workedRules.Count > 0)
                lbl_explain.Text = "Объяснение: " + kbase.workedRules[kbase.workedRules.Count - 1].reason;
            else lbl_explain.Text = "Цель не получена";
            foreach (VarsWithValue vWv in kbase.valuableVariable)
            {
                lbx_workMemory.Items.Add(vWv.var.name + " = " + vWv.value);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tview_steps.ExpandAll();
        }

        private void ConsultResults_Load(object sender, EventArgs e)
        {

        }
    }
}
