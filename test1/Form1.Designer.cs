namespace test1
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.cbSortDirection = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lbSort = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.rbUneployed = new System.Windows.Forms.RadioButton();
            this.rbEmployed = new System.Windows.Forms.RadioButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cbStatStatus = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatStatus = new System.Windows.Forms.Label();
            this.plotViewStats = new OxyPlot.WindowsForms.PlotView();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Статус";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.cbSortDirection);
            this.gbFilters.Controls.Add(this.cbSort);
            this.gbFilters.Controls.Add(this.lbSort);
            this.gbFilters.Controls.Add(this.tbLastName);
            this.gbFilters.Controls.Add(this.cbPost);
            this.gbFilters.Controls.Add(this.cbDep);
            this.gbFilters.Controls.Add(this.btnApply);
            this.gbFilters.Controls.Add(this.lblLastName);
            this.gbFilters.Controls.Add(this.lblPost);
            this.gbFilters.Controls.Add(this.lblDep);
            this.gbFilters.Controls.Add(this.cbStatus);
            this.gbFilters.Controls.Add(this.lblStatus);
            this.gbFilters.Location = new System.Drawing.Point(36, 58);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(730, 103);
            this.gbFilters.TabIndex = 1;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Фильтры";
            // 
            // cbSortDirection
            // 
            this.cbSortDirection.FormattingEnabled = true;
            this.cbSortDirection.Location = new System.Drawing.Point(458, 70);
            this.cbSortDirection.Name = "cbSortDirection";
            this.cbSortDirection.Size = new System.Drawing.Size(121, 24);
            this.cbSortDirection.TabIndex = 8;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(325, 70);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 24);
            this.cbSort.TabIndex = 7;
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Location = new System.Drawing.Point(179, 77);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(86, 16);
            this.lbSort.TabIndex = 6;
            this.lbSort.Text = "Сортировка";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(458, 39);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 22);
            this.tbLastName.TabIndex = 5;
            // 
            // cbPost
            // 
            this.cbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(323, 37);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(121, 24);
            this.cbPost.TabIndex = 2;
            // 
            // cbDep
            // 
            this.cbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(175, 37);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(121, 24);
            this.cbDep.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(18, 77);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(97, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(450, 18);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(108, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Часть фамилии";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(343, 18);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(78, 16);
            this.lblPost.TabIndex = 3;
            this.lblPost.Text = "Должность";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(217, 17);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(48, 16);
            this.lblDep.TabIndex = 2;
            this.lblDep.Text = "Отдел";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(18, 37);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(36, 215);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(730, 479);
            this.dgvEmployees.TabIndex = 2;
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.btnShowStats);
            this.gbStats.Controls.Add(this.rbUneployed);
            this.gbStats.Controls.Add(this.rbEmployed);
            this.gbStats.Controls.Add(this.dtpEnd);
            this.gbStats.Controls.Add(this.dtpStart);
            this.gbStats.Controls.Add(this.cbStatStatus);
            this.gbStats.Controls.Add(this.lblEndDate);
            this.gbStats.Controls.Add(this.lblStartDate);
            this.gbStats.Controls.Add(this.lblStatStatus);
            this.gbStats.Location = new System.Drawing.Point(782, 58);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(730, 135);
            this.gbStats.TabIndex = 3;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Отчет";
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(40, 71);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(131, 58);
            this.btnShowStats.TabIndex = 8;
            this.btnShowStats.Text = "Показать статистику";
            this.btnShowStats.UseVisualStyleBackColor = true;
            // 
            // rbUneployed
            // 
            this.rbUneployed.AutoSize = true;
            this.rbUneployed.Location = new System.Drawing.Point(360, 83);
            this.rbUneployed.Name = "rbUneployed";
            this.rbUneployed.Size = new System.Drawing.Size(86, 20);
            this.rbUneployed.TabIndex = 7;
            this.rbUneployed.TabStop = true;
            this.rbUneployed.Text = "Уволены";
            this.rbUneployed.UseVisualStyleBackColor = true;
            // 
            // rbEmployed
            // 
            this.rbEmployed.AutoSize = true;
            this.rbEmployed.Location = new System.Drawing.Point(220, 84);
            this.rbEmployed.Name = "rbEmployed";
            this.rbEmployed.Size = new System.Drawing.Size(85, 20);
            this.rbEmployed.TabIndex = 6;
            this.rbEmployed.TabStop = true;
            this.rbEmployed.Text = "Приняты";
            this.rbEmployed.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(473, 41);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(244, 41);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 4;
            // 
            // cbStatStatus
            // 
            this.cbStatStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatStatus.FormattingEnabled = true;
            this.cbStatStatus.Location = new System.Drawing.Point(71, 41);
            this.cbStatStatus.Name = "cbStatStatus";
            this.cbStatStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatStatus.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(575, 22);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 16);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Дата по";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(357, 22);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(49, 16);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Дата с";
            // 
            // lblStatStatus
            // 
            this.lblStatStatus.AutoSize = true;
            this.lblStatStatus.Location = new System.Drawing.Point(103, 22);
            this.lblStatStatus.Name = "lblStatStatus";
            this.lblStatStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatStatus.TabIndex = 0;
            this.lblStatStatus.Text = "Статус";
            // 
            // plotViewStats
            // 
            this.plotViewStats.Location = new System.Drawing.Point(793, 215);
            this.plotViewStats.Name = "plotViewStats";
            this.plotViewStats.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewStats.Size = new System.Drawing.Size(694, 479);
            this.plotViewStats.TabIndex = 5;
            this.plotViewStats.Text = "plotView1";
            this.plotViewStats.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewStats.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewStats.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 806);
            this.Controls.Add(this.plotViewStats);
            this.Controls.Add(this.gbStats);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.gbFilters);
            this.Name = "Form1";
            this.Text = "Test1";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStatStatus;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.RadioButton rbUneployed;
        private System.Windows.Forms.RadioButton rbEmployed;
        private System.Windows.Forms.Label lbSort;
        private System.Windows.Forms.ComboBox cbSortDirection;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbStatStatus;
        private OxyPlot.WindowsForms.PlotView plotViewStats;
    }
}

