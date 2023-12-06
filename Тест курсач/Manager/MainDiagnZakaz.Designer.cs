namespace Тест_курсач.Manager
{
    partial class MainDiagnZakaz
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
            this.data1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.заказДляУчетаЗаказовНаДиагностикуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделаНоDataSet = new Тест_курсач.СделаНоDataSet();
            this.заказДляУчетаЗаказовНаДиагностикуTableAdapter = new Тест_курсач.СделаНоDataSetTableAdapters.ЗаказДляУчетаЗаказовНаДиагностикуTableAdapter();
            this.идЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПринятияЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОМастераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видТехникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказДляУчетаЗаказовНаДиагностикуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.data1.ColumnHeadersHeight = 75;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идЗаказаDataGridViewTextBoxColumn,
            this.датаПринятияЗаказаDataGridViewTextBoxColumn,
            this.фИОМастераDataGridViewTextBoxColumn,
            this.видТехникиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.авансDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.стоимостьРаботDataGridViewTextBoxColumn,
            this.общаяСтоимостьDataGridViewTextBoxColumn});
            this.data1.DataSource = this.заказДляУчетаЗаказовНаДиагностикуBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle3;
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(16, 17);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1219, 596);
            this.data1.TabIndex = 18;
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
            // заказДляУчетаЗаказовНаДиагностикуBindingSource
            // 
            this.заказДляУчетаЗаказовНаДиагностикуBindingSource.DataMember = "ЗаказДляУчетаЗаказовНаДиагностику";
            this.заказДляУчетаЗаказовНаДиагностикуBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказДляУчетаЗаказовНаДиагностикуTableAdapter
            // 
            this.заказДляУчетаЗаказовНаДиагностикуTableAdapter.ClearBeforeFill = true;
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
            // MainDiagnZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data1);
            this.Name = "MainDiagnZakaz";
            this.Size = new System.Drawing.Size(1250, 630);
            this.Load += new System.EventHandler(this.MainDiagnRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказДляУчетаЗаказовНаДиагностикуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView data1;
        private System.Windows.Forms.BindingSource заказДляУчетаЗаказовНаДиагностикуBindingSource;
        private СделаНоDataSet сделаНоDataSet;
        private СделаНоDataSetTableAdapters.ЗаказДляУчетаЗаказовНаДиагностикуTableAdapter заказДляУчетаЗаказовНаДиагностикуTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПринятияЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОМастераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видТехникиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авансDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСтоимостьDataGridViewTextBoxColumn;
    }
}
