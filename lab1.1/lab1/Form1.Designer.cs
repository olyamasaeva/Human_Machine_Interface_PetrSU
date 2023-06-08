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
            this.ChelTex = new System.Windows.Forms.TextBox();
            this.FarLab = new System.Windows.Forms.Label();
            this.ChelLab = new System.Windows.Forms.Label();
            this.TransFarToChel = new System.Windows.Forms.Button();
            this.ErrMes = new System.Windows.Forms.Label();
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
            // ChelTex
            // 
            this.ChelTex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChelTex.Location = new System.Drawing.Point(261, 91);
            this.ChelTex.Name = "ChelTex";
            this.ChelTex.ReadOnly = true;
            this.ChelTex.Size = new System.Drawing.Size(211, 22);
            this.ChelTex.TabIndex = 1;
            // 
            // FarLab
            // 
            this.FarLab.Location = new System.Drawing.Point(58, 27);
            this.FarLab.Name = "FarLab";
            this.FarLab.Size = new System.Drawing.Size(172, 19);
            this.FarLab.TabIndex = 2;
            this.FarLab.Text = "Градусы Фаренгейта";
            this.FarLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChelLab
            // 
            this.ChelLab.Location = new System.Drawing.Point(58, 87);
            this.ChelLab.Name = "ChelLab";
            this.ChelLab.Size = new System.Drawing.Size(172, 26);
            this.ChelLab.TabIndex = 3;
            this.ChelLab.Text = "Градусы Цельсия";
            // 
            // TransFarToChel
            // 
            this.TransFarToChel.Location = new System.Drawing.Point(261, 160);
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
            this.ErrMes.Location = new System.Drawing.Point(12, 126);
            this.ErrMes.Name = "ErrMes";
            this.ErrMes.Size = new System.Drawing.Size(658, 31);
            this.ErrMes.TabIndex = 5;
            this.ErrMes.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 240);
            this.Controls.Add(this.ErrMes);
            this.Controls.Add(this.TransFarToChel);
            this.Controls.Add(this.ChelLab);
            this.Controls.Add(this.FarLab);
            this.Controls.Add(this.ChelTex);
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
        private System.Windows.Forms.TextBox ChelTex;
        private System.Windows.Forms.Label FarLab;
        private System.Windows.Forms.Label ChelLab;
        private System.Windows.Forms.Button TransFarToChel;
        private System.Windows.Forms.Label ErrMes;
    }
}

