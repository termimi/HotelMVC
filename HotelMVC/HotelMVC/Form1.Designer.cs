namespace HotelMVC
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
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            typeChambre = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(275, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 97);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Date d'arrivée";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(194, 3);
            label2.Name = "label2";
            label2.Size = new Size(384, 72);
            label2.TabIndex = 2;
            label2.Text = "Room Booking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 160);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 3;
            label3.Text = "Date de départ";
            label3.Click += label3_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(275, 178);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 204);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 6;
            label4.Text = "Numéros de chambre";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(310, 222);
            numericUpDown1.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 248);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 9;
            label5.Text = "Demande spécial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 292);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 10;
            label6.Text = "Type de chambre";
            // 
            // typeChambre
            // 
            typeChambre.Items.Add("Chambre simple");
            typeChambre.Items.Add("Chambre double");
            typeChambre.Items.Add("Chambre KingSize");
            typeChambre.Items.Add("");
            typeChambre.Items.Add("");
            typeChambre.Location = new Point(308, 310);
            typeChambre.Name = "typeChambre";
            typeChambre.Size = new Size(120, 23);
            typeChambre.TabIndex = 11;
            typeChambre.Text = "type de chambre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(typeChambre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private DomainUpDown typeChambre;
    }
}