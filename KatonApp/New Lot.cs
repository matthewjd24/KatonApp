

namespace KatonApp
{
    public partial class New_Lot : Form
    {
        public int lotNum;
        public string lotNumString;
        public string qty;
        public string pn;
        public string po;
        public string line;
        public string customer;
        public string partname;
        public New_Lot() {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void Save_Click(object sender, EventArgs e) {
            string fileName = Form1.lotsFolder + @"\" + lotNumString + ".txt";
            if (!File.Exists(fileName)) {
                string[] emptyLines = new string[35];
                emptyLines[6] = "0";
                emptyLines[7] = "0";
                emptyLines[12] = "-1";
                emptyLines[13] = "-1";
                File.WriteAllLines(fileName, emptyLines);
            }

            List<string> lines = File.ReadAllLines(fileName).ToList();

            qty = textBox4.Text;
            pn = textBox5.Text;
            po = textBox6.Text;
            line = textBox3.Text;
            customer = textBox2.Text;
            partname = textBox1.Text;

            lines[0] = qty + "  // quantity";
            lines[1] = pn + "  // part number";
            lines[2] = po + "  // purchase order";
            lines[3] = line + "  // purchase order line";
            lines[4] = customer + "  // customer";
            lines[5] = partname + "  // part name";

            File.WriteAllText(fileName, "");
            File.WriteAllLines(fileName, lines.ToArray());
            Close();
        }

        private void New_Lot_Load(object sender, EventArgs e) {
            
            lotNumString = Form1.ConvertIntToLotNum(lotNum);
            label16.Text = lotNumString;
        }
    }
}
