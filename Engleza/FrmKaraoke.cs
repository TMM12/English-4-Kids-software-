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
    public partial class FrmKaraoke : Form
    {
        public FrmKaraoke(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }

        private void FrmKaraoke_Load(object sender, EventArgs e)
        {

        }

        private void Video_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
        }

        private void lstVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideo.SelectedIndex < 0)
            {
                return;
            }
            Video.Movie = lstLink.Items[lstVideo.SelectedIndex].ToString();
            //  Video.Playing = true;
            Video.Play();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }
    }
}
