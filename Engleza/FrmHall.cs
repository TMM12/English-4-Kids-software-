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
    public partial class FrmHall : Form
    {
        public FrmHall(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "stairs" ,"boor","lamp", "vase","pern", "chandelier" };
        string[] B = { "scairs","door","plan","vaz","bed","lamp"};
        string[] C = {"scan","USA","plant","plant","sofa","light" };
        string[] corect = {"A","B","C","A","C","A"};
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
        private void FrmHall_Load(object sender, EventArgs e)
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


        private void rbUsa_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void rbUsa2_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void rbScari_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbPlanta_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbVaza_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbPat_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlMASA.Visible = false;
        }
    }
}
