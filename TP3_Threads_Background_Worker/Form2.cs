using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Threads_Background_Worker
{
    public partial class Form2 : Form
    {
        private double[] tableau;
        private ListView listOrdonnee;
        private static bool cancel = false;
        private static int progression;

        public Form2(double[] tableauNonTrie, ListView listTriee)
        {
            InitializeComponent();
            tableau = tableauNonTrie;
            listOrdonnee = listTriee;

            backgroundWorker1.RunWorkerAsync();
        }

        private static void TriSelectionPermutation(double[] tableau)
        {
            int i, iRech, iMin;
            double tmp;

            for (i = 0; i < tableau.Length - 1; i++)
            {
                if (cancel)
                {
                    break;
                }
                for (iRech = iMin = i; iRech < tableau.Length - 1; iRech++)
                    if (tableau[iRech] < tableau[iMin])
                        iMin = iRech;

                if (iMin != i)
                {
                    tmp = (double) tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }

                progression = i/tableau.Length*100;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            TriSelectionPermutation(tableau);

        }
        
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarTri.Value = e.ProgressPercentage;
        }
        
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            okButton.Enabled = true;
            cancelButton.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableau.Length - 1; i++)
            {
                listOrdonnee.Items.Add(tableau[i].ToString());
            }

            Close();
        }
    }
}
