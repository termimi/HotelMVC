namespace realHotelMVC
{
    partial class View
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
            Arrivee = new DateTimePicker();
            depart = new DateTimePicker();
            nombrechambre = new NumericUpDown();
            demandeSpecial = new TextBox();
            booker = new Button();
            ((System.ComponentModel.ISupportInitialize)nombrechambre).BeginInit();
            SuspendLayout();
            // 
            // Arrivee
            // 
            Arrivee.Location = new Point(300, 96);
            Arrivee.Name = "Arrivee";
            Arrivee.Size = new Size(200, 23);
            Arrivee.TabIndex = 0;
            Arrivee.ValueChanged += Arrivee_ValueChanged;
            // 
            // depart
            // 
            depart.Location = new Point(300, 159);
            depart.Name = "depart";
            depart.Size = new Size(200, 23);
            depart.TabIndex = 1;
            depart.ValueChanged += depart_ValueChanged;
            // 
            // nombrechambre
            // 
            nombrechambre.Location = new Point(333, 226);
            nombrechambre.Name = "nombrechambre";
            nombrechambre.Size = new Size(120, 23);
            nombrechambre.TabIndex = 2;
            nombrechambre.ValueChanged += nombrechambre_ValueChanged;
            // 
            // demandeSpecial
            // 
            demandeSpecial.Location = new Point(333, 291);
            demandeSpecial.Name = "demandeSpecial";
            demandeSpecial.Size = new Size(100, 23);
            demandeSpecial.TabIndex = 3;
            demandeSpecial.TextChanged += demandeSpecial_TextChanged;
            // 
            // booker
            // 
            booker.Location = new Point(333, 347);
            booker.Name = "booker";
            booker.Size = new Size(75, 23);
            booker.TabIndex = 4;
            booker.Text = "booker";
            booker.UseVisualStyleBackColor = true;
            booker.Click += booker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(booker);
            Controls.Add(demandeSpecial);
            Controls.Add(nombrechambre);
            Controls.Add(depart);
            Controls.Add(Arrivee);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nombrechambre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker Arrivee;
        private DateTimePicker depart;
        private NumericUpDown nombrechambre;
        private TextBox demandeSpecial;
        private Button booker;
    }
}