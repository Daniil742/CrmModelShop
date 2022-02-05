using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product;
            textBoxProductName.Text = Product.Name;
            numericUpDownPrice.Value = Product.Price;
            numericUpDownCount.Value = Product.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            var p = Product ?? new Product();
            p.Name = textBoxProductName.Text;
            p.Price = numericUpDownPrice.Value;
            p.Count = Convert.ToInt32(numericUpDownCount.Value);
            Close();
        }
    }
}
