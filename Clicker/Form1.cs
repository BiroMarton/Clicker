using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {

        public double money = 0;
        public double amount = 1.5;
        bool isUnlocked1 = false;
        bool isUnlocked2 = false;
        bool isUnlocked3 = false;
        bool isUnlocked4 = false;
        bool winnable = false;
        


        public  void UpdateCounter()
        {
            Money.Text = money + "$";
            label2.Text = amount + "$";
            
        }

        public Form1()
        {
            InitializeComponent();
            Money.Text = money.ToString();
            label2.Text = amount + "$";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money += amount;
            UpdateCounter();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (money >= 50 && isUnlocked1 == false)
            {
                
                money -= 50;
                isUnlocked1 = true;
                amount += 2;
                UpdateCounter();
                tier1.Visible = false;
            }


        }

        private void tier2_Click(object sender, EventArgs e)
        {
            if (money >= 250 && isUnlocked2 == false)
            {
                
                money -= 250;
                isUnlocked2 = true;
                amount += 5.5;
                UpdateCounter();
                tier2.Visible = false;
            }
        }

        private void tier3_Click(object sender, EventArgs e)
        {
            if (money >= 150 && isUnlocked3 == false)
            {
                
                money -= 1000;
                isUnlocked3 = true;
                amount += 10;
                UpdateCounter();
                tier3.Visible = false;
            }
        }

        private void tier4_Click(object sender, EventArgs e)
        {
            if (money >= 1750 && isUnlocked4 == false)
            {

                money -= 1750;
                isUnlocked4 = true;
                amount += 35.5;
                UpdateCounter();
                tier4.Visible = false;
                winnable = true;

                if (winnable == true)
                {
                    winThis.Visible = true;
                }
            }
        }

        private void winThis_Click(object sender, EventArgs e)
        {
            if (winnable == true && money >= 5000)
            {
                MessageBox.Show("Congratulation on wasting your time!!!");
                timer1.Enabled = true;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                this.Close();
            
            
            
        }


    }
}
