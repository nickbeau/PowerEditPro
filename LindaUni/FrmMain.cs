using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LindaUni
{
    public partial class FrmMain : Form
    {
        public User LoggedInUser { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmSplash SplashForm { get; set; }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //New Menu Clicked
            FrmTxtEdit myForm = new FrmTxtEdit();
            myForm.thisUser = LoggedInUser;
            myForm.MdiParent = this;
            myForm.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //TODO: Remove on Load Event
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf";
            var filetopOpen = openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            FrmTxtEdit myForm = new FrmTxtEdit(filename);
            myForm.thisUser = LoggedInUser;
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf";
            FrmTxtEdit currentform = (FrmTxtEdit)this.ActiveMdiChild;


        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SplashForm.Close();
        }
    }
}
