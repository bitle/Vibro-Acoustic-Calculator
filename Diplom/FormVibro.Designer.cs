namespace Diplom
{
    partial class FormVibro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSignalPlace = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSignalLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tbAbsorbersNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRatio4000 = new System.Windows.Forms.TextBox();
            this.tbRatio2000 = new System.Windows.Forms.TextBox();
            this.tbRatio1000 = new System.Windows.Forms.TextBox();
            this.tbRatio500 = new System.Windows.Forms.TextBox();
            this.tbRatio250 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel4000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel2000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel1000 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel500 = new System.Windows.Forms.TextBox();
            this.tbSoundprofLevel250 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel4000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel2000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel1000 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel500 = new System.Windows.Forms.TextBox();
            this.tbSignalLevel250 = new System.Windows.Forms.TextBox();
            this.tbReadability = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbNoNoiseReduction = new System.Windows.Forms.RadioButton();
            this.rbWeakNoiseReduction = new System.Windows.Forms.RadioButton();
            this.rbStrongNoiseReduction = new System.Windows.Forms.RadioButton();
            this.colAbsorbSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsorbRatio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsorber)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSignalPlace
            // 
            this.cbSignalPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalPlace.FormattingEnabled = true;
            this.cbSignalPlace.Items.AddRange(new object[] {
            "В центре помещения",
            "Вблизи одной из стен помещения",
            "В углу помещения"});
            this.cbSignalPlace.Location = new System.Drawing.Point(198, 39);
            this.cbSignalPlace.Name = "cbSignalPlace";
            this.cbSignalPlace.Size = new System.Drawing.Size(248, 21);
            this.cbSignalPlace.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Расположение источника сигнала";
            // 
            // cbSignalLevel
            // 
            this.cbSignalLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalLevel.FormattingEnabled = true;
            this.cbSignalLevel.Location = new System.Drawing.Point(167, 12);
            this.cbSignalLevel.Name = "cbSignalLevel";
            this.cbSignalLevel.Size = new System.Drawing.Size(196, 21);
            this.cbSignalLevel.TabIndex = 11;
            this.cbSignalLevel.SelectedIndexChanged += new System.EventHandler(this.cbSignalLevel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Уровень сигнала источника";
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(368, 66);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 20);
            this.tbDistance.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Расстояние от источника сигнала до ограждающей конструкции, м";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 219);
            this.groupBox2.TabIndex = 16;
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
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConsumersSquare});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsumers.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvConsumers.Location = new System.Drawing.Point(678, 44);
            this.dgvConsumers.Name = "dgvConsumers";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumers.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
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
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsorber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvAbsorber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsorber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAbsorbSquare,
            this.colAbsorbRatio});
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsorber.DefaultCellStyle = dataGridViewCellStyle41;
            this.dgvAbsorber.Location = new System.Drawing.Point(10, 44);
            this.dgvAbsorber.Name = "dgvAbsorber";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsorber.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvAbsorber.RowHeadersVisible = false;
            this.dgvAbsorber.Size = new System.Drawing.Size(662, 116);
            this.dgvAbsorber.TabIndex = 2;
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
            // cbMaterial
            // 
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(221, 317);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(388, 21);
            this.cbMaterial.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Материал ограждающей конструкции";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(293, 413);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 13);
            this.label20.TabIndex = 96;
            this.label20.Text = "Отношение сигнал/шум, дБ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(293, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(264, 13);
            this.label18.TabIndex = 94;
            this.label18.Text = "Уровень сигнала у ограждающей конструкции, дБ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(293, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 13);
            this.label17.TabIndex = 93;
            this.label17.Text = "Уровень сигнала источника, дБ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(218, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "4000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "2000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "500";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "250";
            // 
            // tbRatio4000
            // 
            this.tbRatio4000.Location = new System.Drawing.Point(217, 410);
            this.tbRatio4000.Name = "tbRatio4000";
            this.tbRatio4000.ReadOnly = true;
            this.tbRatio4000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio4000.TabIndex = 84;
            // 
            // tbRatio2000
            // 
            this.tbRatio2000.Location = new System.Drawing.Point(179, 410);
            this.tbRatio2000.Name = "tbRatio2000";
            this.tbRatio2000.ReadOnly = true;
            this.tbRatio2000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio2000.TabIndex = 83;
            // 
            // tbRatio1000
            // 
            this.tbRatio1000.Location = new System.Drawing.Point(141, 410);
            this.tbRatio1000.Name = "tbRatio1000";
            this.tbRatio1000.ReadOnly = true;
            this.tbRatio1000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio1000.TabIndex = 82;
            // 
            // tbRatio500
            // 
            this.tbRatio500.Location = new System.Drawing.Point(103, 410);
            this.tbRatio500.Name = "tbRatio500";
            this.tbRatio500.ReadOnly = true;
            this.tbRatio500.Size = new System.Drawing.Size(32, 20);
            this.tbRatio500.TabIndex = 81;
            // 
            // tbRatio250
            // 
            this.tbRatio250.Location = new System.Drawing.Point(65, 410);
            this.tbRatio250.Name = "tbRatio250";
            this.tbRatio250.ReadOnly = true;
            this.tbRatio250.Size = new System.Drawing.Size(32, 20);
            this.tbRatio250.TabIndex = 80;
            // 
            // tbSoundprofLevel4000
            // 
            this.tbSoundprofLevel4000.Location = new System.Drawing.Point(217, 384);
            this.tbSoundprofLevel4000.Name = "tbSoundprofLevel4000";
            this.tbSoundprofLevel4000.ReadOnly = true;
            this.tbSoundprofLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel4000.TabIndex = 70;
            // 
            // tbSoundprofLevel2000
            // 
            this.tbSoundprofLevel2000.Location = new System.Drawing.Point(179, 384);
            this.tbSoundprofLevel2000.Name = "tbSoundprofLevel2000";
            this.tbSoundprofLevel2000.ReadOnly = true;
            this.tbSoundprofLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel2000.TabIndex = 69;
            // 
            // tbSoundprofLevel1000
            // 
            this.tbSoundprofLevel1000.Location = new System.Drawing.Point(141, 384);
            this.tbSoundprofLevel1000.Name = "tbSoundprofLevel1000";
            this.tbSoundprofLevel1000.ReadOnly = true;
            this.tbSoundprofLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel1000.TabIndex = 68;
            // 
            // tbSoundprofLevel500
            // 
            this.tbSoundprofLevel500.Location = new System.Drawing.Point(103, 384);
            this.tbSoundprofLevel500.Name = "tbSoundprofLevel500";
            this.tbSoundprofLevel500.ReadOnly = true;
            this.tbSoundprofLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel500.TabIndex = 67;
            // 
            // tbSoundprofLevel250
            // 
            this.tbSoundprofLevel250.Location = new System.Drawing.Point(65, 384);
            this.tbSoundprofLevel250.Name = "tbSoundprofLevel250";
            this.tbSoundprofLevel250.ReadOnly = true;
            this.tbSoundprofLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel250.TabIndex = 66;
            // 
            // tbSignalLevel4000
            // 
            this.tbSignalLevel4000.Location = new System.Drawing.Point(217, 358);
            this.tbSignalLevel4000.Name = "tbSignalLevel4000";
            this.tbSignalLevel4000.ReadOnly = true;
            this.tbSignalLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel4000.TabIndex = 63;
            // 
            // tbSignalLevel2000
            // 
            this.tbSignalLevel2000.Location = new System.Drawing.Point(179, 358);
            this.tbSignalLevel2000.Name = "tbSignalLevel2000";
            this.tbSignalLevel2000.ReadOnly = true;
            this.tbSignalLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel2000.TabIndex = 62;
            // 
            // tbSignalLevel1000
            // 
            this.tbSignalLevel1000.Location = new System.Drawing.Point(141, 358);
            this.tbSignalLevel1000.Name = "tbSignalLevel1000";
            this.tbSignalLevel1000.ReadOnly = true;
            this.tbSignalLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel1000.TabIndex = 61;
            // 
            // tbSignalLevel500
            // 
            this.tbSignalLevel500.Location = new System.Drawing.Point(103, 358);
            this.tbSignalLevel500.Name = "tbSignalLevel500";
            this.tbSignalLevel500.ReadOnly = true;
            this.tbSignalLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel500.TabIndex = 60;
            // 
            // tbSignalLevel250
            // 
            this.tbSignalLevel250.Location = new System.Drawing.Point(65, 358);
            this.tbSignalLevel250.Name = "tbSignalLevel250";
            this.tbSignalLevel250.ReadOnly = true;
            this.tbSignalLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel250.TabIndex = 59;
            // 
            // tbReadability
            // 
            this.tbReadability.Location = new System.Drawing.Point(215, 436);
            this.tbReadability.Name = "tbReadability";
            this.tbReadability.ReadOnly = true;
            this.tbReadability.Size = new System.Drawing.Size(100, 20);
            this.tbReadability.TabIndex = 103;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 439);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(181, 13);
            this.label21.TabIndex = 102;
            this.label21.Text = "Словесная разборчивость речи, %";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(321, 434);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 101;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbNoNoiseReduction);
            this.groupBox4.Controls.Add(this.rbWeakNoiseReduction);
            this.groupBox4.Controls.Add(this.rbStrongNoiseReduction);
            this.groupBox4.Location = new System.Drawing.Point(563, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 94);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Использовать шумоотчистку";
            // 
            // rbNoNoiseReduction
            // 
            this.rbNoNoiseReduction.AutoSize = true;
            this.rbNoNoiseReduction.Checked = true;
            this.rbNoNoiseReduction.Location = new System.Drawing.Point(46, 19);
            this.rbNoNoiseReduction.Name = "rbNoNoiseReduction";
            this.rbNoNoiseReduction.Size = new System.Drawing.Size(113, 17);
            this.rbNoNoiseReduction.TabIndex = 2;
            this.rbNoNoiseReduction.TabStop = true;
            this.rbNoNoiseReduction.Text = "Не использовать";
            this.rbNoNoiseReduction.UseVisualStyleBackColor = true;
            this.rbNoNoiseReduction.CheckedChanged += new System.EventHandler(this.rbNoNoiseReduction_CheckedChanged);
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
            this.rbWeakNoiseReduction.CheckedChanged += new System.EventHandler(this.rbNoNoiseReduction_CheckedChanged);
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
            this.rbStrongNoiseReduction.CheckedChanged += new System.EventHandler(this.rbNoNoiseReduction_CheckedChanged);
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
            // FormVibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tbReadability);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbRatio4000);
            this.Controls.Add(this.tbRatio2000);
            this.Controls.Add(this.tbRatio1000);
            this.Controls.Add(this.tbRatio500);
            this.Controls.Add(this.tbRatio250);
            this.Controls.Add(this.tbSoundprofLevel4000);
            this.Controls.Add(this.tbSoundprofLevel2000);
            this.Controls.Add(this.tbSoundprofLevel1000);
            this.Controls.Add(this.tbSoundprofLevel500);
            this.Controls.Add(this.tbSoundprofLevel250);
            this.Controls.Add(this.tbSignalLevel4000);
            this.Controls.Add(this.tbSignalLevel2000);
            this.Controls.Add(this.tbSignalLevel1000);
            this.Controls.Add(this.tbSignalLevel500);
            this.Controls.Add(this.tbSignalLevel250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSignalPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSignalLevel);
            this.Controls.Add(this.label1);
            this.Name = "FormVibro";
            this.Text = "Расчет уровня виброакустического сигнала в ограждающих конструкциях";
            this.Load += new System.EventHandler(this.FormVibro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsorber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSignalPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSignalLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRatio4000;
        private System.Windows.Forms.TextBox tbRatio2000;
        private System.Windows.Forms.TextBox tbRatio1000;
        private System.Windows.Forms.TextBox tbRatio500;
        private System.Windows.Forms.TextBox tbRatio250;
        private System.Windows.Forms.TextBox tbSoundprofLevel4000;
        private System.Windows.Forms.TextBox tbSoundprofLevel2000;
        private System.Windows.Forms.TextBox tbSoundprofLevel1000;
        private System.Windows.Forms.TextBox tbSoundprofLevel500;
        private System.Windows.Forms.TextBox tbSoundprofLevel250;
        private System.Windows.Forms.TextBox tbSignalLevel4000;
        private System.Windows.Forms.TextBox tbSignalLevel2000;
        private System.Windows.Forms.TextBox tbSignalLevel1000;
        private System.Windows.Forms.TextBox tbSignalLevel500;
        private System.Windows.Forms.TextBox tbSignalLevel250;
        private System.Windows.Forms.TextBox tbReadability;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbNoNoiseReduction;
        private System.Windows.Forms.RadioButton rbWeakNoiseReduction;
        private System.Windows.Forms.RadioButton rbStrongNoiseReduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsorbSquare;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAbsorbRatio;
    }
}