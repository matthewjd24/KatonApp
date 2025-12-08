using System.Data;
using System.Diagnostics;
using System.Xml.Linq;

namespace KatonApp
{
    public partial class Form1 : Form
    {
        public static int versionNum = 1;
        int? lotNumInt;
        public static string lotsFolder = @"Z:\Zeta\Katon App\Lots";
        //public static string lotsFolder = @"C:\Projects\Katon App\Lots";
        //public string baseFolder = @"C:\Projects\Katon App";
        public Form1() {
            InitializeComponent();
        }

        private void CreateLot_Click(object sender, EventArgs e) {
            string[] files = Directory.GetFiles(lotsFolder);
            List<int> takenNumbers = new() { 0 }; // add zero in case there is nothing in the folder
            for (int i = 0; i < files.Length; i++) {
                string name = Path.GetFileName(files[i]).Replace(".txt", "");
                if (name[0] != 'K') continue;
                bool success = int.TryParse(name.Substring(1), out int num);
                if (!success) {
                    MessageBox.Show("Error: There is a file in the Lots folder with an invalid name: " + name,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                takenNumbers.Add(num);
                Debug.WriteLine(num);
            }
            New_Lot form = new New_Lot();
            form.lotNum = takenNumbers.Max() + 1;
            form.ShowDialog();
            if (form.partname == null) return;  // data from the form wasn't stored, so it must've been canceled
            tabControl1.SelectedIndex = 1;   // activates the second tab
            //lotLabel.Text = form.lotNumString;
            //lotNumInt = form.lotNum;
            //qtyLabel.Text = form.qty;
            //customerLabel.Text = form.customer;
            //partNumberLabel.Text = form.pn;
            //partNameLabel.Text = form.partname;
            //poLabel.Text = form.po;
            //lineLabel.Text = form.line;
            textBox1.Text = form.lotNumString.Replace("K", "");
            Go_Click(null, null);
            Form1_Load_1(null, null);
        }

        private void Form1_Load_1(object sender, EventArgs e) {
            string versionFile = @"Z:\Zeta\Katon App\version.txt";
            List<string> versionLines = File.ReadAllLines(versionFile).ToList();
            int version = int.Parse(versionLines[0]);
            Debug.WriteLine("version: " + version);
            if(version > versionNum) {
                Process.Start(@"C:\Katon App\Updater\Updater.exe");
                Application.Exit();
            }

            string[] matches = Directory.GetFiles(lotsFolder, "*");

            DataTable table = new DataTable();

            // define columns
            table.Columns.Add("Lot", typeof(string));
            table.Columns.Add("Part Number", typeof(string));
            table.Columns.Add("Part Name", typeof(string));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("Customer", typeof(string));
            table.Columns.Add("Completed", typeof(string));

            foreach (var x in matches) {
                string name = Path.GetFileName(x).Replace(".txt", "");
                var lines = File.ReadAllLines(x);
                DataRow row = table.NewRow();
                row["Lot"] = name;
                if (RemoveEverythingAfterSlashSlash(lines[17]) == "1") row["Completed"] = "Yes";
                else row["Completed"] = "No";
                row["Qty"] = int.Parse(RemoveEverythingAfterSlashSlash(lines[0]));
                row["Part Number"] = RemoveEverythingAfterSlashSlash(lines[1]);
                row["Customer"] = RemoveEverythingAfterSlashSlash(lines[4]);
                row["Part Name"] = RemoveEverythingAfterSlashSlash(lines[5]);

                table.Rows.Add(row);
            }

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
            string lotNumber = textBox1.Text;
            string lotFileName = "K" + lotNumber + ".txt";
            string[] matches = Directory.GetFiles(lotsFolder, lotFileName);

            if (matches.Length == 0) {
                MessageBox.Show($"Did not find lot {lotNumber}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> lines = File.ReadAllLines(matches[0]).ToList();
            if (lines.Count == 0) {
                MessageBox.Show($"The file for lot {lotNumber} is empty. Something has gone wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedIndex = 1;   // activates the second tab
            lotNumInt = int.Parse(lotNumber);
            lotLabel.Text = "K" + lotNumber;
            qtyLabel.Text = RemoveEverythingAfterSlashSlash(lines[0]);
            partNumberLabel.Text = RemoveEverythingAfterSlashSlash(lines[1]);
            poLabel.Text = RemoveEverythingAfterSlashSlash(lines[2]);
            lineLabel.Text = RemoveEverythingAfterSlashSlash(lines[3]);
            customerLabel.Text = RemoveEverythingAfterSlashSlash(lines[4]);
            partNameLabel.Text = RemoveEverythingAfterSlashSlash(lines[5]);
            button7.Enabled = true;
            button3.Enabled = true;

            int materialOption = int.Parse(RemoveEverythingAfterSlashSlash(lines[6]));
            if (materialOption == 1) radioButton1.Checked = true;
            else if (materialOption == 2) radioButton2.Checked = true;
            else if (materialOption == 3) radioButton3.Checked = true;
            else if (materialOption == 4) radioButton4.Checked = true;
            else {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            int certsRequired = int.Parse(RemoveEverythingAfterSlashSlash(lines[7]));
            checkBox1.Checked = certsRequired == 1;
            string matSpecs = RemoveEverythingAfterSlashSlash(lines[8]);
            matSpecs = matSpecs.Replace("&&", Environment.NewLine);
            textBox2.Text = matSpecs;
            string camOption = RemoveEverythingAfterSlashSlash(lines[9]);
            if (camOption == "1") radioButton5.Checked = true;
            else if (camOption == "2") radioButton6.Checked = true;
            else {
                radioButton5.Checked = false;
                radioButton6.Checked = false;
            }
            textBox6.Text = RemoveEverythingAfterSlashSlash(lines[10]);
            string setupInstructions = RemoveEverythingAfterSlashSlash(lines[11]);
            setupInstructions = setupInstructions.Replace("&&", Environment.NewLine);
            textBox3.Text = setupInstructions;

            comboBox1.SelectedIndex = int.Parse(RemoveEverythingAfterSlashSlash(lines[12]));
            comboBox2.SelectedIndex = int.Parse(RemoveEverythingAfterSlashSlash(lines[13]));
            string associatedForms = RemoveEverythingAfterSlashSlash(lines[14]);
            associatedForms = associatedForms.Replace("&&", Environment.NewLine);
            textBox4.Text = associatedForms;
            string finishingInstructions = RemoveEverythingAfterSlashSlash(lines[15]);
            finishingInstructions = finishingInstructions.Replace("&&", Environment.NewLine);
            textBox5.Text = finishingInstructions;
            string cOfCRequired = RemoveEverythingAfterSlashSlash(lines[16]);
            checkBox3.Checked = cOfCRequired == "1";
            string completed = RemoveEverythingAfterSlashSlash(lines[17]);
            button9.Enabled = completed != "1";
            if (completed == "1") {
                label4.BackColor = System.Drawing.Color.PaleGreen;
                label4.Text = "Completed";
            }
            else {
                label4.BackColor = SystemColors.Control;
                label4.Text = "";
            }
        }

        string RemoveEverythingAfterSlashSlash(string input) {
            int index = input.IndexOf("  //");
            if (index >= 0) {
                return input.Substring(0, index).Trim();
            }
            return input.Trim();
        }

        private void Edit_Click(object sender, EventArgs e) {
            New_Lot form = new New_Lot();
            form.lotNum = lotNumInt.Value;
        }

        private void tabPage1_Click(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if ((TextBox)sender == textBox1)
                textBox7.Text = textBox1.Text;
            else
                textBox1.Text = textBox7.Text;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            //if (tabControl1.SelectedIndex == 0)
            //    this.AcceptButton = button6;
            //else if (tabControl1.SelectedIndex == 1)
            //    this.AcceptButton = button2;
        }

        private void save_Click(object sender, EventArgs e) {
            string lotString = ConvertIntToLotNum(lotNumInt.Value);
            string fileName = lotsFolder + @"\" + lotString + ".txt";
            if (!File.Exists(fileName)) {
                MessageBox.Show($"Did not find file for lot {lotString}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> lines = File.ReadAllLines(fileName).ToList();
            int selectedMaterialOption = 0;
            if (radioButton1.Checked) selectedMaterialOption = 1;
            else if (radioButton2.Checked) selectedMaterialOption = 2;
            else if (radioButton3.Checked) selectedMaterialOption = 3;
            else if (radioButton4.Checked) selectedMaterialOption = 4;
            lines[6] = selectedMaterialOption.ToString() + "  // material option";
            int certsRequired = checkBox1.Checked ? 1 : 0;
            lines[7] = certsRequired.ToString() + "  // certifications required";
            lines[8] = textBox2.Text.Replace(Environment.NewLine, "&&") + "  // material specs text box";
            int selectedCamOption = 0;
            if (radioButton5.Checked) selectedCamOption = 1;
            else if (radioButton6.Checked) selectedCamOption = 2;
            lines[9] = selectedCamOption.ToString() + "  // CAM option";
            lines[10] = textBox6.Text + "  // CAM file path";
            lines[11] = textBox3.Text.Replace(Environment.NewLine, "&&") + "  // Setup or CAM instructions";
            lines[12] = comboBox1.SelectedIndex + "  // FAI type";
            lines[13] = comboBox2.SelectedIndex + "  // In-process inspection";
            lines[14] = textBox4.Text.Replace(Environment.NewLine, "&&") + "  // Associated controlled inspection forms";
            lines[15] = textBox5.Text.Replace(Environment.NewLine, "&&") + "  // Finishing instructions";
            int cOfCRequired = checkBox3.Checked ? 1 : 0;
            lines[16] = cOfCRequired.ToString() + "  // cert of conformance required";
            lines[17] = button9.Enabled ? "0" : "1" + "  // is completed";

            File.WriteAllText(fileName, "");
            File.WriteAllLines(fileName, lines.ToArray());
            button3.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
            Form1_Load_1(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Stop();
            timer1.Enabled = false;
            button3.Enabled = true;
        }

        public static string ConvertIntToLotNum(int lotNum) {
            string zeroes = "";
            int digitCount = lotNum.ToString().Length;
            for (int i = 0; i < 4 - digitCount; i++) {
                zeroes += "0";
            }
            return "K" + zeroes + lotNum;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return; // ignore header clicks

            var value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = value.ToString().Substring(1);
            Go_Click(null, null);
        }

        private void button9_Click(object sender, EventArgs e) {
            button9.Enabled = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.RowIndex < 0) return;
            var grid = (DataGridView)sender;

            // Target a specific column by its Name
            if (grid.Columns[e.ColumnIndex].DataPropertyName == "Completed") {
                var value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (value != null && value.ToString() == "Yes") {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewColumn col in dataGridView1.Columns) {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
