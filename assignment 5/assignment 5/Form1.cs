using System.Drawing.Text;

namespace assignment_5
{
    public partial class Form1 : Form
    {
        int value;
        Random rnd;
        
        public Form1()
        {
            rnd = new Random();
            value = rnd.Next(1, 100);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
                int a = Convert.ToInt32(textBox1.Text);
                if (a > value)
                {
                MessageBox.Show("Too hight, try again");
                }
                else if (a < value)
                {
                MessageBox.Show("Too low, try again");
                }
                else
                {
                MessageBox.Show("Congratulation");
                value = rnd.Next(1, 10);
                }
            

        }
    }
}