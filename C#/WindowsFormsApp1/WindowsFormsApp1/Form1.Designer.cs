namespace WindowsFormsApp1
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
            this.bereken = new System.Windows.Forms.Button();
            this.straal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.omtrek = new System.Windows.Forms.TextBox();
            this.opervlakte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bereken
            // 
            this.bereken.Location = new System.Drawing.Point(205, 207);
            this.bereken.Name = "bereken";
            this.bereken.Size = new System.Drawing.Size(75, 23);
            this.bereken.TabIndex = 0;
            this.bereken.Text = "Bereken";
            this.bereken.UseVisualStyleBackColor = true;
            this.bereken.Click += new System.EventHandler(this.bereken_Click);
            // 
            // straal
            // 
            this.straal.Location = new System.Drawing.Point(180, 85);
            this.straal.Name = "straal";
            this.straal.Size = new System.Drawing.Size(100, 22);
            this.straal.TabIndex = 1;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Straal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opervlakte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Omtrek";
            // 
            // omtrek
            // 
            this.omtrek.Location = new System.Drawing.Point(180, 132);
            this.omtrek.Name = "omtrek";
            this.omtrek.ReadOnly = true;
            this.omtrek.Size = new System.Drawing.Size(100, 22);
            this.omtrek.TabIndex = 7;
            // 
            // opervlakte
            // 
            this.opervlakte.Location = new System.Drawing.Point(180, 181);
            this.opervlakte.Name = "opervlakte";
            this.opervlakte.ReadOnly = true;
            this.opervlakte.Size = new System.Drawing.Size(100, 22);
            this.opervlakte.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 537);
            this.Controls.Add(this.opervlakte);
            this.Controls.Add(this.omtrek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.straal);
            this.Controls.Add(this.bereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bereken;
        private System.Windows.Forms.TextBox straal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox omtrek;
        protected System.Windows.Forms.TextBox opervlakte;
    }
}

