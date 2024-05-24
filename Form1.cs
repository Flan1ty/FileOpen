namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
              System.Windows.Forms.DialogResult.OK &&
                  openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.SaveFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.PlainText);
                }
                this.Text = openFileDialog1.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
