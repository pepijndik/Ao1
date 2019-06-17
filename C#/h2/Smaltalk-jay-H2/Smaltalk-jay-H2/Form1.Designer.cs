namespace Smaltalk_jay_H2
{
    partial class Smalltalk
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
            this.bttnSmalltalk = new System.Windows.Forms.Button();
            this.bttn2Antwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnSmalltalk
            // 
            this.bttnSmalltalk.Location = new System.Drawing.Point(121, 134);
            this.bttnSmalltalk.Name = "bttnSmalltalk";
            this.bttnSmalltalk.Size = new System.Drawing.Size(116, 67);
            this.bttnSmalltalk.TabIndex = 0;
            this.bttnSmalltalk.Text = "Smalltalk";
            this.bttnSmalltalk.UseVisualStyleBackColor = true;
            this.bttnSmalltalk.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn2Antwoord
            // 
            this.bttn2Antwoord.Location = new System.Drawing.Point(344, 135);
            this.bttn2Antwoord.Name = "bttn2Antwoord";
            this.bttn2Antwoord.Size = new System.Drawing.Size(118, 65);
            this.bttn2Antwoord.TabIndex = 1;
            this.bttn2Antwoord.Text = "Antwoord";
            this.bttn2Antwoord.UseVisualStyleBackColor = true;
            // 
            // Smalltalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn2Antwoord);
            this.Controls.Add(this.bttnSmalltalk);
            this.Name = "Smalltalk";
            this.Text = "Smalltalk";
            this.Load += new System.EventHandler(this.Smalltalk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnSmalltalk;
        private System.Windows.Forms.Button bttn2Antwoord;
    }
}

