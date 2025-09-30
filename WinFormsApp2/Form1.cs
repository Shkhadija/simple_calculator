namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("ishlem daxil edin", "Information");
            }
            else
            {
                double n1 = Convert.ToDouble(maskedTextBox1.Text);
                double n2 = Convert.ToDouble(maskedTextBox2.Text);
                char k = Convert.ToChar(comboBox1.Text);

                if (k == '*')
                {
                    result = n1 * n2;
                }
                else if (k == '-')
                {
                    result = n1 - n2;
                }
                else if (k == '+')
                {
                    result = n1 + n2;
                }
                else if (k == '/')
                {
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        MessageBox.Show("invalid result", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("invalid operatio", "Information");
                }
                listBox1.Items.Add(n1 + " " + k + " " + n2 + "=" + result);
            }
        }
    }
}
