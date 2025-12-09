namespace kursovoi
{
    partial class Add_tov
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_kra = new System.Windows.Forms.ComboBox();
            this.box_kat = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.kilkist_t = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.price_z = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kilkist_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_z)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Країна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Категорія";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Назва";
            // 
            // box_kra
            // 
            this.box_kra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_kra.FormattingEnabled = true;
            this.box_kra.Location = new System.Drawing.Point(12, 158);
            this.box_kra.Name = "box_kra";
            this.box_kra.Size = new System.Drawing.Size(279, 32);
            this.box_kra.TabIndex = 17;
            // 
            // box_kat
            // 
            this.box_kat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_kat.FormattingEnabled = true;
            this.box_kat.Location = new System.Drawing.Point(12, 96);
            this.box_kat.Name = "box_kat";
            this.box_kat.Size = new System.Drawing.Size(279, 32);
            this.box_kat.TabIndex = 16;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(12, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(279, 29);
            this.name.TabIndex = 15;
            // 
            // kilkist_t
            // 
            this.kilkist_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kilkist_t.Location = new System.Drawing.Point(12, 230);
            this.kilkist_t.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kilkist_t.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kilkist_t.Name = "kilkist_t";
            this.kilkist_t.Size = new System.Drawing.Size(279, 29);
            this.kilkist_t.TabIndex = 14;
            this.kilkist_t.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(67, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Додати Товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price_z
            // 
            this.price_z.DecimalPlaces = 2;
            this.price_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_z.Location = new System.Drawing.Point(16, 302);
            this.price_z.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.price_z.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.price_z.Name = "price_z";
            this.price_z.Size = new System.Drawing.Size(275, 29);
            this.price_z.TabIndex = 33;
            this.price_z.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Кількість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ціна";
            // 
            // Add_tov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_z);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_kra);
            this.Controls.Add(this.box_kat);
            this.Controls.Add(this.name);
            this.Controls.Add(this.kilkist_t);
            this.Controls.Add(this.button1);
            this.Name = "Add_tov";
            this.Text = "Add_tov";
            this.Load += new System.EventHandler(this.Add_tov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kilkist_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_kra;
        private System.Windows.Forms.ComboBox box_kat;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown kilkist_t;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown price_z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}