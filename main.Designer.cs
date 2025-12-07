namespace kursovoi
{
    partial class main
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.kilkist_t = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.text_serch = new System.Windows.Forms.TextBox();
            this.box_kat = new System.Windows.Forms.ComboBox();
            this.box_kra = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_spiv = new System.Windows.Forms.Label();
            this.button_fil = new System.Windows.Forms.Button();
            this.pag_n = new System.Windows.Forms.NumericUpDown();
            this.but_ad_post = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilkist_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pag_n)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати в кошик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 525);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(888, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(618, 460);
            this.dataGridView2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1334, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "формування чеку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kilkist_t
            // 
            this.kilkist_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kilkist_t.Location = new System.Drawing.Point(12, 92);
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
            this.kilkist_t.Size = new System.Drawing.Size(120, 29);
            this.kilkist_t.TabIndex = 4;
            this.kilkist_t.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(947, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Загальна ціна:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(924, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Підтверження продажу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // text_serch
            // 
            this.text_serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_serch.Location = new System.Drawing.Point(10, 160);
            this.text_serch.Name = "text_serch";
            this.text_serch.Size = new System.Drawing.Size(132, 29);
            this.text_serch.TabIndex = 7;
            this.text_serch.TextChanged += new System.EventHandler(this.text_serch_TextChanged);
            // 
            // box_kat
            // 
            this.box_kat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_kat.FormattingEnabled = true;
            this.box_kat.Location = new System.Drawing.Point(10, 221);
            this.box_kat.Name = "box_kat";
            this.box_kat.Size = new System.Drawing.Size(132, 32);
            this.box_kat.TabIndex = 8;
            this.box_kat.SelectedIndexChanged += new System.EventHandler(this.box_kat_SelectedIndexChanged);
            // 
            // box_kra
            // 
            this.box_kra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_kra.FormattingEnabled = true;
            this.box_kra.Location = new System.Drawing.Point(10, 283);
            this.box_kra.Name = "box_kra";
            this.box_kra.Size = new System.Drawing.Size(132, 32);
            this.box_kra.TabIndex = 9;
            this.box_kra.SelectedIndexChanged += new System.EventHandler(this.box_kra_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пошук";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Категорія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Країна";
            // 
            // label_spiv
            // 
            this.label_spiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_spiv.AutoSize = true;
            this.label_spiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spiv.Location = new System.Drawing.Point(12, 712);
            this.label_spiv.Name = "label_spiv";
            this.label_spiv.Size = new System.Drawing.Size(68, 24);
            this.label_spiv.TabIndex = 13;
            this.label_spiv.Text = "Нічого";
            this.label_spiv.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button_fil
            // 
            this.button_fil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fil.Location = new System.Drawing.Point(10, 377);
            this.button_fil.Name = "button_fil";
            this.button_fil.Size = new System.Drawing.Size(184, 44);
            this.button_fil.TabIndex = 14;
            this.button_fil.Text = "Очистити фільтри";
            this.button_fil.UseVisualStyleBackColor = true;
            this.button_fil.Click += new System.EventHandler(this.button_fil_Click);
            // 
            // pag_n
            // 
            this.pag_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pag_n.Location = new System.Drawing.Point(414, 555);
            this.pag_n.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pag_n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pag_n.Name = "pag_n";
            this.pag_n.Size = new System.Drawing.Size(120, 29);
            this.pag_n.TabIndex = 15;
            this.pag_n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pag_n.ValueChanged += new System.EventHandler(this.pag_n_ValueChanged);
            // 
            // but_ad_post
            // 
            this.but_ad_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_ad_post.Location = new System.Drawing.Point(10, 555);
            this.but_ad_post.Name = "but_ad_post";
            this.but_ad_post.Size = new System.Drawing.Size(206, 52);
            this.but_ad_post.TabIndex = 16;
            this.but_ad_post.Text = "Додати постачання";
            this.but_ad_post.UseVisualStyleBackColor = true;
            this.but_ad_post.Click += new System.EventHandler(this.but_ad_post_Click);
            // 
            // but_clear
            // 
            this.but_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_clear.Location = new System.Drawing.Point(1229, 587);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(188, 52);
            this.but_clear.TabIndex = 17;
            this.but_clear.Text = "Очистити продаж";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 745);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_ad_post);
            this.Controls.Add(this.pag_n);
            this.Controls.Add(this.button_fil);
            this.Controls.Add(this.label_spiv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_kra);
            this.Controls.Add(this.box_kat);
            this.Controls.Add(this.text_serch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilkist_t);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilkist_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pag_n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown kilkist_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox text_serch;
        private System.Windows.Forms.ComboBox box_kat;
        private System.Windows.Forms.ComboBox box_kra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_spiv;
        private System.Windows.Forms.Button button_fil;
        private System.Windows.Forms.NumericUpDown pag_n;
        private System.Windows.Forms.Button but_ad_post;
        private System.Windows.Forms.Button but_clear;
    }
}