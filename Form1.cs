using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change
{
    public partial class Form1 : Form
    {

        CheckBox[] chkKind = new CheckBox[7];
        Label[] lblNum = new Label[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1689";
            chkKind[0] = checkBox1;
            chkKind[1] = checkBox2;
            chkKind[2] = checkBox3;
            chkKind[3] = checkBox4;
            chkKind[4] = checkBox5;
            chkKind[5] = checkBox6;
            chkKind[6] = checkBox7;
            lblNum[0] = label3;
            lblNum[1] = label4;
            lblNum[2] = label5;
            lblNum[3] = label6;
            lblNum[4] = label7;
            lblNum[5] = label8;
            lblNum[6] = label9;
            for (int i = 0; i <= 6; i++)
            {
                lblNum[i].Text = "0";
                chkKind[i].Checked = true;
            }
            checkBox7.Enabled = false;
        }

        private void numChange_Click(object sender, EventArgs e)
        {
            double money;
            try
            {
                money = double.Parse(textBox1.Text);
                money = Math.Floor(money);
                int[] kind = { 1000, 500, 100, 50, 10, 5, 1 };
                int num;
                for (int i = 0; i <= 6; i++)
                {
                    num = 0;
                    if (chkKind[i].Checked)
                    {
                        while (money - kind[i] >= 0)
                        {
                            num++;
                            money -= kind[i];
                        }
                    }
                    lblNum[i].Text = num.ToString();
                }
            }
            catch
            {
                MessageBox.Show("兌換金額請輸入數值！", "錯誤", MessageBoxButtons.OK);
                textBox1.Text = "1689";
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
