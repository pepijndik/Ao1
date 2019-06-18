namespace Opdracht3
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
            this.nmr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx1 = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInVoer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr)).BeginInit();
            this.SuspendLayout();
            // 
            // nmr
            // 
            this.nmr.Location = new System.Drawing.Point(157, 49);
            this.nmr.Name = "nmr";
            this.nmr.Size = new System.Drawing.Size(42, 22);
            this.nmr.TabIndex = 0;
            this.nmr.ValueChanged += new System.EventHandler(this.nmr_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal Elementen in Binaire Reeks";
            // 
            // lbx1
            // 
            this.lbx1.FormattingEnabled = true;
            this.lbx1.ItemHeight = 16;
            this.lbx1.Location = new System.Drawing.Point(79, 77);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(231, 404);
            this.lbx1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Location = new System.Drawing.Point(319, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInVoer
            // 
            this.txtInVoer.Location = new System.Drawing.Point(205, 48);
            this.txtInVoer.Name = "txtInVoer";
            this.txtInVoer.Size = new System.Drawing.Size(100, 22);
            this.txtInVoer.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(313, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Show";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 507);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInVoer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInVoer;
        private System.Windows.Forms.Button btnStart;
    }
}

