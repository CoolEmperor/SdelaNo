namespace СделаНо
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butExit = new Guna.UI2.WinForms.Guna2Button();
            this.data1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.идСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделаНоDataSet = new СделаНо.СделаНоDataSet();
            this.сотрудникTableAdapter = new СделаНо.СделаНоDataSetTableAdapters.СотрудникTableAdapter();
            this.labelFIO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textFIO = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.butAdd = new Guna.UI2.WinForms.Guna2Button();
            this.butEdit = new Guna.UI2.WinForms.Guna2Button();
            this.butDelete = new Guna.UI2.WinForms.Guna2Button();
            this.butSort = new Guna.UI2.WinForms.Guna2Button();
            this.butFind = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxSort2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFindFam = new Guna.UI2.WinForms.Guna2TextBox();
            this.butClear = new Guna.UI2.WinForms.Guna2Button();
            this.butAll = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 70);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1089, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Бугай Дмитрий Александрович";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(899, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Администратор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастерская \"СделаНо\"";
            // 
            // butExit
            // 
            this.butExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butExit.FillColor = System.Drawing.Color.PeachPuff;
            this.butExit.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.Color.Black;
            this.butExit.Location = new System.Drawing.Point(1239, 748);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(249, 40);
            this.butExit.TabIndex = 11;
            this.butExit.Text = "Выход из программы";
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.data1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.AutoGenerateColumns = false;
            this.data1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.data1.ColumnHeadersHeight = 35;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идСотрудникаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.data1.DataSource = this.сотрудникBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle15;
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(18, 87);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1021, 701);
            this.data1.TabIndex = 12;
            this.data1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data1.ThemeStyle.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.data1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data1.ThemeStyle.HeaderStyle.Height = 35;
            this.data1.ThemeStyle.ReadOnly = true;
            this.data1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.data1.ThemeStyle.RowsStyle.Height = 24;
            this.data1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // идСотрудникаDataGridViewTextBoxColumn
            // 
            this.идСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ИдСотрудника";
            this.идСотрудникаDataGridViewTextBoxColumn.HeaderText = "ИдСотрудника";
            this.идСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идСотрудникаDataGridViewTextBoxColumn.Name = "идСотрудникаDataGridViewTextBoxColumn";
            this.идСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идСотрудникаDataGridViewTextBoxColumn.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            this.рольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIO.Location = new System.Drawing.Point(1066, 108);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(55, 24);
            this.labelFIO.TabIndex = 13;
            this.labelFIO.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1066, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1066, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1066, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Роль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1066, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Телефон:";
            // 
            // textFIO
            // 
            this.textFIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFIO.DefaultText = "";
            this.textFIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textFIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textFIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textFIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textFIO.FillColor = System.Drawing.Color.Gainsboro;
            this.textFIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textFIO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFIO.ForeColor = System.Drawing.Color.Red;
            this.textFIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textFIO.Location = new System.Drawing.Point(1172, 108);
            this.textFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFIO.Name = "textFIO";
            this.textFIO.PasswordChar = '\0';
            this.textFIO.PlaceholderText = "";
            this.textFIO.SelectedText = "";
            this.textFIO.Size = new System.Drawing.Size(304, 36);
            this.textFIO.TabIndex = 24;
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.Transparent;
            this.comboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboRole.ItemHeight = 30;
            this.comboRole.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Мастер"});
            this.comboRole.Location = new System.Drawing.Point(1171, 239);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(305, 36);
            this.comboRole.TabIndex = 25;
            // 
            // textLogin
            // 
            this.textLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLogin.DefaultText = "";
            this.textLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.FillColor = System.Drawing.Color.Gainsboro;
            this.textLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.ForeColor = System.Drawing.Color.Red;
            this.textLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Location = new System.Drawing.Point(1172, 152);
            this.textLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLogin.Name = "textLogin";
            this.textLogin.PasswordChar = '\0';
            this.textLogin.PlaceholderText = "";
            this.textLogin.SelectedText = "";
            this.textLogin.Size = new System.Drawing.Size(304, 36);
            this.textLogin.TabIndex = 26;
            // 
            // textPass
            // 
            this.textPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPass.DefaultText = "";
            this.textPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.FillColor = System.Drawing.Color.Gainsboro;
            this.textPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.Color.Red;
            this.textPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.Location = new System.Drawing.Point(1172, 196);
            this.textPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '\0';
            this.textPass.PlaceholderText = "";
            this.textPass.SelectedText = "";
            this.textPass.Size = new System.Drawing.Size(304, 36);
            this.textPass.TabIndex = 27;
            // 
            // textTel
            // 
            this.textTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTel.DefaultText = "+375";
            this.textTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTel.FillColor = System.Drawing.Color.Gainsboro;
            this.textTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTel.ForeColor = System.Drawing.Color.Red;
            this.textTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTel.Location = new System.Drawing.Point(1172, 282);
            this.textTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTel.Name = "textTel";
            this.textTel.PasswordChar = '\0';
            this.textTel.PlaceholderText = "";
            this.textTel.SelectedText = "";
            this.textTel.Size = new System.Drawing.Size(304, 36);
            this.textTel.TabIndex = 28;
            // 
            // butAdd
            // 
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.PeachPuff;
            this.butAdd.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.Black;
            this.butAdd.Location = new System.Drawing.Point(1172, 375);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(237, 36);
            this.butAdd.TabIndex = 29;
            this.butAdd.Text = "Добавить";
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butEdit.FillColor = System.Drawing.Color.PeachPuff;
            this.butEdit.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.ForeColor = System.Drawing.Color.Black;
            this.butEdit.Location = new System.Drawing.Point(1172, 417);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(237, 36);
            this.butEdit.TabIndex = 30;
            this.butEdit.Text = "Редактировать";
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDelete.FillColor = System.Drawing.Color.PeachPuff;
            this.butDelete.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.Color.Black;
            this.butDelete.Location = new System.Drawing.Point(1172, 459);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(237, 36);
            this.butDelete.TabIndex = 31;
            this.butDelete.Text = "Удалить";
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSort
            // 
            this.butSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSort.FillColor = System.Drawing.Color.PeachPuff;
            this.butSort.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSort.ForeColor = System.Drawing.Color.Black;
            this.butSort.Location = new System.Drawing.Point(1172, 561);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(237, 43);
            this.butSort.TabIndex = 32;
            this.butSort.Text = "Сортировать по ФИО";
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butFind
            // 
            this.butFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFind.FillColor = System.Drawing.Color.PeachPuff;
            this.butFind.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.Black;
            this.butFind.Location = new System.Drawing.Point(1104, 668);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(172, 30);
            this.butFind.TabIndex = 33;
            this.butFind.Text = "Поиск по ФИО";
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // comboBoxSort2
            // 
            this.comboBoxSort2.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSort2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSort2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSort2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSort2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSort2.ItemHeight = 30;
            this.comboBoxSort2.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.comboBoxSort2.Location = new System.Drawing.Point(1170, 510);
            this.comboBoxSort2.Name = "comboBoxSort2";
            this.comboBoxSort2.Size = new System.Drawing.Size(305, 36);
            this.comboBoxSort2.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1078, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Порядок:";
            // 
            // textBoxFindFam
            // 
            this.textBoxFindFam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFindFam.DefaultText = "";
            this.textBoxFindFam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFindFam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFindFam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFindFam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFindFam.FillColor = System.Drawing.Color.Gainsboro;
            this.textBoxFindFam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFindFam.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindFam.ForeColor = System.Drawing.Color.Red;
            this.textBoxFindFam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFindFam.Location = new System.Drawing.Point(1125, 630);
            this.textBoxFindFam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFindFam.Name = "textBoxFindFam";
            this.textBoxFindFam.PasswordChar = '\0';
            this.textBoxFindFam.PlaceholderText = "Текст для поиска";
            this.textBoxFindFam.SelectedText = "";
            this.textBoxFindFam.Size = new System.Drawing.Size(350, 31);
            this.textBoxFindFam.TabIndex = 36;
            // 
            // butClear
            // 
            this.butClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butClear.FillColor = System.Drawing.Color.PeachPuff;
            this.butClear.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.ForeColor = System.Drawing.Color.Black;
            this.butClear.Location = new System.Drawing.Point(1172, 330);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(237, 31);
            this.butClear.TabIndex = 37;
            this.butClear.Text = "Очистить";
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butAll
            // 
            this.butAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAll.FillColor = System.Drawing.Color.PeachPuff;
            this.butAll.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAll.ForeColor = System.Drawing.Color.Black;
            this.butAll.Location = new System.Drawing.Point(1282, 668);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(206, 30);
            this.butAll.TabIndex = 38;
            this.butAll.Text = "Отобразить все";
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.butAll);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.textBoxFindFam);
            this.Controls.Add(this.comboBoxSort2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.textFIO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button butExit;
        private Guna.UI2.WinForms.Guna2DataGridView data1;
        private СделаНоDataSet сделаНоDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private СделаНоDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox textFIO;
        private Guna.UI2.WinForms.Guna2ComboBox comboRole;
        private Guna.UI2.WinForms.Guna2TextBox textLogin;
        private Guna.UI2.WinForms.Guna2TextBox textPass;
        private Guna.UI2.WinForms.Guna2TextBox textTel;
        private Guna.UI2.WinForms.Guna2Button butAdd;
        private Guna.UI2.WinForms.Guna2Button butEdit;
        private Guna.UI2.WinForms.Guna2Button butDelete;
        private Guna.UI2.WinForms.Guna2Button butSort;
        private Guna.UI2.WinForms.Guna2Button butFind;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSort2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFindFam;
        private Guna.UI2.WinForms.Guna2Button butClear;
        private Guna.UI2.WinForms.Guna2Button butAll;
    }
}