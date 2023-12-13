namespace Тест_курсач.Manager
{
    partial class Technick
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.идВидаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типУстройстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видТехникиДляМенеджераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделаНоDataSet = new Тест_курсач.СделаНоDataSet();
            this.butSelect = new Guna.UI2.WinForms.Guna2Button();
            this.видТехникиДляМенеджераTableAdapter = new Тест_курсач.СделаНоDataSetTableAdapters.ВидТехникиДляМенеджераTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видТехникиДляМенеджераBindingSource)).BeginInit();
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
            this.data1.ColumnHeadersHeight = 35;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идВидаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.типУстройстваDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn});
            this.data1.DataSource = this.видТехникиДляМенеджераBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle3;
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(12, 12);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.RowHeadersVisible = false;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 24;
            this.data1.Size = new System.Drawing.Size(1176, 529);
            this.data1.TabIndex = 78;
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
            // 
            // идВидаDataGridViewTextBoxColumn
            // 
            this.идВидаDataGridViewTextBoxColumn.DataPropertyName = "ИдВида";
            this.идВидаDataGridViewTextBoxColumn.HeaderText = "ИдВида";
            this.идВидаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идВидаDataGridViewTextBoxColumn.Name = "идВидаDataGridViewTextBoxColumn";
            this.идВидаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идВидаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типУстройстваDataGridViewTextBoxColumn
            // 
            this.типУстройстваDataGridViewTextBoxColumn.DataPropertyName = "Тип устройства";
            this.типУстройстваDataGridViewTextBoxColumn.HeaderText = "Тип устройства";
            this.типУстройстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типУстройстваDataGridViewTextBoxColumn.Name = "типУстройстваDataGridViewTextBoxColumn";
            this.типУстройстваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видТехникиДляМенеджераBindingSource
            // 
            this.видТехникиДляМенеджераBindingSource.DataMember = "ВидТехникиДляМенеджера";
            this.видТехникиДляМенеджераBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butSelect
            // 
            this.butSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSelect.FillColor = System.Drawing.Color.PeachPuff;
            this.butSelect.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelect.ForeColor = System.Drawing.Color.Black;
            this.butSelect.Location = new System.Drawing.Point(879, 547);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(309, 41);
            this.butSelect.TabIndex = 79;
            this.butSelect.Text = "Выбор вида техники";
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // видТехникиДляМенеджераTableAdapter
            // 
            this.видТехникиДляМенеджераTableAdapter.ClearBeforeFill = true;
            // 
            // Technick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.data1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Technick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вид техники";
            this.Load += new System.EventHandler(this.Technick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видТехникиДляМенеджераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView data1;
        private Guna.UI2.WinForms.Guna2Button butSelect;
        private СделаНоDataSet сделаНоDataSet;
        private System.Windows.Forms.BindingSource видТехникиДляМенеджераBindingSource;
        private СделаНоDataSetTableAdapters.ВидТехникиДляМенеджераTableAdapter видТехникиДляМенеджераTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идВидаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типУстройстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
    }
}