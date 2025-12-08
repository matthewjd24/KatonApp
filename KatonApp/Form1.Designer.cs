namespace KatonApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            partNameLabel = new Label();
            partNumberLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            customerLabel = new Label();
            poLabel = new Label();
            label10 = new Label();
            qtyLabel = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label23 = new Label();
            textBox6 = new TextBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label15 = new Label();
            textBox3 = new TextBox();
            lotLabel = new Label();
            label17 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            label19 = new Label();
            comboBox2 = new ComboBox();
            label18 = new Label();
            comboBox1 = new ComboBox();
            label14 = new Label();
            textBox4 = new TextBox();
            label21 = new Label();
            lineLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox5 = new GroupBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            button8 = new Button();
            label11 = new Label();
            label27 = new Label();
            label28 = new Label();
            label31 = new Label();
            checkBox2 = new CheckBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label24 = new Label();
            textBox7 = new TextBox();
            label25 = new Label();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            button7 = new Button();
            groupBox4 = new GroupBox();
            label20 = new Label();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            label13 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(209, 70);
            button1.Name = "button1";
            button1.Size = new Size(120, 32);
            button1.TabIndex = 0;
            button1.Text = "Create New Lot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateLot_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Lot Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 20);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "K";
            // 
            // button2
            // 
            button2.Location = new Point(400, 11);
            button2.Name = "button2";
            button2.Size = new Size(64, 32);
            button2.TabIndex = 4;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Go_Click;
            // 
            // label3
            // 
            label3.Location = new Point(496, 95);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 5;
            label3.Text = "Part Name:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // partNameLabel
            // 
            partNameLabel.Location = new Point(595, 95);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(305, 20);
            partNameLabel.TabIndex = 6;
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoEllipsis = true;
            partNumberLabel.Location = new Point(595, 39);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new Size(117, 20);
            partNumberLabel.TabIndex = 8;
            // 
            // label6
            // 
            label6.Location = new Point(496, 39);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 7;
            label6.Text = "Part Number:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new Point(496, 68);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 9;
            label7.Text = "Customer:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // customerLabel
            // 
            customerLabel.Location = new Point(595, 68);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(305, 20);
            customerLabel.TabIndex = 10;
            // 
            // poLabel
            // 
            poLabel.Location = new Point(749, 39);
            poLabel.Name = "poLabel";
            poLabel.Size = new Size(107, 20);
            poLabel.TabIndex = 12;
            // 
            // label10
            // 
            label10.Location = new Point(704, 39);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 11;
            label10.Text = "PO:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // qtyLabel
            // 
            qtyLabel.Location = new Point(749, 14);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(107, 20);
            qtyLabel.TabIndex = 14;
            // 
            // label12
            // 
            label12.Location = new Point(704, 14);
            label12.Name = "label12";
            label12.Size = new Size(40, 20);
            label12.TabIndex = 13;
            label12.Text = "Qty:";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(373, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 285);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Job Setup/CAM";
            // 
            // button4
            // 
            button4.Location = new Point(242, 94);
            button4.Name = "button4";
            button4.Size = new Size(58, 23);
            button4.TabIndex = 25;
            button4.Text = "Set";
            button4.UseVisualStyleBackColor = true;
            button4.Click += SetCAM_Click;
            // 
            // label23
            // 
            label23.Location = new Point(17, 97);
            label23.Name = "label23";
            label23.Size = new Size(163, 20);
            label23.TabIndex = 21;
            label23.Text = "CAM File Path:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(17, 120);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(283, 23);
            textBox6.TabIndex = 20;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(17, 58);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(95, 19);
            radioButton5.TabIndex = 19;
            radioButton5.Text = "Existing CAM";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(17, 33);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(79, 19);
            radioButton6.TabIndex = 18;
            radioButton6.Text = "New CAM";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Location = new Point(17, 165);
            label15.Name = "label15";
            label15.Size = new Size(163, 20);
            label15.TabIndex = 17;
            label15.Text = "Setup/CAM Instructions:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 188);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 78);
            textBox3.TabIndex = 17;
            // 
            // lotLabel
            // 
            lotLabel.Location = new Point(595, 14);
            lotLabel.Name = "lotLabel";
            lotLabel.Size = new Size(93, 20);
            lotLabel.TabIndex = 19;
            // 
            // label17
            // 
            label17.Location = new Point(496, 14);
            label17.Name = "label17";
            label17.Size = new Size(93, 20);
            label17.TabIndex = 20;
            label17.Text = "Lot:";
            label17.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(909, 608);
            button3.Name = "button3";
            button3.Size = new Size(102, 38);
            button3.TabIndex = 21;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += save_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_org;
            pictureBox1.Location = new Point(18, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Location = new Point(710, 122);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 257);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Inspection";
            // 
            // label19
            // 
            label19.Location = new Point(18, 65);
            label19.Name = "label19";
            label19.Size = new Size(128, 20);
            label19.TabIndex = 21;
            label19.Text = "In-Process Inspection:";
            label19.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "Standard", "Controlled" });
            comboBox2.Location = new Point(152, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 20;
            // 
            // label18
            // 
            label18.Location = new Point(95, 32);
            label18.Name = "label18";
            label18.Size = new Size(51, 20);
            label18.TabIndex = 19;
            label18.Text = "FAI:";
            label18.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Standard", "Controlled" });
            comboBox1.Location = new Point(152, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            // 
            // label14
            // 
            label14.Location = new Point(18, 110);
            label14.Name = "label14";
            label14.Size = new Size(237, 20);
            label14.TabIndex = 17;
            label14.Text = "Associated Controlled Inspection Forms:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 133);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 109);
            textBox4.TabIndex = 17;
            // 
            // label21
            // 
            label21.Location = new Point(861, 39);
            label21.Name = "label21";
            label21.Size = new Size(40, 20);
            label21.TabIndex = 23;
            label21.Text = "Line:";
            label21.TextAlign = ContentAlignment.TopRight;
            // 
            // lineLabel
            // 
            lineLabel.Location = new Point(909, 39);
            lineLabel.Name = "lineLabel";
            lineLabel.Size = new Size(64, 20);
            lineLabel.TabIndex = 24;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 697);
            tabControl1.TabIndex = 25;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1063, 669);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "         Work List           ";
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox12);
            groupBox5.Controls.Add(textBox11);
            groupBox5.Controls.Add(textBox10);
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label27);
            groupBox5.Controls.Add(label28);
            groupBox5.Controls.Add(label31);
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Location = new Point(499, 5);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(506, 112);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "Filters";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(345, 82);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(144, 23);
            textBox12.TabIndex = 48;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(345, 56);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(144, 23);
            textBox11.TabIndex = 47;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(124, 82);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(116, 23);
            textBox10.TabIndex = 46;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(124, 56);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(116, 23);
            textBox9.TabIndex = 45;
            // 
            // button8
            // 
            button8.Location = new Point(393, 13);
            button8.Name = "button8";
            button8.Size = new Size(95, 32);
            button8.TabIndex = 44;
            button8.Text = "Filter";
            button8.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Location = new Point(238, 86);
            label11.Name = "label11";
            label11.Size = new Size(93, 23);
            label11.TabIndex = 31;
            label11.Text = "Part Name:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label27
            // 
            label27.Location = new Point(18, 58);
            label27.Name = "label27";
            label27.Size = new Size(93, 20);
            label27.TabIndex = 33;
            label27.Text = "Part Number:";
            label27.TextAlign = ContentAlignment.TopRight;
            // 
            // label28
            // 
            label28.Location = new Point(70, 84);
            label28.Name = "label28";
            label28.Size = new Size(40, 20);
            label28.TabIndex = 37;
            label28.Text = "PO:";
            label28.TextAlign = ContentAlignment.TopRight;
            // 
            // label31
            // 
            label31.Location = new Point(238, 58);
            label31.Name = "label31";
            label31.Size = new Size(93, 20);
            label31.TabIndex = 35;
            label31.Text = "Customer:";
            label31.TextAlign = ContentAlignment.TopRight;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 27);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 19);
            checkBox2.TabIndex = 30;
            checkBox2.Text = "Show Completed";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 122);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1054, 546);
            dataGridView1.TabIndex = 29;
            // 
            // button5
            // 
            button5.Location = new Point(209, 70);
            button5.Name = "button5";
            button5.Size = new Size(120, 32);
            button5.TabIndex = 24;
            button5.Text = "Create New Lot";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CreateLot_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(209, 20);
            label24.Name = "label24";
            label24.Size = new Size(74, 15);
            label24.TabIndex = 26;
            label24.Text = "Lot Number:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(302, 17);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(71, 23);
            textBox7.TabIndex = 25;
            textBox7.TextChanged += textBox1_TextChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(289, 20);
            label25.Name = "label25";
            label25.Size = new Size(14, 15);
            label25.TabIndex = 27;
            label25.Text = "K";
            // 
            // button6
            // 
            button6.Location = new Point(400, 11);
            button6.Name = "button6";
            button6.Size = new Size(64, 32);
            button6.TabIndex = 28;
            button6.Text = "Go";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Go_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_org;
            pictureBox2.Location = new Point(18, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(lineLabel);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(lotLabel);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(qtyLabel);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(partNameLabel);
            tabPage2.Controls.Add(poLabel);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(partNumberLabel);
            tabPage2.Controls.Add(customerLabel);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1063, 669);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "           Lot Info           ";
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(953, 11);
            button7.Name = "button7";
            button7.Size = new Size(58, 25);
            button7.TabIndex = 26;
            button7.Text = "Edit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Edit_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Location = new Point(18, 472);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 194);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Finishing";
            // 
            // label20
            // 
            label20.Location = new Point(17, 42);
            label20.Name = "label20";
            label20.Size = new Size(163, 20);
            label20.TabIndex = 17;
            label20.Text = "Finishing Instructions:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 65);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(283, 109);
            textBox5.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(18, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 336);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Material";
            // 
            // label13
            // 
            label13.Location = new Point(17, 187);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 17;
            label13.Text = "Material Specs:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 210);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 109);
            textBox2.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Certs Required";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 108);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(173, 19);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Customer Provided Material";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 83);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(224, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Bulk Material Ordered, Identify by Tag";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(276, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Bulk Material Ordered, Identify by Size and Type";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Shop Stock";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 721);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1110, 760);
            Name = "Form1";
            Text = "Katon Job Information";
            Load += Form1_Load_1;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label partNameLabel;
        private Label partNumberLabel;
        private Label label6;
        private Label label7;
        private Label customerLabel;
        private Label poLabel;
        private Label label10;
        private Label qtyLabel;
        private Label label12;
        private GroupBox groupBox2;
        private Label label15;
        private TextBox textBox3;
        private Label lotLabel;
        private Label label17;
        private Button button3;
        private PictureBox pictureBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox3;
        private Label label14;
        private TextBox textBox4;
        private Label label19;
        private ComboBox comboBox2;
        private Label label18;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private Label label21;
        private Label lineLabel;
        private Label label23;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private Label label20;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private Label label13;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox2;
        private Button button5;
        private Label label24;
        private TextBox textBox7;
        private Label label25;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button7;
        private CheckBox checkBox2;
        private GroupBox groupBox5;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private Button button8;
        private Label label11;
        private Label label27;
        private Label label28;
        private Label label31;
        private System.Windows.Forms.Timer timer1;
    }
}
