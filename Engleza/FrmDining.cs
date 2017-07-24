using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleza
{
    public partial class FrmDining : Form
    {
        public FrmDining(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = {"plant","lamp","fenetre","piture","mass","chair","books","vas"};
        string[] B = { "flower", "chandelier", "window", "tablo", "tabe", "chese", "rews", "cup" };
        string[] C = {"vase","table","light","picture","table","cair", "magazines","sun" };
        string[] corect = {"A","B","B","C","A","C","B"};
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            btnVerifica.Tag = corect[i];
            lblRezultat.Text = " ";
            pnlMASA.Visible = true;
        }
        private void FrmDining_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void pbStatuie_Click(object sender, EventArgs e)
        {
            afis(0);
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {

            if (rbA.Checked && btnVerifica.Tag.ToString() == "A" || rbB.Checked && btnVerifica.Tag.ToString() == "B" || rbC.Checked && btnVerifica.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                lblRezultat.Text = "Corect :" + variabile.punctaj + " puncte";
            }
            else
            {
                pbIncorect.Visible = true;
                pbCorect.Visible = false;
                lblRezultat.Text = "Incorect";

            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            pnlMASA.Visible = false;
        }


        private void rbPLanta_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void rbGeam_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbTablou_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbTablou1_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbTablou2_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbScaun2_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbScaun3_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbReviste_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
        }

        private void rbCesti_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);

        }

        private void pnlMASA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
