using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {


        private GameData gd;



        public  void UpdateCounter()
        {
            Money.Text =gd.money + "$";
            label2.Text = gd.amount + "$";
            mPS.Text = gd.moreAmount + "$";

        }

        public Form1()
        {
            InitializeComponent();
            gd = GetData();
            gd.currentDate = DateTime.Now;
            gd.money += gd.elapsedTime() * gd.moreAmount;
            Money.Text = gd.money + "$";
            mPS.Text = gd.moreAmount + "$";
            label2.Text = gd.amount + "$";
            if (gd.elapsedTime() * gd.moreAmount > 0)
            {

                MessageBox.Show("While you were away you earned " + gd.elapsedTime() * gd.moreAmount + "$");
            }

        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gd.money += gd.amount;
            UpdateCounter();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (gd.money >= 50)
            {
                
                gd.money -= 50;
                gd.amount += 2;
                UpdateCounter();
                tier1.Visible = false;
            }


        }

        private void tier2_Click(object sender, EventArgs e)
        {
            if (gd.money >= 250)
            {
                
                gd.money -= 250;
                gd.amount += 5.5;
                UpdateCounter();
                tier2.Visible = false;
            }
        }

        private void tier3_Click(object sender, EventArgs e)
        {
            if (gd.money >= 1000)
            {
                
                gd.money -= 1000;
                gd.amount += 10;
                UpdateCounter();
                tier3.Visible = false;
            }
        }

        private void tier4_Click(object sender, EventArgs e)
        {
            if (gd.money >= 1750)
            {

                gd.money -= 1750;
                gd.amount += 35.5;
                UpdateCounter();
                tier4.Visible = false;
                gd.winnable = true;

                if (gd.winnable == true)
                {
                    winThis.Visible = true;
                }
            }
        }

        private void winThis_Click(object sender, EventArgs e)
        {
            if (gd.winnable == true && gd.money >= 5000)
            {
                MessageBox.Show("Congratulation on wasting your time!!!");
                timer1.Enabled = true;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moneyPerSec.Enabled = false;
                this.Close();
            
            
            
        }

        private void moneyPerSec_Tick(object sender, EventArgs e)
        {
            gd.money += gd.moreAmount;
            UpdateCounter();
        }

        private void Something_Click(object sender, EventArgs e)
        {

            if (gd.money >= 120)
            {
                gd.moreAmount += 4;
                gd.money -= 120;
                UpdateCounter();
                Something.Visible = false;
            }
            
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
           gd.previousDate = DateTime.Now;
           SerializeData(gd);
        }

        private void SerializeData(GameData data)
        {
            FileStream fs = new FileStream("Data.Dat", FileMode.Create);


            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(fs, data);


            fs.Close();
        }

        private GameData DeserializeData()
        {
            FileStream fs = new FileStream("Data.Dat", FileMode.Open);


            BinaryFormatter bf = new BinaryFormatter();


            GameData gameData = (GameData)bf.Deserialize(fs);


            fs.Close();

            return gameData;
        }

        private GameData GetData()
        {
            try
            {
                return DeserializeData();
            }
            catch (FileNotFoundException e)
            {
                return new GameData(0,1.5,0,false,DateTime.Now);
            }
        }
    }
}
