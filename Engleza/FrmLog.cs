using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Engleza
{
    public partial class FrmLog : Form
    {
        public FrmLog(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath); //numele folderului in care se afla aplicatia

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSlogan_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int flag = 0;


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\engleza.accdb");//se creeaza o noua conexiune
            con.Open();
            string text = "select* from utilizatori";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if (r["utilizator"].ToString() == txtname.Text && r["parola"].ToString() == txtparola.Text)
                {
                    MessageBox.Show("Bine ai venit " + r["utilizator"]);

                    flag = 1;
                    variabile.utilizator = txtname.Text;
                    this.Close();
                }
            }
            r.Close();
            if (flag == 0)
            {


                if (MessageBox.Show("Utilizator inexistent.Creati utilizator?", "Conectare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    com.CommandText = "INSERT INTO utilizatori(utilizator,parola) values(@utilizator,@parola)";
                    com.Parameters.AddWithValue("utilizator", txtname.Text);
                    com.Parameters.AddWithValue("parola", txtparola.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Utilizatorul a fost creat!");
                    variabile.utilizator = txtname.Text;
                    flag = 1;


                }
                if (flag == 1)
                {


                }
            }
        }
        
        private void FrmLog_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
