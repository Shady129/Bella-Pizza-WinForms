namespace Pizza_store
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            UpdateTotalPrice();
        }

        public float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);

            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

        }


        public float CalculateToppingsPrice()
        {
            float total = 0;

            foreach (Control control in gbToppings.Controls)
            {

                if (control is CheckBox ck && ck.Checked)
                {
                    total += (float)(ck.Tag);
                }
            }

            return total;
        }


        public float GetSelectedCrustPrice()
        {

            if (rbThinCrust.Checked)
            {

                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
        }




        public float CalculateTotalPrice()
        {

            float TotalPrice = GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();

            return TotalPrice;

        }




        public void UpdateTotalPrice()
        {
            if (rbSmall.Checked)
                lblSizeValue.Text = "Small";
            else if (rbMedium.Checked)
                lblSizeValue.Text = "Medium";
            else
                lblSizeValue.Text = "Large";


            if (rbThickCrust.Checked)
                lblCrustValue.Text = "Thin Crust";
            else
                lblCrustValue.Text = "Thick Crust";




            string toppings = "";


            foreach (Control control in gbToppings.Controls)
            {

                if (control is CheckBox ck && ck.Checked)
                {
                    toppings += ck.Text + '\n';
                }
            }

            if (toppings == "")
            {
                lblToppingsValue.Text = "No Toppings";
            }
            else
            {
                lblToppingsValue.Text = toppings;
            }

            lblTotalValue.Text = "$ " + CalculateTotalPrice().ToString();
        }

        private void AnyOption_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

       
    }
}
