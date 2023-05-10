namespace ukol_N
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
            this.tbKus1 = new System.Windows.Forms.TextBox();
            this.tbKusC1 = new System.Windows.Forms.TextBox();
            this.tbZbozi1 = new System.Windows.Forms.TextBox();
            this.tbKus2 = new System.Windows.Forms.TextBox();
            this.tbZbozi2 = new System.Windows.Forms.TextBox();
            this.tbKusC2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.tbBal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbKus1
            // 
            this.tbKus1.Location = new System.Drawing.Point(98, 60);
            this.tbKus1.Name = "tbKus1";
            this.tbKus1.Size = new System.Drawing.Size(100, 20);
            this.tbKus1.TabIndex = 2;
            this.tbKus1.TextChanged += new System.EventHandler(this.tbKus1_TextChanged);
            this.tbKus1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKus1_KeyPress);
            // 
            // tbKusC1
            // 
            this.tbKusC1.Location = new System.Drawing.Point(98, 86);
            this.tbKusC1.Name = "tbKusC1";
            this.tbKusC1.Size = new System.Drawing.Size(100, 20);
            this.tbKusC1.TabIndex = 3;
            this.tbKusC1.TextChanged += new System.EventHandler(this.tbKusC1_TextChanged);
            this.tbKusC1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKusC1_KeyPress);
            // 
            // tbZbozi1
            // 
            this.tbZbozi1.Location = new System.Drawing.Point(31, 34);
            this.tbZbozi1.Name = "tbZbozi1";
            this.tbZbozi1.Size = new System.Drawing.Size(167, 20);
            this.tbZbozi1.TabIndex = 1;
            // 
            // tbKus2
            // 
            this.tbKus2.Location = new System.Drawing.Point(302, 60);
            this.tbKus2.Name = "tbKus2";
            this.tbKus2.Size = new System.Drawing.Size(100, 20);
            this.tbKus2.TabIndex = 5;
            this.tbKus2.TextChanged += new System.EventHandler(this.tbKus2_TextChanged);
            this.tbKus2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKus2_KeyPress);
            // 
            // tbZbozi2
            // 
            this.tbZbozi2.Location = new System.Drawing.Point(235, 34);
            this.tbZbozi2.Name = "tbZbozi2";
            this.tbZbozi2.Size = new System.Drawing.Size(167, 20);
            this.tbZbozi2.TabIndex = 4;
            // 
            // tbKusC2
            // 
            this.tbKusC2.Location = new System.Drawing.Point(302, 86);
            this.tbKusC2.Name = "tbKusC2";
            this.tbKusC2.Size = new System.Drawing.Size(100, 20);
            this.tbKusC2.TabIndex = 6;
            this.tbKusC2.TextChanged += new System.EventHandler(this.tbKusC2_TextChanged);
            this.tbKusC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKusC2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kusů:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kč za kus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zboží:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kusů:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zboží:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kč za kus:";
            // 
            // tbPost
            // 
            this.tbPost.Location = new System.Drawing.Point(202, 160);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(100, 20);
            this.tbPost.TabIndex = 7;
            this.tbPost.TextChanged += new System.EventHandler(this.tbPost_TextChanged);
            this.tbPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPost_KeyPress);
            // 
            // tbBal
            // 
            this.tbBal.Location = new System.Drawing.Point(202, 186);
            this.tbBal.Name = "tbBal";
            this.tbBal.Size = new System.Drawing.Size(100, 20);
            this.tbBal.TabIndex = 8;
            this.tbBal.TextChanged += new System.EventHandler(this.tbBal_TextChanged);
            this.tbBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBal_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kč poštovné:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kč balné:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(129, 255);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(173, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Spočtí celkovou cenu";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 307);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbBal);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKusC2);
            this.Controls.Add(this.tbZbozi2);
            this.Controls.Add(this.tbKusC1);
            this.Controls.Add(this.tbKus2);
            this.Controls.Add(this.tbZbozi1);
            this.Controls.Add(this.tbKus1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 346);
            this.MinimumSize = new System.Drawing.Size(445, 346);
            this.Name = "Form1";
            this.Text = "Celková cena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKus1;
        private System.Windows.Forms.TextBox tbKusC1;
        private System.Windows.Forms.TextBox tbZbozi1;
        private System.Windows.Forms.TextBox tbKus2;
        private System.Windows.Forms.TextBox tbZbozi2;
        private System.Windows.Forms.TextBox tbKusC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.TextBox tbBal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalc;
    }
}

