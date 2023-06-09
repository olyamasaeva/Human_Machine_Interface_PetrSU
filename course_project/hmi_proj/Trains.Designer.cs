namespace hmi_proj
{
    partial class Trains
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TrainsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContestName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypedHandle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RemoveSelectedTasks = new System.Windows.Forms.Button();
            this.PracticeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idofContest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TrainsTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeList)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainsTable
            // 
            this.TrainsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ContestName,
            this.accepted,
            this.Column2});
            this.TrainsTable.Location = new System.Drawing.Point(4, 4);
            this.TrainsTable.Margin = new System.Windows.Forms.Padding(2);
            this.TrainsTable.Name = "TrainsTable";
            this.TrainsTable.RowTemplate.Height = 24;
            this.TrainsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrainsTable.Size = new System.Drawing.Size(645, 354);
            this.TrainsTable.TabIndex = 0;
            this.TrainsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainsTable_CellContentClick);
            this.TrainsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainsTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ContestName
            // 
            this.ContestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContestName.HeaderText = "Контест ";
            this.ContestName.Name = "ContestName";
            this.ContestName.ReadOnly = true;
            this.ContestName.Visible = false;
            // 
            // accepted
            // 
            this.accepted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accepted.HeaderText = "Решено";
            this.accepted.Name = "accepted";
            this.accepted.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Посылки";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // TypedHandle
            // 
            this.TypedHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypedHandle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TypedHandle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TypedHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypedHandle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TypedHandle.Location = new System.Drawing.Point(11, 20);
            this.TypedHandle.Margin = new System.Windows.Forms.Padding(2);
            this.TypedHandle.Name = "TypedHandle";
            this.TypedHandle.Size = new System.Drawing.Size(508, 28);
            this.TypedHandle.TabIndex = 1;
            this.TypedHandle.Click += new System.EventHandler(this.TypedHandle_Click);
            this.TypedHandle.TextChanged += new System.EventHandler(this.TypedHandle_TextChanged);
            this.TypedHandle.Enter += new System.EventHandler(this.typedHandle_Enter);
            this.TypedHandle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.TypedHandle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_PressKey);
            this.TypedHandle.Leave += new System.EventHandler(this.typedHandle_leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(524, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 386);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TrainsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(652, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Мои тренировки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RemoveSelectedTasks);
            this.tabPage2.Controls.Add(this.PracticeList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(652, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Моя дорешка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RemoveSelectedTasks
            // 
            this.RemoveSelectedTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSelectedTasks.Location = new System.Drawing.Point(513, 61);
            this.RemoveSelectedTasks.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveSelectedTasks.Name = "RemoveSelectedTasks";
            this.RemoveSelectedTasks.Size = new System.Drawing.Size(135, 59);
            this.RemoveSelectedTasks.TabIndex = 1;
            this.RemoveSelectedTasks.Text = "Убрать выделенные задачи";
            this.RemoveSelectedTasks.UseVisualStyleBackColor = true;
            this.RemoveSelectedTasks.Click += new System.EventHandler(this.RemoveSelectedTasks_Click);
            // 
            // PracticeList
            // 
            this.PracticeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PracticeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddDate,
            this.Tasks,
            this.idofContest});
            this.PracticeList.Location = new System.Drawing.Point(0, 0);
            this.PracticeList.Margin = new System.Windows.Forms.Padding(2);
            this.PracticeList.Name = "PracticeList";
            this.PracticeList.RowTemplate.Height = 24;
            this.PracticeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PracticeList.Size = new System.Drawing.Size(509, 362);
            this.PracticeList.TabIndex = 0;
            this.PracticeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.PracticeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PracticeList_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Хендл не найден";
            this.label1.Visible = false;
            // 
            // AddDate
            // 
            this.AddDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.AddDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddDate.HeaderText = "Дата добавления";
            this.AddDate.Name = "AddDate";
            this.AddDate.ReadOnly = true;
            this.AddDate.Width = 111;
            // 
            // Tasks
            // 
            this.Tasks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tasks.HeaderText = "Задачи";
            this.Tasks.Name = "Tasks";
            this.Tasks.ReadOnly = true;
            // 
            // idofContest
            // 
            this.idofContest.HeaderText = "idofContest";
            this.idofContest.Name = "idofContest";
            this.idofContest.Visible = false;
            // 
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypedHandle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(398, 294);
            this.Name = "Trains";
            this.Text = "Codeforces Trains";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trains_FormClosing);
            this.Load += new System.EventHandler(this.Trains_Load);
            this.Click += new System.EventHandler(this.TypedHandle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TrainsTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PracticeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TrainsTable;
        private System.Windows.Forms.TextBox TypedHandle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView PracticeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn ContestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button RemoveSelectedTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idofContest;
    }
}