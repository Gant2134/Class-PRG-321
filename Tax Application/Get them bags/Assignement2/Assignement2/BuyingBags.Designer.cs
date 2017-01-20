namespace Assignement2
{
    partial class BuyingBags
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
            this.label_bags = new System.Windows.Forms.Label();
            this.Add_item = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Selected_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Shopping_Cart = new System.Windows.Forms.ListBox();
            this.Label_cart = new System.Windows.Forms.Label();
            this.Shipping_Rates = new System.Windows.Forms.GroupBox();
            this.m_rd_Standard = new System.Windows.Forms.RadioButton();
            this.m_rb_threeday = new System.Windows.Forms.RadioButton();
            this.m_rb_overnight = new System.Windows.Forms.RadioButton();
            this.label_shipping_costs = new System.Windows.Forms.Label();
            this.label_TAX = new System.Windows.Forms.Label();
            this.SUBMIT_ORDER = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label_quantity = new System.Windows.Forms.Label();
            this.Label_subtotal = new System.Windows.Forms.Label();
            this.Shipping_Rates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bags
            // 
            this.label_bags.AutoSize = true;
            this.label_bags.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bags.Location = new System.Drawing.Point(24, 9);
            this.label_bags.Name = "label_bags";
            this.label_bags.Size = new System.Drawing.Size(389, 37);
            this.label_bags.TabIndex = 0;
            this.label_bags.Text = "But these bags though...";
            // 
            // Add_item
            // 
            this.Add_item.Location = new System.Drawing.Point(109, 239);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(116, 23);
            this.Add_item.TabIndex = 2;
            this.Add_item.Text = "Add Selected";
            this.Add_item.UseVisualStyleBackColor = true;
            this.Add_item.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Full Decorative \t$50.00",
            "Beaded\t\t$45.00",
            "Needlepoint Design\t$40.00",
            "Fringed\t\t$25.00",
            "Fringed Beaded\t$30.00",
            "Plain\t\t$20.00"});
            this.listBox1.Location = new System.Drawing.Point(31, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 112);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Selected_item
            // 
            this.Selected_item.Location = new System.Drawing.Point(129, 212);
            this.Selected_item.Name = "Selected_item";
            this.Selected_item.ReadOnly = true;
            this.Selected_item.Size = new System.Drawing.Size(100, 20);
            this.Selected_item.TabIndex = 12;
            this.Selected_item.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your Selection";
            // 
            // Shopping_Cart
            // 
            this.Shopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shopping_Cart.FormattingEnabled = true;
            this.Shopping_Cart.ItemHeight = 18;
            this.Shopping_Cart.Location = new System.Drawing.Point(363, 78);
            this.Shopping_Cart.Name = "Shopping_Cart";
            this.Shopping_Cart.Size = new System.Drawing.Size(182, 112);
            this.Shopping_Cart.TabIndex = 16;
            // 
            // Label_cart
            // 
            this.Label_cart.AutoSize = true;
            this.Label_cart.Location = new System.Drawing.Point(360, 62);
            this.Label_cart.Name = "Label_cart";
            this.Label_cart.Size = new System.Drawing.Size(51, 13);
            this.Label_cart.TabIndex = 17;
            this.Label_cart.Text = "Your Cart";
            // 
            // Shipping_Rates
            // 
            this.Shipping_Rates.Controls.Add(this.m_rb_overnight);
            this.Shipping_Rates.Controls.Add(this.m_rb_threeday);
            this.Shipping_Rates.Controls.Add(this.m_rd_Standard);
            this.Shipping_Rates.Location = new System.Drawing.Point(25, 284);
            this.Shipping_Rates.Name = "Shipping_Rates";
            this.Shipping_Rates.Size = new System.Drawing.Size(200, 100);
            this.Shipping_Rates.TabIndex = 18;
            this.Shipping_Rates.TabStop = false;
            this.Shipping_Rates.Text = "Shipping";
            // 
            // m_rd_Standard
            // 
            this.m_rd_Standard.AutoSize = true;
            this.m_rd_Standard.Location = new System.Drawing.Point(7, 20);
            this.m_rd_Standard.Name = "m_rd_Standard";
            this.m_rd_Standard.Size = new System.Drawing.Size(129, 17);
            this.m_rd_Standard.TabIndex = 0;
            this.m_rd_Standard.TabStop = true;
            this.m_rd_Standard.Text = "Standard Shipping 5%";
            this.m_rd_Standard.UseVisualStyleBackColor = true;
            // 
            // m_rb_threeday
            // 
            this.m_rb_threeday.AutoSize = true;
            this.m_rb_threeday.Location = new System.Drawing.Point(7, 44);
            this.m_rb_threeday.Name = "m_rb_threeday";
            this.m_rb_threeday.Size = new System.Drawing.Size(142, 17);
            this.m_rb_threeday.TabIndex = 1;
            this.m_rb_threeday.TabStop = true;
            this.m_rb_threeday.Text = "Three Day Shipping (7%)";
            this.m_rb_threeday.UseVisualStyleBackColor = true;
            // 
            // m_rb_overnight
            // 
            this.m_rb_overnight.AutoSize = true;
            this.m_rb_overnight.Location = new System.Drawing.Point(7, 68);
            this.m_rb_overnight.Name = "m_rb_overnight";
            this.m_rb_overnight.Size = new System.Drawing.Size(144, 17);
            this.m_rb_overnight.TabIndex = 2;
            this.m_rb_overnight.TabStop = true;
            this.m_rb_overnight.Text = "Overnight Shipping (10%)";
            this.m_rb_overnight.UseVisualStyleBackColor = true;
            // 
            // label_shipping_costs
            // 
            this.label_shipping_costs.AutoSize = true;
            this.label_shipping_costs.Location = new System.Drawing.Point(268, 328);
            this.label_shipping_costs.Name = "label_shipping_costs";
            this.label_shipping_costs.Size = new System.Drawing.Size(77, 13);
            this.label_shipping_costs.TabIndex = 20;
            this.label_shipping_costs.Text = "Shipping Costs";
            // 
            // label_TAX
            // 
            this.label_TAX.AutoSize = true;
            this.label_TAX.Location = new System.Drawing.Point(268, 354);
            this.label_TAX.Name = "label_TAX";
            this.label_TAX.Size = new System.Drawing.Size(63, 13);
            this.label_TAX.TabIndex = 21;
            this.label_TAX.Text = "Grand Total";
            // 
            // SUBMIT_ORDER
            // 
            this.SUBMIT_ORDER.Location = new System.Drawing.Point(184, 413);
            this.SUBMIT_ORDER.Name = "SUBMIT_ORDER";
            this.SUBMIT_ORDER.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT_ORDER.TabIndex = 22;
            this.SUBMIT_ORDER.Text = "Submit";
            this.SUBMIT_ORDER.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(308, 213);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown2.TabIndex = 24;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(256, 215);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(46, 13);
            this.label_quantity.TabIndex = 25;
            this.label_quantity.Text = "Quantity";
            // 
            // Label_subtotal
            // 
            this.Label_subtotal.AutoSize = true;
            this.Label_subtotal.Location = new System.Drawing.Point(268, 304);
            this.Label_subtotal.Name = "Label_subtotal";
            this.Label_subtotal.Size = new System.Drawing.Size(46, 13);
            this.Label_subtotal.TabIndex = 26;
            this.Label_subtotal.Text = "Subtotal";
            // 
            // BuyingBags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(671, 474);
            this.Controls.Add(this.Label_subtotal);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.SUBMIT_ORDER);
            this.Controls.Add(this.label_TAX);
            this.Controls.Add(this.label_shipping_costs);
            this.Controls.Add(this.Shipping_Rates);
            this.Controls.Add(this.Label_cart);
            this.Controls.Add(this.Shopping_Cart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selected_item);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_item);
            this.Controls.Add(this.label_bags);
            this.Name = "BuyingBags";
            this.Text = "Form1";
            this.Shipping_Rates.ResumeLayout(false);
            this.Shipping_Rates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bags;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Selected_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Shopping_Cart;
        private System.Windows.Forms.Label Label_cart;
        private System.Windows.Forms.GroupBox Shipping_Rates;
        private System.Windows.Forms.RadioButton m_rb_overnight;
        private System.Windows.Forms.RadioButton m_rb_threeday;
        private System.Windows.Forms.RadioButton m_rd_Standard;
        private System.Windows.Forms.Label label_shipping_costs;
        private System.Windows.Forms.Label label_TAX;
        private System.Windows.Forms.Button SUBMIT_ORDER;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label Label_subtotal;
    }
}

