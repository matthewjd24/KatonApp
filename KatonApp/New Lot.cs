

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
            qty = textBox4.Text;
            pn = textBox5.Text;
            po = textBox6.Text;
            line = textBox3.Text;
            customer = textBox2.Text;
            partname = textBox1.Text;
            List<string> list = new() {
                qty, pn, po, line, customer, partname
            };
            string fileName = Form1.dataFolder + @"\" + lotNumString + ".txt";
            File.WriteAllLines(fileName, list.ToArray());
            Close();
        }

        private void New_Lot_Load(object sender, EventArgs e) {
            string zeroes = "";
            int digitCount = lotNum.ToString().Length;
            for (int i = 0; i < 4 - digitCount; i++) {
                zeroes += "0";
            }
            lotNumString = "K" + zeroes + lotNum;
            label16.Text = lotNumString;
        }
    }
}
