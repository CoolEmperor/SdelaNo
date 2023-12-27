namespace СделаНо
{
    partial class Work
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butClear = new Guna.UI2.WinForms.Guna2Button();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butSort = new Guna.UI2.WinForms.Guna2Button();
            this.butDelete = new Guna.UI2.WinForms.Guna2Button();
            this.butEdit = new Guna.UI2.WinForms.Guna2Button();
            this.butAdd = new Guna.UI2.WinForms.Guna2Button();
            this.data1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.идРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видремонтныхработBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделаНоDataSet = new Тест_курсач.СделаНоDataSet();
            this.textDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.вид_ремонтных_работTableAdapter = new Тест_курсач.СделаНоDataSetTableAdapters.Вид_ремонтных_работTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видремонтныхработBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // butClear
            // 
            this.butClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butClear.FillColor = System.Drawing.Color.PeachPuff;
            this.butClear.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.butClear.ForeColor = System.Drawing.Color.Black;
            this.butClear.Location = new System.Drawing.Point(927, 171);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(237, 31);
            this.butClear.TabIndex = 102;
            this.butClear.Text = "Очистить";
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.DefaultText = "";
            this.textName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.ForeColor = System.Drawing.Color.Black;
            this.textName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Location = new System.Drawing.Point(979, 26);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderText = "";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(251, 36);
            this.textName.TabIndex = 101;
            // 
            // textCost
            // 
            this.textCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCost.DefaultText = "";
            this.textCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCost.ForeColor = System.Drawing.Color.Black;
            this.textCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCost.Location = new System.Drawing.Point(979, 70);
            this.textCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCost.Name = "textCost";
            this.textCost.PasswordChar = '\0';
            this.textCost.PlaceholderText = "";
            this.textCost.SelectedText = "";
            this.textCost.Size = new System.Drawing.Size(251, 36);
            this.textCost.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(854, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 99;
            this.label2.Text = "Стоимость:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(854, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 98;
            this.label1.Text = "Название:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFind.DefaultText = "";
            this.textBoxFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFind.FillColor = System.Drawing.Color.Gainsboro;
            this.textBoxFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFind.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.ForeColor = System.Drawing.Color.Red;
            this.textBoxFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFind.Location = new System.Drawing.Point(868, 548);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.PasswordChar = '\0';
            this.textBoxFind.PlaceholderText = "Текст для поиска по названию";
            this.textBoxFind.SelectedText = "";
            this.textBoxFind.Size = new System.Drawing.Size(350, 31);
            this.textBoxFind.TabIndex = 97;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.Transparent;
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox2.ItemHeight = 30;
            this.comboBox2.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.comboBox2.Location = new System.Drawing.Point(927, 398);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(305, 36);
            this.comboBox2.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(821, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 95;
            this.label8.Text = "Порядок:";
            // 
            // butSort
            // 
            this.butSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSort.FillColor = System.Drawing.Color.PeachPuff;
            this.butSort.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSort.ForeColor = System.Drawing.Color.Black;
            this.butSort.Location = new System.Drawing.Point(899, 455);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(300, 36);
            this.butSort.TabIndex = 94;
            this.butSort.Text = "Сортировать по Названию";
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butDelete
            // 
            this.butDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDelete.FillColor = System.Drawing.Color.PeachPuff;
            this.butDelete.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.Color.Black;
            this.butDelete.Location = new System.Drawing.Point(927, 305);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(237, 36);
            this.butDelete.TabIndex = 93;
            this.butDelete.Text = "Удалить";
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butEdit.FillColor = System.Drawing.Color.PeachPuff;
            this.butEdit.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.ForeColor = System.Drawing.Color.Black;
            this.butEdit.Location = new System.Drawing.Point(927, 263);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(237, 36);
            this.butEdit.TabIndex = 92;
            this.butEdit.Text = "Редактировать";
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.PeachPuff;
            this.butAdd.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.Black;
            this.butAdd.Location = new System.Drawing.Point(927, 221);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(237, 36);
            this.butAdd.TabIndex = 91;
            this.butAdd.Text = "Добавить";
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.AutoGenerateColumns = false;
            this.data1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data1.ColumnHeadersHeight = 35;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идРаботыDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.data1.DataSource = this.видремонтныхработBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle3;
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(19, 17);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(794, 626);
            this.data1.TabIndex = 90;
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
            this.data1.SelectionChanged += new System.EventHandler(this.data1_SelectionChanged);
            // 
            // идРаботыDataGridViewTextBoxColumn
            // 
            this.идРаботыDataGridViewTextBoxColumn.DataPropertyName = "ИдРаботы";
            this.идРаботыDataGridViewTextBoxColumn.HeaderText = "ИдРаботы";
            this.идРаботыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идРаботыDataGridViewTextBoxColumn.Name = "идРаботыDataGridViewTextBoxColumn";
            this.идРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            this.идРаботыDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видремонтныхработBindingSource
            // 
            this.видремонтныхработBindingSource.DataMember = "Вид_ремонтных_работ";
            this.видремонтныхработBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textDesc
            // 
            this.textDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDesc.DefaultText = "";
            this.textDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDesc.ForeColor = System.Drawing.Color.Black;
            this.textDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDesc.Location = new System.Drawing.Point(979, 114);
            this.textDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDesc.Name = "textDesc";
            this.textDesc.PasswordChar = '\0';
            this.textDesc.PlaceholderText = "";
            this.textDesc.SelectedText = "";
            this.textDesc.Size = new System.Drawing.Size(251, 36);
            this.textDesc.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(854, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = "Описание:";
            // 
            // вид_ремонтных_работTableAdapter
            // 
            this.вид_ремонтных_работTableAdapter.ClearBeforeFill = true;
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.data1);
            this.Name = "Work";
            this.Size = new System.Drawing.Size(1250, 660);
            this.Load += new System.EventHandler(this.Work_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видремонтныхработBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button butClear;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private Guna.UI2.WinForms.Guna2TextBox textCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFind;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button butSort;
        private Guna.UI2.WinForms.Guna2Button butDelete;
        private Guna.UI2.WinForms.Guna2Button butEdit;
        private Guna.UI2.WinForms.Guna2Button butAdd;
        private Guna.UI2.WinForms.Guna2DataGridView data1;
        private Guna.UI2.WinForms.Guna2TextBox textDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn идРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource видремонтныхработBindingSource;
        private Тест_курсач.СделаНоDataSet сделаНоDataSet;
        private Тест_курсач.СделаНоDataSetTableAdapters.Вид_ремонтных_работTableAdapter вид_ремонтных_работTableAdapter;
    }
}
