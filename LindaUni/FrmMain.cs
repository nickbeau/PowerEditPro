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
          
            menuStrip1.MdiWindowListItem = WindowStripMenuItem1;

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
            currentform.saveFile();

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTxtEdit currentform = (FrmTxtEdit)this.ActiveMdiChild;
            currentform.SaveAS();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SplashForm.Close();
        }

        private void WindowStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 myaboutbox = new AboutBox1();
            myaboutbox.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement Print
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement Print Preview
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashForm.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement Undo
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement REDO
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO: Implement CUT
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO: Implement COPY
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO: Implement Paste
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement SELECT ALL
        }
    }
}
