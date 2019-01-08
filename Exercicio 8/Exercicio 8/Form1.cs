using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtContrato_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double salBruto, numFilhos, salLiq, descSaude, descINSS=0, valCom = 0;
            int selectedIndex = cmbVendas.SelectedIndex;
            Object selectedItem = cmbVendas.SelectedItem;

            salBruto = Convert.ToDouble(txtSalario.Text); 
            numFilhos = Convert.ToDouble(txtFilhos.Text);

            descSaude = numFilhos * 5;


            if (rbVendas.Checked == true)
            {
                if (selectedIndex == 1)
                    valCom = (salBruto * 1/100);
                else if (selectedIndex == 2)
                    valCom = (salBruto * 5.65/100);
                else if (selectedIndex == 3)
                    valCom = (salBruto * 7.34/100);
                else if (selectedIndex == 4)
                    valCom = (salBruto * 10/100);

                salLiq = salBruto + valCom;

                txtCom.Text = string.Format("{0:###.##0,##}", valCom);
            }
            else
                txtCom.Text = "Não há comissão";


            if (salBruto >= 1.000)
            { descINSS = salBruto - (salBruto * 10/100);

                txtDesc.Text = string.Format("{0:###.##0,00}", descINSS); }

            else if (salBruto < 1.000)
            {  descINSS = salBruto - (salBruto * 8/100);
                txtDesc.Text = string.Format("{0:###.##0,00}", descINSS);
            }

            salLiq = (salBruto + valCom) - (descSaude + descINSS);

            txtSalLiq.Text = string.Format("{0:###.##0,00}", salLiq);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCom.Text = "";
            txtDesc.Text = "";
            txtFilhos.Text = "";
            txtNome.Text ="";
            txtSalario.Text = "";
            txtSalLiq.Text = "";
            rbHora.Checked = false;
            rbMensal.Checked = false;
            rbVendas.Checked = false;
            rbOther.Checked = false;

        }
    }
}
