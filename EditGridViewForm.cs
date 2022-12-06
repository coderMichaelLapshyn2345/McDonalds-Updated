using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace МакДональдс
{
    public partial class EditGridViewForm : Form
    {
        private readonly Form1 frm1;
        public EditGridViewForm(Form1 frm)
        {
            InitializeComponent();
            this.frm1 = frm;
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditGridViewForm frm = new EditGridViewForm(frm1);
                frm1.dataGridView.CurrentRow.Cells[0].Value = textBox1.Text;
                frm1.dataGridView.CurrentRow.Cells[1].Value = Convert.ToDouble(textBox2.Text);
                frm1.dataGridView.CurrentRow.Cells[2].Value = Convert.ToInt32(textBox3.Text);
                frm1.dataGridView.CurrentRow.Cells[3].Value = textBox4.Text;
                Close();
            }
            catch { MessageBox.Show("Введіть коректні дані", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
