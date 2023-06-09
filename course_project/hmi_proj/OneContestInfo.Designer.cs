namespace hmi_proj
{
    partial class OneContestInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContestName = new System.Windows.Forms.TextBox();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProblemsTable = new System.Windows.Forms.DataGridView();
            this.Problemlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.addNewTasks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProblemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название контеста";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ContestName
            // 
            this.ContestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContestName.Location = new System.Drawing.Point(148, 20);
            this.ContestName.Margin = new System.Windows.Forms.Padding(2);
            this.ContestName.Multiline = true;
            this.ContestName.Name = "ContestName";
            this.ContestName.ReadOnly = true;
            this.ContestName.Size = new System.Drawing.Size(378, 49);
            this.ContestName.TabIndex = 1;
            this.ContestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeamName
            // 
            this.TeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamName.Location = new System.Drawing.Point(148, 121);
            this.TeamName.Margin = new System.Windows.Forms.Padding(2);
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            this.TeamName.Size = new System.Drawing.Size(378, 20);
            this.TeamName.TabIndex = 3;
            this.TeamName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название команды";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Difficulty
            // 
            this.Difficulty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Difficulty.Location = new System.Drawing.Point(148, 97);
            this.Difficulty.Margin = new System.Windows.Forms.Padding(2);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.Size = new System.Drawing.Size(378, 20);
            this.Difficulty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сложность";
            // 
            // ProblemsTable
            // 
            this.ProblemsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProblemsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProblemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProblemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Problemlist});
            this.ProblemsTable.Location = new System.Drawing.Point(11, 156);
            this.ProblemsTable.Margin = new System.Windows.Forms.Padding(2);
            this.ProblemsTable.Name = "ProblemsTable";
            this.ProblemsTable.RowTemplate.Height = 24;
            this.ProblemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProblemsTable.Size = new System.Drawing.Size(392, 237);
            this.ProblemsTable.TabIndex = 6;
            // 
            // Problemlist
            // 
            this.Problemlist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Problemlist.HeaderText = "Задачи";
            this.Problemlist.Name = "Problemlist";
            this.Problemlist.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID контеста";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox.Location = new System.Drawing.Point(148, 73);
            this.idBox.Margin = new System.Windows.Forms.Padding(2);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(378, 20);
            this.idBox.TabIndex = 8;
            // 
            // addNewTasks
            // 
            this.addNewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewTasks.Location = new System.Drawing.Point(407, 205);
            this.addNewTasks.Margin = new System.Windows.Forms.Padding(2);
            this.addNewTasks.Name = "addNewTasks";
            this.addNewTasks.Size = new System.Drawing.Size(124, 57);
            this.addNewTasks.TabIndex = 9;
            this.addNewTasks.Text = "Добавить выделенные задачи";
            this.addNewTasks.UseVisualStyleBackColor = true;
            this.addNewTasks.Click += new System.EventHandler(this.addNewTasks_Click);
            // 
            // OneContestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.addNewTasks);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProblemsTable);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContestName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(398, 296);
            this.Name = "OneContestInfo";
            this.Text = "Информация о контесте";
            this.Load += new System.EventHandler(this.OneContestInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProblemsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContestName;
        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Difficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProblemsTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problemlist;
        private System.Windows.Forms.Button addNewTasks;
    }
}