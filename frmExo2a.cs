using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2
{
    public partial class frmExo2a : Form
    {
        public frmExo2a()
        {
            InitializeComponent();
            this.Height = 240;
        }

        private void chk_Modifier_CheckedChanged(object sender, EventArgs e)
        {
            this.gbx_Couleur.Visible = this.chk_Modifier.Checked;

            if (this.chk_Modifier.Checked)
            {
                this.Height = 420;
            }
            else this.Height = 240;
        }

        private void rbt_Rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Rouge.Checked)
            {
                this.lbl_Affichage_Couleur.BackColor = System.Drawing.Color.Red;
            }
        }

        private void rbt_Vert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Vert.Checked)
            {
                this.lbl_Affichage_Couleur.BackColor = System.Drawing.Color.Green;
            }
        }

        private void rbt_Bleu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Bleu.Checked)
            {
                this.lbl_Affichage_Couleur.BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
