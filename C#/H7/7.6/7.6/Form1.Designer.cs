namespace _7._6
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
            this.txtKwad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKwadraaten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKwad
            // 
            this.txtKwad.Location = new System.Drawing.Point(288, 80);
            this.txtKwad.Name = "txtKwad";
            this.txtKwad.Size = new System.Drawing.Size(124, 22);
            this.txtKwad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "tot hoever";
            // 
            // lbKwadraaten
            // 
            this.lbKwadraaten.FormattingEnabled = true;
            this.lbKwadraaten.ItemHeight = 16;
            this.lbKwadraaten.Location = new System.Drawing.Point(174, 137);
            this.lbKwadraaten.Name = "lbKwadraaten";
            this.lbKwadraaten.Size = new System.Drawing.Size(418, 260);
            this.lbKwadraaten.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKwadraaten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKwad);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKwad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKwadraaten;
    }
}

