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
    public partial class FrmTxtEdit : Form
    {
        public User thisUser { get; set; }
        public string FormText { get; set; }
        public string FileName { get; set; }
        public bool IsDirty { get; set; }
        public FrmTxtEdit()
        {
            FileName = $"New File";
            InitializeComponent();
            this.Text = $"Text Edit - {FileName}";
        }

        public FrmTxtEdit(string fileName)
        {
            //TODO: Open File
            FileName = fileName;
            
            InitializeComponent();
            this.Text = $"Text Edit - {FileName}";
            richTextBox1.LoadFile(fileName);
            this.Text = $"Text Edit - {FileName}";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IsDirty = true;
            this.Text = $"Text Edit - {FileName} *";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //TODO: Save File
            string filename = ((SaveFileDialog)sender).FileName;
            System.IO.File.WriteAllText(filename, richTextBox1.Rtf);
            FileName = filename;
            IsDirty = false;
            this.Text = $"Text Edit - {FileName}";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf";
            
            saveFileDialog1.ShowDialog();
        }

        private void FrmTxtEdit_Load(object sender, EventArgs e)
        {
            if(thisUser.UserType=="View")
            {
                richTextBox1.Enabled = false;
            }
        }

        /// <summary>
        /// Saves the file with a specific filename
        /// </summary>
        /// <param name="filename"></param>
        public void SaveFile(string filename)
        {
            System.IO.File.WriteAllText(filename, richTextBox1.Rtf);
            FileName = filename;
            IsDirty = false;
            this.Text = $"Text Edit - {FileName}";
        }


        /// <summary>
        /// Saves the File
        /// </summary>
        public void saveFile()
        {
            if(FileName == "New File")
            {
                saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf";

                saveFileDialog1.ShowDialog();
            }
            else
            {
                System.IO.File.WriteAllText(FileName, richTextBox1.Rtf);

                IsDirty = false;
                this.Text = $"Text Edit - {FileName}";
            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            saveFile();

        }

        private void tsSaveAs_Click(object sender, EventArgs e)
        {
            //SaveAS
            saveFileDialog1.ShowDialog();

        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            int selstart = richTextBox1.SelectionStart;
            int sellength = richTextBox1.SelectionLength;

            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);

            // Set cursor after selected text
            richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            richTextBox1.SelectionLength = 0;
            // Set font immediately after selection
            richTextBox1.SelectionFont = richTextBox1.Font;

            // Reselect previous text
            richTextBox1.Select(selstart, sellength);
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            int selstart = richTextBox1.SelectionStart;
            int sellength = richTextBox1.SelectionLength;

            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);

            // Set cursor after selected text
            richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            richTextBox1.SelectionLength = 0;
            // Set font immediately after selection
            richTextBox1.SelectionFont = richTextBox1.Font;

            // Reselect previous text
            richTextBox1.Select(selstart, sellength);
        }

        private void tsUnderline_Click(object sender, EventArgs e)
        {
            int selstart = richTextBox1.SelectionStart;
            int sellength = richTextBox1.SelectionLength;

            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);

            // Set cursor after selected text
            richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            richTextBox1.SelectionLength = 0;
            // Set font immediately after selection
            richTextBox1.SelectionFont = richTextBox1.Font;

            // Reselect previous text
            richTextBox1.Select(selstart, sellength);
        }

        private void tsFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

        }
    }
}
