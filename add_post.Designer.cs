namespace kursovoi
{
    partial class add_post
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.fone = new System.Windows.Forms.MaskedTextBox();
            this.rahunok = new System.Windows.Forms.MaskedTextBox();
            this.edr = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_postacalnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Номер телефону";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Назва";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(76, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(319, 29);
            this.name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Розрахунковий номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(72, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Адреса";
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adres.Location = new System.Drawing.Point(76, 339);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(319, 29);
            this.adres.TabIndex = 23;
            // 
            // fone
            // 
            this.fone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fone.Location = new System.Drawing.Point(76, 142);
            this.fone.Mask = "+38\\0000000000";
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(175, 29);
            this.fone.TabIndex = 26;
            this.fone.ValidatingType = typeof(int);
            // 
            // rahunok
            // 
            this.rahunok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rahunok.Location = new System.Drawing.Point(76, 210);
            this.rahunok.Mask = "U\\A000000000000000000000000000";
            this.rahunok.Name = "rahunok";
            this.rahunok.Size = new System.Drawing.Size(319, 29);
            this.rahunok.TabIndex = 27;
            this.rahunok.ValidatingType = typeof(int);
            // 
            // edr
            // 
            this.edr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edr.Location = new System.Drawing.Point(76, 280);
            this.edr.Mask = "00000000";
            this.edr.Name = "edr";
            this.edr.Size = new System.Drawing.Size(96, 29);
            this.edr.TabIndex = 29;
            this.edr.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(72, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Код ЄДРПОУ";
            // 
            // add_postacalnik
            // 
            this.add_postacalnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_postacalnik.Location = new System.Drawing.Point(102, 407);
            this.add_postacalnik.Name = "add_postacalnik";
            this.add_postacalnik.Size = new System.Drawing.Size(266, 44);
            this.add_postacalnik.TabIndex = 30;
            this.add_postacalnik.Text = "Додати постачальника";
            this.add_postacalnik.UseVisualStyleBackColor = true;
            this.add_postacalnik.Click += new System.EventHandler(this.add_postacalnik_Click);
            // 
            // add_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 536);
            this.Controls.Add(this.add_postacalnik);
            this.Controls.Add(this.edr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rahunok);
            this.Controls.Add(this.fone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Name = "add_post";
            this.Text = "add_post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.MaskedTextBox fone;
        private System.Windows.Forms.MaskedTextBox rahunok;
        private System.Windows.Forms.MaskedTextBox edr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_postacalnik;
    }
}