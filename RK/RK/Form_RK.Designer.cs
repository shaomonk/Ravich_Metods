namespace RK
{
    partial class Form_RK
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщитьОПроблемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиПредложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbPK = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbTf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoiler = new System.Windows.Forms.ComboBox();
            this.boilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezhimKardDB = new RK.RezhimKardDB();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boilergabaritwatergazzhidkoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataResult = new System.Windows.Forms.DataGridView();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRas = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbQsn = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGwater = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPair = new System.Windows.Forms.TextBox();
            this.tbPb = new System.Windows.Forms.TextBox();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbQn = new System.Windows.Forms.TextBox();
            this.tbCO2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNO2 = new System.Windows.Forms.TextBox();
            this.tbCH4 = new System.Windows.Forms.TextBox();
            this.tbCO = new System.Windows.Forms.TextBox();
            this.tbYgaz = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.fuelTableAdapter = new RK.RezhimKardDBTableAdapters.fuelTableAdapter();
            this.charzhidkoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.char_zhidkoeTableAdapter = new RK.RezhimKardDBTableAdapters.char_zhidkoeTableAdapter();
            this.boilerTableAdapter = new RK.RezhimKardDBTableAdapters.boilerTableAdapter();
            this.boilerboilergabaritsteamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boiler_gabarit_steamTableAdapter = new RK.RezhimKardDBTableAdapters.boiler_gabarit_steamTableAdapter();
            this.boilergabaritsteamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boiler_gabarit_water_gaz_zhidkoeTableAdapter = new RK.RezhimKardDBTableAdapters.boiler_gabarit_water_gaz_zhidkoeTableAdapter();
            this.dataResult1 = new System.Windows.Forms.DataGridView();
            this.Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezhimKardDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilergabaritwatergazzhidkoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charzhidkoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilerboilergabaritsteamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilergabaritsteamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.инфоToolStripMenuItem,
            this.контактыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчетToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // рассчетToolStripMenuItem
            // 
            this.рассчетToolStripMenuItem.Name = "рассчетToolStripMenuItem";
            this.рассчетToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рассчетToolStripMenuItem.Text = "Расчет";
            this.рассчетToolStripMenuItem.Click += new System.EventHandler(this.рассчетToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.базаДанныхToolStripMenuItem});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.программаToolStripMenuItem.Text = "Программа";
            this.программаToolStripMenuItem.Click += new System.EventHandler(this.программаToolStripMenuItem_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиБДToolStripMenuItem,
            this.поискПоБДToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.базаДанныхToolStripMenuItem.Text = "База Данных";
            // 
            // вывестиБДToolStripMenuItem
            // 
            this.вывестиБДToolStripMenuItem.Name = "вывестиБДToolStripMenuItem";
            this.вывестиБДToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.вывестиБДToolStripMenuItem.Text = "Вывести БД";
            this.вывестиБДToolStripMenuItem.Click += new System.EventHandler(this.вывестиБДToolStripMenuItem_Click);
            // 
            // поискПоБДToolStripMenuItem
            // 
            this.поискПоБДToolStripMenuItem.Name = "поискПоБДToolStripMenuItem";
            this.поискПоБДToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.поискПоБДToolStripMenuItem.Text = "Справка по БД";
            this.поискПоБДToolStripMenuItem.Click += new System.EventHandler(this.поискПоБДToolStripMenuItem_Click);
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сообщитьОПроблемеToolStripMenuItem,
            this.внестиПредложениеToolStripMenuItem,
            this.контактнаяИнформацияToolStripMenuItem});
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.контактыToolStripMenuItem.Text = "Справка";
            // 
            // сообщитьОПроблемеToolStripMenuItem
            // 
            this.сообщитьОПроблемеToolStripMenuItem.Name = "сообщитьОПроблемеToolStripMenuItem";
            this.сообщитьОПроблемеToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.сообщитьОПроблемеToolStripMenuItem.Text = "Сообщить о проблеме";
            this.сообщитьОПроблемеToolStripMenuItem.Click += new System.EventHandler(this.сообщитьОПроблемеToolStripMenuItem_Click);
            // 
            // внестиПредложениеToolStripMenuItem
            // 
            this.внестиПредложениеToolStripMenuItem.Name = "внестиПредложениеToolStripMenuItem";
            this.внестиПредложениеToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.внестиПредложениеToolStripMenuItem.Text = "Внести предложение";
            this.внестиПредложениеToolStripMenuItem.Click += new System.EventHandler(this.внестиПредложениеToolStripMenuItem_Click);
            // 
            // контактнаяИнформацияToolStripMenuItem
            // 
            this.контактнаяИнформацияToolStripMenuItem.Name = "контактнаяИнформацияToolStripMenuItem";
            this.контактнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.контактнаяИнформацияToolStripMenuItem.Text = "Контактная информация";
            this.контактнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.контактнаяИнформацияToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.tbPK);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.tbTf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbF);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBoiler);
            this.groupBox1.Controls.Add(this.cmbFuel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            this.groupBox1.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(181, 101);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "МВт";
            // 
            // tbPK
            // 
            this.tbPK.Location = new System.Drawing.Point(98, 98);
            this.tbPK.Name = "tbPK";
            this.tbPK.Size = new System.Drawing.Size(77, 20);
            this.tbPK.TabIndex = 8;
            this.tbPK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(181, 170);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "*С";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Температура \r\nПНК";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(181, 134);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "м2";
            // 
            // tbTf
            // 
            this.tbTf.Location = new System.Drawing.Point(98, 167);
            this.tbTf.Name = "tbTf";
            this.tbTf.Size = new System.Drawing.Size(78, 20);
            this.tbTf.TabIndex = 18;
            this.tbTf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Площадь ПНК";
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(98, 131);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(78, 20);
            this.tbF.TabIndex = 17;
            this.tbF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 26);
            this.label12.TabIndex = 7;
            this.label12.Text = "Мощность \r\nкотла";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(91, 204);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(121, 32);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Далее";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип котлов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Топливо";
            // 
            // cmbBoiler
            // 
            this.cmbBoiler.DataSource = this.boilerBindingSource;
            this.cmbBoiler.DisplayMember = "Boiler";
            this.cmbBoiler.FormattingEnabled = true;
            this.cmbBoiler.Location = new System.Drawing.Point(91, 61);
            this.cmbBoiler.Name = "cmbBoiler";
            this.cmbBoiler.Size = new System.Drawing.Size(121, 21);
            this.cmbBoiler.TabIndex = 1;
            // 
            // boilerBindingSource
            // 
            this.boilerBindingSource.DataMember = "boiler";
            this.boilerBindingSource.DataSource = this.rezhimKardDB;
            // 
            // rezhimKardDB
            // 
            this.rezhimKardDB.DataSetName = "RezhimKardDB";
            this.rezhimKardDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFuel
            // 
            this.cmbFuel.DataSource = this.fuelBindingSource;
            this.cmbFuel.DisplayMember = "Fuel";
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(91, 25);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(121, 21);
            this.cmbFuel.TabIndex = 0;
            // 
            // fuelBindingSource
            // 
            this.fuelBindingSource.DataMember = "fuel";
            this.fuelBindingSource.DataSource = this.rezhimKardDB;
            // 
            // boilergabaritwatergazzhidkoeBindingSource
            // 
            this.boilergabaritwatergazzhidkoeBindingSource.DataMember = "boiler_gabarit_water_gaz/zhidkoe";
            this.boilergabaritwatergazzhidkoeBindingSource.DataSource = this.rezhimKardDB;
            // 
            // dataResult
            // 
            this.dataResult.AllowUserToAddRows = false;
            this.dataResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResult.Location = new System.Drawing.Point(892, 209);
            this.dataResult.Name = "dataResult";
            this.dataResult.RowTemplate.Height = 25;
            this.dataResult.Size = new System.Drawing.Size(673, 250);
            this.dataResult.TabIndex = 19;
            this.dataResult.Visible = false;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "Result";
            this.resultBindingSource.DataSource = this.rezhimKardDB;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Данная программа предназначена для расчета режимно-наладочных\r\nиспытаний котлоагр" +
    "егата и определения его номинальных и расчетных\r\nпараметров";
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbout.Location = new System.Drawing.Point(12, 379);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(223, 53);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "Справка";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRas
            // 
            this.btnRas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRas.Location = new System.Drawing.Point(241, 379);
            this.btnRas.Name = "btnRas";
            this.btnRas.Size = new System.Drawing.Size(219, 52);
            this.btnRas.TabIndex = 4;
            this.btnRas.Text = "Расчет";
            this.btnRas.UseVisualStyleBackColor = true;
            this.btnRas.Visible = false;
            this.btnRas.Click += new System.EventHandler(this.btnRas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.tbQsn);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbGwater);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbPair);
            this.groupBox3.Controls.Add(this.tbPb);
            this.groupBox3.Controls.Add(this.tbFuel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbQn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(241, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 255);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Константы";
            this.groupBox3.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(174, 210);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "кДж";
            // 
            // tbQsn
            // 
            this.tbQsn.Location = new System.Drawing.Point(111, 207);
            this.tbQsn.Name = "tbQsn";
            this.tbQsn.Size = new System.Drawing.Size(57, 20);
            this.tbQsn.TabIndex = 8;
            this.tbQsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(172, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "*С";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 26);
            this.label22.TabIndex = 7;
            this.label22.Text = "Расход на соб.\r\n нужды";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(172, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "*С";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(172, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "м3/ч";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(172, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "кДж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Температура \r\nвоздуха";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(174, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "м3/ч";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Рабочая темпера-\r\nтура топлива";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Расход топлива";
            // 
            // tbGwater
            // 
            this.tbGwater.Location = new System.Drawing.Point(111, 165);
            this.tbGwater.Name = "tbGwater";
            this.tbGwater.Size = new System.Drawing.Size(57, 20);
            this.tbGwater.TabIndex = 2;
            this.tbGwater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Низшая теплота\r\nсгорания топл.";
            // 
            // tbPair
            // 
            this.tbPair.Location = new System.Drawing.Point(111, 126);
            this.tbPair.Name = "tbPair";
            this.tbPair.Size = new System.Drawing.Size(57, 20);
            this.tbPair.TabIndex = 2;
            this.tbPair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // tbPb
            // 
            this.tbPb.Location = new System.Drawing.Point(111, 92);
            this.tbPb.Name = "tbPb";
            this.tbPb.Size = new System.Drawing.Size(57, 20);
            this.tbPb.TabIndex = 2;
            this.tbPb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // tbFuel
            // 
            this.tbFuel.Location = new System.Drawing.Point(111, 62);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.Size = new System.Drawing.Size(57, 20);
            this.tbFuel.TabIndex = 1;
            this.tbFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Расход воды";
            // 
            // tbQn
            // 
            this.tbQn.Location = new System.Drawing.Point(111, 28);
            this.tbQn.Name = "tbQn";
            this.tbQn.Size = new System.Drawing.Size(57, 20);
            this.tbQn.TabIndex = 0;
            this.tbQn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // tbCO2
            // 
            this.tbCO2.Location = new System.Drawing.Point(116, 25);
            this.tbCO2.Name = "tbCO2";
            this.tbCO2.Size = new System.Drawing.Size(56, 20);
            this.tbCO2.TabIndex = 2;
            this.tbCO2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Содержание СО2";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(716, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbNO2);
            this.groupBox4.Controls.Add(this.tbCH4);
            this.groupBox4.Controls.Add(this.tbCO);
            this.groupBox4.Controls.Add(this.tbCO2);
            this.groupBox4.Controls.Add(this.tbYgaz);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(466, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 255);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Переменные";
            this.groupBox4.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(178, 225);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "*С";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Содержание NO2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Содержание СН4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Содержание СО";
            // 
            // tbNO2
            // 
            this.tbNO2.Location = new System.Drawing.Point(116, 121);
            this.tbNO2.Name = "tbNO2";
            this.tbNO2.Size = new System.Drawing.Size(56, 20);
            this.tbNO2.TabIndex = 2;
            this.tbNO2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // tbCH4
            // 
            this.tbCH4.Location = new System.Drawing.Point(116, 87);
            this.tbCH4.Name = "tbCH4";
            this.tbCH4.Size = new System.Drawing.Size(56, 20);
            this.tbCH4.TabIndex = 2;
            this.tbCH4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // tbCO
            // 
            this.tbCO.Location = new System.Drawing.Point(116, 55);
            this.tbCO.Name = "tbCO";
            this.tbCO.Size = new System.Drawing.Size(56, 20);
            this.tbCO.TabIndex = 2;
            this.tbCO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // tbYgaz
            // 
            this.tbYgaz.Location = new System.Drawing.Point(115, 222);
            this.tbYgaz.Name = "tbYgaz";
            this.tbYgaz.Size = new System.Drawing.Size(57, 20);
            this.tbYgaz.TabIndex = 2;
            this.tbYgaz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Т ух газов";
            // 
            // btnRetry
            // 
            this.btnRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRetry.Location = new System.Drawing.Point(466, 379);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(219, 53);
            this.btnRetry.TabIndex = 15;
            this.btnRetry.Text = "Расчет на другой нагрузке";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(691, 379);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(195, 52);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Вывести отчет";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // fuelTableAdapter
            // 
            this.fuelTableAdapter.ClearBeforeFill = true;
            // 
            // charzhidkoeBindingSource
            // 
            this.charzhidkoeBindingSource.DataMember = "char_zhidkoe";
            this.charzhidkoeBindingSource.DataSource = this.rezhimKardDB;
            // 
            // char_zhidkoeTableAdapter
            // 
            this.char_zhidkoeTableAdapter.ClearBeforeFill = true;
            // 
            // boilerTableAdapter
            // 
            this.boilerTableAdapter.ClearBeforeFill = true;
            // 
            // boilerboilergabaritsteamBindingSource
            // 
            this.boilerboilergabaritsteamBindingSource.DataMember = "boilerboiler_gabarit_steam";
            this.boilerboilergabaritsteamBindingSource.DataSource = this.boilerBindingSource;
            // 
            // boiler_gabarit_steamTableAdapter
            // 
            this.boiler_gabarit_steamTableAdapter.ClearBeforeFill = true;
            // 
            // boilergabaritsteamBindingSource
            // 
            this.boilergabaritsteamBindingSource.DataMember = "boiler_gabarit_steam";
            this.boilergabaritsteamBindingSource.DataSource = this.rezhimKardDB;
            // 
            // boiler_gabarit_water_gaz_zhidkoeTableAdapter
            // 
            this.boiler_gabarit_water_gaz_zhidkoeTableAdapter.ClearBeforeFill = true;
            // 
            // dataResult1
            // 
            this.dataResult1.AllowUserToAddRows = false;
            this.dataResult1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataResult1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResult1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fuel,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataResult1.Location = new System.Drawing.Point(103, 451);
            this.dataResult1.Name = "dataResult1";
            this.dataResult1.Size = new System.Drawing.Size(668, 271);
            this.dataResult1.TabIndex = 19;
            this.dataResult1.Visible = false;
            // 
            // Fuel
            // 
            this.Fuel.HeaderText = "Расход топлива";
            this.Fuel.Name = "Fuel";
            this.Fuel.Width = 103;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RO2max";
            this.Column2.Name = "Column2";
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Коэф Kh";
            this.Column3.Name = "Column3";
            this.Column3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Коэф alpha";
            this.Column4.Name = "Column4";
            this.Column4.Width = 81;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Объем ПС";
            this.Column5.Name = "Column5";
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Q2";
            this.Column6.Name = "Column6";
            this.Column6.Width = 46;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Q3";
            this.Column7.Name = "Column7";
            this.Column7.Width = 46;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Q5";
            this.Column8.Name = "Column8";
            this.Column8.Width = 46;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "КПДбрутто";
            this.Column9.Name = "Column9";
            this.Column9.Width = 89;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Уд расход";
            this.Column10.Name = "Column10";
            this.Column10.Width = 78;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Расход усл";
            this.Column11.Name = "Column11";
            this.Column11.Width = 81;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.SpringGreen;
            this.label28.Location = new System.Drawing.Point(535, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(150, 44);
            this.label28.TabIndex = 20;
            this.label28.Text = "label28";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(178, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "%";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(178, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "%";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(178, 90);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "%";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(178, 124);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(16, 13);
            this.label32.TabIndex = 10;
            this.label32.Text = "%";
            // 
            // Form_RK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RK.Properties.Resources.fon5;
            this.ClientSize = new System.Drawing.Size(899, 497);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dataResult1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnRas);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_RK";
            this.Text = "Rezhim Kard";
            this.Load += new System.EventHandler(this.Form_RK_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezhimKardDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilergabaritwatergazzhidkoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charzhidkoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilerboilergabaritsteamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilergabaritsteamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoiler;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRas;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCO2;
        private System.Windows.Forms.TextBox tbGwater;
        private System.Windows.Forms.TextBox tbPair;
        private System.Windows.Forms.TextBox tbPb;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.TextBox tbQn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbYgaz;
        private System.Windows.Forms.TextBox tbNO2;
        private System.Windows.Forms.TextBox tbCH4;
        private System.Windows.Forms.TextBox tbCO;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbQsn;
        private System.Windows.Forms.Label label22;
        private RezhimKardDB rezhimKardDB;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private RezhimKardDBTableAdapters.fuelTableAdapter fuelTableAdapter;
        private System.Windows.Forms.BindingSource charzhidkoeBindingSource;
        private RezhimKardDBTableAdapters.char_zhidkoeTableAdapter char_zhidkoeTableAdapter;
        private System.Windows.Forms.BindingSource boilerBindingSource;
        private RezhimKardDBTableAdapters.boilerTableAdapter boilerTableAdapter;
        private System.Windows.Forms.BindingSource boilerboilergabaritsteamBindingSource;
        private RezhimKardDBTableAdapters.boiler_gabarit_steamTableAdapter boiler_gabarit_steamTableAdapter;
        private System.Windows.Forms.BindingSource boilergabaritsteamBindingSource;
        private System.Windows.Forms.BindingSource boilergabaritwatergazzhidkoeBindingSource;
        private RezhimKardDBTableAdapters.boiler_gabarit_water_gaz_zhidkoeTableAdapter boiler_gabarit_water_gaz_zhidkoeTableAdapter;
        private System.Windows.Forms.DataGridView dataResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbPK;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.DataGridView dataResult1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.ToolStripMenuItem сообщитьОПроблемеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиПредложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
    }
}

