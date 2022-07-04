using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dphv1
{
    public partial class nobet : Form
    {
        public nobet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            if (checkBox1.Checked == true)
            {
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {












        }

        private void button3_Click(object sender, EventArgs e)
        {
  
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nobet_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.Text == "y1")
            {
                y1.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            if (listBox2.Text == "y2")
            {
                y2.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "y3")
            {
                y3.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "y4")
            {
                y4.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }


            if (listBox2.Text == "y5")
            {
                y5.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }


            if (listBox2.Text == "y6")
            {
                y6.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            if (listBox2.Text == "y7")
            {
                y7.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }





            if (listBox2.Text == "bölüm1")
            {
                label1.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }


            if (listBox2.Text == "bölüm2")
            {
                label2.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            if (listBox2.Text == "bölüm3")
            {
                label3.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm4")
            {
                label4.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            if (listBox2.Text == "bölüm5")
            {
                label5.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm6")
            {
                label6.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm7")
            {
                label7.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm8")
            {
                label8.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm9")
            {
                label9.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }


            if (listBox2.Text == "bölüm10")
            {
                label10.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
            if (listBox2.Text == "bölüm11")
            {
                label11.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm12")
            {
                label12.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm13")
            {
                label13.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm14")
            {
                label14.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm15")
            {
                label15.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }


            if (listBox2.Text == "bölüm16")
            {
                label16.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm17")
            {
                label17.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm18")
            {
                label18.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm19")
            {
                label19.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm20")
            {
                label20.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm21")
            {
                label21.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm22")
            {
                label22.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm23")
            {
                label23.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm24")
            {
                label24.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm25")
            {
                label25.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm26")
            {
                label26.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm27")
            {
                label27.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm28")
            {
                label28.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm29")
            {
                label29.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm30")
            {
                label30.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm31")
            {
                label31.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm32")
            {
                label32.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm33")
            {
                label33.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm34")
            {
                label34.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (listBox2.Text == "bölüm35")
            {
                label35.Text = listBox1.Text;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            
            



        }

        private void button6_Click(object sender, EventArgs e)
        {
              
        }
    }
}
