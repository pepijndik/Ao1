namespace _6._2
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
            this.txtBru = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtLoon = new System.Windows.Forms.TextBox();
            this.btn1Bereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef Brutoloon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geef aantaal artikelen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "geef loon";
            // 
            // txtBru
            // 
            this.txtBru.Location = new System.Drawing.Point(285, 142);
            this.txtBru.Name = "txtBru";
            this.txtBru.Size = new System.Drawing.Size(121, 22);
            this.txtBru.TabIndex = 3;
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(285, 174);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(121, 22);
            this.txtArt.TabIndex = 4;
            // 
            // txtLoon
            // 
            this.txtLoon.Location = new System.Drawing.Point(285, 244);
            this.txtLoon.Name = "txtLoon";
            this.txtLoon.Size = new System.Drawing.Size(121, 22);
            this.txtLoon.TabIndex = 5;
            // 
            // btn1Bereken
            // 
            this.btn1Bereken.Location = new System.Drawing.Point(285, 202);
            this.btn1Bereken.Name = "btn1Bereken";
            this.btn1Bereken.Size = new System.Drawing.Size(124, 36);
            this.btn1Bereken.TabIndex = 6;
            this.btn1Bereken.Text = "Bereken";
            this.btn1Bereken.UseVisualStyleBackColor = true;
            this.btn1Bereken.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1Bereken);
            this.Controls.Add(this.txtLoon);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtBru);
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
        private System.Windows.Forms.TextBox txtBru;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtLoon;
        private System.Windows.Forms.Button btn1Bereken;
    }
}

