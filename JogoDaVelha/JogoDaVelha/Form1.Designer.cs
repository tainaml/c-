namespace JogoDaVelha
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacar1 = new System.Windows.Forms.TextBox();
            this.txtPlacar2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(43, 26);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(21, 20);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(194, 98);
            this.txt6.MaxLength = 1;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(21, 20);
            this.txt6.TabIndex = 1;
            this.txt6.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(194, 166);
            this.txt9.MaxLength = 1;
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(21, 20);
            this.txt9.TabIndex = 2;
            this.txt9.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(120, 166);
            this.txt8.MaxLength = 1;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(21, 20);
            this.txt8.TabIndex = 3;
            this.txt8.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(43, 166);
            this.txt7.MaxLength = 1;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(21, 20);
            this.txt7.TabIndex = 4;
            this.txt7.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(120, 98);
            this.txt5.MaxLength = 1;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(21, 20);
            this.txt5.TabIndex = 5;
            this.txt5.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(43, 98);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(21, 20);
            this.txt4.TabIndex = 6;
            this.txt4.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(194, 26);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(21, 20);
            this.txt3.TabIndex = 7;
            this.txt3.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(120, 26);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(21, 20);
            this.txt2.TabIndex = 8;
            this.txt2.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.txt6);
            this.panel1.Controls.Add(this.txt3);
            this.panel1.Controls.Add(this.txt9);
            this.panel1.Controls.Add(this.txt4);
            this.panel1.Controls.Add(this.txt8);
            this.panel1.Controls.Add(this.txt5);
            this.panel1.Controls.Add(this.txt7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 204);
            this.panel1.TabIndex = 9;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 227);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PLACAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Você";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adversário";
            // 
            // txtPlacar1
            // 
            this.txtPlacar1.Location = new System.Drawing.Point(241, 253);
            this.txtPlacar1.Name = "txtPlacar1";
            this.txtPlacar1.Size = new System.Drawing.Size(35, 20);
            this.txtPlacar1.TabIndex = 14;
            // 
            // txtPlacar2
            // 
            this.txtPlacar2.Location = new System.Drawing.Point(241, 284);
            this.txtPlacar2.Name = "txtPlacar2";
            this.txtPlacar2.Size = new System.Drawing.Size(35, 20);
            this.txtPlacar2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 319);
            this.Controls.Add(this.txtPlacar2);
            this.Controls.Add(this.txtPlacar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlacar1;
        private System.Windows.Forms.TextBox txtPlacar2;
    }
}

