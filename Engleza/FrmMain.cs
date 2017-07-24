using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleza
{
    public partial class FrmMain : Form
        
    {
        public FrmKitchen fkitchen = null;
        public FrmLiving fliving = null;
        public FrmDining fdining = null;
        public FrmHall fhall = null;
        public FrmBoyBedroom frmybed = null;
        public FrmLog flog = null;
        public frmDesen fDesen = null;
        public FrmBedroomGirl fGirl = null;
        public FrmBath fbath = null;
        public FrmYard fyard = null;
        public FrmBed fBed = null;
        public FrmLogOut fLogOut = null;
        public frmSpanzura fspanzura = null;
        public frmMainS fdictionar = null;
        public Administrare fadm = null;
        public Ilustratfrm filust = null;
        public frmCautare fcaut = null;
        public Ajutorfrm aj = null;
        public FrmTabel fTabel = null;
        public FrmDressUpBoy fboy = null;
        public frmDressG fgirl = null;
        public FrmKaraoke fKaraoke = null;
        public FrmBib fbib = null;
        public frmRecipe fcook = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            sndplayr = new SoundPlayer("muzica1.wav");
            sndplayr.Tag = "start";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btgo_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fkitchen = new FrmKitchen(this );
            fkitchen.Show();
        }

        private void livingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fliving = new FrmLiving(this);
            fliving.Show();
        }

        private void dinningRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdining = new FrmDining(this);
            fdining.Show(); 
        }

        private void hallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhall = new FrmHall(this);
            fhall.Show();
        }

       
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flog = new FrmLog(this);
            flog.Show();
        }

       
        private void bathroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbath = new FrmBath(this);
            fbath.Show();

        }

        private void yardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fyard = new FrmYard(this);
            fyard.Show();
        }

        private void parentsBedroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBed = new Engleza.FrmBed(this);
            fBed.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogOut = new FrmLogOut(this);
            fLogOut.Show();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void spanzuratoareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fspanzura = new frmSpanzura(this);
            fspanzura.Show();
        }

        private void dictionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void dictionarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
        SoundPlayer sndplayr;
        private void pbSound_Click(object sender, EventArgs e)
        {
            if (sndplayr.Tag.Equals("start"))
            {
                sndplayr = new SoundPlayer("muzica1.wav");
                sndplayr.Play();
                sndplayr.Tag = "stop";
                pbSound.Image = new Bitmap("images/stop.png");
            }
            else
            {
                sndplayr.Stop();
                sndplayr.Tag = "start";
                pbSound.Image = new Bitmap("images/start.png");
            }
        }

        private void administrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fadm = new Administrare(this);
            fadm.Show();

        }

        private void cautăCuvântToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filust = new Ilustratfrm(this);
            filust.Show();
        }

        private void cautăCuvântToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fcaut = new frmCautare(this);
            fcaut.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aj = new Ajutorfrm(this);
            aj.Show();
        }

        private void firstFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTabel = new FrmTabel(this);
            fTabel.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {

            aj = new Ajutorfrm(this);
            aj.Show();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDesen = new frmDesen(this);
            fDesen.Show();
        }

        private void cookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fcook = new frmRecipe(this);
            fcook.Show();
        }

        private void dressToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void boyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fboy = new FrmDressUpBoy(this);
            fboy.Show();

        }

        private void girlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fgirl = new frmDressG(this);
            fgirl.Show();
        }

        private void karaokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKaraoke = new FrmKaraoke(this);
            fKaraoke.Show();
        }

        private void bibliografieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbib = new FrmBib(this);
            fbib.Show();
        }
    }
}
