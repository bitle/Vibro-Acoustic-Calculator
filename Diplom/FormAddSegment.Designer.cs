namespace Diplom
{
    partial class FormAddSegment
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
            this.panelTurn = new System.Windows.Forms.Panel();
            this.cbTurnAngleAndSize = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStraight = new System.Windows.Forms.RadioButton();
            this.rbTurn = new System.Windows.Forms.RadioButton();
            this.rbExtension = new System.Windows.Forms.RadioButton();
            this.panelStraight = new System.Windows.Forms.Panel();
            this.tbSegmentLength = new System.Windows.Forms.TextBox();
            this.panelStraightBeton = new System.Windows.Forms.Panel();
            this.tbSectorPerimetr = new System.Windows.Forms.TextBox();
            this.tbSectorSquare = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFadeRatio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStreightMaterial = new System.Windows.Forms.ComboBox();
            this.panelStraightMetal = new System.Windows.Forms.Panel();
            this.cbSignalFading = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelExtention = new System.Windows.Forms.Panel();
            this.tbSquareAfterExt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbSquareBeforeExt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTurn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelStraight.SuspendLayout();
            this.panelStraightBeton.SuspendLayout();
            this.panelStraightMetal.SuspendLayout();
            this.panelExtention.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTurn
            // 
            this.panelTurn.Controls.Add(this.cbTurnAngleAndSize);
            this.panelTurn.Controls.Add(this.label16);
            this.panelTurn.Location = new System.Drawing.Point(21, 113);
            this.panelTurn.Name = "panelTurn";
            this.panelTurn.Size = new System.Drawing.Size(337, 45);
            this.panelTurn.TabIndex = 5;
            this.panelTurn.Visible = false;
            // 
            // cbTurnAngleAndSize
            // 
            this.cbTurnAngleAndSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurnAngleAndSize.FormattingEnabled = true;
            this.cbTurnAngleAndSize.Location = new System.Drawing.Point(6, 16);
            this.cbTurnAngleAndSize.Name = "cbTurnAngleAndSize";
            this.cbTurnAngleAndSize.Size = new System.Drawing.Size(300, 21);
            this.cbTurnAngleAndSize.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(314, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Угол поворота и размер воздуховода в плоскости поворота";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExtension);
            this.groupBox1.Controls.Add(this.rbTurn);
            this.groupBox1.Controls.Add(this.rbStraight);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Участок";
            // 
            // rbStraight
            // 
            this.rbStraight.AutoSize = true;
            this.rbStraight.Checked = true;
            this.rbStraight.Location = new System.Drawing.Point(6, 19);
            this.rbStraight.Name = "rbStraight";
            this.rbStraight.Size = new System.Drawing.Size(65, 17);
            this.rbStraight.TabIndex = 0;
            this.rbStraight.TabStop = true;
            this.rbStraight.Text = "Прямой";
            this.rbStraight.UseVisualStyleBackColor = true;
            this.rbStraight.CheckedChanged += new System.EventHandler(this.rbStraight_CheckedChanged);
            // 
            // rbTurn
            // 
            this.rbTurn.AutoSize = true;
            this.rbTurn.Location = new System.Drawing.Point(6, 42);
            this.rbTurn.Name = "rbTurn";
            this.rbTurn.Size = new System.Drawing.Size(68, 17);
            this.rbTurn.TabIndex = 1;
            this.rbTurn.Text = "Поворот";
            this.rbTurn.UseVisualStyleBackColor = true;
            this.rbTurn.CheckedChanged += new System.EventHandler(this.rbStraight_CheckedChanged);
            // 
            // rbExtension
            // 
            this.rbExtension.AutoSize = true;
            this.rbExtension.Location = new System.Drawing.Point(6, 65);
            this.rbExtension.Name = "rbExtension";
            this.rbExtension.Size = new System.Drawing.Size(136, 17);
            this.rbExtension.TabIndex = 2;
            this.rbExtension.Text = "Расширение/сужение";
            this.rbExtension.UseVisualStyleBackColor = true;
            this.rbExtension.CheckedChanged += new System.EventHandler(this.rbStraight_CheckedChanged);
            // 
            // panelStraight
            // 
            this.panelStraight.Controls.Add(this.tbSegmentLength);
            this.panelStraight.Controls.Add(this.panelStraightBeton);
            this.panelStraight.Controls.Add(this.label14);
            this.panelStraight.Controls.Add(this.label10);
            this.panelStraight.Controls.Add(this.cbStreightMaterial);
            this.panelStraight.Controls.Add(this.panelStraightMetal);
            this.panelStraight.Location = new System.Drawing.Point(21, 164);
            this.panelStraight.Name = "panelStraight";
            this.panelStraight.Size = new System.Drawing.Size(689, 163);
            this.panelStraight.TabIndex = 7;
            // 
            // tbSegmentLength
            // 
            this.tbSegmentLength.Location = new System.Drawing.Point(397, 17);
            this.tbSegmentLength.Name = "tbSegmentLength";
            this.tbSegmentLength.Size = new System.Drawing.Size(100, 20);
            this.tbSegmentLength.TabIndex = 7;
            // 
            // panelStraightBeton
            // 
            this.panelStraightBeton.Controls.Add(this.tbSectorPerimetr);
            this.panelStraightBeton.Controls.Add(this.tbSectorSquare);
            this.panelStraightBeton.Controls.Add(this.label13);
            this.panelStraightBeton.Controls.Add(this.label12);
            this.panelStraightBeton.Controls.Add(this.cbFadeRatio);
            this.panelStraightBeton.Controls.Add(this.label11);
            this.panelStraightBeton.Location = new System.Drawing.Point(6, 51);
            this.panelStraightBeton.Name = "panelStraightBeton";
            this.panelStraightBeton.Size = new System.Drawing.Size(482, 81);
            this.panelStraightBeton.TabIndex = 2;
            this.panelStraightBeton.Visible = false;
            // 
            // tbSectorPerimetr
            // 
            this.tbSectorPerimetr.Location = new System.Drawing.Point(286, 56);
            this.tbSectorPerimetr.Name = "tbSectorPerimetr";
            this.tbSectorPerimetr.Size = new System.Drawing.Size(189, 20);
            this.tbSectorPerimetr.TabIndex = 6;
            // 
            // tbSectorSquare
            // 
            this.tbSectorSquare.Location = new System.Drawing.Point(286, 30);
            this.tbSectorSquare.Name = "tbSectorSquare";
            this.tbSectorSquare.Size = new System.Drawing.Size(189, 20);
            this.tbSectorSquare.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Периметр поперечного сечения канала, м";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Площадь поперечного сечения канала, м^2";
            // 
            // cbFadeRatio
            // 
            this.cbFadeRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFadeRatio.FormattingEnabled = true;
            this.cbFadeRatio.Location = new System.Drawing.Point(286, 3);
            this.cbFadeRatio.Name = "cbFadeRatio";
            this.cbFadeRatio.Size = new System.Drawing.Size(189, 21);
            this.cbFadeRatio.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Коэффициент затухания акустического сигнала, дБ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(249, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Длина прямого участка, м";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Материал участка";
            // 
            // cbStreightMaterial
            // 
            this.cbStreightMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStreightMaterial.FormattingEnabled = true;
            this.cbStreightMaterial.Items.AddRange(new object[] {
            "Бетон, кирпич",
            "Металл"});
            this.cbStreightMaterial.Location = new System.Drawing.Point(120, 16);
            this.cbStreightMaterial.Name = "cbStreightMaterial";
            this.cbStreightMaterial.Size = new System.Drawing.Size(121, 21);
            this.cbStreightMaterial.TabIndex = 0;
            this.cbStreightMaterial.SelectedIndexChanged += new System.EventHandler(this.cbStreightMaterial_SelectedIndexChanged);
            // 
            // panelStraightMetal
            // 
            this.panelStraightMetal.Controls.Add(this.cbSignalFading);
            this.panelStraightMetal.Controls.Add(this.label15);
            this.panelStraightMetal.Location = new System.Drawing.Point(16, 67);
            this.panelStraightMetal.Name = "panelStraightMetal";
            this.panelStraightMetal.Size = new System.Drawing.Size(498, 32);
            this.panelStraightMetal.TabIndex = 3;
            this.panelStraightMetal.Visible = false;
            // 
            // cbSignalFading
            // 
            this.cbSignalFading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalFading.FormattingEnabled = true;
            this.cbSignalFading.Location = new System.Drawing.Point(217, 3);
            this.cbSignalFading.Name = "cbSignalFading";
            this.cbSignalFading.Size = new System.Drawing.Size(264, 21);
            this.cbSignalFading.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Погонное затухание акуст. сигнала, дБ";
            // 
            // panelExtention
            // 
            this.panelExtention.Controls.Add(this.tbSquareAfterExt);
            this.panelExtention.Controls.Add(this.label18);
            this.panelExtention.Controls.Add(this.tbSquareBeforeExt);
            this.panelExtention.Controls.Add(this.label17);
            this.panelExtention.Location = new System.Drawing.Point(51, 354);
            this.panelExtention.Name = "panelExtention";
            this.panelExtention.Size = new System.Drawing.Size(484, 61);
            this.panelExtention.TabIndex = 8;
            this.panelExtention.Visible = false;
            // 
            // tbSquareAfterExt
            // 
            this.tbSquareAfterExt.Location = new System.Drawing.Point(357, 26);
            this.tbSquareAfterExt.Name = "tbSquareAfterExt";
            this.tbSquareAfterExt.Size = new System.Drawing.Size(100, 20);
            this.tbSquareAfterExt.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(340, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Площаьдь поперечного сечения после изменения сегмента, м^2";
            // 
            // tbSquareBeforeExt
            // 
            this.tbSquareBeforeExt.Location = new System.Drawing.Point(330, 0);
            this.tbSquareBeforeExt.Name = "tbSquareBeforeExt";
            this.tbSquareBeforeExt.Size = new System.Drawing.Size(127, 20);
            this.tbSquareBeforeExt.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(316, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Площадь поперечного сечения до изменения сегмента, м^2";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(283, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(283, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddSegment
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(828, 454);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelExtention);
            this.Controls.Add(this.panelStraight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTurn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddSegment";
            this.Text = "Добавить новый сегмент";
            this.panelTurn.ResumeLayout(false);
            this.panelTurn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelStraight.ResumeLayout(false);
            this.panelStraight.PerformLayout();
            this.panelStraightBeton.ResumeLayout(false);
            this.panelStraightBeton.PerformLayout();
            this.panelStraightMetal.ResumeLayout(false);
            this.panelStraightMetal.PerformLayout();
            this.panelExtention.ResumeLayout(false);
            this.panelExtention.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTurn;
        private System.Windows.Forms.ComboBox cbTurnAngleAndSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExtension;
        private System.Windows.Forms.RadioButton rbTurn;
        private System.Windows.Forms.RadioButton rbStraight;
        private System.Windows.Forms.Panel panelStraight;
        private System.Windows.Forms.TextBox tbSegmentLength;
        private System.Windows.Forms.Panel panelStraightBeton;
        private System.Windows.Forms.TextBox tbSectorPerimetr;
        private System.Windows.Forms.TextBox tbSectorSquare;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbFadeRatio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbStreightMaterial;
        private System.Windows.Forms.Panel panelStraightMetal;
        private System.Windows.Forms.ComboBox cbSignalFading;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelExtention;
        private System.Windows.Forms.TextBox tbSquareAfterExt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbSquareBeforeExt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}