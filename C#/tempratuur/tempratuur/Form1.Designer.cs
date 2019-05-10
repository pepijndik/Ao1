namespace tempratuur
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
            this.bntreken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lg = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.TextBox();
            this.fahren = new System.Windows.Forms.TextBox();
            this.klevin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntreken
            // 
            this.bntreken.Location = new System.Drawing.Point(230, 208);
            this.bntreken.Name = "bntreken";
            this.bntreken.Size = new System.Drawing.Size(75, 23);
            this.bntreken.TabIndex = 0;
            this.bntreken.Text = "Bereken";
            this.bntreken.UseVisualStyleBackColor = true;
            this.bntreken.Click += new System.EventHandler(this.bntreken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempratuur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Graden Fahrenheit";
            // 
            // lg
            // 
            this.lg.AutoSize = true;
            this.lg.Location = new System.Drawing.Point(66, 151);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(98, 17);
            this.lg.TabIndex = 3;
            this.lg.Text = "Graden Klevin";
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(230, 60);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(100, 22);
            this.temp.TabIndex = 4;
            // 
            // fahren
            // 
            this.fahren.Location = new System.Drawing.Point(230, 102);
            this.fahren.Name = "fahren";
            this.fahren.ReadOnly = true;
            this.fahren.Size = new System.Drawing.Size(100, 22);
            this.fahren.TabIndex = 5;
            // 
            // klevin
            // 
            this.klevin.Location = new System.Drawing.Point(230, 148);
            this.klevin.Name = "klevin";
            this.klevin.ReadOnly = true;
            this.klevin.Size = new System.Drawing.Size(100, 22);
            this.klevin.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.klevin);
            this.Controls.Add(this.fahren);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntreken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntreken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lg;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.TextBox fahren;
        private System.Windows.Forms.TextBox klevin;
    }
}

