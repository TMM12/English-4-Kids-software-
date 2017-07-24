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
    public partial class FrmBed : Form
    {
        public FrmBed(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "tableu", "jewelry box","wood", "wallpaper","bed","chan" ,"vase","chair","chair", "television","mass","sun","perdals" };
        string[] B = { "picture","boxx","bedstand","paper","bad", "chandelier", "lamp","papers","chesee","playstation","tableu","cowor", "curtains" };
        string[] C = {  "imagine","wood", "nightstand","flower","deb","lier","vasse","books","cheese","wall","table","carpet","pedals" };
        string[] corect = { "B","A","C","A","A","B","B","C","A","A","C","C","B", };
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
        private void FrmBed_Load(object sender, EventArgs e)
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

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }

    

        private void btver_Click_1(object sender, EventArgs e)
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

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbTablou_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void afisCutie_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbTapet_CheckedChanged(object sender, EventArgs e)
        {
            afis(3); 
        }

        private void rbPat_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbCandelabru1_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbLampa_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
        }

        private void rbCarti_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
        }

        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
        }

        private void rbTelevizor_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
        }

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
        }

        private void rbPerdele_CheckedChanged(object sender, EventArgs e)
        {
            afis(12);
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
