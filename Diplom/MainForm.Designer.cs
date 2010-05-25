namespace Diplom
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReportResearch = new System.Windows.Forms.Button();
            this.btnDeleteResearch = new System.Windows.Forms.Button();
            this.btnAddNewResearch = new System.Windows.Forms.Button();
            this.lstResearches = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditKT = new System.Windows.Forms.Button();
            this.btnRenameKT = new System.Windows.Forms.Button();
            this.btnDelAcousticKT = new System.Windows.Forms.Button();
            this.btnAddAcousticKT = new System.Windows.Forms.Button();
            this.lstAcousticList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnZoomSideView = new System.Windows.Forms.Button();
            this.btnRefreshSideView = new System.Windows.Forms.Button();
            this.btnDelSideView = new System.Windows.Forms.Button();
            this.btnAddSideView = new System.Windows.Forms.Button();
            this.btnZoomTopView = new System.Windows.Forms.Button();
            this.btnRefreshTopView = new System.Windows.Forms.Button();
            this.btnDelTopView = new System.Windows.Forms.Button();
            this.btnAddTopView = new System.Windows.Forms.Button();
            this.pbSideView = new System.Windows.Forms.PictureBox();
            this.pbTopView = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnReportResearch);
            this.groupBox1.Controls.Add(this.btnDeleteResearch);
            this.groupBox1.Controls.Add(this.btnAddNewResearch);
            this.groupBox1.Controls.Add(this.lstResearches);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название исследования";
            // 
            // btnReportResearch
            // 
            this.btnReportResearch.Enabled = false;
            this.btnReportResearch.Location = new System.Drawing.Point(298, 120);
            this.btnReportResearch.Name = "btnReportResearch";
            this.btnReportResearch.Size = new System.Drawing.Size(186, 23);
            this.btnReportResearch.TabIndex = 3;
            this.btnReportResearch.Text = "Сделать протокол исследования";
            this.btnReportResearch.UseVisualStyleBackColor = true;
            this.btnReportResearch.Click += new System.EventHandler(this.btnReportResearch_Click);
            // 
            // btnDeleteResearch
            // 
            this.btnDeleteResearch.Enabled = false;
            this.btnDeleteResearch.Location = new System.Drawing.Point(155, 120);
            this.btnDeleteResearch.Name = "btnDeleteResearch";
            this.btnDeleteResearch.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteResearch.TabIndex = 2;
            this.btnDeleteResearch.Text = "Удалить исследование";
            this.btnDeleteResearch.UseVisualStyleBackColor = true;
            this.btnDeleteResearch.Click += new System.EventHandler(this.btnDeleteResearch_Click);
            // 
            // btnAddNewResearch
            // 
            this.btnAddNewResearch.Location = new System.Drawing.Point(6, 120);
            this.btnAddNewResearch.Name = "btnAddNewResearch";
            this.btnAddNewResearch.Size = new System.Drawing.Size(143, 23);
            this.btnAddNewResearch.TabIndex = 1;
            this.btnAddNewResearch.Text = "Добавить исследование";
            this.btnAddNewResearch.UseVisualStyleBackColor = true;
            this.btnAddNewResearch.Click += new System.EventHandler(this.btnAddNewResearch_Click);
            // 
            // lstResearches
            // 
            this.lstResearches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResearches.FormattingEnabled = true;
            this.lstResearches.Location = new System.Drawing.Point(6, 19);
            this.lstResearches.Name = "lstResearches";
            this.lstResearches.Size = new System.Drawing.Size(562, 95);
            this.lstResearches.TabIndex = 0;
            this.lstResearches.SelectedIndexChanged += new System.EventHandler(this.lstResearches_SelectedIndexChanged);
            this.lstResearches.DoubleClick += new System.EventHandler(this.lstResearches_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditKT);
            this.groupBox2.Controls.Add(this.btnRenameKT);
            this.groupBox2.Controls.Add(this.btnDelAcousticKT);
            this.groupBox2.Controls.Add(this.btnAddAcousticKT);
            this.groupBox2.Controls.Add(this.lstAcousticList);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контрольные точки";
            // 
            // btnEditKT
            // 
            this.btnEditKT.Enabled = false;
            this.btnEditKT.Location = new System.Drawing.Point(369, 146);
            this.btnEditKT.Name = "btnEditKT";
            this.btnEditKT.Size = new System.Drawing.Size(99, 23);
            this.btnEditKT.TabIndex = 7;
            this.btnEditKT.Text = "Изменить";
            this.btnEditKT.UseVisualStyleBackColor = true;
            this.btnEditKT.Click += new System.EventHandler(this.btnEditKT_Click);
            // 
            // btnRenameKT
            // 
            this.btnRenameKT.Enabled = false;
            this.btnRenameKT.Location = new System.Drawing.Point(257, 146);
            this.btnRenameKT.Name = "btnRenameKT";
            this.btnRenameKT.Size = new System.Drawing.Size(106, 23);
            this.btnRenameKT.TabIndex = 6;
            this.btnRenameKT.Text = "Переименовать";
            this.btnRenameKT.UseVisualStyleBackColor = true;
            this.btnRenameKT.Click += new System.EventHandler(this.btnRenameKT_Click);
            // 
            // btnDelAcousticKT
            // 
            this.btnDelAcousticKT.Enabled = false;
            this.btnDelAcousticKT.Location = new System.Drawing.Point(133, 146);
            this.btnDelAcousticKT.Name = "btnDelAcousticKT";
            this.btnDelAcousticKT.Size = new System.Drawing.Size(118, 23);
            this.btnDelAcousticKT.TabIndex = 5;
            this.btnDelAcousticKT.Text = "Удалить КТ";
            this.btnDelAcousticKT.UseVisualStyleBackColor = true;
            this.btnDelAcousticKT.Click += new System.EventHandler(this.btnDelAcousticKT_Click);
            // 
            // btnAddAcousticKT
            // 
            this.btnAddAcousticKT.Enabled = false;
            this.btnAddAcousticKT.Location = new System.Drawing.Point(9, 146);
            this.btnAddAcousticKT.Name = "btnAddAcousticKT";
            this.btnAddAcousticKT.Size = new System.Drawing.Size(118, 23);
            this.btnAddAcousticKT.TabIndex = 4;
            this.btnAddAcousticKT.Text = "Добавить КТ";
            this.btnAddAcousticKT.UseVisualStyleBackColor = true;
            this.btnAddAcousticKT.Click += new System.EventHandler(this.btnAddAcousticKT_Click);
            // 
            // lstAcousticList
            // 
            this.lstAcousticList.FormattingEnabled = true;
            this.lstAcousticList.Location = new System.Drawing.Point(9, 19);
            this.lstAcousticList.Name = "lstAcousticList";
            this.lstAcousticList.Size = new System.Drawing.Size(574, 121);
            this.lstAcousticList.TabIndex = 1;
            this.lstAcousticList.SelectedIndexChanged += new System.EventHandler(this.lstAcousticList_SelectedIndexChanged);
            this.lstAcousticList.DoubleClick += new System.EventHandler(this.lstAcousticList_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZoomSideView);
            this.groupBox3.Controls.Add(this.btnRefreshSideView);
            this.groupBox3.Controls.Add(this.btnDelSideView);
            this.groupBox3.Controls.Add(this.btnAddSideView);
            this.groupBox3.Controls.Add(this.btnZoomTopView);
            this.groupBox3.Controls.Add(this.btnRefreshTopView);
            this.groupBox3.Controls.Add(this.btnDelTopView);
            this.groupBox3.Controls.Add(this.btnAddTopView);
            this.groupBox3.Controls.Add(this.pbSideView);
            this.groupBox3.Controls.Add(this.pbTopView);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(15, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 243);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Схемы";
            // 
            // btnZoomSideView
            // 
            this.btnZoomSideView.Enabled = false;
            this.btnZoomSideView.Location = new System.Drawing.Point(503, 202);
            this.btnZoomSideView.Name = "btnZoomSideView";
            this.btnZoomSideView.Size = new System.Drawing.Size(75, 23);
            this.btnZoomSideView.TabIndex = 11;
            this.btnZoomSideView.Text = "Увеличить";
            this.btnZoomSideView.UseVisualStyleBackColor = true;
            this.btnZoomSideView.Click += new System.EventHandler(this.btnZoomSideView_Click);
            // 
            // btnRefreshSideView
            // 
            this.btnRefreshSideView.Enabled = false;
            this.btnRefreshSideView.Location = new System.Drawing.Point(431, 202);
            this.btnRefreshSideView.Name = "btnRefreshSideView";
            this.btnRefreshSideView.Size = new System.Drawing.Size(64, 23);
            this.btnRefreshSideView.TabIndex = 10;
            this.btnRefreshSideView.Text = "Обновить";
            this.btnRefreshSideView.UseVisualStyleBackColor = true;
            this.btnRefreshSideView.Click += new System.EventHandler(this.btnRefreshSideView_Click);
            // 
            // btnDelSideView
            // 
            this.btnDelSideView.Enabled = false;
            this.btnDelSideView.Location = new System.Drawing.Point(366, 202);
            this.btnDelSideView.Name = "btnDelSideView";
            this.btnDelSideView.Size = new System.Drawing.Size(59, 23);
            this.btnDelSideView.TabIndex = 9;
            this.btnDelSideView.Text = "Удалить";
            this.btnDelSideView.UseVisualStyleBackColor = true;
            this.btnDelSideView.Click += new System.EventHandler(this.btnDelSideView_Click);
            // 
            // btnAddSideView
            // 
            this.btnAddSideView.Enabled = false;
            this.btnAddSideView.Location = new System.Drawing.Point(295, 202);
            this.btnAddSideView.Name = "btnAddSideView";
            this.btnAddSideView.Size = new System.Drawing.Size(65, 23);
            this.btnAddSideView.TabIndex = 8;
            this.btnAddSideView.Text = "Добавить";
            this.btnAddSideView.UseVisualStyleBackColor = true;
            this.btnAddSideView.Click += new System.EventHandler(this.btnAddSideView_Click);
            // 
            // btnZoomTopView
            // 
            this.btnZoomTopView.Enabled = false;
            this.btnZoomTopView.Location = new System.Drawing.Point(214, 202);
            this.btnZoomTopView.Name = "btnZoomTopView";
            this.btnZoomTopView.Size = new System.Drawing.Size(75, 23);
            this.btnZoomTopView.TabIndex = 7;
            this.btnZoomTopView.Text = "Увеличить";
            this.btnZoomTopView.UseVisualStyleBackColor = true;
            this.btnZoomTopView.Click += new System.EventHandler(this.btnZoomTopView_Click);
            // 
            // btnRefreshTopView
            // 
            this.btnRefreshTopView.Enabled = false;
            this.btnRefreshTopView.Location = new System.Drawing.Point(142, 202);
            this.btnRefreshTopView.Name = "btnRefreshTopView";
            this.btnRefreshTopView.Size = new System.Drawing.Size(64, 23);
            this.btnRefreshTopView.TabIndex = 6;
            this.btnRefreshTopView.Text = "Обновить";
            this.btnRefreshTopView.UseVisualStyleBackColor = true;
            this.btnRefreshTopView.Click += new System.EventHandler(this.btnRefreshTopView_Click);
            // 
            // btnDelTopView
            // 
            this.btnDelTopView.Enabled = false;
            this.btnDelTopView.Location = new System.Drawing.Point(77, 202);
            this.btnDelTopView.Name = "btnDelTopView";
            this.btnDelTopView.Size = new System.Drawing.Size(59, 23);
            this.btnDelTopView.TabIndex = 5;
            this.btnDelTopView.Text = "Удалить";
            this.btnDelTopView.UseVisualStyleBackColor = true;
            this.btnDelTopView.Click += new System.EventHandler(this.btnDelTopView_Click);
            // 
            // btnAddTopView
            // 
            this.btnAddTopView.Enabled = false;
            this.btnAddTopView.Location = new System.Drawing.Point(6, 202);
            this.btnAddTopView.Name = "btnAddTopView";
            this.btnAddTopView.Size = new System.Drawing.Size(65, 23);
            this.btnAddTopView.TabIndex = 4;
            this.btnAddTopView.Text = "Добавить";
            this.btnAddTopView.UseVisualStyleBackColor = true;
            this.btnAddTopView.Click += new System.EventHandler(this.btnAddTopView_Click);
            // 
            // pbSideView
            // 
            this.pbSideView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSideView.Location = new System.Drawing.Point(295, 32);
            this.pbSideView.Name = "pbSideView";
            this.pbSideView.Size = new System.Drawing.Size(283, 164);
            this.pbSideView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSideView.TabIndex = 3;
            this.pbSideView.TabStop = false;
            // 
            // pbTopView
            // 
            this.pbTopView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTopView.Location = new System.Drawing.Point(6, 32);
            this.pbTopView.Name = "pbTopView";
            this.pbTopView.Size = new System.Drawing.Size(283, 164);
            this.pbTopView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTopView.TabIndex = 2;
            this.pbTopView.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(409, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вид сбоку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(120, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вид сверху";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(632, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Исследование по защищенности выделенного помещения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReportResearch;
        private System.Windows.Forms.Button btnDeleteResearch;
        private System.Windows.Forms.Button btnAddNewResearch;
        private System.Windows.Forms.ListBox lstResearches;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelAcousticKT;
        private System.Windows.Forms.Button btnAddAcousticKT;
        private System.Windows.Forms.ListBox lstAcousticList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnZoomSideView;
        private System.Windows.Forms.Button btnDelSideView;
        private System.Windows.Forms.Button btnAddSideView;
        private System.Windows.Forms.Button btnZoomTopView;
        private System.Windows.Forms.Button btnDelTopView;
        private System.Windows.Forms.Button btnAddTopView;
        private System.Windows.Forms.PictureBox pbSideView;
        private System.Windows.Forms.PictureBox pbTopView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefreshSideView;
        private System.Windows.Forms.Button btnRefreshTopView;
        private System.Windows.Forms.Button btnEditKT;
        private System.Windows.Forms.Button btnRenameKT;

    }
}

