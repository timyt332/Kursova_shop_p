namespace kursovoi
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
            this.buttonvhid = new System.Windows.Forms.Button();
            this.listcor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonvhid
            // 
            this.buttonvhid.Location = new System.Drawing.Point(171, 216);
            this.buttonvhid.Name = "buttonvhid";
            this.buttonvhid.Size = new System.Drawing.Size(75, 23);
            this.buttonvhid.TabIndex = 0;
            this.buttonvhid.Text = "Вхід";
            this.buttonvhid.UseVisualStyleBackColor = true;
            this.buttonvhid.Click += new System.EventHandler(this.buttonvhid_Click);
            // 
            // listcor
            // 
            this.listcor.FormattingEnabled = true;
            this.listcor.Location = new System.Drawing.Point(34, 89);
            this.listcor.Name = "listcor";
            this.listcor.Size = new System.Drawing.Size(338, 21);
            this.listcor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Користувач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // parol
            // 
            this.parol.Location = new System.Drawing.Point(34, 167);
            this.parol.MaxLength = 10;
            this.parol.Name = "parol";
            this.parol.Size = new System.Drawing.Size(338, 20);
            this.parol.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 319);
            this.Controls.Add(this.parol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listcor);
            this.Controls.Add(this.buttonvhid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonvhid;
        private System.Windows.Forms.ComboBox listcor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parol;
    }
}

