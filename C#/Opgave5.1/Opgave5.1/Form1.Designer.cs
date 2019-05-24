namespace Opgave5._1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textStraal = new System.Windows.Forms.TextBox();
            this.textOppervlakte = new System.Windows.Forms.TextBox();
            this.textOmtrek = new System.Windows.Forms.TextBox();
            this.straal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textStraal
            // 
            this.textStraal.Location = new System.Drawing.Point(245, 64);
            this.textStraal.Name = "textStraal";
            this.textStraal.Size = new System.Drawing.Size(100, 22);
            this.textStraal.TabIndex = 1;
            // 
            // textOppervlakte
            // 
            this.textOppervlakte.Location = new System.Drawing.Point(245, 92);
            this.textOppervlakte.Name = "textOppervlakte";
            this.textOppervlakte.ReadOnly = true;
            this.textOppervlakte.Size = new System.Drawing.Size(100, 22);
            this.textOppervlakte.TabIndex = 2;
            // 
            // textOmtrek
            // 
            this.textOmtrek.Location = new System.Drawing.Point(245, 131);
            this.textOmtrek.Name = "textOmtrek";
            this.textOmtrek.ReadOnly = true;
            this.textOmtrek.Size = new System.Drawing.Size(100, 22);
            this.textOmtrek.TabIndex = 3;
            // 
            // straal
            // 
            this.straal.AutoSize = true;
            this.straal.Location = new System.Drawing.Point(131, 69);
            this.straal.Name = "straal";
            this.straal.Size = new System.Drawing.Size(45, 17);
            this.straal.TabIndex = 4;
            this.straal.Text = "Straal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oppervlakte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Omtrek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.straal);
            this.Controls.Add(this.textOmtrek);
            this.Controls.Add(this.textOppervlakte);
            this.Controls.Add(this.textStraal);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textStraal;
        private System.Windows.Forms.TextBox textOppervlakte;
        private System.Windows.Forms.TextBox textOmtrek;
        private System.Windows.Forms.Label straal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

