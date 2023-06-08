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
            this.TransFarToChel = new System.Windows.Forms.Button();
            this.ErrMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IfChel = new System.Windows.Forms.TextBox();
            this.IfFar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FarTex
            // 
            this.FarTex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FarTex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FarTex.Location = new System.Drawing.Point(261, 24);
            this.FarTex.Name = "FarTex";
            this.FarTex.Size = new System.Drawing.Size(211, 22);
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
            // TransFarToChel
            // 
            this.TransFarToChel.Location = new System.Drawing.Point(261, 201);
            this.TransFarToChel.Name = "TransFarToChel";
            this.TransFarToChel.Size = new System.Drawing.Size(138, 27);
            this.TransFarToChel.TabIndex = 4;
            this.TransFarToChel.Text = "Преобразовать";
            this.TransFarToChel.UseVisualStyleBackColor = true;
            this.TransFarToChel.Click += new System.EventHandler(this.TransFarToChel_Click);
            // 
            // ErrMes
            // 
            this.ErrMes.ForeColor = System.Drawing.Color.Red;
            this.ErrMes.Location = new System.Drawing.Point(12, 157);
            this.ErrMes.Name = "ErrMes";
            this.ErrMes.Size = new System.Drawing.Size(658, 31);
            this.ErrMes.TabIndex = 5;
            this.ErrMes.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цельсий - Фаренгейт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фаренгейт - Цельсий:";
            // 
            // IfChel
            // 
            this.IfChel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IfChel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfChel.Location = new System.Drawing.Point(61, 132);
            this.IfChel.Name = "IfChel";
            this.IfChel.ReadOnly = true;
            this.IfChel.Size = new System.Drawing.Size(211, 22);
            this.IfChel.TabIndex = 8;
            // 
            // IfFar
            // 
            this.IfFar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IfFar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IfFar.Location = new System.Drawing.Point(360, 132);
            this.IfFar.Name = "IfFar";
            this.IfFar.ReadOnly = true;
            this.IfFar.Size = new System.Drawing.Size(211, 22);
            this.IfFar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 240);
            this.Controls.Add(this.IfFar);
            this.Controls.Add(this.IfChel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrMes);
            this.Controls.Add(this.TransFarToChel);
            this.Controls.Add(this.FarLab);
            this.Controls.Add(this.FarTex);
            this.MinimumSize = new System.Drawing.Size(700, 287);
            this.Name = "Form1";
            this.Text = "Преобразователь температур";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FarTex;
        private System.Windows.Forms.Label FarLab;
        private System.Windows.Forms.Button TransFarToChel;
        private System.Windows.Forms.Label ErrMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IfChel;
        private System.Windows.Forms.TextBox IfFar;
    }
}

