using System.Data;
using System.Diagnostics;

namespace KatonApp
{
    public partial class Form1 : Form
    {
        int? lotNumInt;
        public static string dataFolder = @"Z:\Zeta\Katon App Data";
        public Form1() {
            InitializeComponent();
        }

        private void CreateLot_Click(object sender, EventArgs e) {
            string[] files = Directory.GetFiles(dataFolder);
            List<int> takenNumbers = new() { 0 }; // add zero in case there is nothing in the folder
            for (int i = 0; i < files.Length; i++) {
                string name = Path.GetFileName(files[i]).Replace(".txt", "");
                if (name[0] != 'K') continue;
                bool success = int.TryParse(name.Substring(1), out int num);
                if (!success) {
                    MessageBox.Show("Error: There is a file in the folder with an invalid name: " + name,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                takenNumbers.Add(num);
                Debug.WriteLine(num);
            }
            New_Lot form = new New_Lot();
            form.lotNum = takenNumbers.Max() + 1;
            form.ShowDialog();
            if (form.partname == null) return;
            lotLabel.Text = form.lotNumString;
            lotNumInt = form.lotNum;
            qtyLabel.Text = form.qty;
            customerLabel.Text = form.customer;
            partNumberLabel.Text = form.pn;
            partNameLabel.Text = form.partname;
            poLabel.Text = form.po;
            lineLabel.Text = form.line;
            textBox1.Text = form.lotNumString.Replace("K", "");
        }

        private void Form1_Load_1(object sender, EventArgs e) {

            DataTable table = new DataTable();

            // define columns
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));

            // add rows
            table.Rows.Add(1, "Alpha");
            table.Rows.Add(2, "Beta");

            // bind to grid
            dataGridView1.DataSource = table;
        }

        private void SetCAM_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                textBox6.Text = ofd.FileName;
            }
        }

        private void Go_Click(object sender, EventArgs e) {
            button7.Enabled = true;
        }

        private void Edit_Click(object sender, EventArgs e) {
            New_Lot form = new New_Lot();
            form.lotNum = lotNumInt.Value;
        }

        private void tabPage1_Click(object sender, EventArgs e) {
        }
    }
}
