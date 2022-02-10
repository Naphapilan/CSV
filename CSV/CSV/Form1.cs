namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create openfiledialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                string data = File.ReadAllText(filepath);
                this.textBoxDisplayData.Text = data;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///get text from textboox
            string data = this.textBoxDisplayData.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                ///save to file
                File.WriteAllText(filepath, data, System.Text.Encoding.UTF8);
            }
        }
    }
}