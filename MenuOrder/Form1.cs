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
        List<MainChoice> meals = new List<MainChoice>()
        {
            new MainChoice { Name = "Hamburger", Price = 5.00m},
            new MainChoice { Name = "Cheeseburger", Price = 5.45m},
            new MainChoice { Name = "HotDog", Price = 3.00m},
            new MainChoice { Name = "Salad", Price = 2.45m}
        };

        List<Drink> drinks = new List<Drink>()
        {
            new Drink {Name = "Beer", Price = 7.00m},
            new Drink {Name = "Coke", Price = 2.00m},
            new Drink {Name = "DietCoke", Price = 2.00m},
            new Drink {Name = "Water", Price = 0.50m}
        };

        double mainOrder;
        double drinkOrder;

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
            mainOrder = Convert.ToDouble(cmbBoxMainChoice.SelectedItem);
            drinkOrder = Convert.ToDouble(cmbBoxDrink.SelectedItem);
            subTotal = mainOrder + drinkOrder;
            txtBoxSubtotal.Text = subTotal.ToString("c");
        }

        
    }
}
