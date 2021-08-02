using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const double Price_voda = 1.5;
        const double Price_soknarandza = 2.0;
        const double Price_kafa = 1.5;
        const double Price_cola = 2.5;
        const double Price_caj = 1.5;
        const double Price_vanilijashake = 2.5;
        const double Price_jagodashake = 3.0;
        const double Price_cokoladnishake = 3.5;
        const double Price_vocnimix = 4.0;
        const double Price_cokomafin = 2.5;
        const double Price_palacincikinderbueno = 5.5;
        const double Price_palacinciraffaelo = 6.5;
        const double Price_cheescake = 4.5;
        const double Price_vocnikolac = 3.5;
        const double Price_pomfrit = 2.0;
        const double Price_salata = 2.5;
        const double Price_lukac = 2.0;
        const double Price_pilecasalata = 4.0;
        const double Price_ribljisendvic = 3.5;
        const double Price_cheesburger = 3.5;
        const double Price_hamburger = 3.0;
        const double Price_chickenburger = 2.5;
        const double Tax_Rate = 0.30;

        double iTax, iSubTotal, iTotal;
        



        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Potvrdite da želite izaći iz aplikacije", "Restaurant App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);

        }
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
            label3.Text = "";
            lbl2.Text = "";
            lbl1.Text = "";
            lbl3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbPaymentMethod.Items.Add(" ");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Master Card");
            cmbPaymentMethod.Items.Add("Visa Card");
            cmbPaymentMethod.Items.Add("Debit Card");
            EnableTextBoxes();
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();
            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();
            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();
            }
            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox23.Enabled = true;
                textBox23.Text = "";
                textBox23.Focus();
            }
            else
            {
                textBox23.Enabled = false;
                textBox23.Text = "0";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();
            }
            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();
            }
            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();
            }
            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();
            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();
            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();
            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();
            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.Text == "Cash")
            {
                textBox24.Enabled = true;
                textBox24.Text = "";
                textBox24.Focus();

            }
            else
            {
                textBox24.Enabled = false;
                textBox24.Text = "";
            
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[23];
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = Convert.ToDouble(textBox4.Text);
            double ex = Convert.ToDouble(textBox5.Text);
            double f = Convert.ToDouble(textBox6.Text);
            double g = Convert.ToDouble(textBox7.Text);
            double h = Convert.ToDouble(textBox8.Text);
            double i = Convert.ToDouble(textBox19.Text);
            double j = Convert.ToDouble(textBox20.Text);
            double l = Convert.ToDouble(textBox21.Text);
            double m = Convert.ToDouble(textBox23.Text);
            double n = Convert.ToDouble(textBox22.Text);
            double o = Convert.ToDouble(textBox18.Text);
            double r = Convert.ToDouble(textBox17.Text);
            double s = Convert.ToDouble(textBox16.Text);
            double t = Convert.ToDouble(textBox15.Text);
            double u = Convert.ToDouble(textBox14.Text);
            double v = Convert.ToDouble(textBox13.Text);
            double z = Convert.ToDouble(textBox12.Text);
            double x = Convert.ToDouble(textBox11.Text);
            double y = Convert.ToDouble(textBox10.Text);


           
        
            itemcost[0] = a * Price_pomfrit;
            itemcost[1] = b * Price_salata;
            itemcost[2] = c * Price_lukac;
            itemcost[3] = d * Price_pilecasalata;
            itemcost[4] = ex * Price_ribljisendvic;
            itemcost[5] = f * Price_cheesburger;
            itemcost[6] = g * Price_hamburger;
            itemcost[7] = h * Price_chickenburger;
            itemcost[8] = i * Price_cokomafin;
            itemcost[9] = j * Price_palacincikinderbueno;
            itemcost[10] = l * Price_palacinciraffaelo;
            itemcost[11] = m * Price_cheescake;
            itemcost[12] = n * Price_vocnikolac;
            itemcost[13] = o * Price_caj;
            itemcost[14] = r * Price_cola;
            itemcost[15] = s * Price_kafa;
            itemcost[16] = t * Price_soknarandza;
            itemcost[17] = u * Price_voda;
            itemcost[18] = v * Price_vanilijashake;
            itemcost[19] = z * Price_jagodashake;
            itemcost[20] = x * Price_cokoladnishake;
            itemcost[21] = y * Price_vocnimix;









            double cost, ichange;

            if (cmbPaymentMethod.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] +
                    itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] +
                    itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21]; ;

                lbl1.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lbl2.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lbl3.Text = Convert.ToString(iTotal);

                ichange = Convert.ToDouble(textBox24.Text);
                cost = ichange - (iTax + iTotal);
                label3.Text = Convert.ToString(cost);

                label3.Text = String.Format("{0:C}", cost);
                lbl2.Text = String.Format("{0:C}", iTax);
                lbl1.Text = String.Format("{0:C}", iSubTotal);
                lbl3.Text = String.Format("{0:C}", iTotal);


            }
            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] +
                        itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] +
                        itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21]; ;

                lbl1.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lbl2.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lbl3.Text = Convert.ToString(iTotal);

                

              
                lbl2.Text = String.Format("{0:C}", iTax);
                lbl1.Text = String.Format("{0:C}", iSubTotal);
                lbl3.Text = String.Format("{0:C}", iTotal);
            
            
            
            
            
            
            
            
            }
                



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

      

        
    }
}
