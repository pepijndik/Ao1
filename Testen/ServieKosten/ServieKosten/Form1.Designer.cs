namespace ServieKosten
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHKosten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtPunten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbParticulier = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totaal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HardwareKosten";
            // 
            // txtHKosten
            // 
            this.txtHKosten.Location = new System.Drawing.Point(158, 34);
            this.txtHKosten.Name = "txtHKosten";
            this.txtHKosten.Size = new System.Drawing.Size(100, 22);
            this.txtHKosten.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtPunten
            // 
            this.txtPunten.Location = new System.Drawing.Point(158, 62);
            this.txtPunten.Name = "txtPunten";
            this.txtPunten.Size = new System.Drawing.Size(100, 22);
            this.txtPunten.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Werktijd in Punten";
            // 
            // rdbParticulier
            // 
            this.rdbParticulier.AutoSize = true;
            this.rdbParticulier.Location = new System.Drawing.Point(22, 62);
            this.rdbParticulier.Name = "rdbParticulier";
            this.rdbParticulier.Size = new System.Drawing.Size(77, 21);
            this.rdbParticulier.TabIndex = 6;
            this.rdbParticulier.TabStop = true;
            this.rdbParticulier.Text = "Patiulier";
            this.rdbParticulier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbParticulier);
            this.groupBox1.Location = new System.Drawing.Point(289, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant";
            // 
            // totaal
            // 
            this.totaal.Location = new System.Drawing.Point(267, 174);
            this.totaal.Name = "totaal";
            this.totaal.ReadOnly = true;
            this.totaal.Size = new System.Drawing.Size(100, 22);
            this.totaal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Uitleg : 1 punt =15min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Totaal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totaal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPunten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHKosten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHKosten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtPunten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbParticulier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totaal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

