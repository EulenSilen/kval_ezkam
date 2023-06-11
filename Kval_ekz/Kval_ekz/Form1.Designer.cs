
namespace Kval_ekz
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edenicaizmereniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razmerdopustimoiskidkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvoditelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriyatovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekushayaskidkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnalichiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obuvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kval_ekzDataSet1 = new Kval_ekz.Kval_ekzDataSet1();
            this.kval_ekzDataSet = new Kval_ekz.Kval_ekzDataSet();
            this.kvalekzDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obuvTableAdapter = new Kval_ekz.Kval_ekzDataSet1TableAdapters.ObuvTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obuvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kval_ekzDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kval_ekzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalekzDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Личный кабинет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.edenicaizmereniyaDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.razmerdopustimoiskidkiDataGridViewTextBoxColumn,
            this.proizvoditelDataGridViewTextBoxColumn,
            this.postavshikDataGridViewTextBoxColumn,
            this.kategoriyatovaraDataGridViewTextBoxColumn,
            this.tekushayaskidkaDataGridViewTextBoxColumn,
            this.vnalichiiDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obuvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // articulDataGridViewTextBoxColumn
            // 
            this.articulDataGridViewTextBoxColumn.DataPropertyName = "Articul";
            this.articulDataGridViewTextBoxColumn.HeaderText = "Articul";
            this.articulDataGridViewTextBoxColumn.Name = "articulDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // edenicaizmereniyaDataGridViewTextBoxColumn
            // 
            this.edenicaizmereniyaDataGridViewTextBoxColumn.DataPropertyName = "Edenica_izmereniya";
            this.edenicaizmereniyaDataGridViewTextBoxColumn.HeaderText = "Edenica_izmereniya";
            this.edenicaizmereniyaDataGridViewTextBoxColumn.Name = "edenicaizmereniyaDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // razmerdopustimoiskidkiDataGridViewTextBoxColumn
            // 
            this.razmerdopustimoiskidkiDataGridViewTextBoxColumn.DataPropertyName = "Razmer_dopustimoi_skidki";
            this.razmerdopustimoiskidkiDataGridViewTextBoxColumn.HeaderText = "Razmer_dopustimoi_skidki";
            this.razmerdopustimoiskidkiDataGridViewTextBoxColumn.Name = "razmerdopustimoiskidkiDataGridViewTextBoxColumn";
            // 
            // proizvoditelDataGridViewTextBoxColumn
            // 
            this.proizvoditelDataGridViewTextBoxColumn.DataPropertyName = "Proizvoditel";
            this.proizvoditelDataGridViewTextBoxColumn.HeaderText = "Proizvoditel";
            this.proizvoditelDataGridViewTextBoxColumn.Name = "proizvoditelDataGridViewTextBoxColumn";
            // 
            // postavshikDataGridViewTextBoxColumn
            // 
            this.postavshikDataGridViewTextBoxColumn.DataPropertyName = "Postavshik";
            this.postavshikDataGridViewTextBoxColumn.HeaderText = "Postavshik";
            this.postavshikDataGridViewTextBoxColumn.Name = "postavshikDataGridViewTextBoxColumn";
            // 
            // kategoriyatovaraDataGridViewTextBoxColumn
            // 
            this.kategoriyatovaraDataGridViewTextBoxColumn.DataPropertyName = "Kategoriya_tovara";
            this.kategoriyatovaraDataGridViewTextBoxColumn.HeaderText = "Kategoriya_tovara";
            this.kategoriyatovaraDataGridViewTextBoxColumn.Name = "kategoriyatovaraDataGridViewTextBoxColumn";
            // 
            // tekushayaskidkaDataGridViewTextBoxColumn
            // 
            this.tekushayaskidkaDataGridViewTextBoxColumn.DataPropertyName = "tekushaya_skidka";
            this.tekushayaskidkaDataGridViewTextBoxColumn.HeaderText = "tekushaya_skidka";
            this.tekushayaskidkaDataGridViewTextBoxColumn.Name = "tekushayaskidkaDataGridViewTextBoxColumn";
            // 
            // vnalichiiDataGridViewTextBoxColumn
            // 
            this.vnalichiiDataGridViewTextBoxColumn.DataPropertyName = "V_nalichii";
            this.vnalichiiDataGridViewTextBoxColumn.HeaderText = "V_nalichii";
            this.vnalichiiDataGridViewTextBoxColumn.Name = "vnalichiiDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // obuvBindingSource
            // 
            this.obuvBindingSource.DataMember = "Obuv";
            this.obuvBindingSource.DataSource = this.kval_ekzDataSet1;
            // 
            // kval_ekzDataSet1
            // 
            this.kval_ekzDataSet1.DataSetName = "Kval_ekzDataSet1";
            this.kval_ekzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kval_ekzDataSet
            // 
            this.kval_ekzDataSet.DataSetName = "Kval_ekzDataSet";
            this.kval_ekzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvalekzDataSetBindingSource
            // 
            this.kvalekzDataSetBindingSource.DataSource = this.kval_ekzDataSet;
            this.kvalekzDataSetBindingSource.Position = 0;
            // 
            // obuvTableAdapter
            // 
            this.obuvTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "По возрастанию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "По убыванию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сортировать ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все диапазоны ",
            "0-9",
            "10-14",
            "15-оо"});
            this.comboBox1.Location = new System.Drawing.Point(247, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(267, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Скидки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(31, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 89);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 15);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(817, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "B320R5.jpg",
            "D329H3.jpg",
            "D572U8.jpg",
            "F572H7.jpg",
            "F635R4.jpg",
            "G432E4.jpg",
            "G783F5.jpg",
            "H782T5.jpg",
            "J384T6.jpg",
            "А112Т4.jpg"});
            this.comboBox2.Location = new System.Drawing.Point(690, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Просмотреть товар";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(690, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 26);
            this.panel3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1064, 403);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1080, 442);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obuvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kval_ekzDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kval_ekzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalekzDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kvalekzDataSetBindingSource;
        private Kval_ekzDataSet kval_ekzDataSet;
        private Kval_ekzDataSet1 kval_ekzDataSet1;
        private System.Windows.Forms.BindingSource obuvBindingSource;
        private Kval_ekzDataSet1TableAdapters.ObuvTableAdapter obuvTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edenicaizmereniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmerdopustimoiskidkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvoditelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriyatovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekushayaskidkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnalichiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}

