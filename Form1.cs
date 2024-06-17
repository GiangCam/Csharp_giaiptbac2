using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_giaiptbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtB.Text = akbB.Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
          double a, b, c;
            a = Convert.ToDouble (txtA.Text);
            b = Convert.ToDouble (txtB.Text);
            c = Convert.ToDouble (txtC.Text);
            double delta, x1, x2;
            if (a == 0)
            
                if (b == 0)
                
                    if (c != 0)
                    
                        lblKQ.Text = "Phương trình vô nghiệm ";


                     else 
                    
                        lblKQ.Text = " Phương trình vô số nghiệm";

                    
                
                else
                
                   
                    lblKQ.Text = "Phương trình có nghiệm x1 =x2: " + ((-c) / b).ToString();
            else
            {
                delta = b + b - 4 * a * c;
                if (delta < 0)
                    lblKQ.Text = " Phương trình vô nghiệm ";
                else
                {
                    if (delta == 0)
                        lblKQ.Text = "Phương trình có nghiệm" + ((-b) / (2*a )).ToString();
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        lblKQ.Text = "Phương trình có nghiệm\n " + "x1 = " + x1 + "\nx2= " + x2;

                    }    
                }
            }


                }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtA.Text = akbA.Value.ToString();
        }

        private void akbC_Scroll(object sender, EventArgs e)
        {
            txtC.Text = akbC.Value.ToString();
        }
    }
        }
    
