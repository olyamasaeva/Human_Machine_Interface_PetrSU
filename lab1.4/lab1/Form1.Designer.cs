namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FarTex = new System.Windows.Forms.TextBox();
            this.FarLab = new System.Windows.Forms.Label();
            this.ErrMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IfCheltoFar = new System.Windows.Forms.TextBox();
            this.IfFartoChel = new System.Windows.Forms.TextBox();
            this.IfKeltoChel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IfCheltoKel = new System.Windows.Forms.TextBox();
            this.IfFartoKel = new System.Windows.Forms.TextBox();
            this.IfKeltoFar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FarTex
            // 
            this.FarTex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FarTex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FarTex.Location = new System.Drawing.Point(261, 24);
            this.FarTex.Name = "FarTex";
            this.FarTex.Size = new System.Drawing.Size(411, 22);
            this.FarTex.TabIndex = 0;
            this.FarTex.TextChanged += new System.EventHandler(this.FarTex_TextChanged);
            // 
            // FarLab
            // 
            this.FarLab.Location = new System.Drawing.Point(58, 27);
            this.FarLab.Name = "FarLab";
            this.FarLab.Size = new System.Drawing.Size(172, 19);
            this.FarLab.TabIndex = 2;
            this.FarLab.Text = "Введите градусы";
            this.FarLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrMes
            // 
            this.ErrMes.ForeColor = System.Drawing.Color.Red;
            this.ErrMes.Location = new System.Drawing.Point(58, 186);
            this.ErrMes.Name = "ErrMes";
            this.ErrMes.Size = new System.Drawing.Size(771, 25);
            this.ErrMes.TabIndex = 5;
            this.ErrMes.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Если вы ввели градусы Цельсия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Если вы ввели градусы  Фаренгейта:";
            // 
            // IfCheltoFar
            // 
            this.IfCheltoFar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfCheltoFar.Location = new System.Drawing.Point(181, 103);
            this.IfCheltoFar.Name = "IfCheltoFar";
            this.IfCheltoFar.ReadOnly = true;
            this.IfCheltoFar.Size = new System.Drawing.Size(102, 22);
            this.IfCheltoFar.TabIndex = 8;
            // 
            // IfFartoChel
            // 
            this.IfFartoChel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfFartoChel.Location = new System.Drawing.Point(465, 112);
            this.IfFartoChel.Name = "IfFartoChel";
            this.IfFartoChel.ReadOnly = true;
            this.IfFartoChel.Size = new System.Drawing.Size(102, 22);
            this.IfFartoChel.TabIndex = 9;
            // 
            // IfKeltoChel
            // 
            this.IfKeltoChel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfKeltoChel.Location = new System.Drawing.Point(724, 103);
            this.IfKeltoChel.Name = "IfKeltoChel";
            this.IfKeltoChel.ReadOnly = true;
            this.IfKeltoChel.Size = new System.Drawing.Size(105, 22);
            this.IfKeltoChel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Если вы ввели градусы  Кельвина:";
            // 
            // IfCheltoKel
            // 
            this.IfCheltoKel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfCheltoKel.Location = new System.Drawing.Point(181, 140);
            this.IfCheltoKel.Name = "IfCheltoKel";
            this.IfCheltoKel.ReadOnly = true;
            this.IfCheltoKel.Size = new System.Drawing.Size(102, 22);
            this.IfCheltoKel.TabIndex = 12;
            // 
            // IfFartoKel
            // 
            this.IfFartoKel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfFartoKel.Location = new System.Drawing.Point(465, 140);
            this.IfFartoKel.Name = "IfFartoKel";
            this.IfFartoKel.ReadOnly = true;
            this.IfFartoKel.Size = new System.Drawing.Size(102, 22);
            this.IfFartoKel.TabIndex = 13;
            // 
            // IfKeltoFar
            // 
            this.IfKeltoFar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfKeltoFar.Location = new System.Drawing.Point(724, 140);
            this.IfKeltoFar.Name = "IfKeltoFar";
            this.IfKeltoFar.ReadOnly = true;
            this.IfKeltoFar.Size = new System.Drawing.Size(105, 22);
            this.IfKeltoFar.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "В фаренгейтах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "В Кельвинах";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "В фаренгейтах";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "В Кельвинах";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "В Цельсиях";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "В Цельсиях";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 253);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IfKeltoFar);
            this.Controls.Add(this.IfFartoKel);
            this.Controls.Add(this.IfCheltoKel);
            this.Controls.Add(this.IfKeltoChel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IfFartoChel);
            this.Controls.Add(this.IfCheltoFar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrMes);
            this.Controls.Add(this.FarLab);
            this.Controls.Add(this.FarTex);
            this.MinimumSize = new System.Drawing.Size(900, 300);
            this.Name = "Form1";
            this.Text = "Преобразователь температур";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FarTex;
        private System.Windows.Forms.Label FarLab;
        private System.Windows.Forms.Label ErrMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IfCheltoFar;
        private System.Windows.Forms.TextBox IfFartoChel;
        private System.Windows.Forms.TextBox IfKeltoChel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IfCheltoKel;
        private System.Windows.Forms.TextBox IfFartoKel;
        private System.Windows.Forms.TextBox IfKeltoFar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

