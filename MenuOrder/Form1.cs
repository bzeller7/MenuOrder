﻿using System;
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
            new MainChoice { Name = "Hamburger", Price = 5.00d },
            new MainChoice { Name = "Cheeseburger", Price = 5.45d },
            new MainChoice { Name = "HotDog", Price = 3.00d },
            new MainChoice { Name = "Salad", Price = 2.45d }
        };

        List<Drink> drinks = new List<Drink>()
        {
            new Drink { Name = "Beer", Price = 7.00d },
            new Drink { Name = "Coke", Price = 2.00d },
            new Drink { Name = "DietCoke", Price = 2.00d },
            new Drink { Name = "Water", Price = 0.50d }
        };

        /// <summary>
        /// Populates the combo boxes with the food drink objects
        /// </summary>
        private void BindComboBoxes()
        {
            cmbBoxMainChoice.DataSource = meals;
            cmbBoxMainChoice.DisplayMember = "Name";
            cmbBoxDrink.DataSource = drinks;
            cmbBoxDrink.DisplayMember = "Name";
        }

        double subTotal = 0.0d;
        double Tax = 0.00d;
        double salesTax = 0.08;
        double Order_total = 0.0d;

        public Form1()
        {
            InitializeComponent();
            BindComboBoxes();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for ordering " + cmbBoxMainChoice.Text + " and " + cmbBoxDrink.Text + "!");
            MessageBox.Show("Please pay " + txtBoxTotal.Text + " to the cashier");
            Application.Exit();
        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            //retrieve the food and drink selections as objects
            //and gets their prices 
            MainChoice m = cmbBoxMainChoice.SelectedItem as MainChoice;
            subTotal += m.Price;
            Drink d = cmbBoxDrink.SelectedItem as Drink;
            subTotal += d.Price;
            Tax += subTotal * salesTax;
            Order_total = subTotal + Tax;

            txtBoxSubtotal.Text = subTotal.ToString("c"); //send subTotal to TextBox
            txtBoxTax.Text = Tax.ToString("c"); // send Tax to TextBox
            txtBoxTotal.Text = Order_total.ToString("c");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);
        }
    }
}
