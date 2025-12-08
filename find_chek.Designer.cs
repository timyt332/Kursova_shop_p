namespace kursovoi
{
    partial class find_chek
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
            this.label2 = new System.Windows.Forms.Label();
            this.text_serch = new System.Windows.Forms.TextBox();
            this.kilkist_t = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.date1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButV = new System.Windows.Forms.RadioButton();
            this.rButPr = new System.Windows.Forms.RadioButton();
            this.rButDay = new System.Windows.Forms.RadioButton();
            this.date2 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kilkist_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пошук";
            // 
            // text_serch
            // 
            this.text_serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_serch.Location = new System.Drawing.Point(2, 153);
            this.text_serch.Name = "text_serch";
            this.text_serch.Size = new System.Drawing.Size(132, 29);
            this.text_serch.TabIndex = 16;
            // 
            // kilkist_t
            // 
            this.kilkist_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kilkist_t.Location = new System.Drawing.Point(4, 85);
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
            this.kilkist_t.TabIndex = 15;
            this.kilkist_t.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 462);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(4, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Додати в кошик";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(18, 293);
            this.date1.MaxSelectionCount = 1;
            this.date1.Name = "date1";
            this.date1.TabIndex = 23;
            this.date1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.data_p);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButV);
            this.groupBox1.Controls.Add(this.rButPr);
            this.groupBox1.Controls.Add(this.rButDay);
            this.groupBox1.Location = new System.Drawing.Point(11, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтр дати";
            // 
            // rButV
            // 
            this.rButV.AutoSize = true;
            this.rButV.Location = new System.Drawing.Point(55, 42);
            this.rButV.Name = "rButV";
            this.rButV.Size = new System.Drawing.Size(85, 17);
            this.rButV.TabIndex = 2;
            this.rButV.TabStop = true;
            this.rButV.Text = "Без фільтру";
            this.rButV.UseVisualStyleBackColor = true;
            this.rButV.CheckedChanged += new System.EventHandler(this.rbut_d);
            // 
            // rButPr
            // 
            this.rButPr.AutoSize = true;
            this.rButPr.Location = new System.Drawing.Point(100, 19);
            this.rButPr.Name = "rButPr";
            this.rButPr.Size = new System.Drawing.Size(100, 17);
            this.rButPr.TabIndex = 1;
            this.rButPr.TabStop = true;
            this.rButPr.Text = "Проміжок часу";
            this.rButPr.UseVisualStyleBackColor = true;
            this.rButPr.CheckedChanged += new System.EventHandler(this.rbut_d);
            // 
            // rButDay
            // 
            this.rButDay.AutoSize = true;
            this.rButDay.Location = new System.Drawing.Point(1, 19);
            this.rButDay.Name = "rButDay";
            this.rButDay.Size = new System.Drawing.Size(98, 17);
            this.rButDay.TabIndex = 0;
            this.rButDay.TabStop = true;
            this.rButDay.Text = "Окремий день";
            this.rButDay.UseVisualStyleBackColor = true;
            this.rButDay.CheckedChanged += new System.EventHandler(this.rbut_d);
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(18, 473);
            this.date2.MaxSelectionCount = 1;
            this.date2.Name = "date2";
            this.date2.TabIndex = 25;
            this.date2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.data_p);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(773, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(522, 462);
            this.dataGridView2.TabIndex = 26;
            // 
            // find_chek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 675);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_serch);
            this.Controls.Add(this.kilkist_t);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "find_chek";
            this.Text = "find_chek";
            this.Load += new System.EventHandler(this.find_chek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kilkist_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_serch;
        private System.Windows.Forms.NumericUpDown kilkist_t;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar date1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButPr;
        private System.Windows.Forms.RadioButton rButDay;
        private System.Windows.Forms.RadioButton rButV;
        private System.Windows.Forms.MonthCalendar date2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}