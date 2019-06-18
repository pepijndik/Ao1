namespace Opgave2
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
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.btnDelen = new System.Windows.Forms.Button();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(26, 38);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(165, 22);
            this.txtGetal1.TabIndex = 0;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(26, 66);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(165, 22);
            this.txtGetal2.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(26, 111);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(116, 111);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKeer
            // 
            this.btnKeer.Location = new System.Drawing.Point(26, 152);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(75, 23);
            this.btnKeer.TabIndex = 4;
            this.btnKeer.Text = "X";
            this.btnKeer.UseVisualStyleBackColor = true;
            this.btnKeer.Click += new System.EventHandler(this.btnKeer_Click);
            // 
            // btnDelen
            // 
            this.btnDelen.Location = new System.Drawing.Point(116, 152);
            this.btnDelen.Name = "btnDelen";
            this.btnDelen.Size = new System.Drawing.Size(75, 23);
            this.btnDelen.TabIndex = 5;
            this.btnDelen.Text = "/";
            this.btnDelen.UseVisualStyleBackColor = true;
            this.btnDelen.Click += new System.EventHandler(this.btnDelen_Click);
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(26, 181);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(165, 22);
            this.txtTotaal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "RekenMachine pepijn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.btnDelen);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Button btnDelen;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Label label1;
    }
}

