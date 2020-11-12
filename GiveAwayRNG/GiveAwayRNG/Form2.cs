using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace GiveAwayRNG
{
    public partial class Form2 : Form
    {
        private int countdown = 30;
        private string[] boosters;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

            timer2.Interval = 2000;
            timer2.Enabled = true;
            timer2.Start();

            timer3.Interval = 1500;
            timer3.Enabled = true;
            timer3.Start();

            timer4.Interval = 1100;
            timer4.Enabled = true;
            timer4.Start();

            timer5.Interval = 3000;
            timer5.Enabled = true;
            timer5.Start();

            boosters = System.IO.File.ReadAllLines(@"boosters.txt");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            lblName.Visible = true;
            timer6.Interval = 250;
            timer6.Enabled = true;
            timer6.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool invalidLoc;

            do
            {
                invalidLoc = false;
                Random rand = new Random();
                int x = rand.Next(0, 1279);
                int y = rand.Next(0, 719);

                picBlack.Visible = false;
                picBlack.Left = x;
                picBlack.Top = y;

                if (picBlack.Bounds.IntersectsWith(btnStart.Bounds) || picBlack.Bounds.IntersectsWith(picWhite.Bounds) ||
                    picBlack.Bounds.IntersectsWith(picCyan.Bounds) || picBlack.Bounds.IntersectsWith(picLime.Bounds) || 
                        picBlack.Bounds.IntersectsWith(picPurple.Bounds) || picBlack.Bounds.IntersectsWith(picRed.Bounds))
                    invalidLoc = true;
                else
                    picBlack.Visible = true;

            } while (invalidLoc);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bool invalidLoc;

            do
            {
                invalidLoc = false;
                Random rand = new Random();
                int x = rand.Next(0, 1279);
                int y = rand.Next(0, 719);

                picCyan.Visible = false;
                picCyan.Left = x;
                picCyan.Top = y;

                if (picCyan.Bounds.IntersectsWith(btnStart.Bounds) || picCyan.Bounds.IntersectsWith(picWhite.Bounds) ||
                    picCyan.Bounds.IntersectsWith(picBlack.Bounds) || picCyan.Bounds.IntersectsWith(picLime.Bounds) || 
                        picCyan.Bounds.IntersectsWith(picPurple.Bounds) || picCyan.Bounds.IntersectsWith(picRed.Bounds))
                    invalidLoc = true;
                else
                    picCyan.Visible = true;

            } while (invalidLoc);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            bool invalidLoc;

            do
            {
                invalidLoc = false;
                Random rand = new Random();
                int x = rand.Next(0, 1279);
                int y = rand.Next(0, 719);

                picLime.Visible = false;
                picLime.Left = x;
                picLime.Top = y;

                if (picLime.Bounds.IntersectsWith(btnStart.Bounds) || picLime.Bounds.IntersectsWith(picWhite.Bounds) ||
                    picLime.Bounds.IntersectsWith(picCyan.Bounds) || picLime.Bounds.IntersectsWith(picBlack.Bounds) ||
                        picLime.Bounds.IntersectsWith(picPurple.Bounds) || picLime.Bounds.IntersectsWith(picRed.Bounds))
                    invalidLoc = true;
                else
                    picLime.Visible = true;

            } while (invalidLoc);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            bool invalidLoc;

            do
            {
                invalidLoc = false;
                Random rand = new Random();
                int x = rand.Next(0, 1279);
                int y = rand.Next(0, 719);

                picPurple.Visible = false;
                picPurple.Left = x;
                picPurple.Top = y;

                if (picPurple.Bounds.IntersectsWith(btnStart.Bounds) || picPurple.Bounds.IntersectsWith(picWhite.Bounds) ||
                    picPurple.Bounds.IntersectsWith(picCyan.Bounds) || picPurple.Bounds.IntersectsWith(picLime.Bounds) ||
                        picPurple.Bounds.IntersectsWith(picBlack.Bounds) || picPurple.Bounds.IntersectsWith(picRed.Bounds))
                    invalidLoc = true;
                else
                    picPurple.Visible = true;

            } while (invalidLoc);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            bool invalidLoc;

            do
            {
                invalidLoc = false;
                Random rand = new Random();
                int x = rand.Next(0, 1279);
                int y = rand.Next(0, 719);

                picRed.Visible = false;
                picRed.Left = x;
                picRed.Top = y;

                if (picRed.Bounds.IntersectsWith(btnStart.Bounds) || picRed.Bounds.IntersectsWith(picWhite.Bounds) ||
                    picRed.Bounds.IntersectsWith(picCyan.Bounds) || picRed.Bounds.IntersectsWith(picLime.Bounds) ||
                        picRed.Bounds.IntersectsWith(picPurple.Bounds) || picRed.Bounds.IntersectsWith(picBlack.Bounds))
                    invalidLoc = true;
                else
                    picRed.Visible = true;

            } while (invalidLoc);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int max = this.boosters.Length;
            Random rand = new Random();
            int randIndex = rand.Next(0, max);
            if (countdown != 0)
                lblName.Text = this.boosters[randIndex];
            else
            {
                string winner = this.boosters[randIndex];
                lblName.Text = "Winner: " + winner;
                this.boosters = removeWinner(winner, boosters);
                timer6.Stop();
            }
            
            this.Update();
            countdown--;
            
        }

        private void picWhite_Click(object sender, EventArgs e)
        {
            lblName.Text = "";
            lblName.Visible = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;
            countdown = 20;
        }

        private string[] removeWinner(string winner, string[] boosters_array)
        {
            List<String> boostersCopy = new List<String>();
            List<int> locations = new List<int>();
            int locCount = 0;
            // Removing the winner from the boosters list
            foreach (string booster in boosters_array)
            {
                if (!booster.Equals(winner))
                    boostersCopy.Add(booster);
                else
                    locations.Add(locCount);
                locCount++;
            }
            boosters_array = boostersCopy.ToArray();

            // Removing the winner from the boosters text file
            /*int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"boosters.txt");
            string newstr = null;
            while ((line = file.ReadLine()) != null)
            {
                // Console.WriteLine(line);
                if (locations.Contains(counter + 1))
                {

                }
                else
                {
                    newstr += line + Environment.NewLine;

                }
                counter++;
            }

            file.Close();

            if (System.IO.File.Exists(@"boosters.txt"))
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(@"boosters.txt");
                sw.WriteLine(newstr);
                sw.Close();
            }*/

            return boosters_array;
        }
    }
}
