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
    public partial class FrmBedroomGirl : Form
    {
        public FrmBedroomGirl(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "bed" , "wallpaper","pernnes","bed","time","chair","carpet","stairs","light","banc","banc","books" };
        string[] B = { "bad","paintings", "pillow","furnituure","lamb","chese","sun", "curtains" , "chandelier","table","books","rewiws" };
        string[] C = { "sofa","pillows","pilows", "night stand","lamp","hesee" ,"campet","pedals","lamp", "desk", "box of crayons","panel" };
        string[] corect = { "A","A","B","C","C","A","A","B","B","C","C","A"};
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            btver.Tag = corect[i];
            lblrezultat.Text = "  ";
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            penIntrebare.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
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

        private void rbTapet_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }
        private void rbVaza_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbPerdele_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
        }

        private void rbBirou_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
        }

        private void rbCreioane_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
        }

        private void rbCarti_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbBed_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbPillow_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbNightStannd_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbCarpet_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbChair_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbDesk_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
        }

        private void rbPenels_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
        }

        private void rbBooks_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
        }
    }
}
