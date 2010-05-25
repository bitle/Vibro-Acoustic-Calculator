namespace Diplom
{
    partial class FormAddAcoustickKT
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVent = new System.Windows.Forms.RadioButton();
            this.rbNeighor = new System.Windows.Forms.RadioButton();
            this.rbOutside = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbVibro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(67, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(158, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVibro);
            this.groupBox1.Controls.Add(this.rbVent);
            this.groupBox1.Controls.Add(this.rbNeighor);
            this.groupBox1.Controls.Add(this.rbOutside);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расположение КТ";
            // 
            // rbVent
            // 
            this.rbVent.AutoSize = true;
            this.rbVent.Location = new System.Drawing.Point(6, 65);
            this.rbVent.Name = "rbVent";
            this.rbVent.Size = new System.Drawing.Size(151, 17);
            this.rbVent.TabIndex = 2;
            this.rbVent.Text = "В вентиляционной шахте";
            this.rbVent.UseVisualStyleBackColor = true;
            // 
            // rbNeighor
            // 
            this.rbNeighor.AutoSize = true;
            this.rbNeighor.Location = new System.Drawing.Point(6, 42);
            this.rbNeighor.Name = "rbNeighor";
            this.rbNeighor.Size = new System.Drawing.Size(145, 17);
            this.rbNeighor.TabIndex = 1;
            this.rbNeighor.Text = "В смежном помещении";
            this.rbNeighor.UseVisualStyleBackColor = true;
            // 
            // rbOutside
            // 
            this.rbOutside.AutoSize = true;
            this.rbOutside.Checked = true;
            this.rbOutside.Location = new System.Drawing.Point(6, 19);
            this.rbOutside.Name = "rbOutside";
            this.rbOutside.Size = new System.Drawing.Size(71, 17);
            this.rbOutside.TabIndex = 0;
            this.rbOutside.TabStop = true;
            this.rbOutside.Text = "На улице";
            this.rbOutside.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbVibro
            // 
            this.rbVibro.AutoSize = true;
            this.rbVibro.Location = new System.Drawing.Point(6, 88);
            this.rbVibro.Name = "rbVibro";
            this.rbVibro.Size = new System.Drawing.Size(102, 17);
            this.rbVibro.TabIndex = 3;
            this.rbVibro.TabStop = true;
            this.rbVibro.Text = "Виброакустика";
            this.rbVibro.UseVisualStyleBackColor = true;
            // 
            // FormAddAcoustickKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 187);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddAcoustickKT";
            this.Text = "Добавление КТ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVent;
        private System.Windows.Forms.RadioButton rbNeighor;
        private System.Windows.Forms.RadioButton rbOutside;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbVibro;
    }
}