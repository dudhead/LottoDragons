namespace lottery
{
    partial class Form1
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
            //if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.MonthCalendar();
            this.res_tbx = new System.Windows.Forms.TextBox();
            this.draw_time = new System.Windows.Forms.ComboBox();
            this.gamtyp_grpbx = new System.Windows.Forms.GroupBox();
            this.pick5_radbtn = new System.Windows.Forms.RadioButton();
            this.pick4_radbtn = new System.Windows.Forms.RadioButton();
            this.pick3_radbtn = new System.Windows.Forms.RadioButton();
            this.hide_lbl = new System.Windows.Forms.Label();
            this.drw_tm = new System.Windows.Forms.Label();
            this.sav_btn = new System.Windows.Forms.Button();
            this.Clr_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.max_num_txt = new System.Windows.Forms.TextBox();
            this.col4_txt = new System.Windows.Forms.TextBox();
            this.col3_txt = new System.Windows.Forms.TextBox();
            this.col2_txt = new System.Windows.Forms.TextBox();
            this.col1_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.col5_txt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pick5radio = new System.Windows.Forms.RadioButton();
            this.pick4radio = new System.Windows.Forms.RadioButton();
            this.pick3radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lottoDragonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.results_lbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gamtyp_grpbx.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 520);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.res_tbx);
            this.tabPage1.Controls.Add(this.draw_time);
            this.tabPage1.Controls.Add(this.gamtyp_grpbx);
            this.tabPage1.Controls.Add(this.hide_lbl);
            this.tabPage1.Controls.Add(this.drw_tm);
            this.tabPage1.Controls.Add(this.sav_btn);
            this.tabPage1.Controls.Add(this.Clr_btn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DATA ENTRY";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 69);
            this.button2.TabIndex = 27;
            this.button2.Text = "CLEAR HISTORY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 240);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(10);
            this.dateTimePicker1.MaxSelectionCount = 1;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowToday = false;
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateTimePicker1_DateChanged);
            // 
            // res_tbx
            // 
            this.res_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_tbx.Location = new System.Drawing.Point(216, 278);
            this.res_tbx.MaxLength = 3;
            this.res_tbx.Name = "res_tbx";
            this.res_tbx.Size = new System.Drawing.Size(116, 21);
            this.res_tbx.TabIndex = 1;
            // 
            // draw_time
            // 
            this.draw_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.draw_time.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.draw_time.FormattingEnabled = true;
            this.draw_time.Items.AddRange(new object[] {
            "evening",
            "mid day"});
            this.draw_time.Location = new System.Drawing.Point(472, 162);
            this.draw_time.MaxDropDownItems = 3;
            this.draw_time.Name = "draw_time";
            this.draw_time.Size = new System.Drawing.Size(140, 23);
            this.draw_time.TabIndex = 10;
            // 
            // gamtyp_grpbx
            // 
            this.gamtyp_grpbx.Controls.Add(this.pick5_radbtn);
            this.gamtyp_grpbx.Controls.Add(this.pick4_radbtn);
            this.gamtyp_grpbx.Controls.Add(this.pick3_radbtn);
            this.gamtyp_grpbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamtyp_grpbx.Location = new System.Drawing.Point(52, 60);
            this.gamtyp_grpbx.Name = "gamtyp_grpbx";
            this.gamtyp_grpbx.Size = new System.Drawing.Size(280, 82);
            this.gamtyp_grpbx.TabIndex = 26;
            this.gamtyp_grpbx.TabStop = false;
            this.gamtyp_grpbx.Text = "game type";
            // 
            // pick5_radbtn
            // 
            this.pick5_radbtn.AutoSize = true;
            this.pick5_radbtn.Location = new System.Drawing.Point(182, 42);
            this.pick5_radbtn.Name = "pick5_radbtn";
            this.pick5_radbtn.Size = new System.Drawing.Size(61, 20);
            this.pick5_radbtn.TabIndex = 2;
            this.pick5_radbtn.Text = "pick 5";
            this.pick5_radbtn.UseVisualStyleBackColor = true;
            this.pick5_radbtn.CheckedChanged += new System.EventHandler(this.pick5_radbtn_CheckedChanged);
            // 
            // pick4_radbtn
            // 
            this.pick4_radbtn.AutoSize = true;
            this.pick4_radbtn.Location = new System.Drawing.Point(111, 42);
            this.pick4_radbtn.Name = "pick4_radbtn";
            this.pick4_radbtn.Size = new System.Drawing.Size(61, 20);
            this.pick4_radbtn.TabIndex = 1;
            this.pick4_radbtn.Text = "pick 4";
            this.pick4_radbtn.UseVisualStyleBackColor = true;
            this.pick4_radbtn.CheckedChanged += new System.EventHandler(this.pick4_radbtn_CheckedChanged);
            // 
            // pick3_radbtn
            // 
            this.pick3_radbtn.AutoSize = true;
            this.pick3_radbtn.Checked = true;
            this.pick3_radbtn.Location = new System.Drawing.Point(29, 42);
            this.pick3_radbtn.Name = "pick3_radbtn";
            this.pick3_radbtn.Size = new System.Drawing.Size(61, 20);
            this.pick3_radbtn.TabIndex = 0;
            this.pick3_radbtn.TabStop = true;
            this.pick3_radbtn.Text = "pick 3";
            this.pick3_radbtn.UseVisualStyleBackColor = true;
            this.pick3_radbtn.CheckedChanged += new System.EventHandler(this.pick3_radbtn_CheckedChanged);
            // 
            // hide_lbl
            // 
            this.hide_lbl.AutoSize = true;
            this.hide_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide_lbl.Location = new System.Drawing.Point(84, 290);
            this.hide_lbl.Name = "hide_lbl";
            this.hide_lbl.Size = new System.Drawing.Size(112, 16);
            this.hide_lbl.TabIndex = 20;
            this.hide_lbl.Text = "ENTER RESULT";
            // 
            // drw_tm
            // 
            this.drw_tm.AutoSize = true;
            this.drw_tm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drw_tm.Location = new System.Drawing.Point(346, 171);
            this.drw_tm.Name = "drw_tm";
            this.drw_tm.Size = new System.Drawing.Size(85, 16);
            this.drw_tm.TabIndex = 19;
            this.drw_tm.Text = "DRAW TIME";
            // 
            // sav_btn
            // 
            this.sav_btn.Location = new System.Drawing.Point(797, 159);
            this.sav_btn.Name = "sav_btn";
            this.sav_btn.Size = new System.Drawing.Size(118, 38);
            this.sav_btn.TabIndex = 11;
            this.sav_btn.Text = "save";
            this.sav_btn.UseVisualStyleBackColor = true;
            this.sav_btn.Click += new System.EventHandler(this.sav_btn_Click);
            // 
            // Clr_btn
            // 
            this.Clr_btn.Enabled = false;
            this.Clr_btn.Location = new System.Drawing.Point(797, 204);
            this.Clr_btn.Name = "Clr_btn";
            this.Clr_btn.Size = new System.Drawing.Size(118, 38);
            this.Clr_btn.TabIndex = 16;
            this.Clr_btn.Text = "clear";
            this.Clr_btn.UseVisualStyleBackColor = true;
            this.Clr_btn.Visible = false;
            this.Clr_btn.Click += new System.EventHandler(this.Clr_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.max_num_txt);
            this.groupBox2.Controls.Add(this.col4_txt);
            this.groupBox2.Controls.Add(this.col3_txt);
            this.groupBox2.Controls.Add(this.col2_txt);
            this.groupBox2.Controls.Add(this.col1_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.col5_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 156);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "super lotto";
            this.groupBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 25);
            this.button3.TabIndex = 28;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "value";
            // 
            // max_num_txt
            // 
            this.max_num_txt.Location = new System.Drawing.Point(141, 33);
            this.max_num_txt.MaxLength = 2;
            this.max_num_txt.Name = "max_num_txt";
            this.max_num_txt.Size = new System.Drawing.Size(33, 21);
            this.max_num_txt.TabIndex = 4;
            // 
            // col4_txt
            // 
            this.col4_txt.Location = new System.Drawing.Point(258, 75);
            this.col4_txt.MaxLength = 2;
            this.col4_txt.Name = "col4_txt";
            this.col4_txt.Size = new System.Drawing.Size(33, 21);
            this.col4_txt.TabIndex = 8;
            // 
            // col3_txt
            // 
            this.col3_txt.Location = new System.Drawing.Point(216, 75);
            this.col3_txt.MaxLength = 2;
            this.col3_txt.Name = "col3_txt";
            this.col3_txt.Size = new System.Drawing.Size(33, 21);
            this.col3_txt.TabIndex = 7;
            // 
            // col2_txt
            // 
            this.col2_txt.Location = new System.Drawing.Point(174, 75);
            this.col2_txt.MaxLength = 2;
            this.col2_txt.Name = "col2_txt";
            this.col2_txt.Size = new System.Drawing.Size(33, 21);
            this.col2_txt.TabIndex = 6;
            // 
            // col1_txt
            // 
            this.col1_txt.Location = new System.Drawing.Point(132, 75);
            this.col1_txt.MaxLength = 2;
            this.col1_txt.Name = "col1_txt";
            this.col1_txt.Size = new System.Drawing.Size(33, 21);
            this.col1_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "MAX NUMBER";
            // 
            // col5_txt
            // 
            this.col5_txt.Location = new System.Drawing.Point(300, 75);
            this.col5_txt.MaxLength = 2;
            this.col5_txt.Name = "col5_txt";
            this.col5_txt.Size = new System.Drawing.Size(33, 21);
            this.col5_txt.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GENERATE";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click_1);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(77, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "RESULTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(778, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "TICKETS ENTERED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(488, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "BEST COMBINATIONS";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView3.Location = new System.Drawing.Point(712, 94);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(311, 379);
            this.dataGridView3.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 41);
            this.button4.TabIndex = 33;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(16, 302);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(208, 184);
            this.listBox2.TabIndex = 32;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(441, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 379);
            this.listBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "NEXT DRAWING";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "SOURCE";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "evening",
            "mid day"});
            this.comboBox2.Location = new System.Drawing.Point(148, 228);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "evening",
            "mid day"});
            this.comboBox1.Location = new System.Drawing.Point(148, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pick5radio);
            this.groupBox1.Controls.Add(this.pick4radio);
            this.groupBox1.Controls.Add(this.pick3radio);
            this.groupBox1.Location = new System.Drawing.Point(38, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 104);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GAME TYPE";
            // 
            // pick5radio
            // 
            this.pick5radio.AutoSize = true;
            this.pick5radio.Location = new System.Drawing.Point(182, 42);
            this.pick5radio.Name = "pick5radio";
            this.pick5radio.Size = new System.Drawing.Size(61, 20);
            this.pick5radio.TabIndex = 3;
            this.pick5radio.Text = "pick 5";
            this.pick5radio.UseVisualStyleBackColor = true;
            this.pick5radio.CheckedChanged += new System.EventHandler(this.pick5radio_CheckedChanged);
            // 
            // pick4radio
            // 
            this.pick4radio.AutoSize = true;
            this.pick4radio.Location = new System.Drawing.Point(111, 42);
            this.pick4radio.Name = "pick4radio";
            this.pick4radio.Size = new System.Drawing.Size(61, 20);
            this.pick4radio.TabIndex = 1;
            this.pick4radio.Text = "pick 4";
            this.pick4radio.UseVisualStyleBackColor = true;
            this.pick4radio.CheckedChanged += new System.EventHandler(this.pick4radio_CheckedChanged);
            // 
            // pick3radio
            // 
            this.pick3radio.AutoSize = true;
            this.pick3radio.Checked = true;
            this.pick3radio.Location = new System.Drawing.Point(29, 42);
            this.pick3radio.Name = "pick3radio";
            this.pick3radio.Size = new System.Drawing.Size(61, 20);
            this.pick3radio.TabIndex = 0;
            this.pick3radio.TabStop = true;
            this.pick3radio.Text = "pick 3";
            this.pick3radio.UseVisualStyleBackColor = true;
            this.pick3radio.CheckedChanged += new System.EventHandler(this.pick3radio_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.error_lbl.Location = new System.Drawing.Point(162, 44);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 20);
            this.error_lbl.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Checked = true;
            this.exitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationToolStripMenuItem});
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Tag = "";
            this.exitToolStripMenuItem.Text = "&FILE";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitApplicationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitApplicationToolStripMenuItem.ShowShortcutKeys = false;
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.exitApplicationToolStripMenuItem.Text = "&EXIT";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lottoDragonsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "ABOUT";
            // 
            // lottoDragonsToolStripMenuItem
            // 
            this.lottoDragonsToolStripMenuItem.Name = "lottoDragonsToolStripMenuItem";
            this.lottoDragonsToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.lottoDragonsToolStripMenuItem.Text = "Lotto Dragons-True Alignment v.1.0";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // results_lbl
            // 
            this.results_lbl.AutoSize = true;
            this.results_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.results_lbl.Location = new System.Drawing.Point(46, 44);
            this.results_lbl.Name = "results_lbl";
            this.results_lbl.Size = new System.Drawing.Size(92, 20);
            this.results_lbl.TabIndex = 33;
            this.results_lbl.Text = "RESULTS :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1124, 658);
            this.Controls.Add(this.results_lbl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto Dragons-True Alignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gamtyp_grpbx.ResumeLayout(false);
            this.gamtyp_grpbx.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox res_tbx;
        private System.Windows.Forms.ComboBox draw_time;
        private System.Windows.Forms.GroupBox gamtyp_grpbx;
        private System.Windows.Forms.RadioButton pick4_radbtn;
        private System.Windows.Forms.RadioButton pick3_radbtn;
        private System.Windows.Forms.Label hide_lbl;
        private System.Windows.Forms.Label drw_tm;
        private System.Windows.Forms.Button sav_btn;
        private System.Windows.Forms.Button Clr_btn;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.MonthCalendar dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pick4radio;
        private System.Windows.Forms.RadioButton pick3radio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton pick5_radbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox max_num_txt;
        private System.Windows.Forms.TextBox col4_txt;
        private System.Windows.Forms.TextBox col3_txt;
        private System.Windows.Forms.TextBox col2_txt;
        private System.Windows.Forms.TextBox col1_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox col5_txt;
        private System.Windows.Forms.RadioButton pick5radio;
        private System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lottoDragonsToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label results_lbl;
    }
}

