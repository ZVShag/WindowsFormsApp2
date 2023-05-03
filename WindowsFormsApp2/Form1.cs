using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturing { get; set; }
        public int Count { get; set; }


        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", this.Name, this.Price, this.Manufacturing, this.Count);
        }
    }
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public string st = "";
        public Form1()
        {
            InitializeComponent();
        
        }
        public void Linq_method()
        {
            string[] country = {"Albania", "UK",
                                "Lithuania", "Andorra", "Austria",
                                "Latvia", "Liechtenstein", "Switzerland",
                                "Ireland", "Sweden","Italy", "France",
                                "Liechtenstein", "Spain", "Turkey", "Germany",
                                "Switzerland", "Monaco", "Montenegro",
                                "Norway", "Finland", "Turkey", "UK", "Poland",
                                "Portugal", "Lithuania", "Luxembourg"
                                 };
            
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
                products.Add(new Product
                {
                    Name = "Product" + (++i),
                    Price = (new Random()).Next(0, 10000),
                    Manufacturing = country[(new Random()).Next(0, country.Length - 1)],
                    Count = (new Random()).Next(0, 100)
                });
            }
        }
        public void start_with()
        {

            var result = products.Where(x => x.Manufacturing.StartsWith(st));
            label1.Text=string.Join(Environment.NewLine, result);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            st = textBox1.Text;
            string[] country = {"Albania", "UK",
                                "Lithuania", "Andorra", "Austria",
                                "Latvia", "Liechtenstein", "Switzerland",
                                "Ireland", "Sweden","Italy", "France",
                                "Liechtenstein", "Spain", "Turkey", "Germany",
                                "Switzerland", "Monaco", "Montenegro",
                                "Norway", "Finland", "Turkey", "UK", "Poland",
                                "Portugal", "Lithuania", "Luxembourg"
                                 };
            if (checkBox1.Checked)
            {
                var result = country.Where(x => x.StartsWith(st));
                label1.Text = string.Join(Environment.NewLine, result);
            }
            if (checkBox2.Checked)
            {
                var result = country.Where(x => x.Contains(st));
                label1.Text = string.Join(Environment.NewLine, result);
            }

        }
    }
}
