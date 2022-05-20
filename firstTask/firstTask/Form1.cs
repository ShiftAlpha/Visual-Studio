using System;
using System.Windows.Forms;

namespace firstTask
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            //Form1 form = new Form1();
            //Form1.SetDesktopLocation(0, 200);
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean flag = false;
            int number;
            double num;



            while (flag == false)
            {
                //String amount = textBox4.Text;
                int amount = Convert.ToInt32(textBox4.Text);
                double percentage = Convert.ToDouble(textBox1.Text);

                //if (int.TryParse(amount, out number) && double.TryParse(amount, out number)&& double.TryParse(amount, out num) )
                //{

                if (!Char.IsDigit(Convert.ToChar(amount))&& !Char.IsDigit(Convert.ToChar(percentage)))
                    {
                        flag = true;
                       
                        Convert.ToDouble(amount);

                        double tip = Convert.ToDouble(Math.Round(amount * (percentage / 100)));

                        Convert.ToDouble(amount);
                        //Double.Parse(amount);


                        //double.TryParse(amount, out num);

                        //amount = (int) amount / percentage; 

                        Convert.ToString(tip);
                        textBox3.Text = tip.ToString();
                        textBox2.Text = Convert.ToDecimal(tip + amount) + "";


                    }
                    else
                    {
                        MessageBox.Show("Enter a number");
                        flag = true;
                    }           
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
