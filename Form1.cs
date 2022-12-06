using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace МакДональдс
{
    public partial class Form1 : Form
    {
        public List<ProductClass> Product { get; set; }
        public class Helper
        {
            public static Timer timer;
            public static void SaveTxt(string path, List<ProductClass> products)
            {
                FileStream fs = new FileStream("ProductList.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                double value1;
                int value2;
                for (int i = 0; i < products.Count; i++)
                {
                    string a = products[i].Price.ToString();
                    string b = products[i].Kcal.ToString();
                    double.TryParse(string.Join("", a.Where(c => char.IsDigit(c))), out value1);
                    int.TryParse(string.Join("", b.Where(c => char.IsDigit(c))), out value2);
                    sw.WriteLine(products[i].Name + "|" + value1 + "|" + value2 + "|"  + products[i].CollectionStatus);
                }
                sw.Close();
            }
            public static List<ProductClass> LoadTxt(string path)
            {
                List<ProductClass> products = new List<ProductClass>();
                string[] productsTxt = System.IO.File.ReadAllLines("ProductList.txt");
                foreach (var product in productsTxt)
                {
                    var oneProduct = product.Split('|');
                    string name = oneProduct[0];
                    double price = Convert.ToDouble(oneProduct[1]);
                    int kcal = Convert.ToInt32(oneProduct[2]);
                    string collection_status = oneProduct[3]; 
                    products.Add(new ProductClass(name, price, kcal, collection_status));
                }
                return products;
            }
            public static void SaveJson(string path, List<ProductClass> products)
            {
                var serializedProducts = JsonSerializer.Serialize(products);
                System.IO.File.WriteAllText(path, serializedProducts);
            }
            public static List<ProductClass> LoadJson(string path)
            {
                var deserializedProducts = System.IO.File.ReadAllText(path);
                var pr = JsonSerializer.Deserialize<List<ProductClass>>(deserializedProducts);
                return pr;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Helper.timer = new Timer();
            Product = new List<ProductClass>
            {
                new ProductClass("BigMac", 300.0, 4000, "В колекції"),
                new ProductClass("McChicken", 180.0, 2700, "Не в колекції"),
                new ProductClass("Oreo McFlurry", 95.0, 2000, "Не в колекції"),
                new ProductClass("Coca-Cola", 45.0, 1900, "В колекції"),
                new ProductClass("Fanta", 45.0, 1900, "В колекції"),
                new ProductClass("Sprite", 45.0, 1900, "В колекції"),
                new ProductClass("Apple Pie", 60.0, 2300, "Не в колекції"),
                new ProductClass("RedBull", 38.0, 2300, "Не в колекції"),
                new ProductClass("Cappucino", 50.0, 300, "Не в колекції"),
                new ProductClass("9 Chicken McNuggets", 140.0, 1500,"В колекції"),
                new ProductClass("6 Chicken McNuggets", 100.0, 1250, "В колекції"),
                new ProductClass("McChicken Sandwich", 120.0, 2000, "В колекції"),
                new ProductClass("Late", 70.0, 1000, "Не в колекції"),
                new ProductClass("Green Tea", 40.0, 200, "Не в колекції"),
                new ProductClass("Black Tea", 40.0, 200, "Не в колекції"),
                new ProductClass("Still Water", 25.0, 100, "Не в колекції")
            };
            productClassBindingSource.DataSource = Product;
            Helper.timer.Enabled = true;
            Helper.timer.Interval = 1000;
            Helper.timer.Tick += (sender, args) =>
            {
                int seconds = Convert.ToInt32(label1.Text);
                seconds += 1;
                label1.Text = seconds.ToString();
            };
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("В таблиці відсутні дані про продукти");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    var minimum = Product.OrderBy(x => x.Price).First();
                    productClassBindingSource.DataSource = minimum;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    var maximum = Product.OrderBy(x => x.Price).Last();
                    productClassBindingSource.DataSource = maximum;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    var query = Product.Where(x => x.CollectionStatus.Equals("В колекції")).Select(x => x).ToList();
                    productClassBindingSource.DataSource = query;
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            var addpr = new AddNewProductForm();
            if(addpr.ShowDialog() == DialogResult.OK)
            {
                productClassBindingSource.Add(addpr.pr);
            }
            else
            {
                MessageBox.Show("Операція скасована", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aboutme = new AboutMeForm();
            aboutme.ShowDialog();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                productClassBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("Помилка видалення, таблиця порожня", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveTxtButton_Click(object sender, EventArgs e)
        {
            Helper.SaveTxt("C:\\Users\\Lenovo\\Desktop\\ЛАБА4 ООП\\МакДональдс\\ProductsList.txt", Product);
        }
        private void LoadTxtButton_Click(object sender, EventArgs e)
        {
            Product = Helper.LoadTxt("C:\\Users\\Lenovo\\Desktop\\ЛАБА4 ООП\\МакДональдс\\ProductsList.txt");
            productClassBindingSource.DataSource = Product;
        }
        private void SerializeJsonButton_Click(object sender, EventArgs e)
        {
            Helper.SaveJson("products.json", Product);
        }
        private void DeserializeJsonButton_Click(object sender, EventArgs e)
        {
            Product = Helper.LoadJson("products.json");
            productClassBindingSource.DataSource = Product;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditGridViewForm form = new EditGridViewForm(this);
            form.ShowDialog();
            form.textBox1.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
            form.textBox2.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            form.textBox3.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            form.textBox4.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productClassBindingSource.DataSource = Product;
        }
    }
}
