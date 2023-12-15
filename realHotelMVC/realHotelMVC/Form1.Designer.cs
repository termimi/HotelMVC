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
            Titre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nombrechambre).BeginInit();
            SuspendLayout();
            // 
            // Arrivee
            // 
            Arrivee.Location = new Point(300, 121);
            Arrivee.Name = "Arrivee";
            Arrivee.Size = new Size(200, 23);
            Arrivee.TabIndex = 0;
            Arrivee.ValueChanged += Arrivee_ValueChanged;
            // 
            // depart
            // 
            depart.Location = new Point(300, 165);
            depart.Name = "depart";
            depart.Size = new Size(200, 23);
            depart.TabIndex = 1;
            depart.ValueChanged += depart_ValueChanged;
            // 
            // nombrechambre
            // 
            nombrechambre.Location = new Point(333, 219);
            nombrechambre.Name = "nombrechambre";
            nombrechambre.Size = new Size(120, 23);
            nombrechambre.TabIndex = 2;
            nombrechambre.ValueChanged += nombrechambre_ValueChanged;
            // 
            // demandeSpecial
            // 
            demandeSpecial.Location = new Point(333, 262);
            demandeSpecial.Name = "demandeSpecial";
            demandeSpecial.Size = new Size(100, 23);
            demandeSpecial.TabIndex = 3;
            demandeSpecial.TextChanged += demandeSpecial_TextChanged;
            // 
            // booker
            // 
            booker.Location = new Point(348, 312);
            booker.Name = "booker";
            booker.Size = new Size(75, 23);
            booker.TabIndex = 4;
            booker.Text = "booker";
            booker.UseVisualStyleBackColor = true;
            booker.Click += booker_Click;
            // 
            // Titre
            // 
            Titre.AutoSize = true;
            Titre.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            Titre.Location = new Point(200, 9);
            Titre.Name = "Titre";
            Titre.Size = new Size(409, 81);
            Titre.TabIndex = 5;
            Titre.Text = "RoomBooking";
            Titre.Click += Titre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 103);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Date d'arrivée";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 147);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Date de départ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 201);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombres de chambre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 245);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Demande spécial";
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._463156637;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Titre);
            Controls.Add(booker);
            Controls.Add(demandeSpecial);
            Controls.Add(nombrechambre);
            Controls.Add(depart);
            Controls.Add(Arrivee);
            Name = "View";
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
        private Label Titre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}