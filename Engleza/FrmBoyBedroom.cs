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
    public partial class FrmBoyBedroom : Form
    {
        public FrmBoyBedroom(FrmMain fMain)
        {
            this.MdiParent = fMain; 
            InitializeComponent();
        }
        string[] A = { "dragon", "drawing","rabbit","carts","bear","chair","light", "soldier","box","telephone","lamp","cheir","capet", "cupboard","ball","sabs", "sneakers" };
        string[] B = {  "snake","draw","moouse","books","cat","sofa","chandelier","solder","cup", "radio","window","scan","cower","armchair","sofa", "sword" , "adidasi" };
        string[] C = {  "sheep","painting","mose","news","dog","bed","lamp","soldat","bocs","television","geam","chair","carpet","box","teddy bear","sourd","clothes"};
        string[] corect = { "A", "A", "B", "B", "C", "C", "C" ,"A","A","B","B","C","C","A","A","B","B"};
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
            penIntrebare.Visible = true;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
        }

        private void FrmMybed_Load(object sender, EventArgs e)
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

        

        private void lblrezultat_Click(object sender, EventArgs e)
        {

        }

        private void rbDragon_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbDragon2_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbDragoni_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbDesen_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void rbSoarece_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void rbCarte_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbDragons_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }

        private void rbCaine_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbCaine1_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbPat_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbLampa_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbSoldat_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
        }

        private void rbCutii_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
        }

        private void rbRadio_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
        }

        private void rbGeam_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
        }

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(12);
        }

        private void rbDulap_CheckedChanged(object sender, EventArgs e)
        {
            afis(13);
        }

        private void rbMinge_CheckedChanged(object sender, EventArgs e)
        {
            afis(14);
        }

        private void rbSabie_CheckedChanged(object sender, EventArgs e)
        {
            afis(15);
        }

        private void rbAdidasi_CheckedChanged(object sender, EventArgs e)
        {
            afis(16);
        }

        private void lblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
