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
        double Hamburger = 5.00d;
        double Cheeseburger = 5.45d;
        double HotDog = 3.00d;
        double Salad = 2.45d;
        double Beer = 7.00d;
        double Coke = 2.00d;
        double DietCoke = 2.00d;
        double Water = 0.5d;

        double mainOrder = 0.0d;
        double drinkOrder = 0.0d;

        double subTotal = 0.0d;
        double Tax = 7.75d;
        double Order_total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
