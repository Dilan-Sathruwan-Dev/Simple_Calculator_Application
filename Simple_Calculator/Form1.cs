namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num_1.Text);
            double num2 = double.Parse(txt_Num_2.Text);
            double result = num1 + num2;
            txt_Result.Text = result.ToString();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Num_1.Text = "";
            txt_Num_2.Text = "";
            txt_Result.Text = "";
        }

        private void btn_low_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num_1.Text);
            double num2 = double.Parse(txt_Num_2.Text);
            double result = num1 - num2;
            txt_Result.Text = result.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num_1.Text);
            double num2 = double.Parse(txt_Num_2.Text);
            double result = num1 * num2;
            txt_Result.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
         
                double num1 = double.Parse(txt_Num_1.Text);
                double num2 = double.Parse(txt_Num_2.Text);

                if (num2 == 0)
                {
                    MessageBox.Show("Cannot Divide by Zero.");
                    return;
                }
                double result = num1 / num2;
                txt_Result.Text = result.ToString();
            }
           
        }
    }
