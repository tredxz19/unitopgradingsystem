using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace gradingsystem

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbutton.PerformClick();
            }
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            try

            {

                double first = (Convert.ToDouble(textBox1.Text));
                double second = (Convert.ToDouble(textBox2.Text));
                double third = (Convert.ToDouble(textBox3.Text));
                double fourth = (Convert.ToDouble(textBox4.Text));

                double final = ((first + second + third + fourth) / 4);

                textBox5.Text = (Convert.ToString(final));



                if (final < 75)
                {
                    label6.Text = "You Is Failed" + " " + (final);
                }
                else
                {
                    label6.Text = "You Is Passed" + " " + (final);
                }
            }

            catch (Exception ex)
            {
                label6.Text = ex.Message;
                label6.Text = "Wrong Input Try Again";
            }










        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string student = "student";
          
            if (Logintextbox.Text == student && Passtextbox.Text == student)
            {
                
                Loginpanel.Visible = false;
                Gradingpanel.Visible = true;
                Gradingpanel.BringToFront();
                Logintextbox.Clear();
                Passtextbox.Clear();
            

            }
        
            

            else 
                {
                    Noticelabel.Text = "Incorrect Username or Password";
                Logintextbox.Clear();
                Passtextbox.Clear();
            }

            }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Passtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbutton.PerformClick();
            }
                    
                    
                    }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Passtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
        }
   
    

