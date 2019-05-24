namespace opdracht5._4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSorteer = new System.Windows.Forms.Button();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.txtGetal3 = new System.Windows.Forms.TextBox();
            this.txtGroot = new System.Windows.Forms.TextBox();
            this.txtKlein = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "getal 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "getal 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "getal 3";
            // 
            // btnSorteer
            // 
            this.btnSorteer.Location = new System.Drawing.Point(124, 192);
            this.btnSorteer.Name = "btnSorteer";
            this.btnSorteer.Size = new System.Drawing.Size(182, 23);
            this.btnSorteer.TabIndex = 3;
            this.btnSorteer.Text = "Sorteer";
            this.btnSorteer.UseVisualStyleBackColor = true;
            this.btnSorteer.Click += new System.EventHandler(this.btnSorteer_Click);
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(206, 107);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 22);
            this.txtGetal1.TabIndex = 4;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(206, 135);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 22);
            this.txtGetal2.TabIndex = 5;
            // 
            // txtGetal3
            // 
            this.txtGetal3.Location = new System.Drawing.Point(206, 163);
            this.txtGetal3.Name = "txtGetal3";
            this.txtGetal3.Size = new System.Drawing.Size(100, 22);
            this.txtGetal3.TabIndex = 6;
            // 
            // txtGroot
            // 
            this.txtGroot.Location = new System.Drawing.Point(206, 249);
            this.txtGroot.Name = "txtGroot";
            this.txtGroot.ReadOnly = true;
            this.txtGroot.Size = new System.Drawing.Size(100, 22);
            this.txtGroot.TabIndex = 10;
            // 
            // txtKlein
            // 
            this.txtKlein.Location = new System.Drawing.Point(206, 221);
            this.txtKlein.Name = "txtKlein";
            this.txtKlein.ReadOnly = true;
            this.txtKlein.Size = new System.Drawing.Size(100, 22);
            this.txtKlein.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grootse getal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kleinste getal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGroot);
            this.Controls.Add(this.txtKlein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGetal3);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.btnSorteer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSorteer;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.TextBox txtGetal3;
        private System.Windows.Forms.TextBox txtGroot;
        private System.Windows.Forms.TextBox txtKlein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

