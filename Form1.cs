using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Add("BOB");
            comboBox1.Items.Add("ILS");
            comboBox1.Items.Add("GBP");
            comboBox1.Items.Add("EUR");
            TextBox textBoxUSD = new TextBox();
            TextBox textBoxOtherCurrency = new TextBox();

        }

        private void calculate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
