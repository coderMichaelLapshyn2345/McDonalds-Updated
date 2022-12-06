using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace МакДональдс
{
    public partial class AddNewProductForm : Form
    {
        public ProductClass pr { get; private set; }
        public AddNewProductForm()
        {
            InitializeComponent();
        }
        private void AddingProduct_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") || (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == ""))
            {
                MessageBox.Show("Заповніть поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                pr = new ProductClass(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Введіть коректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
