using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Threads_Background_Worker
{
    public partial class Form1 : Form
    {
        private double[] tableau;

        public Form1()
        {
            InitializeComponent();
        }

        public static void Initialiser(double[] tableau)
        {
            Random r = new Random((int) DateTime.Now.Ticks);
            for (int i = 0; i < tableau.Length; i++) 
                tableau[i] = r.NextDouble();
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            int tailleTab = int.Parse(textBoxArray.Text);
            tableau = new double[tailleTab];

            Initialiser(tableau);

            ListViewItem[] listItem = new ListViewItem[tailleTab];
            for (int i = 0; i < tailleTab; i++)
            {

                ListViewItem itemTMP = new ListViewItem();
                itemTMP.Text = tableau[i].ToString();
                listItem[i] = itemTMP;
            }

            this.listNonTriee.Items.AddRange(listItem);
        }

        private void triButton_Click(object sender, EventArgs e)
        {
            Form2 progressForm = new Form2(tableau, listTriee);
            progressForm.Enabled = true;
            progressForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
