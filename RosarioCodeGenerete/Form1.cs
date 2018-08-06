using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosarioCodeGenerete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 50;
            if (EdtCardNumber.Text.Length == 8 && EdtCorrelatorNumber.Text.Length == 8)
            {
               // try
               // {
                    double a = double.Parse(EdtCardNumber.Text);
                    Bo.GerarListaDeCodigos(EdtCorrelatorNumber.Text, (int)EdtTotCards.Value, EdtCardNumber.Text, EdtPath.Text);
                    ProgressBar.Value = 100;
                    lblStatus.Text = "Concluido";
               // }
               /* catch (Exception)
                {
                    ProgressBar.Value = 0;
                    lblStatus.Text = "Erro";
                }*/
            }
            else
            {
                ProgressBar.Value = 0;
                lblStatus.Text = "Digite 8 digitos";
            }
            
            
        }

        private void BtnGetPath_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    EdtPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
    }
}
