namespace Тест_курсач.Master
{
    partial class MainMaster
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
            this.идЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерквитанцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапринятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаконцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идВидаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьматериаловDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьработDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаястоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделаНоDataSet = new СделаНо.СделаНоDataSet();
            this.заказTableAdapter = new СделаНо.СделаНоDataSetTableAdapters.ЗаказTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
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
            this.номерквитанцииDataGridViewTextBoxColumn,
            this.датапринятияDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаконцаDataGridViewTextBoxColumn,
            this.датавыдачиDataGridViewTextBoxColumn,
            this.идСотрудникаDataGridViewTextBoxColumn,
            this.идВидаDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.авансDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.стоимостьматериаловDataGridViewTextBoxColumn,
            this.стоимостьработDataGridViewTextBoxColumn,
            this.общаястоимостьDataGridViewTextBoxColumn});
            this.data1.DataSource = this.заказBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle3;
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(16, 69);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1464, 643);
            this.data1.TabIndex = 16;
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
            // номерквитанцииDataGridViewTextBoxColumn
            // 
            this.номерквитанцииDataGridViewTextBoxColumn.DataPropertyName = "Номер_квитанции";
            this.номерквитанцииDataGridViewTextBoxColumn.HeaderText = "Номер_квитанции";
            this.номерквитанцииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерквитанцииDataGridViewTextBoxColumn.Name = "номерквитанцииDataGridViewTextBoxColumn";
            this.номерквитанцииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерквитанцииDataGridViewTextBoxColumn.Visible = false;
            // 
            // датапринятияDataGridViewTextBoxColumn
            // 
            this.датапринятияDataGridViewTextBoxColumn.DataPropertyName = "Дата_принятия";
            this.датапринятияDataGridViewTextBoxColumn.HeaderText = "Дата принятия";
            this.датапринятияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датапринятияDataGridViewTextBoxColumn.Name = "датапринятияDataGridViewTextBoxColumn";
            this.датапринятияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата начала ремонта";
            this.датаначалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            this.датаначалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаконцаDataGridViewTextBoxColumn
            // 
            this.датаконцаDataGridViewTextBoxColumn.DataPropertyName = "Дата_конца";
            this.датаконцаDataGridViewTextBoxColumn.HeaderText = "Дата конца ремонта";
            this.датаконцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаконцаDataGridViewTextBoxColumn.Name = "датаконцаDataGridViewTextBoxColumn";
            this.датаконцаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датавыдачиDataGridViewTextBoxColumn
            // 
            this.датавыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавыдачиDataGridViewTextBoxColumn.Name = "датавыдачиDataGridViewTextBoxColumn";
            this.датавыдачиDataGridViewTextBoxColumn.ReadOnly = true;
            this.датавыдачиDataGridViewTextBoxColumn.Visible = false;
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
            // идВидаDataGridViewTextBoxColumn
            // 
            this.идВидаDataGridViewTextBoxColumn.DataPropertyName = "ИдВида";
            this.идВидаDataGridViewTextBoxColumn.HeaderText = "Вид техники";
            this.идВидаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идВидаDataGridViewTextBoxColumn.Name = "идВидаDataGridViewTextBoxColumn";
            this.идВидаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номертелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьматериаловDataGridViewTextBoxColumn
            // 
            this.стоимостьматериаловDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_материалов";
            this.стоимостьматериаловDataGridViewTextBoxColumn.HeaderText = "Стоимость материалов";
            this.стоимостьматериаловDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьматериаловDataGridViewTextBoxColumn.Name = "стоимостьматериаловDataGridViewTextBoxColumn";
            this.стоимостьматериаловDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьработDataGridViewTextBoxColumn
            // 
            this.стоимостьработDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_работ";
            this.стоимостьработDataGridViewTextBoxColumn.HeaderText = "Стоимость работ";
            this.стоимостьработDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьработDataGridViewTextBoxColumn.Name = "стоимостьработDataGridViewTextBoxColumn";
            this.стоимостьработDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // общаястоимостьDataGridViewTextBoxColumn
            // 
            this.общаястоимостьDataGridViewTextBoxColumn.DataPropertyName = "Общая_стоимость";
            this.общаястоимостьDataGridViewTextBoxColumn.HeaderText = "Общая стоимость";
            this.общаястоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.общаястоимостьDataGridViewTextBoxColumn.Name = "общаястоимостьDataGridViewTextBoxColumn";
            this.общаястоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(474, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 28);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все заказы";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(621, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(215, 28);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Заказы на диагностику";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(863, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(175, 28);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Заказы на ремонт";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // MainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.data1);
            this.Name = "MainMaster";
            this.Size = new System.Drawing.Size(1500, 730);
            this.Load += new System.EventHandler(this.MainMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView data1;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private СделаНо.СделаНоDataSet сделаНоDataSet;
        private СделаНо.СделаНоDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерквитанцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапринятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаконцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn идСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn идВидаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авансDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьматериаловDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьработDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаястоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}
