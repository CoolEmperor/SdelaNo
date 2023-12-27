namespace Тест_курсач.Manager
{
    partial class MainRepairZakaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.идЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПринятияЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОМастераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видТехникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьМатериаловDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказДляУчетаЗаказовНаРемонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделаНоDataSet = new Тест_курсач.СделаНоDataSet();
            this.заказДляУчетаЗаказовНаРемонтTableAdapter = new Тест_курсач.СделаНоDataSetTableAdapters.ЗаказДляУчетаЗаказовНаРемонтTableAdapter();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказДляУчетаЗаказовНаРемонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.data1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.AutoGenerateColumns = false;
            this.data1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.data1.ColumnHeadersHeight = 75;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идЗаказаDataGridViewTextBoxColumn,
            this.датаПринятияЗаказаDataGridViewTextBoxColumn,
            this.датаНачалаРемонтаDataGridViewTextBoxColumn,
            this.фИОМастераDataGridViewTextBoxColumn,
            this.видТехникиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.авансDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.стоимостьМатериаловDataGridViewTextBoxColumn,
            this.стоимостьРаботDataGridViewTextBoxColumn,
            this.общаяСтоимостьDataGridViewTextBoxColumn});
            this.data1.DataSource = this.заказДляУчетаЗаказовНаРемонтBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle12;
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(16, 60);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1219, 553);
            this.data1.TabIndex = 19;
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
            this.data1.ThemeStyle.HeaderStyle.Height = 75;
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
            // идЗаказаDataGridViewTextBoxColumn
            // 
            this.идЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ИдЗаказа";
            this.идЗаказаDataGridViewTextBoxColumn.HeaderText = "ИдЗаказа";
            this.идЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идЗаказаDataGridViewTextBoxColumn.Name = "идЗаказаDataGridViewTextBoxColumn";
            this.идЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идЗаказаDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаПринятияЗаказаDataGridViewTextBoxColumn
            // 
            this.датаПринятияЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата принятия заказа";
            this.датаПринятияЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата принятия заказа";
            this.датаПринятияЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПринятияЗаказаDataGridViewTextBoxColumn.Name = "датаПринятияЗаказаDataGridViewTextBoxColumn";
            this.датаПринятияЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНачалаРемонтаDataGridViewTextBoxColumn
            // 
            this.датаНачалаРемонтаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала ремонта";
            this.датаНачалаРемонтаDataGridViewTextBoxColumn.HeaderText = "Дата начала ремонта";
            this.датаНачалаРемонтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНачалаРемонтаDataGridViewTextBoxColumn.Name = "датаНачалаРемонтаDataGridViewTextBoxColumn";
            this.датаНачалаРемонтаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОМастераDataGridViewTextBoxColumn
            // 
            this.фИОМастераDataGridViewTextBoxColumn.DataPropertyName = "ФИО Мастера";
            this.фИОМастераDataGridViewTextBoxColumn.HeaderText = "ФИО Мастера";
            this.фИОМастераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОМастераDataGridViewTextBoxColumn.Name = "фИОМастераDataGridViewTextBoxColumn";
            this.фИОМастераDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видТехникиDataGridViewTextBoxColumn
            // 
            this.видТехникиDataGridViewTextBoxColumn.DataPropertyName = "Вид техники";
            this.видТехникиDataGridViewTextBoxColumn.HeaderText = "Вид техники";
            this.видТехникиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видТехникиDataGridViewTextBoxColumn.Name = "видТехникиDataGridViewTextBoxColumn";
            this.видТехникиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авансDataGridViewTextBoxColumn
            // 
            this.авансDataGridViewTextBoxColumn.DataPropertyName = "Аванс";
            this.авансDataGridViewTextBoxColumn.HeaderText = "Аванс";
            this.авансDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.авансDataGridViewTextBoxColumn.Name = "авансDataGridViewTextBoxColumn";
            this.авансDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьМатериаловDataGridViewTextBoxColumn
            // 
            this.стоимостьМатериаловDataGridViewTextBoxColumn.DataPropertyName = "Стоимость материалов";
            this.стоимостьМатериаловDataGridViewTextBoxColumn.HeaderText = "Стоимость материалов";
            this.стоимостьМатериаловDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьМатериаловDataGridViewTextBoxColumn.Name = "стоимостьМатериаловDataGridViewTextBoxColumn";
            this.стоимостьМатериаловDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьРаботDataGridViewTextBoxColumn
            // 
            this.стоимостьРаботDataGridViewTextBoxColumn.DataPropertyName = "Стоимость работ";
            this.стоимостьРаботDataGridViewTextBoxColumn.HeaderText = "Стоимость работ";
            this.стоимостьРаботDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьРаботDataGridViewTextBoxColumn.Name = "стоимостьРаботDataGridViewTextBoxColumn";
            this.стоимостьРаботDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // общаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.общаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Общая стоимость";
            this.общаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Общая стоимость";
            this.общаяСтоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.общаяСтоимостьDataGridViewTextBoxColumn.Name = "общаяСтоимостьDataGridViewTextBoxColumn";
            this.общаяСтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказДляУчетаЗаказовНаРемонтBindingSource
            // 
            this.заказДляУчетаЗаказовНаРемонтBindingSource.DataMember = "ЗаказДляУчетаЗаказовНаРемонт";
            this.заказДляУчетаЗаказовНаРемонтBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказДляУчетаЗаказовНаРемонтTableAdapter
            // 
            this.заказДляУчетаЗаказовНаРемонтTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(728, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(237, 28);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Заказы готовые к выдаче";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(498, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 28);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Заказы на ремонте";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(311, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 28);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все заказы";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MainRepairZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.data1);
            this.Name = "MainRepairZakaz";
            this.Size = new System.Drawing.Size(1250, 630);
            this.Load += new System.EventHandler(this.MainRepairZakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказДляУчетаЗаказовНаРемонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn идЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПринятияЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОМастераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видТехникиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авансDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьМатериаловDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource заказДляУчетаЗаказовНаРемонтBindingSource;
        private СделаНоDataSet сделаНоDataSet;
        private СделаНоDataSetTableAdapters.ЗаказДляУчетаЗаказовНаРемонтTableAdapter заказДляУчетаЗаказовНаРемонтTableAdapter;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
