using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лампочки_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text));
            int a1 = Convert.ToInt32(textBox1.Text);
            int a2 = Convert.ToInt16(textBox2.Text);
            int a3 = (Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text));

            //обработка первого положительного числа
            string t = "+", f = "-";

            if (a1 > 0) label6.Text = t;
            else label6.Text = f;

            if (a2 > 0) label7.Text = t;
            else label7.Text = f;

            if (a3 > 0) label8.Text = t;
            else label8.Text = f;

            int[] b1 = new int[12];
            for (int i = 0; i < 12; i++) b1[i] = 0; //обнуление массива

            if (a1 >= 0)
            {
                for (int i = 11; i >= 0; i--)            //запись остатков от деление в массив
                {
                    b1[i] = a1 % 2;
                    a1 /= 2;
                }
                if (b1[1] == 1) pictureBox107.BringToFront(); else pictureBox105.BringToFront();
                if (b1[2] == 1) pictureBox10.BringToFront(); else pictureBox30.BringToFront();
                if (b1[3] == 1) pictureBox9.BringToFront(); else pictureBox29.BringToFront();
                if (b1[4] == 1) pictureBox8.BringToFront(); else pictureBox28.BringToFront();
                if (b1[5] == 1) pictureBox7.BringToFront(); else pictureBox27.BringToFront();
                if (b1[6] == 1) pictureBox6.BringToFront(); else pictureBox26.BringToFront();
                if (b1[7] == 1) pictureBox5.BringToFront(); else pictureBox25.BringToFront();
                if (b1[8] == 1) pictureBox4.BringToFront(); else pictureBox24.BringToFront();
                if (b1[9] == 1) pictureBox3.BringToFront(); else pictureBox23.BringToFront();
                if (b1[10] == 1) pictureBox2.BringToFront(); else pictureBox22.BringToFront();
                if (b1[11] == 1) pictureBox1.BringToFront(); else pictureBox21.BringToFront();
                long bin1 = 1;                           //переход к типу лонг, для записи числа в 2 СИ
                for (int i = 0; i < 12; i++)
                    bin1 = bin1 * 10 + b1[i];
                string bi1;
                bi1 = Convert.ToString(bin1);            //переход к строке
                bi1 = bi1.Remove(0, 1);                    //удаление первой 1
                label1.Text = Convert.ToString(bi1);
            }

            if (a1 < 0)
            {
                a1 *= -1;
                for (int i = 11; i >= 1; i--)            //запись остатков от деление в массив
                {
                    b1[i] = a1 % 2;
                    a1 /= 2;
                }
                b1[0] = 1;
                for (int i = 1; i < 12; i++)
                    if (b1[i] == 0) b1[i] = 1;
                    else if (b1[i] == 1) b1[i] = 0;
               
                if (b1[1] == 1) pictureBox107.BringToFront(); else pictureBox105.BringToFront();
                if (b1[2] == 1) pictureBox10.BringToFront(); else pictureBox30.BringToFront();
                if (b1[3] == 1) pictureBox9.BringToFront(); else pictureBox29.BringToFront();
                if (b1[4] == 1) pictureBox8.BringToFront(); else pictureBox28.BringToFront();
                if (b1[5] == 1) pictureBox7.BringToFront(); else pictureBox27.BringToFront();
                if (b1[6] == 1) pictureBox6.BringToFront(); else pictureBox26.BringToFront();
                if (b1[7] == 1) pictureBox5.BringToFront(); else pictureBox25.BringToFront();
                if (b1[8] == 1) pictureBox4.BringToFront(); else pictureBox24.BringToFront();
                if (b1[9] == 1) pictureBox3.BringToFront(); else pictureBox23.BringToFront();
                if (b1[10] == 1) pictureBox2.BringToFront(); else pictureBox22.BringToFront();
                if (b1[11] == 1) pictureBox1.BringToFront(); else pictureBox21.BringToFront();
                
                long bin1 = 1;
                for (int i = 0; i < 12; i++)
                    bin1 = bin1 * 10 + b1[i];
                string bi1;
                bi1 = Convert.ToString(bin1);
                bi1 = bi1.Remove(0, 1);
                label1.Text = Convert.ToString(bi1);
            }

            //обработка второго положительного числа
            int[] b2 = new int[12];
            for (int i = 0; i < 12; i++) b2[i] = 0;
            if (a2 >= 0)
            {
                for (int i = 11; i >= 0; i--)
                {
                    b2[i] = a2 % 2;
                    a2 /= 2;
                }
                if (b2[1] == 1) pictureBox106.BringToFront(); else pictureBox104.BringToFront();
                if (b2[2] == 1) pictureBox11.BringToFront(); else pictureBox31.BringToFront();
                if (b2[3] == 1) pictureBox12.BringToFront(); else pictureBox32.BringToFront();
                if (b2[4] == 1) pictureBox13.BringToFront(); else pictureBox33.BringToFront();
                if (b2[5] == 1) pictureBox14.BringToFront(); else pictureBox34.BringToFront();
                if (b2[6] == 1) pictureBox15.BringToFront(); else pictureBox35.BringToFront();
                if (b2[7] == 1) pictureBox16.BringToFront(); else pictureBox36.BringToFront();
                if (b2[8] == 1) pictureBox17.BringToFront(); else pictureBox37.BringToFront();
                if (b2[9] == 1) pictureBox18.BringToFront(); else pictureBox38.BringToFront();
                if (b2[10] == 1) pictureBox19.BringToFront(); else pictureBox39.BringToFront();
                if (b2[11] == 1) pictureBox20.BringToFront(); else pictureBox40.BringToFront();
                long bin2 = 1;
                for (int i = 0; i < 12; i++)
                    bin2 = bin2 * 10 + b2[i];
                string bi2;
                bi2 = Convert.ToString(bin2);
                bi2 = bi2.Remove(0, 1);
                label2.Text = Convert.ToString(bi2);
            }
            if (a2 < 0)
            {
                a2 *= -1;
                for (int i = 11; i >= 1; i--)
                {
                    b2[i] = a2 % 2;
                    a2 /= 2;
                }
                b2[0] = 1;
                for (int i = 1; i < 12; i++)
                    if (b2[i] == 0) b2[i] = 1;
                    else if (b2[i] == 1) b2[i] = 0;

                if (b2[1] == 1) pictureBox106.BringToFront(); else pictureBox104.BringToFront();
                if (b2[2] == 1) pictureBox11.BringToFront(); else pictureBox31.BringToFront();
                if (b2[3] == 1) pictureBox12.BringToFront(); else pictureBox32.BringToFront();
                if (b2[4] == 1) pictureBox13.BringToFront(); else pictureBox33.BringToFront();
                if (b2[5] == 1) pictureBox14.BringToFront(); else pictureBox34.BringToFront();
                if (b2[6] == 1) pictureBox15.BringToFront(); else pictureBox35.BringToFront();
                if (b2[7] == 1) pictureBox16.BringToFront(); else pictureBox36.BringToFront();
                if (b2[8] == 1) pictureBox17.BringToFront(); else pictureBox37.BringToFront();
                if (b2[9] == 1) pictureBox18.BringToFront(); else pictureBox38.BringToFront();
                if (b2[10] == 1) pictureBox19.BringToFront(); else pictureBox39.BringToFront();
                if (b2[11] == 1) pictureBox20.BringToFront(); else pictureBox40.BringToFront();
                
                long bin2 = 1;
                for (int i = 0; i < 12; i++)
                    bin2 = bin2 * 10 + b2[i];
                string bi2;
                bi2 = Convert.ToString(bin2);
                bi2 = bi2.Remove(0, 1);
                label2.Text = Convert.ToString(bi2);
            }
            //обработка положительного ответа
            int[] b3 = new int[12];
            for (int i = 0; i < 12; i++) b3[i] = 0;
            if (a3 >= 0)
            {
                for (int i = 11; i >= 0; i--)
                {
                    b3[i] = a3 % 2;
                    a3 /= 2;
                }
                
                if (b3[1] == 1) pictureBox103.BringToFront(); else pictureBox102.BringToFront();
                if (b3[2] == 1) pictureBox41.BringToFront(); else pictureBox51.BringToFront();
                if (b3[3] == 1) pictureBox42.BringToFront(); else pictureBox52.BringToFront();
                if (b3[4] == 1) pictureBox43.BringToFront(); else pictureBox53.BringToFront();
                if (b3[5] == 1) pictureBox44.BringToFront(); else pictureBox54.BringToFront();
                if (b3[6] == 1) pictureBox45.BringToFront(); else pictureBox55.BringToFront();
                if (b3[7] == 1) pictureBox46.BringToFront(); else pictureBox56.BringToFront();
                if (b3[8] == 1) pictureBox47.BringToFront(); else pictureBox57.BringToFront();
                if (b3[9] == 1) pictureBox48.BringToFront(); else pictureBox58.BringToFront();
                if (b3[10] == 1) pictureBox49.BringToFront(); else pictureBox59.BringToFront();
                if (b3[11] == 1) pictureBox50.BringToFront(); else pictureBox60.BringToFront();
                
                long bin3 = 1;
                for (int i = 0; i < 12; i++)
                    bin3 = bin3 * 10 + b3[i];
                string bi3;
                bi3 = Convert.ToString(bin3);
                bi3 = bi3.Remove(0, 1);
                label5.Text = Convert.ToString(bi3);
            }
            if (a3 < 0)
            {
                a3 *= -1;
                for (int i = 11; i >= 1; i--)
                {
                    b3[i] = a3 % 2;
                    a3 /= 2;
                }
                b3[0] = 1;
                for (int i = 1; i < 12; i++)
                    if (b3[i] == 0) b3[i] = 1;
                    else if (b3[i] == 1) b3[i] = 0;
                
                 if (b3[1] == 1) pictureBox103.BringToFront(); else pictureBox102.BringToFront();
                if (b3[2] == 1) pictureBox41.BringToFront(); else pictureBox51.BringToFront();
                if (b3[3] == 1) pictureBox42.BringToFront(); else pictureBox52.BringToFront();
                if (b3[4] == 1) pictureBox43.BringToFront(); else pictureBox53.BringToFront();
                if (b3[5] == 1) pictureBox44.BringToFront(); else pictureBox54.BringToFront();
                if (b3[6] == 1) pictureBox45.BringToFront(); else pictureBox55.BringToFront();
                if (b3[7] == 1) pictureBox46.BringToFront(); else pictureBox56.BringToFront();
                if (b3[8] == 1) pictureBox47.BringToFront(); else pictureBox57.BringToFront();
                if (b3[9] == 1) pictureBox48.BringToFront(); else pictureBox58.BringToFront();
                if (b3[10] == 1) pictureBox49.BringToFront(); else pictureBox59.BringToFront();
                if (b3[11] == 1) pictureBox50.BringToFront(); else pictureBox60.BringToFront();
                
                long bin3 = 1;
                for (int i = 0; i < 12; i++)
                    bin3 = bin3 * 10 + b3[i];
                string bi3;
                bi3 = Convert.ToString(bin3);
                bi3 = bi3.Remove(0, 1);
                label5.Text = Convert.ToString(bi3);
            }
            }
            //не смотрите я понатыкал оно крашится если я удаляю это =(
        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox58_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox55_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox102_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label19_Click(object sender, EventArgs e)
        {

        }   
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {

        }
    }
}
