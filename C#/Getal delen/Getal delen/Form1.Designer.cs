namespace Getal_delen
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
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGedeeld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVijf = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(158, 55);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(100, 22);
            this.txtGetal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gedeeld door 3";
            // 
            // txtGedeeld
            // 
            this.txtGedeeld.Location = new System.Drawing.Point(158, 116);
            this.txtGedeeld.Name = "txtGedeeld";
            this.txtGedeeld.ReadOnly = true;
            this.txtGedeeld.Size = new System.Drawing.Size(100, 22);
            this.txtGedeeld.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "vijfvoud";
            // 
            // txtVijf
            // 
            this.txtVijf.Location = new System.Drawing.Point(158, 155);
            this.txtVijf.Name = "txtVijf";
            this.txtVijf.ReadOnly = true;
            this.txtVijf.Size = new System.Drawing.Size(100, 22);
            this.txtVijf.TabIndex = 4;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(48, 86);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(210, 23);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVijf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGedeeld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGetal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGedeeld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVijf;
        private System.Windows.Forms.Button btnBereken;
    }
}

