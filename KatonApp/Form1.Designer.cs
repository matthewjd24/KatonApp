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
            button1.Location = new Point(267, 94);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 0;
            button1.Text = "Create New Lot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateLot_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 23);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Lot Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 27);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 3;
            label2.Text = "K";
            // 
            // button2
            // 
            button2.Location = new Point(457, 15);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(73, 43);
            button2.TabIndex = 4;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Go_Click;
            // 
            // label3
            // 
            label3.Location = new Point(567, 127);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 5;
            label3.Text = "Part Name:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // partNameLabel
            // 
            partNameLabel.Location = new Point(680, 127);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(349, 27);
            partNameLabel.TabIndex = 6;
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoEllipsis = true;
            partNumberLabel.Location = new Point(680, 52);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new Size(134, 27);
            partNumberLabel.TabIndex = 8;
            // 
            // label6
            // 
            label6.Location = new Point(567, 52);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 7;
            label6.Text = "Part Number:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new Point(567, 90);
            label7.Name = "label7";
            label7.Size = new Size(106, 27);
            label7.TabIndex = 9;
            label7.Text = "Customer:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // customerLabel
            // 
            customerLabel.Location = new Point(680, 91);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(349, 27);
            customerLabel.TabIndex = 10;
            // 
            // poLabel
            // 
            poLabel.Location = new Point(856, 52);
            poLabel.Name = "poLabel";
            poLabel.Size = new Size(122, 27);
            poLabel.TabIndex = 12;
            // 
            // label10
            // 
            label10.Location = new Point(804, 52);
            label10.Name = "label10";
            label10.Size = new Size(46, 27);
            label10.TabIndex = 11;
            label10.Text = "PO:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // qtyLabel
            // 
            qtyLabel.Location = new Point(856, 18);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(122, 27);
            qtyLabel.TabIndex = 14;
            // 
            // label12
            // 
            label12.Location = new Point(804, 18);
            label12.Name = "label12";
            label12.Size = new Size(46, 27);
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
            groupBox2.Location = new Point(426, 162);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(360, 380);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Job Setup/CAM";
            // 
            // button4
            // 
            button4.Location = new Point(276, 126);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(66, 27);
            button4.TabIndex = 25;
            button4.Text = "Set";
            button4.UseVisualStyleBackColor = true;
            button4.Click += SetCAM_Click;
            // 
            // label23
            // 
            label23.Location = new Point(19, 129);
            label23.Name = "label23";
            label23.Size = new Size(186, 27);
            label23.TabIndex = 21;
            label23.Text = "CAM File Path:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(19, 160);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(323, 27);
            textBox6.TabIndex = 20;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(19, 77);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(117, 24);
            radioButton5.TabIndex = 19;
            radioButton5.Text = "Existing CAM";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(19, 44);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(96, 24);
            radioButton6.TabIndex = 18;
            radioButton6.Text = "New CAM";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Location = new Point(19, 220);
            label15.Name = "label15";
            label15.Size = new Size(186, 27);
            label15.TabIndex = 17;
            label15.Text = "Setup/CAM Instructions:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 250);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 103);
            textBox3.TabIndex = 17;
            // 
            // lotLabel
            // 
            lotLabel.Location = new Point(680, 18);
            lotLabel.Name = "lotLabel";
            lotLabel.Size = new Size(106, 27);
            lotLabel.TabIndex = 19;
            // 
            // label17
            // 
            label17.Location = new Point(567, 18);
            label17.Name = "label17";
            label17.Size = new Size(106, 27);
            label17.TabIndex = 20;
            label17.Text = "Lot:";
            label17.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Location = new Point(1056, 115);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(99, 43);
            button3.TabIndex = 21;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_org;
            pictureBox1.Location = new Point(21, 7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 129);
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
            groupBox3.Location = new Point(812, 162);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(360, 343);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Inspection";
            // 
            // label19
            // 
            label19.Location = new Point(21, 87);
            label19.Name = "label19";
            label19.Size = new Size(146, 27);
            label19.TabIndex = 21;
            label19.Text = "In-Process Inspection:";
            label19.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "Standard", "Controlled" });
            comboBox2.Location = new Point(174, 83);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 20;
            // 
            // label18
            // 
            label18.Location = new Point(109, 43);
            label18.Name = "label18";
            label18.Size = new Size(58, 27);
            label18.TabIndex = 19;
            label18.Text = "FAI:";
            label18.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Standard", "Controlled" });
            comboBox1.Location = new Point(174, 39);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 18;
            // 
            // label14
            // 
            label14.Location = new Point(21, 147);
            label14.Name = "label14";
            label14.Size = new Size(271, 27);
            label14.TabIndex = 17;
            label14.Text = "Associated Controlled Inspection Forms:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 177);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 144);
            textBox4.TabIndex = 17;
            // 
            // label21
            // 
            label21.Location = new Point(984, 52);
            label21.Name = "label21";
            label21.Size = new Size(46, 27);
            label21.TabIndex = 23;
            label21.Text = "Line:";
            label21.TextAlign = ContentAlignment.TopRight;
            // 
            // lineLabel
            // 
            lineLabel.Location = new Point(1039, 52);
            lineLabel.Name = "lineLabel";
            lineLabel.Size = new Size(73, 27);
            lineLabel.TabIndex = 24;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1224, 929);
            tabControl1.TabIndex = 25;
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1216, 896);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "     Work List       ";
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
            groupBox5.Location = new Point(570, 7);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(578, 149);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "Filters";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(394, 109);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(164, 27);
            textBox12.TabIndex = 48;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(394, 74);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(164, 27);
            textBox11.TabIndex = 47;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(142, 109);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(132, 27);
            textBox10.TabIndex = 46;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(142, 74);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(132, 27);
            textBox9.TabIndex = 45;
            // 
            // button8
            // 
            button8.Location = new Point(449, 17);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(109, 43);
            button8.TabIndex = 44;
            button8.Text = "Filter";
            button8.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Location = new Point(272, 115);
            label11.Name = "label11";
            label11.Size = new Size(106, 31);
            label11.TabIndex = 31;
            label11.Text = "Part Name:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label27
            // 
            label27.Location = new Point(20, 77);
            label27.Name = "label27";
            label27.Size = new Size(106, 27);
            label27.TabIndex = 33;
            label27.Text = "Part Number:";
            label27.TextAlign = ContentAlignment.TopRight;
            // 
            // label28
            // 
            label28.Location = new Point(80, 112);
            label28.Name = "label28";
            label28.Size = new Size(46, 27);
            label28.TabIndex = 37;
            label28.Text = "PO:";
            label28.TextAlign = ContentAlignment.TopRight;
            // 
            // label31
            // 
            label31.Location = new Point(272, 77);
            label31.Name = "label31";
            label31.Size = new Size(106, 27);
            label31.TabIndex = 35;
            label31.Text = "Customer:";
            label31.TextAlign = ContentAlignment.TopRight;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(20, 36);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(145, 24);
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
            dataGridView1.Location = new Point(6, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1204, 728);
            dataGridView1.TabIndex = 29;
            // 
            // button5
            // 
            button5.Location = new Point(267, 94);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(137, 43);
            button5.TabIndex = 24;
            button5.Text = "Create New Lot";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CreateLot_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(239, 27);
            label24.Name = "label24";
            label24.Size = new Size(91, 20);
            label24.TabIndex = 26;
            label24.Text = "Lot Number:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(345, 23);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(81, 27);
            textBox7.TabIndex = 25;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(330, 27);
            label25.Name = "label25";
            label25.Size = new Size(18, 20);
            label25.TabIndex = 27;
            label25.Text = "K";
            // 
            // button6
            // 
            button6.Location = new Point(457, 15);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(73, 43);
            button6.TabIndex = 28;
            button6.Text = "Go";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Go_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_org;
            pictureBox2.Location = new Point(21, 7);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 129);
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1216, 896);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "       Lot Info       ";
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(1089, 15);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(66, 27);
            button7.TabIndex = 26;
            button7.Text = "Edit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Edit_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Location = new Point(21, 630);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(382, 259);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Finishing";
            // 
            // label20
            // 
            label20.Location = new Point(19, 56);
            label20.Name = "label20";
            label20.Size = new Size(186, 27);
            label20.TabIndex = 17;
            label20.Text = "Finishing Instructions:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(19, 87);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(323, 144);
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
            groupBox1.Location = new Point(21, 162);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(382, 448);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Material";
            // 
            // label13
            // 
            label13.Location = new Point(19, 249);
            label13.Name = "label13";
            label13.Size = new Size(106, 27);
            label13.TabIndex = 17;
            label13.Text = "Material Specs:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 280);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 144);
            textBox2.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 189);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Certs Required";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(19, 144);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(215, 24);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Customer Provided Material";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 111);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(280, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Bulk Material Ordered, Identify by Tag";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 77);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(348, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Bulk Material Ordered, Identify by Size and Type";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 44);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Shop Stock";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 953);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1266, 1000);
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
    }
}
