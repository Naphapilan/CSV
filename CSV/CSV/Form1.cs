using System.Text;

namespace CSV
{
    public partial class Form1 : Form
    {
        private string? strData;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV(*.csv)|*.csv";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[]readAllLine = File.ReadAllLines(openFileDialog.FileName);
             
                for(int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                    Student student = new Student(studentSplited[0], studentSplited[1], studentSplited[2]);
                    //addDataToGridView(student);
                    //TODO Add Student object to DataGridView
                }
                //TODO : calculate max,min,gpax
            }
        }
        private void addDataToGridView(string id,string name,string major) {
            this.dataGridView1.Rows.Add(new string[] {id,name,major}); }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string filepath =string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != string.Empty)
                {
                  
                    int row = this.dataGridView1.Rows.Count;
                    for(int i = 0; i< row; i++) 
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for(int j = 0; j< column; j++)
                        {
                            if (this.dataGridView1.Rows[i].Cells[j].Value != null) 
                            { 
                                strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                                //TODO save data from dataGridView1 to variable
                            }
                            
                        }
                    }
                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO add data to dataGridView
            //TODO CalCulate GPA,Max,Min
        }
    }
}