using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad_kbj20221228
{
    public partial class note : Form
    {
        public note()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new note().Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bumju = new OpenFileDialog();
            bumju.Title = "Open";
            bumju.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if(bumju.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(bumju.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = bumju.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog bumju = new SaveFileDialog();
            bumju.Title = "Save";
            bumju.OverwritePrompt = true;
            bumju.DefaultExt = "*.txt";
            bumju.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (bumju.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(bumju.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = bumju.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if(fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fnt.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
