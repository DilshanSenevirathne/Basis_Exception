using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb1 = Convert.ToInt32(textBox1.Text);
            int numb2 = Convert.ToInt32(textBox2.Text);
            int answer = 0;

            
            if (((numb1==0) || (numb2==0)) || ((numb1 == 0)&(numb2 == 0))) //if number 1 or 2 zero or both are zero,
            {                                                              //it won`t give an answer.
                try
                {
                    if (numb1==0)
                    {
                        answer = (numb2 / numb1);
                    }
                    else if (numb2 == 0)
                    {
                        answer = (numb1 / numb2);
                    }
                    
                }
                catch (Exception)
                {
                    textBox3.Clear();                                  //give a messege to user and
                    MessageBox.Show("Can`t divide by Zero","Messege"); //answer box will be cleared.
                }
            }
            else  //if both numbers aren`t equal to zero,gives the divided answer.
            {
                answer = (numb1 / numb2);
                textBox3.Text = Convert.ToString(answer);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int startLoop = 11;
            int endLoop = 1;
            int answer = 0;

            

            for (int i = startLoop; i < endLoop; i++)
            {
                answer = answer + 1;
            }

            MessageBox.Show("answer = "+answer.ToString());
        }
    }
}
