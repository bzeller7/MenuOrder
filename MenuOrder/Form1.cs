using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuOrder
{
    public partial class Form1 : Form
    {
        const double Hamburger = 5.00d;
        const double Cheeseburger = 5.45d;
        const double HotDog = 3.00d;
        const double Salad = 2.45d;
        const double Tax = 7.75d;

        double AddOn_Soda = 2.00d;

        double Order_total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
