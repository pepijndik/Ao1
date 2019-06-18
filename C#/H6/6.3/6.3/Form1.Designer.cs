namespace _6._3
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtAnt = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSen = new System.Windows.Forms.RadioButton();
            this.rbtnVol = new System.Windows.Forms.RadioButton();
            this.rbtnJeug = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(347, 240);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(149, 42);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtAnt
            // 
            this.txtAnt.Location = new System.Drawing.Point(347, 192);
            this.txtAnt.Name = "txtAnt";
            this.txtAnt.Size = new System.Drawing.Size(149, 22);
            this.txtAnt.TabIndex = 1;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(347, 301);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(149, 22);
            this.txtCash.TabIndex = 2;
            this.txtCash.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aantal in de groep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Te betalen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSen);
            this.groupBox1.Controls.Add(this.rbtnVol);
            this.groupBox1.Controls.Add(this.rbtnJeug);
            this.groupBox1.Location = new System.Drawing.Point(149, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grbleeftijd";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnSen
            // 
            this.rbtnSen.AutoSize = true;
            this.rbtnSen.Location = new System.Drawing.Point(6, 86);
            this.rbtnSen.Name = "rbtnSen";
            this.rbtnSen.Size = new System.Drawing.Size(132, 21);
            this.rbtnSen.TabIndex = 2;
            this.rbtnSen.TabStop = true;
            this.rbtnSen.Text = "Senioren (>=65)";
            this.rbtnSen.UseVisualStyleBackColor = true;
            // 
            // rbtnVol
            // 
            this.rbtnVol.AutoSize = true;
            this.rbtnVol.Location = new System.Drawing.Point(6, 59);
            this.rbtnVol.Name = "rbtnVol";
            this.rbtnVol.Size = new System.Drawing.Size(112, 21);
            this.rbtnVol.TabIndex = 1;
            this.rbtnVol.TabStop = true;
            this.rbtnVol.Text = "Volwassenen";
            this.rbtnVol.UseVisualStyleBackColor = true;
            // 
            // rbtnJeug
            // 
            this.rbtnJeug.AutoSize = true;
            this.rbtnJeug.Location = new System.Drawing.Point(6, 32);
            this.rbtnJeug.Name = "rbtnJeug";
            this.rbtnJeug.Size = new System.Drawing.Size(106, 21);
            this.rbtnJeug.TabIndex = 0;
            this.rbtnJeug.TabStop = true;
            this.rbtnJeug.Text = "Jeugd (<18)";
            this.rbtnJeug.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtAnt);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtAnt;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSen;
        private System.Windows.Forms.RadioButton rbtnVol;
        private System.Windows.Forms.RadioButton rbtnJeug;
        private System.Windows.Forms.TextBox textBox1;
    }
}

