namespace _6._5
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
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(287, 148);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(135, 22);
            this.txtKg.TabIndex = 0;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(287, 176);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(135, 22);
            this.txtM.TabIndex = 1;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(287, 291);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(173, 22);
            this.txtBMI.TabIndex = 2;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(287, 319);
            this.txtCat.Name = "txtCat";
            this.txtCat.ReadOnly = true;
            this.txtCat.Size = new System.Drawing.Size(173, 22);
            this.txtCat.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gewicht (Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "lengte (m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "BMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cat.";
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtKg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

