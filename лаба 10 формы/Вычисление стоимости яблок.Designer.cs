namespace лаба_10_формы
{
    partial class Вычисление_стоимости_яблок
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kilogramms = new System.Windows.Forms.TextBox();
            this.textformoney = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Вывод = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = global::лаба_10_формы.Properties.Resources.КОРЗИНА;
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::лаба_10_формы.Properties.Resources.цена_за_килос;
            this.pictureBox2.Location = new System.Drawing.Point(12, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // kilogramms
            // 
            this.kilogramms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kilogramms.Location = new System.Drawing.Point(157, 137);
            this.kilogramms.Name = "kilogramms";
            this.kilogramms.Size = new System.Drawing.Size(100, 38);
            this.kilogramms.TabIndex = 3;
            this.kilogramms.TextChanged += new System.EventHandler(this.kilogramms_TextChanged);
            // 
            // textformoney
            // 
            this.textformoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textformoney.Location = new System.Drawing.Point(157, 270);
            this.textformoney.Name = "textformoney";
            this.textformoney.Size = new System.Drawing.Size(100, 38);
            this.textformoney.TabIndex = 4;
            this.textformoney.TextChanged += new System.EventHandler(this.textformoney_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "ВЫЧИСЛИТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Вывод
            // 
            this.Вывод.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вывод.Location = new System.Drawing.Point(434, 466);
            this.Вывод.Multiline = true;
            this.Вывод.Name = "Вывод";
            this.Вывод.Size = new System.Drawing.Size(144, 60);
            this.Вывод.TabIndex = 6;
            this.Вывод.TextChanged += new System.EventHandler(this.Вывод_TextChanged);
            // 
            // Вычисление_стоимости_яблок
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::лаба_10_формы.Properties.Resources.pngwing_com__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1003, 751);
            this.Controls.Add(this.Вывод);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textformoney);
            this.Controls.Add(this.kilogramms);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Вычисление_стоимости_яблок";
            this.Text = "Вычисление_стоимости_яблок";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox kilogramms;
        private System.Windows.Forms.TextBox textformoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Вывод;
    }
}