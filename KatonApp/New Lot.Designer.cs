namespace KatonApp
{
    partial class New_Lot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Lot));
            label21 = new Label();
            label17 = new Label();
            label16 = new Label();
            label3 = new Label();
            label12 = new Label();
            label6 = new Label();
            label10 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label21
            // 
            label21.Location = new Point(480, 66);
            label21.Name = "label21";
            label21.Size = new Size(46, 27);
            label21.TabIndex = 37;
            label21.Text = "Line:";
            label21.TextAlign = ContentAlignment.TopRight;
            // 
            // label17
            // 
            label17.Location = new Point(63, 28);
            label17.Name = "label17";
            label17.Size = new Size(106, 27);
            label17.TabIndex = 36;
            label17.Text = "Lot Number:";
            label17.TextAlign = ContentAlignment.TopRight;
            // 
            // label16
            // 
            label16.Location = new Point(176, 28);
            label16.Name = "label16";
            label16.Size = new Size(106, 27);
            label16.TabIndex = 35;
            // 
            // label3
            // 
            label3.Location = new Point(63, 141);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 25;
            label3.Text = "Part Name:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.Location = new Point(300, 28);
            label12.Name = "label12";
            label12.Size = new Size(46, 27);
            label12.TabIndex = 33;
            label12.Text = "Qty:";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Location = new Point(63, 66);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 27;
            label6.Text = "Part Number:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.Location = new Point(300, 66);
            label10.Name = "label10";
            label10.Size = new Size(46, 27);
            label10.TabIndex = 31;
            label10.Text = "PO:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new Point(63, 104);
            label7.Name = "label7";
            label7.Size = new Size(106, 27);
            label7.TabIndex = 29;
            label7.Text = "Customer:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 27);
            textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 27);
            textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(532, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 27);
            textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(352, 25);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 27);
            textBox4.TabIndex = 41;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 63);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 27);
            textBox5.TabIndex = 42;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(352, 63);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 27);
            textBox6.TabIndex = 43;
            // 
            // button2
            // 
            button2.Location = new Point(344, 193);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(125, 43);
            button2.TabIndex = 44;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(179, 193);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 43);
            button1.TabIndex = 45;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Cancel_Click;
            // 
            // New_Lot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 261);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label21);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "New_Lot";
            Text = "New Lot";
            Load += New_Lot_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label21;
        private Label label17;
        private Label label16;
        private Label label3;
        private Label label12;
        private Label label6;
        private Label label10;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private Button button1;
    }
}