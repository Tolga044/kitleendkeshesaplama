using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitleendkshesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
    

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                double kilo, boy, index = 0;
                kilo = Convert.ToDouble(textBox2.Text);
                boy = Convert.ToDouble(textBox1.Text);
                index = kilo / (boy * boy);

                textBox3.Text=index.ToString();
                
            
            




            
                if ( index <= 18)
                {
                    label5.Text = "zayıf";

                }
                else if (index >= 18 && index < 25)
                {
                    label5.Text = "normal";
                }
                else if (index >= 25 && index < 30)
                {
                    label5.Text = "kilolu";
                }
                else if (index >= 30 && index < 35)
                {
                    label5.Text = "aşırı kilolu";

                }
                else
                {
                    label5.Text = "diyet önerilir";
                }
               
            




            
            
        }
    }
}
