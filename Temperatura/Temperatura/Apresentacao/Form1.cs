using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = null;
            if (rdbCF.Checked)
            {
                controle = new Modelo.Controle(txbTemperatura.Text, "CF");
            }
            if (rdbFC.Checked)
            {
                controle = new Modelo.Controle(txbTemperatura.Text, "FC");
            }
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.ToString();
            }
            else
            {
                lblResultado.Text = controle.Mensagem;
            }
        }
    }
}
