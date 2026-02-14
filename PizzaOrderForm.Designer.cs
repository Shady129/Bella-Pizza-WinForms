namespace Pizza_store
{
    partial class PizzaOrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrderForm));
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            gbSize = new GroupBox();
            gbToppings = new GroupBox();
            chkGreenPeppers = new CheckBox();
            chkTomatoes = new CheckBox();
            chkOlives = new CheckBox();
            chkOnion = new CheckBox();
            chkMushrooms = new CheckBox();
            chkExtraCheese = new CheckBox();
            gbCrust = new GroupBox();
            rbThickCrust = new RadioButton();
            rbThinCrust = new RadioButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblSizeTitle = new Label();
            lblSizeValue = new Label();
            lblToppingsTitle = new Label();
            lblToppingsValue = new Label();
            lblCrustTitle = new Label();
            lblCrustValue = new Label();
            lblTotalTitle = new Label();
            lblTotalValue = new Label();
            gbSummary = new GroupBox();
            gbSize.SuspendLayout();
            gbToppings.SuspendLayout();
            gbCrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbSummary.SuspendLayout();
            SuspendLayout();
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(26, 45);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(60, 21);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Tag = 5F;
            rbSmall.Text = "Small";
            rbSmall.UseVisualStyleBackColor = true;
            rbSmall.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(26, 84);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(77, 21);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Tag = 7F;
            rbMedium.Text = "Medium";
            rbMedium.UseVisualStyleBackColor = true;
            rbMedium.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(26, 129);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(60, 21);
            rbLarge.TabIndex = 2;
            rbLarge.TabStop = true;
            rbLarge.Tag = 10F;
            rbLarge.Text = "Large";
            rbLarge.UseVisualStyleBackColor = true;
            rbLarge.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // gbSize
            // 
            gbSize.Controls.Add(rbLarge);
            gbSize.Controls.Add(rbMedium);
            gbSize.Controls.Add(rbSmall);
            gbSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSize.Location = new Point(32, 303);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(147, 194);
            gbSize.TabIndex = 0;
            gbSize.TabStop = false;
            gbSize.Text = "Size";
            // 
            // gbToppings
            // 
            gbToppings.Controls.Add(chkGreenPeppers);
            gbToppings.Controls.Add(chkTomatoes);
            gbToppings.Controls.Add(chkOlives);
            gbToppings.Controls.Add(chkOnion);
            gbToppings.Controls.Add(chkMushrooms);
            gbToppings.Controls.Add(chkExtraCheese);
            gbToppings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbToppings.Location = new Point(774, 37);
            gbToppings.Name = "gbToppings";
            gbToppings.Size = new Size(166, 279);
            gbToppings.TabIndex = 1;
            gbToppings.TabStop = false;
            gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            chkGreenPeppers.AutoSize = true;
            chkGreenPeppers.Location = new Point(26, 235);
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Size = new Size(116, 21);
            chkGreenPeppers.TabIndex = 11;
            chkGreenPeppers.Tag = 1F;
            chkGreenPeppers.Text = "Green Peppers";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            chkGreenPeppers.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Location = new Point(26, 196);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(87, 21);
            chkTomatoes.TabIndex = 10;
            chkTomatoes.Tag = 1F;
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            chkTomatoes.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Location = new Point(26, 158);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(65, 21);
            chkOlives.TabIndex = 9;
            chkOlives.Tag = 1F;
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Location = new Point(26, 81);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(65, 21);
            chkOnion.TabIndex = 8;
            chkOnion.Tag = 2F;
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(26, 120);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(100, 21);
            chkMushrooms.TabIndex = 7;
            chkMushrooms.Tag = 3F;
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            chkMushrooms.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Location = new Point(26, 45);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(105, 21);
            chkExtraCheese.TabIndex = 6;
            chkExtraCheese.Tag = 5F;
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            chkExtraCheese.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // gbCrust
            // 
            gbCrust.Controls.Add(rbThickCrust);
            gbCrust.Controls.Add(rbThinCrust);
            gbCrust.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCrust.Location = new Point(32, 76);
            gbCrust.Name = "gbCrust";
            gbCrust.Size = new Size(147, 171);
            gbCrust.TabIndex = 2;
            gbCrust.TabStop = false;
            gbCrust.Text = "Crust";
            // 
            // rbThickCrust
            // 
            rbThickCrust.AutoSize = true;
            rbThickCrust.Location = new Point(13, 113);
            rbThickCrust.Name = "rbThickCrust";
            rbThickCrust.Size = new Size(95, 21);
            rbThickCrust.TabIndex = 1;
            rbThickCrust.TabStop = true;
            rbThickCrust.Tag = 2F;
            rbThickCrust.Text = "Thick Crust";
            rbThickCrust.UseVisualStyleBackColor = true;
            rbThickCrust.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // rbThinCrust
            // 
            rbThinCrust.AutoSize = true;
            rbThinCrust.Location = new Point(13, 52);
            rbThinCrust.Name = "rbThinCrust";
            rbThinCrust.Size = new Size(90, 21);
            rbThinCrust.TabIndex = 0;
            rbThinCrust.TabStop = true;
            rbThinCrust.Tag = 0F;
            rbThinCrust.Text = "Thin Crust";
            rbThinCrust.UseVisualStyleBackColor = true;
            rbThinCrust.CheckedChanged += AnyOption_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 37);
            label1.Name = "label1";
            label1.Size = new Size(260, 40);
            label1.TabIndex = 4;
            label1.Text = "Bella Pizza 🍕";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 323);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblSizeTitle
            // 
            lblSizeTitle.AutoSize = true;
            lblSizeTitle.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSizeTitle.Location = new Point(9, 26);
            lblSizeTitle.Name = "lblSizeTitle";
            lblSizeTitle.Size = new Size(43, 18);
            lblSizeTitle.TabIndex = 6;
            lblSizeTitle.Text = "Size";
            // 
            // lblSizeValue
            // 
            lblSizeValue.AutoSize = true;
            lblSizeValue.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSizeValue.Location = new Point(104, 32);
            lblSizeValue.Name = "lblSizeValue";
            lblSizeValue.Size = new Size(22, 15);
            lblSizeValue.TabIndex = 7;
            lblSizeValue.Text = "\"-\"";
            // 
            // lblToppingsTitle
            // 
            lblToppingsTitle.AutoSize = true;
            lblToppingsTitle.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToppingsTitle.Location = new Point(186, 18);
            lblToppingsTitle.Name = "lblToppingsTitle";
            lblToppingsTitle.Size = new Size(85, 17);
            lblToppingsTitle.TabIndex = 8;
            lblToppingsTitle.Text = "\"Toppings\"";
            // 
            // lblToppingsValue
            // 
            lblToppingsValue.AutoSize = true;
            lblToppingsValue.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToppingsValue.Location = new Point(209, 53);
            lblToppingsValue.Name = "lblToppingsValue";
            lblToppingsValue.Size = new Size(22, 15);
            lblToppingsValue.TabIndex = 9;
            lblToppingsValue.Text = "\"-\"";
            // 
            // lblCrustTitle
            // 
            lblCrustTitle.AutoSize = true;
            lblCrustTitle.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrustTitle.Location = new Point(6, 95);
            lblCrustTitle.Name = "lblCrustTitle";
            lblCrustTitle.Size = new Size(95, 18);
            lblCrustTitle.TabIndex = 10;
            lblCrustTitle.Text = "Crust Type";
            // 
            // lblCrustValue
            // 
            lblCrustValue.AutoSize = true;
            lblCrustValue.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrustValue.Location = new Point(110, 98);
            lblCrustValue.Name = "lblCrustValue";
            lblCrustValue.Size = new Size(22, 15);
            lblCrustValue.TabIndex = 11;
            lblCrustValue.Text = "\"-\"";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalTitle.Location = new Point(9, 217);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(117, 18);
            lblTotalTitle.TabIndex = 12;
            lblTotalTitle.Text = "Total Price:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(197, 217);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(61, 46);
            lblTotalValue.TabIndex = 13;
            lblTotalValue.Text = "$0";
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(lblToppingsValue);
            gbSummary.Controls.Add(lblCrustValue);
            gbSummary.Controls.Add(lblTotalValue);
            gbSummary.Controls.Add(lblSizeValue);
            gbSummary.Controls.Add(lblTotalTitle);
            gbSummary.Controls.Add(lblSizeTitle);
            gbSummary.Controls.Add(lblCrustTitle);
            gbSummary.Controls.Add(lblToppingsTitle);
            gbSummary.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSummary.Location = new Point(642, 322);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(326, 285);
            gbSummary.TabIndex = 14;
            gbSummary.TabStop = false;
            gbSummary.Text = "Order Summary";
            // 
            // labelSizeValue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(980, 619);
            Controls.Add(gbSummary);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(gbCrust);
            Controls.Add(gbToppings);
            Controls.Add(gbSize);
            Name = "labelSizeValue";
            Text = "Bella Pizza 🍕";
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbToppings.ResumeLayout(false);
            gbToppings.PerformLayout();
            gbCrust.ResumeLayout(false);
            gbCrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private GroupBox gbSize;
        private GroupBox gbToppings;
        private GroupBox gbCrust;
        private RadioButton rbThickCrust;
        private RadioButton rbThinCrust;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox chkGreenPeppers;
        private CheckBox chkTomatoes;
        private CheckBox chkOlives;
        private CheckBox chkOnion;
        private CheckBox chkMushrooms;
        private CheckBox chkExtraCheese;
        private Label lblSizeTitle;
        private Label lblSizeValue;
        private Label lblToppingsTitle;
        private Label lblToppingsValue;
        private Label lblCrustTitle;
        private Label lblCrustValue;
        private Label lblTotalTitle;
        private Label lblTotalValue;
        private GroupBox gbSummary;
    }
}
