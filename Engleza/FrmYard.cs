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
    public partial class FrmYard : Form
    {
        public FrmYard(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "pool"  , "tret" ,"ring-shaped life-buoy","boi","gow","desk","fere","flower", "umbrella", "trash","chair" };
        string[] B = { "pol", "tre", "ring", "boy","dog","chair","firre", "flower pot","umbrela","trash can","chezlong" };
        string[] C = { "poll" , "tree","ring life","girl","cat", "lounge chair","fire","plant","rella","bin","long" };
        string[] corect = { "A" ,"C","A","B","B","C","C","B","A","A","A"};
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            btver.Tag = corect[i];
            lblrezultat.Text = "  ";
            penIntrebare.Visible = true;
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
        }
        private void FrmYard_Load(object sender, EventArgs e)
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

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void lblrezultat_Click(object sender, EventArgs e)
        {

        }

        private void btver_Click(object sender, EventArgs e)
        {
          if (rbA.Checked && btver.Tag.ToString() == "A" || rbB.Checked && btver.Tag.ToString() == "B" || rbC.Checked && btver.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                lblrezultat.Text = "Corect :" + variabile.punctaj + " puncte";
            }
            else
            {
                pbCorect.Visible = false;
                pbIncorect.Visible = true;
                lblrezultat.Text = "Incorect";

            }

        }

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }
        

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbPiscina_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbPiscina1_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbCopac_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void rbColac_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbColac1_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbSezlong_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbSezlong1_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbFoc_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbGhiveci_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
        }

        private void rbBaiat_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbCaine_CheckedChanged(object sender, EventArgs e)
        {
afis(4);
        }

        private void rbUmbrela_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
        }

        private void rbGunoi_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
