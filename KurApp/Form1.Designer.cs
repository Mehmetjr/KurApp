namespace KurApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            lbl_usd = new Label();
            lbl_eur = new Label();
            lbl_gbp = new Label();
            lbl_chf = new Label();
            lbl_jpy = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(326, 122);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 0;
            label1.Text = "Usd :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(326, 161);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 1;
            label2.Text = "Eur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(326, 200);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Gbp :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(326, 241);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "Chf :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(326, 278);
            label5.Name = "label5";
            label5.Size = new Size(50, 28);
            label5.TabIndex = 4;
            label5.Text = "Jpy :";
            // 
            // button1
            // 
            button1.Location = new Point(365, 339);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 11;
            button1.Text = "Kurları Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_usd
            // 
            lbl_usd.AutoSize = true;
            lbl_usd.Font = new Font("Segoe UI", 15F);
            lbl_usd.Location = new Point(409, 122);
            lbl_usd.Name = "lbl_usd";
            lbl_usd.Size = new Size(0, 28);
            lbl_usd.TabIndex = 12;
            // 
            // lbl_eur
            // 
            lbl_eur.AutoSize = true;
            lbl_eur.Font = new Font("Segoe UI", 15F);
            lbl_eur.Location = new Point(409, 161);
            lbl_eur.Name = "lbl_eur";
            lbl_eur.Size = new Size(0, 28);
            lbl_eur.TabIndex = 13;
            // 
            // lbl_gbp
            // 
            lbl_gbp.AutoSize = true;
            lbl_gbp.Font = new Font("Segoe UI", 15F);
            lbl_gbp.Location = new Point(409, 200);
            lbl_gbp.Name = "lbl_gbp";
            lbl_gbp.Size = new Size(0, 28);
            lbl_gbp.TabIndex = 14;
            // 
            // lbl_chf
            // 
            lbl_chf.AutoSize = true;
            lbl_chf.Font = new Font("Segoe UI", 15F);
            lbl_chf.Location = new Point(409, 241);
            lbl_chf.Name = "lbl_chf";
            lbl_chf.Size = new Size(0, 28);
            lbl_chf.TabIndex = 15;
            // 
            // lbl_jpy
            // 
            lbl_jpy.AutoSize = true;
            lbl_jpy.Font = new Font("Segoe UI", 15F);
            lbl_jpy.Location = new Point(409, 278);
            lbl_jpy.Name = "lbl_jpy";
            lbl_jpy.Size = new Size(0, 28);
            lbl_jpy.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 30F);
            label7.Location = new Point(303, 9);
            label7.Name = "label7";
            label7.Size = new Size(197, 54);
            label7.TabIndex = 17;
            label7.Text = "TCMB Kur";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(lbl_jpy);
            Controls.Add(lbl_chf);
            Controls.Add(lbl_gbp);
            Controls.Add(lbl_eur);
            Controls.Add(lbl_usd);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label lbl_usd;
        private Label lbl_eur;
        private Label lbl_gbp;
        private Label lbl_chf;
        private Label lbl_jpy;
        private Label label7;
    }
}
