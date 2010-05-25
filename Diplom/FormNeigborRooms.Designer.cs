namespace Diplom
{
    partial class FormNeigborRooms
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSignalLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNoiseType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReflectors = new System.Windows.Forms.DataGridView();
            this.colReflectSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReflectMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbReflectorsNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRatio8000 = new System.Windows.Forms.TextBox();
            this.tbRatio4000 = new System.Windows.Forms.TextBox();
            this.tbRatio2000 = new System.Windows.Forms.TextBox();
            this.tbRatio1000 = new System.Windows.Forms.TextBox();
            this.tbRatio500 = new System.Windows.Forms.TextBox();
            this.tbRatio250 = new System.Windows.Forms.TextBox();
            this.tbRatio125 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel8000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel4000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel2000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel1000 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel500 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel250 = new System.Windows.Forms.TextBox();
            this.tbNoiseLevel125 = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbReadability = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNoNoiseReduction = new System.Windows.Forms.RadioButton();
            this.rbWeakNoiseReduction = new System.Windows.Forms.RadioButton();
            this.rbStrongNoiseReduction = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReflectors)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsorber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровень сигнала источника";
            // 
            // cbSignalLevel
            // 
            this.cbSignalLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalLevel.FormattingEnabled = true;
            this.cbSignalLevel.Location = new System.Drawing.Point(168, 6);
            this.cbSignalLevel.Name = "cbSignalLevel";
            this.cbSignalLevel.Size = new System.Drawing.Size(196, 21);
            this.cbSignalLevel.TabIndex = 1;
            this.cbSignalLevel.SelectedIndexChanged += new System.EventHandler(this.cbSignalLevel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид шума";
            // 
            // cbNoiseType
            // 
            this.cbNoiseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNoiseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNoiseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoiseType.FormattingEnabled = true;
            this.cbNoiseType.Location = new System.Drawing.Point(432, 6);
            this.cbNoiseType.Name = "cbNoiseType";
            this.cbNoiseType.Size = new System.Drawing.Size(292, 21);
            this.cbNoiseType.TabIndex = 3;
            this.cbNoiseType.SelectedIndexChanged += new System.EventHandler(this.cbNoiseType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReflectors);
            this.groupBox1.Controls.Add(this.tbReflectorsNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание составных частей ограждающей конструкции";
            // 
            // dgvReflectors
            // 
            this.dgvReflectors.AllowUserToAddRows = false;
            this.dgvReflectors.AllowUserToDeleteRows = false;
            this.dgvReflectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReflectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReflectSquare,
            this.colReflectMaterial});
            this.dgvReflectors.Location = new System.Drawing.Point(9, 47);
            this.dgvReflectors.Name = "dgvReflectors";
            this.dgvReflectors.RowHeadersVisible = false;
            this.dgvReflectors.Size = new System.Drawing.Size(863, 131);
            this.dgvReflectors.TabIndex = 2;
            // 
            // colReflectSquare
            // 
            this.colReflectSquare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReflectSquare.FillWeight = 50F;
            this.colReflectSquare.HeaderText = "Площадь составной части, м^2";
            this.colReflectSquare.Name = "colReflectSquare";
            // 
            // colReflectMaterial
            // 
            this.colReflectMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReflectMaterial.HeaderText = "Материал составной части";
            this.colReflectMaterial.Name = "colReflectMaterial";
            this.colReflectMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReflectMaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbReflectorsNumber
            // 
            this.tbReflectorsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReflectorsNumber.Location = new System.Drawing.Point(308, 21);
            this.tbReflectorsNumber.Name = "tbReflectorsNumber";
            this.tbReflectorsNumber.Size = new System.Drawing.Size(105, 20);
            this.tbReflectorsNumber.TabIndex = 1;
            this.tbReflectorsNumber.TextChanged += new System.EventHandler(this.tbReflectorsNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество составных частей отражающей конструкции";
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(15, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 219);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Описание смежного помещения";
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
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Тип смежного помещения";
            // 
            // tbNeighborVolume
            // 
            this.tbNeighborVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNeighborVolume.Location = new System.Drawing.Point(197, 166);
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
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Объем смежного помещения, м^3";
            // 
            // dgvConsumers
            // 
            this.dgvConsumers.AllowUserToAddRows = false;
            this.dgvConsumers.AllowUserToDeleteRows = false;
            this.dgvConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConsumersSquare});
            this.dgvConsumers.Location = new System.Drawing.Point(678, 44);
            this.dgvConsumers.Name = "dgvConsumers";
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
            this.dgvAbsorber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsorber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAbsorbSquare,
            this.colAbsorbRatio});
            this.dgvAbsorber.Location = new System.Drawing.Point(10, 44);
            this.dgvAbsorber.Name = "dgvAbsorber";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Количество звукопоглащающих поверхностей";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 563);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 13);
            this.label20.TabIndex = 96;
            this.label20.Text = "Отношение сигнал/шум, дБ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(280, 537);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 95;
            this.label19.Text = "Уровень шума, дБ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 511);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 13);
            this.label18.TabIndex = 94;
            this.label18.Text = "Уровень сигнала в КТ, дБ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 485);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 13);
            this.label17.TabIndex = 93;
            this.label17.Text = "Уровень сигнала источника, дБ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 466);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 92;
            this.label16.Text = "8000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(205, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "4000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(167, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "2000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "500";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "250";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "125";
            // 
            // tbRatio8000
            // 
            this.tbRatio8000.Location = new System.Drawing.Point(242, 560);
            this.tbRatio8000.Name = "tbRatio8000";
            this.tbRatio8000.ReadOnly = true;
            this.tbRatio8000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio8000.TabIndex = 85;
            // 
            // tbRatio4000
            // 
            this.tbRatio4000.Location = new System.Drawing.Point(204, 560);
            this.tbRatio4000.Name = "tbRatio4000";
            this.tbRatio4000.ReadOnly = true;
            this.tbRatio4000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio4000.TabIndex = 84;
            // 
            // tbRatio2000
            // 
            this.tbRatio2000.Location = new System.Drawing.Point(166, 560);
            this.tbRatio2000.Name = "tbRatio2000";
            this.tbRatio2000.ReadOnly = true;
            this.tbRatio2000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio2000.TabIndex = 83;
            // 
            // tbRatio1000
            // 
            this.tbRatio1000.Location = new System.Drawing.Point(128, 560);
            this.tbRatio1000.Name = "tbRatio1000";
            this.tbRatio1000.ReadOnly = true;
            this.tbRatio1000.Size = new System.Drawing.Size(32, 20);
            this.tbRatio1000.TabIndex = 82;
            // 
            // tbRatio500
            // 
            this.tbRatio500.Location = new System.Drawing.Point(90, 560);
            this.tbRatio500.Name = "tbRatio500";
            this.tbRatio500.ReadOnly = true;
            this.tbRatio500.Size = new System.Drawing.Size(32, 20);
            this.tbRatio500.TabIndex = 81;
            // 
            // tbRatio250
            // 
            this.tbRatio250.Location = new System.Drawing.Point(52, 560);
            this.tbRatio250.Name = "tbRatio250";
            this.tbRatio250.ReadOnly = true;
            this.tbRatio250.Size = new System.Drawing.Size(32, 20);
            this.tbRatio250.TabIndex = 80;
            // 
            // tbRatio125
            // 
            this.tbRatio125.Location = new System.Drawing.Point(14, 560);
            this.tbRatio125.Name = "tbRatio125";
            this.tbRatio125.ReadOnly = true;
            this.tbRatio125.Size = new System.Drawing.Size(32, 20);
            this.tbRatio125.TabIndex = 79;
            // 
            // tbNoiseLevel8000
            // 
            this.tbNoiseLevel8000.Location = new System.Drawing.Point(242, 534);
            this.tbNoiseLevel8000.Name = "tbNoiseLevel8000";
            this.tbNoiseLevel8000.ReadOnly = true;
            this.tbNoiseLevel8000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel8000.TabIndex = 78;
            // 
            // tbNoiseLevel4000
            // 
            this.tbNoiseLevel4000.Location = new System.Drawing.Point(204, 534);
            this.tbNoiseLevel4000.Name = "tbNoiseLevel4000";
            this.tbNoiseLevel4000.ReadOnly = true;
            this.tbNoiseLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel4000.TabIndex = 77;
            // 
            // tbNoiseLevel2000
            // 
            this.tbNoiseLevel2000.Location = new System.Drawing.Point(166, 534);
            this.tbNoiseLevel2000.Name = "tbNoiseLevel2000";
            this.tbNoiseLevel2000.ReadOnly = true;
            this.tbNoiseLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel2000.TabIndex = 76;
            // 
            // tbNoiseLevel1000
            // 
            this.tbNoiseLevel1000.Location = new System.Drawing.Point(128, 534);
            this.tbNoiseLevel1000.Name = "tbNoiseLevel1000";
            this.tbNoiseLevel1000.ReadOnly = true;
            this.tbNoiseLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel1000.TabIndex = 75;
            // 
            // tbNoiseLevel500
            // 
            this.tbNoiseLevel500.Location = new System.Drawing.Point(90, 534);
            this.tbNoiseLevel500.Name = "tbNoiseLevel500";
            this.tbNoiseLevel500.ReadOnly = true;
            this.tbNoiseLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel500.TabIndex = 74;
            // 
            // tbNoiseLevel250
            // 
            this.tbNoiseLevel250.Location = new System.Drawing.Point(52, 534);
            this.tbNoiseLevel250.Name = "tbNoiseLevel250";
            this.tbNoiseLevel250.ReadOnly = true;
            this.tbNoiseLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel250.TabIndex = 73;
            // 
            // tbNoiseLevel125
            // 
            this.tbNoiseLevel125.Location = new System.Drawing.Point(14, 534);
            this.tbNoiseLevel125.Name = "tbNoiseLevel125";
            this.tbNoiseLevel125.ReadOnly = true;
            this.tbNoiseLevel125.Size = new System.Drawing.Size(32, 20);
            this.tbNoiseLevel125.TabIndex = 72;
            // 
            // tbSoundprofLevel8000
            // 
            this.tbSoundprofLevel8000.Location = new System.Drawing.Point(242, 508);
            this.tbSoundprofLevel8000.Name = "tbSoundprofLevel8000";
            this.tbSoundprofLevel8000.ReadOnly = true;
            this.tbSoundprofLevel8000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel8000.TabIndex = 71;
            // 
            // tbSoundprofLevel4000
            // 
            this.tbSoundprofLevel4000.Location = new System.Drawing.Point(204, 508);
            this.tbSoundprofLevel4000.Name = "tbSoundprofLevel4000";
            this.tbSoundprofLevel4000.ReadOnly = true;
            this.tbSoundprofLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel4000.TabIndex = 70;
            // 
            // tbSoundprofLevel2000
            // 
            this.tbSoundprofLevel2000.Location = new System.Drawing.Point(166, 508);
            this.tbSoundprofLevel2000.Name = "tbSoundprofLevel2000";
            this.tbSoundprofLevel2000.ReadOnly = true;
            this.tbSoundprofLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel2000.TabIndex = 69;
            // 
            // tbSoundprofLevel1000
            // 
            this.tbSoundprofLevel1000.Location = new System.Drawing.Point(128, 508);
            this.tbSoundprofLevel1000.Name = "tbSoundprofLevel1000";
            this.tbSoundprofLevel1000.ReadOnly = true;
            this.tbSoundprofLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel1000.TabIndex = 68;
            // 
            // tbSoundprofLevel500
            // 
            this.tbSoundprofLevel500.Location = new System.Drawing.Point(90, 508);
            this.tbSoundprofLevel500.Name = "tbSoundprofLevel500";
            this.tbSoundprofLevel500.ReadOnly = true;
            this.tbSoundprofLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel500.TabIndex = 67;
            // 
            // tbSoundprofLevel250
            // 
            this.tbSoundprofLevel250.Location = new System.Drawing.Point(52, 508);
            this.tbSoundprofLevel250.Name = "tbSoundprofLevel250";
            this.tbSoundprofLevel250.ReadOnly = true;
            this.tbSoundprofLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel250.TabIndex = 66;
            // 
            // tbSoundprofLevel125
            // 
            this.tbSoundprofLevel125.Location = new System.Drawing.Point(14, 508);
            this.tbSoundprofLevel125.Name = "tbSoundprofLevel125";
            this.tbSoundprofLevel125.ReadOnly = true;
            this.tbSoundprofLevel125.Size = new System.Drawing.Size(32, 20);
            this.tbSoundprofLevel125.TabIndex = 65;
            // 
            // tbSignalLevel8000
            // 
            this.tbSignalLevel8000.Location = new System.Drawing.Point(242, 482);
            this.tbSignalLevel8000.Name = "tbSignalLevel8000";
            this.tbSignalLevel8000.ReadOnly = true;
            this.tbSignalLevel8000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel8000.TabIndex = 64;
            // 
            // tbSignalLevel4000
            // 
            this.tbSignalLevel4000.Location = new System.Drawing.Point(204, 482);
            this.tbSignalLevel4000.Name = "tbSignalLevel4000";
            this.tbSignalLevel4000.ReadOnly = true;
            this.tbSignalLevel4000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel4000.TabIndex = 63;
            // 
            // tbSignalLevel2000
            // 
            this.tbSignalLevel2000.Location = new System.Drawing.Point(166, 482);
            this.tbSignalLevel2000.Name = "tbSignalLevel2000";
            this.tbSignalLevel2000.ReadOnly = true;
            this.tbSignalLevel2000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel2000.TabIndex = 62;
            // 
            // tbSignalLevel1000
            // 
            this.tbSignalLevel1000.Location = new System.Drawing.Point(128, 482);
            this.tbSignalLevel1000.Name = "tbSignalLevel1000";
            this.tbSignalLevel1000.ReadOnly = true;
            this.tbSignalLevel1000.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel1000.TabIndex = 61;
            // 
            // tbSignalLevel500
            // 
            this.tbSignalLevel500.Location = new System.Drawing.Point(90, 482);
            this.tbSignalLevel500.Name = "tbSignalLevel500";
            this.tbSignalLevel500.ReadOnly = true;
            this.tbSignalLevel500.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel500.TabIndex = 60;
            // 
            // tbSignalLevel250
            // 
            this.tbSignalLevel250.Location = new System.Drawing.Point(52, 482);
            this.tbSignalLevel250.Name = "tbSignalLevel250";
            this.tbSignalLevel250.ReadOnly = true;
            this.tbSignalLevel250.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel250.TabIndex = 59;
            // 
            // tbSignalLevel125
            // 
            this.tbSignalLevel125.Location = new System.Drawing.Point(14, 482);
            this.tbSignalLevel125.Name = "tbSignalLevel125";
            this.tbSignalLevel125.ReadOnly = true;
            this.tbSignalLevel125.Size = new System.Drawing.Size(32, 20);
            this.tbSignalLevel125.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Словесная разборчивость речи, %";
            // 
            // tbReadability
            // 
            this.tbReadability.Location = new System.Drawing.Point(204, 586);
            this.tbReadability.Name = "tbReadability";
            this.tbReadability.ReadOnly = true;
            this.tbReadability.Size = new System.Drawing.Size(100, 20);
            this.tbReadability.TabIndex = 98;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(472, 584);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 99;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNoNoiseReduction);
            this.groupBox3.Controls.Add(this.rbWeakNoiseReduction);
            this.groupBox3.Controls.Add(this.rbStrongNoiseReduction);
            this.groupBox3.Location = new System.Drawing.Point(604, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 94);
            this.groupBox3.TabIndex = 100;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Использовать шумоотчистку";
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
            this.rbNoNoiseReduction.CheckedChanged += new System.EventHandler(this.rbStrongNoiseReduction_CheckedChanged);
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
            this.rbWeakNoiseReduction.CheckedChanged += new System.EventHandler(this.rbStrongNoiseReduction_CheckedChanged);
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
            this.rbStrongNoiseReduction.CheckedChanged += new System.EventHandler(this.rbStrongNoiseReduction_CheckedChanged);
            // 
            // FormNeigborRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(920, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbReadability);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNoiseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSignalLevel);
            this.Controls.Add(this.label1);
            this.Name = "FormNeigborRooms";
            this.Text = "Расчет уровня акустического сигнала в смежных помещениях";
            this.Load += new System.EventHandler(this.FormNeigborRooms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReflectors)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsorber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSignalLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNoiseType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbReflectorsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReflectors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAbsorbersNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAbsorber;
        private System.Windows.Forms.DataGridView dgvConsumers;
        private System.Windows.Forms.TextBox tbConsumersNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNeighborVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRatio8000;
        private System.Windows.Forms.TextBox tbRatio4000;
        private System.Windows.Forms.TextBox tbRatio2000;
        private System.Windows.Forms.TextBox tbRatio1000;
        private System.Windows.Forms.TextBox tbRatio500;
        private System.Windows.Forms.TextBox tbRatio250;
        private System.Windows.Forms.TextBox tbRatio125;
        private System.Windows.Forms.TextBox tbNoiseLevel8000;
        private System.Windows.Forms.TextBox tbNoiseLevel4000;
        private System.Windows.Forms.TextBox tbNoiseLevel2000;
        private System.Windows.Forms.TextBox tbNoiseLevel1000;
        private System.Windows.Forms.TextBox tbNoiseLevel500;
        private System.Windows.Forms.TextBox tbNoiseLevel250;
        private System.Windows.Forms.TextBox tbNoiseLevel125;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbReadability;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colConsumersSquare;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbWeakNoiseReduction;
        private System.Windows.Forms.RadioButton rbStrongNoiseReduction;
        private System.Windows.Forms.RadioButton rbNoNoiseReduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReflectSquare;
        private System.Windows.Forms.DataGridViewComboBoxColumn colReflectMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsorbSquare;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAbsorbRatio;
    }
}