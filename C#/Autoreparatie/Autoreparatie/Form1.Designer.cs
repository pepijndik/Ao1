namespace Autoreparatie
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtGewerkt = new System.Windows.Forms.TextBox();
            this.txtUur = new System.Windows.Forms.TextBox();
            this.txtOnderdelen = new System.Windows.Forms.TextBox();
            this.txtBetalen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(57, 189);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(245, 23);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtGewerkt
            // 
            this.txtGewerkt.Location = new System.Drawing.Point(202, 102);
            this.txtGewerkt.Name = "txtGewerkt";
            this.txtGewerkt.Size = new System.Drawing.Size(100, 22);
            this.txtGewerkt.TabIndex = 1;
            // 
            // txtUur
            // 
            this.txtUur.Location = new System.Drawing.Point(202, 130);
            this.txtUur.Name = "txtUur";
            this.txtUur.Size = new System.Drawing.Size(100, 22);
            this.txtUur.TabIndex = 2;
            // 
            // txtOnderdelen
            // 
            this.txtOnderdelen.Location = new System.Drawing.Point(202, 158);
            this.txtOnderdelen.Name = "txtOnderdelen";
            this.txtOnderdelen.Size = new System.Drawing.Size(100, 22);
            this.txtOnderdelen.TabIndex = 3;
            // 
            // txtBetalen
            // 
            this.txtBetalen.Location = new System.Drawing.Point(202, 229);
            this.txtBetalen.Name = "txtBetalen";
            this.txtBetalen.ReadOnly = true;
            this.txtBetalen.Size = new System.Drawing.Size(100, 22);
            this.txtBetalen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aantal gewerkte uren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uurloon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Onderdelen in Euro\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Te betalen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBetalen);
            this.Controls.Add(this.txtOnderdelen);
            this.Controls.Add(this.txtUur);
            this.Controls.Add(this.txtGewerkt);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtGewerkt;
        private System.Windows.Forms.TextBox txtUur;
        private System.Windows.Forms.TextBox txtOnderdelen;
        private System.Windows.Forms.TextBox txtBetalen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

