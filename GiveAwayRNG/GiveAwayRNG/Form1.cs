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
using System.Reflection;

namespace GiveAwayRNG
{
    public partial class Form1 : Form
    {
        public List<Form> formList;
        public Form1()
        {
            InitializeComponent();
            btnSubmit.MouseEnter += OnMouseEnterbtnSubmit;
            btnSubmit.MouseLeave += OnMouseLeavebtnSubmit;
            btnRandomize.MouseEnter += OnMouseEnterbtnRandomize;
            btnRandomize.MouseLeave += OnMouseLeavebtnRandomize;
        }
        void Main()
        {
            Application.Run(new Form1());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string newBooster = txtNewBooster.Text;

            if (!newBooster[0].Equals("@"))
                newBooster = "@" + newBooster;

            using (StreamWriter sw = File.AppendText(@"boosters.txt"))
            { sw.WriteLine(newBooster); }

            lstboxBoosters.Items.Add(newBooster);
            txtNewBooster.Text = "";
        }

        private void frm_Load(object sender, EventArgs e)
        {
            string[] boosters = System.IO.File.ReadAllLines(@"boosters.txt");
            foreach (string booster in boosters)
            {
                lstboxBoosters.Items.Add(booster);
            }
        }

        private void OnMouseEnterbtnSubmit(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Lime;
        }
        private void OnMouseLeavebtnSubmit(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Red;
        }
        private void OnMouseEnterbtnRandomize(object sender, EventArgs e)
        {
            btnRandomize.BackgroundImage = Properties.Resources.vent;
        }
        private void OnMouseLeavebtnRandomize(object sender, EventArgs e)
        {
            btnRandomize.BackgroundImage = Properties.Resources.floor_vent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color currentColor = btnRandomize.BackColor;

            
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
