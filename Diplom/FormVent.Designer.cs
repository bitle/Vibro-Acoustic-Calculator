namespace Diplom
{
    partial class FormVent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbNoiseType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSignalLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSignalPlace = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNeighborVolume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvConsumers = new System.Windows.Forms.DataGridView();
            this.colConsumersSquare = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbConsumersNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAbsorber = new System.Windows.Forms.DataGridView();
            this.colAbsorbSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsorbRatio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbAbsorbersNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditSector = new System.Windows.Forms.Button();
            this.btnRemoveSector = new System.Windows.Forms.Button();
            this.btnAddSector = new System.Windows.Forms.Button();
            this.lstSegments = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbWeakNoiseReduction = new System.Windows.Forms.RadioButton();
            this.rbStrongNoiseReduction = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbReadability = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbRatio8000 = new System.Windows.Forms.TextBox();
            this.tbRatio4000 = new System.Windows.Forms.TextBox();
            this.tbRatio2000 = new System.Windows.Forms.TextBox();
            this.tbRatio1000 = new System.Windows.Forms.TextBox();
            this.tbRatio500 = new System.Windows.Forms.TextBox();
            this.tbRatio250 = new System.Windows.Forms.TextBox();
            this.tbRatio125 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel8000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel4000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel2000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel1000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel500 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel250 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel125 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel8000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel4000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel2000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel1000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel500 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel250 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel125 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel8000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel4000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel2000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel1000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel500 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel250 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel125 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsorber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNoiseType
            // 
            this.cbNoiseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNoiseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNoiseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoiseType.FormattingEnabled = true;
            this.cbNoiseType.Location = new System.Drawing.Point(432, 12);
            this.cbNoiseType.Name = "cbNoiseType";
            this.cbNoiseType.Size = new System.Drawing.Size(456, 21);
            this.cbNoiseType.TabIndex = 7;
            this.cbNoiseType.SelectedIndexChanged += new System.EventHandler(this.cbNoiseType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид шума";
            // 
            // cbSignalLevel
            // 
            this.cbSignalLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalLevel.FormattingEnabled = true;
            this.cbSignalLevel.Location = new System.Drawing.Point(168, 12);
            this.cbSignalLevel.Name = "cbSignalLevel";
            this.cbSignalLevel.Size = new System.Drawing.Size(196, 21);
            this.cbSignalLevel.TabIndex = 5;
            this.cbSignalLevel.SelectedIndexChanged += new System.EventHandler(this.cbSignalLevel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Уровень сигнала источника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Расположение источника сигнала";
            // 
            // cbSignalPlace
            // 
            this.cbSignalPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalPlace.FormattingEnabled = true;
            this.cbSignalPlace.Items.AddRange(new object[] {
            "В центре помещения",
            "Вблизи одной из стен помещения",
            "В углу помещения"});
            this.cbSignalPlace.Location = new System.Drawing.Point(199, 39);
            this.cbSignalPlace.Name = "cbSignalPlace";
            this.cbSignalPlace.Size = new System.Drawing.Size(248, 21);
            this.cbSignalPlace.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRoomType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbNeighborVolume);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvConsumers);
            this.groupBox2.Controls.Add(this.tbConsumersNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvAbsorber);
            this.groupBox2.Controls.Add(this.tbAbsorbersNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(15, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 219);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Описание выделенного помещения";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "С мягкой мебелью и небольшим количеством людей (кабинеты руководящего состава)",
            "С жесткой мебелью и большим количеством людей (комнаты для ведения переговоров, р" +
                "абочие кабинеты)",
            "С мягкой мебельюи большим количеством людей (комнаты для ведения переговоров, раб" +
                "очие кабинеты)",
            "Помещения со звукопоглащающей облицовкой потолка и части стен (специальные выделе" +
                "нные помещения)"});
            this.cbRoomType.Location = new System.Drawing.Point(171, 192);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(693, 21);
            this.cbRoomType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Тип выделенного помещения";
            // 
            // tbNeighborVolume
            // 
            this.tbNeighborVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNeighborVolume.Location = new System.Drawing.Point(213, 166);
            this.tbNeighborVolume.Name = "tbNeighborVolume";
            this.tbNeighborVolume.Size = new System.Drawing.Size(132, 20);
            this.tbNeighborVolume.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Объем выделенного помещения, м^3";
            // 
            // dgvConsumers
            // 
            this.dgvConsumers.AllowUserToAddRows = false;
            this.dgvConsumers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConsumersSquare});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsumers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsumers.Location = new System.Drawing.Point(678, 44);
            this.dgvConsumers.Name = "dgvConsumers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsumers.RowHeadersVisible = false;
            this.dgvConsumers.ShowCellErrors = false;
            this.dgvConsumers.Size = new System.Drawing.Size(195, 116);
            this.dgvConsumers.TabIndex = 5;
            // 
            // colConsumersSquare
            // 
            this.colConsumersSquare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colConsumersSquare.HeaderText = "Эквивалентная площадь звукопоглащения поглотителя";
            this.colConsumersSquare.Name = "colConsumersSquare";
            this.colConsumersSquare.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConsumersSquare.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbConsumersNumber
            // 
            this.tbConsumersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConsumersNumber.Location = new System.Drawing.Point(751, 19);
            this.tbConsumersNumber.Name = "tbConsumersNumber";
            this.tbConsumersNumber.Size = new System.Drawing.Size(113, 20);
            this.tbConsumersNumber.TabIndex = 4;
            this.tbConsumersNumber.TextChanged += new System.EventHandler(this.tbConsumersNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(562, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Количество штучных поглотителей";
            // 
            // dgvAbsorber
            // 
            this.dgvAbsorber.AllowUserToAddRows = false;
            this.dgvAbsorber.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsorber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbsorber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsorber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAbsorbSquare,
            this.colAbsorbRatio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsorber.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAbsorber.Location = new System.Drawing.Point(10, 44);
            this.dgvAbsorber.Name = "dgvAbsorber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsorber.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAbsorber.RowHeadersVisible = false;
            this.dgvAbsorber.Size = new System.Drawing.Size(662, 116);
            this.dgvAbsorber.TabIndex = 2;
            // 
            // colAbsorbSquare
            // 
            this.colAbsorbSquare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAbsorbSquare.FillWeight = 30F;
            this.colAbsorbSquare.HeaderText = "Площадь звукопоглащающей поверхности, м^2";
            this.colAbsorbSquare.Name = "colAbsorbSquare";
            this.colAbsorbSquare.ToolTipText = "Площадь звукопоглащающей поверхности";
            // 
            // colAbsorbRatio
            // 
            this.colAbsorbRatio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAbsorbRatio.HeaderText = "Коэффициент звукопоглащения поверхности";
            this.colAbsorbRatio.Name = "colAbsorbRatio";
            this.colAbsorbRatio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAbsorbRatio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAbsorbRatio.ToolTipText = "Коэффициент звукопоглащения поверхности";
            // 
            // tbAbsorbersNumber
            // 
            this.tbAbsorbersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAbsorbersNumber.Location = new System.Drawing.Point(256, 18);
            this.tbAbsorbersNumber.Name = "tbAbsorbersNumber";
            this.tbAbsorbersNumber.Size = new System.Drawing.Size(47, 20);
            this.tbAbsorbersNumber.TabIndex = 1;
            this.tbAbsorbersNumber.TextChanged += new System.EventHandler(this.tbAbsorbersNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Количество звукопоглащающих поверхностей";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditSector);
            this.groupBox1.Controls.Add(this.btnRemoveSector);
            this.groupBox1.Controls.Add(this.btnAddSector);
            this.groupBox1.Controls.Add(this.lstSegments);
            this.groupBox1.Location = new System.Drawing.Point(15, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 213);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание трассы воздуховода";
            // 
            // btnEditSector
            // 
            this.btnEditSector.Enabled = false;
            this.btnEditSector.Location = new System.Drawing.Point(244, 73);
            this.btnEditSector.Name = "btnEditSector";
            this.btnEditSector.Size = new System.Drawing.Size(75, 23);
            this.btnEditSector.TabIndex = 5;
            this.btnEditSector.Text = "Изменить";
            this.btnEditSector.UseVisualStyleBackColor = true;
            this.btnEditSector.Click += new System.EventHandler(this.btnEditSector_Click);
            // 
            // btnRemoveSector
            // 
            this.btnRemoveSector.Enabled = false;
            this.btnRemoveSector.Location = new System.Drawing.Point(244, 44);
            this.btnRemoveSector.Name = "btnRemoveSector";
            this.btnRemoveSector.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSector.TabIndex = 4;
            this.btnRemoveSector.Text = "Удалить";
            this.btnRemoveSector.UseVisualStyleBackColor = true;
            this.btnRemoveSector.Click += new System.EventHandler(this.btnRemoveSector_Click);
            // 
            // btnAddSector
            // 
            this.btnAddSector.Location = new System.Drawing.Point(244, 15);
            this.btnAddSector.Name = "btnAddSector";
            this.btnAddSector.Size = new System.Drawing.Size(75, 23);
            this.btnAddSector.TabIndex = 3;
            this.btnAddSector.Text = "Добавить";
            this.btnAddSector.UseVisualStyleBackColor = true;
            this.btnAddSector.Click += new System.EventHandler(this.btnAddSector_Click);
            // 
            // lstSegments
            // 
            this.lstSegments.FormattingEnabled = true;
            this.lstSegments.Location = new System.Drawing.Point(10, 15);
            this.lstSegments.Name = "lstSegments";
            this.lstSegments.Size = new System.Drawing.Size(228, 186);
            this.lstSegments.TabIndex = 2;
            this.lstSegments.SelectedIndexChanged += new System.EventHandler(this.lstSegments_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNone);
            this.groupBox3.Controls.Add(this.rbWeakNoiseReduction);
            this.groupBox3.Controls.Add(this.rbStrongNoiseReduction);
            this.groupBox3.Location = new System.Drawing.Point(605, 549);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 94);
            this.groupBox3.TabIndex = 143;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Использовать шумоотчистку";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(46, 19);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(113, 17);
            this.rbNone.TabIndex = 2;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "Не использовать";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbWeakNoiseReduction
            // 
            this.rbWeakNoiseReduction.AutoSize = true;
            this.rbWeakNoiseReduction.Location = new System.Drawing.Point(46, 65);
            this.rbWeakNoiseReduction.Name = "rbWeakNoiseReduction";
            this.rbWeakNoiseReduction.Size = new System.Drawing.Size(62, 17);
            this.rbWeakNoiseReduction.TabIndex = 1;
            this.rbWeakNoiseReduction.Text = "Слабая";
            this.rbWeakNoiseReduction.UseVisualStyleBackColor = true;
            this.rbWeakNoiseReduction.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbStrongNoiseReduction
            // 
            this.rbStrongNoiseReduction.AutoSize = true;
            this.rbStrongNoiseReduction.Location = new System.Drawing.Point(46, 42);
            this.rbStrongNoiseReduction.Name = "rbStrongNoiseReduction";
            this.rbStrongNoiseReduction.Size = new System.Drawing.Size(95, 17);
            this.rbStrongNoiseReduction.TabIndex = 0;
            this.rbStrongNoiseReduction.Text = "Эффективная";
            this.rbStrongNoiseReduction.UseVisualStyleBackColor = true;
            this.rbStrongNoiseReduction.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(473, 651);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 142;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbReadability
            // 
            this.tbReadability.Location = new System.Drawing.Point(205, 653);
            this.tbReadability.Name = "tbReadability";
            this.tbReadability.ReadOnly = true;
            this.tbReadability.Size = new System.Drawing.Size(100, 20);
            this.tbReadability.TabIndex = 141;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 656);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 13);
            this.label19.TabIndex = 140;
            this.label19.Text = "Словесная разборчивость речи, %";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(281, 630);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 13);
            this.label20.TabIndex = 139;
            this.label20.Text = "Отношение сигнал/шум, дБ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(281, 578);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 13);
            this.label22.TabIndex = 137;
            this.label22.Text = "Уровень сигнала в КТ, дБ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(281, 552);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(169, 13);
            this.label23.TabIndex = 136;
            this.label23.Text = "Уровень сигнала источника, дБ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(244, 533);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 135;
            this.label24.Text = "8000";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(206, 533);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 134;
            this.label25.Text = "4000";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(168, 533);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 133;
            this.label26.Text = "2000";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(130, 533);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 132;
            this.label27.Text = "1000";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(98, 533);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 13);
            this.label28.TabIndex = 131;
            this.label28.Text = "500";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(60, 533);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 13);
            this.label29.TabIndex = 130;
            this.label29.Text = "250";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(22, 533);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 13);
            this.label30.TabIndex = 129;
            this.label30.Text = "125";
            // 
            // tbRatio8000
            // 
            this.tbRatio8000.Location = new System.Drawing.Point(243, 627);
            this.tbRatio8000.Name = "tbRatio8000";
            this.tbRatio8000.ReadOnly = true;
            this.tbRatio8000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio8000.TabIndex = 128;
            // 
            // tbRatio4000
            // 
            this.tbRatio4000.Location = new System.Drawing.Point(205, 627);
            this.tbRatio4000.Name = "tbRatio4000";
            this.tbRatio4000.ReadOnly = true;
            this.tbRatio4000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio4000.TabIndex = 127;
            // 
            // tbRatio2000
            // 
            this.tbRatio2000.Location = new System.Drawing.Point(167, 627);
            this.tbRatio2000.Name = "tbRatio2000";
            this.tbRatio2000.ReadOnly = true;
            this.tbRatio2000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio2000.TabIndex = 126;
            // 
            // tbRatio1000
            // 
            this.tbRatio1000.Location = new System.Drawing.Point(129, 627);
            this.tbRatio1000.Name = "tbRatio1000";
            this.tbRatio1000.ReadOnly = true;
            this.tbRatio1000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio1000.TabIndex = 125;
            // 
            // tbRatio500
            // 
            this.tbRatio500.Location = new System.Drawing.Point(91, 627);
            this.tbRatio500.Name = "tbRatio500";
            this.tbRatio500.ReadOnly = true;
            this.tbRatio500.Size = new System.Drawing.Size(32, 20);
            this.tbRatio500.TabIndex = 124;
            // 
            // tbRatio250
            // 
            this.tbRatio250.Location = new System.Drawing.Point(53, 627);
            this.tbRatio250.Name = "tbRatio250";
            this.tbRatio250.ReadOnly = true;
            this.tbRatio250.Size = new System.Drawing.Size(32, 20);
            this.tbRatio250.TabIndex = 123;
            // 
            // tbRatio125
            // 
            this.tbRatio125.Location = new System.Drawing.Point(15, 627);
            this.tbRatio125.Name = "tbRatio125";
            this.tbRatio125.ReadOnly = true;
            this.tbRatio125.Size = new System.Drawing.Size(32, 20);
            this.tbRatio125.TabIndex = 122;
            // 
            // tbSoundprofLevel8000
            // 
            this.tbSoundprofLevel8000.Location = new System.Drawing.Point(243, 575);
            this.tbSoundprofLevel8000.Name = "tbSoundprofLevel8000";
            this.tbSoundprofLevel8000.ReadOnly = true;
            this.tbSoundprofLevel8000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel8000.TabIndex = 114;
            // 
            // tbSoundprofLevel4000
            // 
            this.tbSoundprofLevel4000.Location = new System.Drawing.Point(205, 575);
            this.tbSoundprofLevel4000.Name = "tbSoundprofLevel4000";
            this.tbSoundprofLevel4000.ReadOnly = true;
            this.tbSoundprofLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel4000.TabIndex = 113;
            // 
            // tbSoundprofLevel2000
            // 
            this.tbSoundprofLevel2000.Location = new System.Drawing.Point(167, 575);
            this.tbSoundprofLevel2000.Name = "tbSoundprofLevel2000";
            this.tbSoundprofLevel2000.ReadOnly = true;
            this.tbSoundprofLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel2000.TabIndex = 112;
            // 
            // tbSoundprofLevel1000
            // 
            this.tbSoundprofLevel1000.Location = new System.Drawing.Point(129, 575);
            this.tbSoundprofLevel1000.Name = "tbSoundprofLevel1000";
            this.tbSoundprofLevel1000.ReadOnly = true;
            this.tbSoundprofLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel1000.TabIndex = 111;
            // 
            // tbSoundprofLevel500
            // 
            this.tbSoundprofLevel500.Location = new System.Drawing.Point(91, 575);
            this.tbSoundprofLevel500.Name = "tbSoundprofLevel500";
            this.tbSoundprofLevel500.ReadOnly = true;
            this.tbSoundprofLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel500.TabIndex = 110;
            // 
            // tbSoundprofLevel250
            // 
            this.tbSoundprofLevel250.Location = new System.Drawing.Point(53, 575);
            this.tbSoundprofLevel250.Name = "tbSoundprofLevel250";
            this.tbSoundprofLevel250.ReadOnly = true;
            this.tbSoundprofLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel250.TabIndex = 109;
            // 
            // tbSoundprofLevel125
            // 
            this.tbSoundprofLevel125.Location = new System.Drawing.Point(15, 575);
            this.tbSoundprofLevel125.Name = "tbSoundprofLevel125";
            this.tbSoundprofLevel125.ReadOnly = true;
            this.tbSoundprofLevel125.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel125.TabIndex = 108;
            // 
            // tbSignalLevel8000
            // 
            this.tbSignalLevel8000.Location = new System.Drawing.Point(243, 549);
            this.tbSignalLevel8000.Name = "tbSignalLevel8000";
            this.tbSignalLevel8000.ReadOnly = true;
            this.tbSignalLevel8000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel8000.TabIndex = 107;
            // 
            // tbSignalLevel4000
            // 
            this.tbSignalLevel4000.Location = new System.Drawing.Point(205, 549);
            this.tbSignalLevel4000.Name = "tbSignalLevel4000";
            this.tbSignalLevel4000.ReadOnly = true;
            this.tbSignalLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel4000.TabIndex = 106;
            // 
            // tbSignalLevel2000
            // 
            this.tbSignalLevel2000.Location = new System.Drawing.Point(167, 549);
            this.tbSignalLevel2000.Name = "tbSignalLevel2000";
            this.tbSignalLevel2000.ReadOnly = true;
            this.tbSignalLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel2000.TabIndex = 105;
            // 
            // tbSignalLevel1000
            // 
            this.tbSignalLevel1000.Location = new System.Drawing.Point(129, 549);
            this.tbSignalLevel1000.Name = "tbSignalLevel1000";
            this.tbSignalLevel1000.ReadOnly = true;
            this.tbSignalLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel1000.TabIndex = 104;
            // 
            // tbSignalLevel500
            // 
            this.tbSignalLevel500.Location = new System.Drawing.Point(91, 549);
            this.tbSignalLevel500.Name = "tbSignalLevel500";
            this.tbSignalLevel500.ReadOnly = true;
            this.tbSignalLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel500.TabIndex = 103;
            // 
            // tbSignalLevel250
            // 
            this.tbSignalLevel250.Location = new System.Drawing.Point(53, 549);
            this.tbSignalLevel250.Name = "tbSignalLevel250";
            this.tbSignalLevel250.ReadOnly = true;
            this.tbSignalLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel250.TabIndex = 102;
            // 
            // tbSignalLevel125
            // 
            this.tbSignalLevel125.Location = new System.Drawing.Point(15, 549);
            this.tbSignalLevel125.Name = "tbSignalLevel125";
            this.tbSignalLevel125.ReadOnly = true;
            this.tbSignalLevel125.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel125.TabIndex = 101;
            // 
            // tbNoiseLevel8000
            // 
            this.tbNoiseLevel8000.Location = new System.Drawing.Point(243, 601);
            this.tbNoiseLevel8000.Name = "tbNoiseLevel8000";
            this.tbNoiseLevel8000.ReadOnly = true;
            this.tbNoiseLevel8000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel8000.TabIndex = 121;
            // 
            // tbNoiseLevel4000
            // 
            this.tbNoiseLevel4000.Location = new System.Drawing.Point(205, 601);
            this.tbNoiseLevel4000.Name = "tbNoiseLevel4000";
            this.tbNoiseLevel4000.ReadOnly = true;
            this.tbNoiseLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel4000.TabIndex = 120;
            // 
            // tbNoiseLevel2000
            // 
            this.tbNoiseLevel2000.Location = new System.Drawing.Point(167, 601);
            this.tbNoiseLevel2000.Name = "tbNoiseLevel2000";
            this.tbNoiseLevel2000.ReadOnly = true;
            this.tbNoiseLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel2000.TabIndex = 119;
            // 
            // tbNoiseLevel1000
            // 
            this.tbNoiseLevel1000.Location = new System.Drawing.Point(129, 601);
            this.tbNoiseLevel1000.Name = "tbNoiseLevel1000";
            this.tbNoiseLevel1000.ReadOnly = true;
            this.tbNoiseLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel1000.TabIndex = 118;
            // 
            // tbNoiseLevel500
            // 
            this.tbNoiseLevel500.Location = new System.Drawing.Point(91, 601);
            this.tbNoiseLevel500.Name = "tbNoiseLevel500";
            this.tbNoiseLevel500.ReadOnly = true;
            this.tbNoiseLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel500.TabIndex = 117;
            // 
            // tbNoiseLevel250
            // 
            this.tbNoiseLevel250.Location = new System.Drawing.Point(53, 601);
            this.tbNoiseLevel250.Name = "tbNoiseLevel250";
            this.tbNoiseLevel250.ReadOnly = true;
            this.tbNoiseLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel250.TabIndex = 116;
            // 
            // tbNoiseLevel125
            // 
            this.tbNoiseLevel125.Location = new System.Drawing.Point(15, 601);
            this.tbNoiseLevel125.Name = "tbNoiseLevel125";
            this.tbNoiseLevel125.ReadOnly = true;
            this.tbNoiseLevel125.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel125.TabIndex = 115;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(281, 604);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 13);
            this.label21.TabIndex = 138;
            this.label21.Text = "Уровень шума, дБ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 13);
            this.label9.TabIndex = 144;
            this.label9.Text = "Расстояние от источника звука до вентиляционной решетки, м";
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(347, 66);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 20);
            this.tbDistance.TabIndex = 145;
            // 
            // FormVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(917, 678);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbReadability);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tbRatio8000);
            this.Controls.Add(this.tbRatio4000);
            this.Controls.Add(this.tbRatio2000);
            this.Controls.Add(this.tbRatio1000);
            this.Controls.Add(this.tbRatio500);
            this.Controls.Add(this.tbRatio250);
            this.Controls.Add(this.tbRatio125);
            this.Controls.Add(this.tbNoiseLevel8000);
            this.Controls.Add(this.tbNoiseLevel4000);
            this.Controls.Add(this.tbNoiseLevel2000);
            this.Controls.Add(this.tbNoiseLevel1000);
            this.Controls.Add(this.tbNoiseLevel500);
            this.Controls.Add(this.tbNoiseLevel250);
            this.Controls.Add(this.tbNoiseLevel125);
            this.Controls.Add(this.tbSoundprofLevel8000);
            this.Controls.Add(this.tbSoundprofLevel4000);
            this.Controls.Add(this.tbSoundprofLevel2000);
            this.Controls.Add(this.tbSoundprofLevel1000);
            this.Controls.Add(this.tbSoundprofLevel500);
            this.Controls.Add(this.tbSoundprofLevel250);
            this.Controls.Add(this.tbSoundprofLevel125);
            this.Controls.Add(this.tbSignalLevel8000);
            this.Controls.Add(this.tbSignalLevel4000);
            this.Controls.Add(this.tbSignalLevel2000);
            this.Controls.Add(this.tbSignalLevel1000);
            this.Controls.Add(this.tbSignalLevel500);
            this.Controls.Add(this.tbSignalLevel250);
            this.Controls.Add(this.tbSignalLevel125);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbSignalPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNoiseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSignalLevel);
            this.Controls.Add(this.label1);
            this.Name = "FormVent";
            this.Text = "Расчет уровня акустического сигнала в вентиляционном канале";
            this.Load += new System.EventHandler(this.FormVent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsorber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNoiseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSignalLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSignalPlace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNeighborVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvConsumers;
        private System.Windows.Forms.DataGridViewComboBoxColumn colConsumersSquare;
        private System.Windows.Forms.TextBox tbConsumersNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAbsorber;
        private System.Windows.Forms.TextBox tbAbsorbersNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbWeakNoiseReduction;
        private System.Windows.Forms.RadioButton rbStrongNoiseReduction;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbReadability;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbRatio8000;
        private System.Windows.Forms.TextBox tbRatio4000;
        private System.Windows.Forms.TextBox tbRatio2000;
        private System.Windows.Forms.TextBox tbRatio1000;
        private System.Windows.Forms.TextBox tbRatio500;
        private System.Windows.Forms.TextBox tbRatio250;
        private System.Windows.Forms.TextBox tbRatio125;
        private System.Windows.Forms.TextBox tbSoundprofLevel8000;
        private System.Windows.Forms.TextBox tbSoundprofLevel4000;
        private System.Windows.Forms.TextBox tbSoundprofLevel2000;
        private System.Windows.Forms.TextBox tbSoundprofLevel1000;
        private System.Windows.Forms.TextBox tbSoundprofLevel500;
        private System.Windows.Forms.TextBox tbSoundprofLevel250;
        private System.Windows.Forms.TextBox tbSoundprofLevel125;
        private System.Windows.Forms.TextBox tbSignalLevel8000;
        private System.Windows.Forms.TextBox tbSignalLevel4000;
        private System.Windows.Forms.TextBox tbSignalLevel2000;
        private System.Windows.Forms.TextBox tbSignalLevel1000;
        private System.Windows.Forms.TextBox tbSignalLevel500;
        private System.Windows.Forms.TextBox tbSignalLevel250;
        private System.Windows.Forms.TextBox tbSignalLevel125;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsorbSquare;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAbsorbRatio;
        private System.Windows.Forms.TextBox tbNoiseLevel8000;
        private System.Windows.Forms.TextBox tbNoiseLevel4000;
        private System.Windows.Forms.TextBox tbNoiseLevel2000;
        private System.Windows.Forms.TextBox tbNoiseLevel1000;
        private System.Windows.Forms.TextBox tbNoiseLevel500;
        private System.Windows.Forms.TextBox tbNoiseLevel250;
        private System.Windows.Forms.TextBox tbNoiseLevel125;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lstSegments;
        private System.Windows.Forms.Button btnEditSector;
        private System.Windows.Forms.Button btnRemoveSector;
        private System.Windows.Forms.Button btnAddSector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDistance;
    }
}