namespace MenuOrder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBoxMainChoice = new System.Windows.Forms.ComboBox();
            this.lblMainChoice = new System.Windows.Forms.Label();
            this.cmbBoxDrink = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListBoxTopping = new System.Windows.Forms.CheckedListBox();
            this.lblCondiments = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnCalculateOrder = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoxMainChoice
            // 
            this.cmbBoxMainChoice.FormattingEnabled = true;
            this.cmbBoxMainChoice.Items.AddRange(new object[] {
            "Cheeseburger",
            "Hamburger",
            "Hot Dog",
            "Salad"});
            this.cmbBoxMainChoice.Location = new System.Drawing.Point(72, 62);
            this.cmbBoxMainChoice.Name = "cmbBoxMainChoice";
            this.cmbBoxMainChoice.Size = new System.Drawing.Size(158, 21);
            this.cmbBoxMainChoice.Sorted = true;
            this.cmbBoxMainChoice.TabIndex = 0;
            // 
            // lblMainChoice
            // 
            this.lblMainChoice.AutoSize = true;
            this.lblMainChoice.Location = new System.Drawing.Point(69, 25);
            this.lblMainChoice.Name = "lblMainChoice";
            this.lblMainChoice.Size = new System.Drawing.Size(66, 13);
            this.lblMainChoice.TabIndex = 1;
            this.lblMainChoice.Text = "Main Choice";
            // 
            // cmbBoxDrink
            // 
            this.cmbBoxDrink.FormattingEnabled = true;
            this.cmbBoxDrink.Items.AddRange(new object[] {
            "Beer",
            "Coke",
            "Diet Coke",
            "Water"});
            this.cmbBoxDrink.Location = new System.Drawing.Point(352, 62);
            this.cmbBoxDrink.Name = "cmbBoxDrink";
            this.cmbBoxDrink.Size = new System.Drawing.Size(159, 21);
            this.cmbBoxDrink.Sorted = true;
            this.cmbBoxDrink.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drinks";
            // 
            // chkListBoxTopping
            // 
            this.chkListBoxTopping.FormattingEnabled = true;
            this.chkListBoxTopping.Items.AddRange(new object[] {
            "Bacon",
            "Ketchup",
            "Mustard",
            "Onions",
            "Pickles",
            "Tomato"});
            this.chkListBoxTopping.Location = new System.Drawing.Point(72, 147);
            this.chkListBoxTopping.Name = "chkListBoxTopping";
            this.chkListBoxTopping.Size = new System.Drawing.Size(120, 94);
            this.chkListBoxTopping.Sorted = true;
            this.chkListBoxTopping.TabIndex = 4;
            // 
            // lblCondiments
            // 
            this.lblCondiments.AutoSize = true;
            this.lblCondiments.Location = new System.Drawing.Point(72, 114);
            this.lblCondiments.Name = "lblCondiments";
            this.lblCondiments.Size = new System.Drawing.Size(62, 13);
            this.lblCondiments.TabIndex = 5;
            this.lblCondiments.Text = "Condiments";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(509, 147);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(512, 189);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(509, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Enabled = false;
            this.txtBoxSubtotal.Location = new System.Drawing.Point(352, 147);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(134, 20);
            this.txtBoxSubtotal.TabIndex = 9;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Enabled = false;
            this.txtBoxTax.Location = new System.Drawing.Point(352, 189);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.Size = new System.Drawing.Size(134, 20);
            this.txtBoxTax.TabIndex = 10;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Enabled = false;
            this.txtBoxTotal.Location = new System.Drawing.Point(352, 227);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(134, 20);
            this.txtBoxTotal.TabIndex = 11;
            // 
            // btnCalculateOrder
            // 
            this.btnCalculateOrder.Location = new System.Drawing.Point(72, 278);
            this.btnCalculateOrder.Name = "btnCalculateOrder";
            this.btnCalculateOrder.Size = new System.Drawing.Size(170, 70);
            this.btnCalculateOrder.TabIndex = 12;
            this.btnCalculateOrder.Text = "Get Total";
            this.btnCalculateOrder.UseVisualStyleBackColor = true;
            this.btnCalculateOrder.Click += new System.EventHandler(this.btnCalculateOrder_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(352, 278);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(170, 70);
            this.btnSubmitOrder.TabIndex = 13;
            this.btnSubmitOrder.Text = "SUBMIT ORDER";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.btnCalculateOrder);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxTax);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblCondiments);
            this.Controls.Add(this.chkListBoxTopping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxDrink);
            this.Controls.Add(this.lblMainChoice);
            this.Controls.Add(this.cmbBoxMainChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxMainChoice;
        private System.Windows.Forms.Label lblMainChoice;
        private System.Windows.Forms.ComboBox cmbBoxDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListBoxTopping;
        private System.Windows.Forms.Label lblCondiments;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnCalculateOrder;
        private System.Windows.Forms.Button btnSubmitOrder;
    }
}

