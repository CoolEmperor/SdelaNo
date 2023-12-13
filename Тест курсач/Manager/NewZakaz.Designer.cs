namespace Тест_курсач.Manager
{
    partial class NewZakaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butAcceptZakaz = new Guna.UI2.WinForms.Guna2Button();
            this.texttel = new Guna.UI2.WinForms.Guna2TextBox();
            this.combomaster = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textfio = new Guna.UI2.WinForms.Guna2TextBox();
            this.textdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.сделаНоDataSet = new Тест_курсач.СделаНоDataSet();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new Тест_курсач.СделаНоDataSetTableAdapters.СотрудникTableAdapter();
            this.видтехникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_техникиTableAdapter = new Тест_курсач.СделаНоDataSetTableAdapters.Вид_техникиTableAdapter();
            this.textTypeEq = new Guna.UI2.WinForms.Guna2TextBox();
            this.CheckTechnick = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата принятия заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Мастер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид техники:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "ФИО Клиента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер телефона:";
            // 
            // butAcceptZakaz
            // 
            this.butAcceptZakaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAcceptZakaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAcceptZakaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAcceptZakaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAcceptZakaz.FillColor = System.Drawing.Color.PeachPuff;
            this.butAcceptZakaz.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAcceptZakaz.ForeColor = System.Drawing.Color.Black;
            this.butAcceptZakaz.Location = new System.Drawing.Point(540, 366);
            this.butAcceptZakaz.Name = "butAcceptZakaz";
            this.butAcceptZakaz.Size = new System.Drawing.Size(227, 41);
            this.butAcceptZakaz.TabIndex = 11;
            this.butAcceptZakaz.Text = "Принять заказ";
            this.butAcceptZakaz.Click += new System.EventHandler(this.butAcceptZakaz_Click);
            // 
            // texttel
            // 
            this.texttel.BorderColor = System.Drawing.Color.Black;
            this.texttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texttel.DefaultText = "";
            this.texttel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texttel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texttel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texttel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texttel.FillColor = System.Drawing.Color.Silver;
            this.texttel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texttel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.texttel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.texttel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texttel.Location = new System.Drawing.Point(501, 296);
            this.texttel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texttel.Name = "texttel";
            this.texttel.PasswordChar = '\0';
            this.texttel.PlaceholderText = "";
            this.texttel.SelectedText = "";
            this.texttel.Size = new System.Drawing.Size(586, 36);
            this.texttel.TabIndex = 12;
            // 
            // combomaster
            // 
            this.combomaster.BackColor = System.Drawing.Color.Transparent;
            this.combomaster.BorderColor = System.Drawing.Color.Black;
            this.combomaster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combomaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomaster.FillColor = System.Drawing.Color.Silver;
            this.combomaster.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combomaster.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combomaster.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combomaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.combomaster.ItemHeight = 30;
            this.combomaster.Location = new System.Drawing.Point(501, 154);
            this.combomaster.Name = "combomaster";
            this.combomaster.Size = new System.Drawing.Size(586, 36);
            this.combomaster.TabIndex = 13;
            // 
            // textfio
            // 
            this.textfio.BorderColor = System.Drawing.Color.Black;
            this.textfio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textfio.DefaultText = "";
            this.textfio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textfio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textfio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textfio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textfio.FillColor = System.Drawing.Color.Silver;
            this.textfio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textfio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textfio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textfio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textfio.Location = new System.Drawing.Point(501, 252);
            this.textfio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textfio.Name = "textfio";
            this.textfio.PasswordChar = '\0';
            this.textfio.PlaceholderText = "";
            this.textfio.SelectedText = "";
            this.textfio.Size = new System.Drawing.Size(586, 36);
            this.textfio.TabIndex = 15;
            // 
            // textdate
            // 
            this.textdate.Checked = true;
            this.textdate.FillColor = System.Drawing.Color.Silver;
            this.textdate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.textdate.Location = new System.Drawing.Point(501, 112);
            this.textdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.textdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(586, 36);
            this.textdate.TabIndex = 16;
            this.textdate.Value = new System.DateTime(2023, 12, 2, 23, 22, 47, 290);
            // 
            // сделаНоDataSet
            // 
            this.сделаНоDataSet.DataSetName = "СделаНоDataSet";
            this.сделаНоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // видтехникиBindingSource
            // 
            this.видтехникиBindingSource.DataMember = "Вид_техники";
            this.видтехникиBindingSource.DataSource = this.сделаНоDataSet;
            // 
            // вид_техникиTableAdapter
            // 
            this.вид_техникиTableAdapter.ClearBeforeFill = true;
            // 
            // textTypeEq
            // 
            this.textTypeEq.BorderColor = System.Drawing.Color.Black;
            this.textTypeEq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTypeEq.DefaultText = "";
            this.textTypeEq.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTypeEq.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTypeEq.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTypeEq.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTypeEq.FillColor = System.Drawing.Color.Silver;
            this.textTypeEq.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTypeEq.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textTypeEq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textTypeEq.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTypeEq.Location = new System.Drawing.Point(501, 208);
            this.textTypeEq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTypeEq.Name = "textTypeEq";
            this.textTypeEq.PasswordChar = '\0';
            this.textTypeEq.PlaceholderText = "";
            this.textTypeEq.ReadOnly = true;
            this.textTypeEq.SelectedText = "";
            this.textTypeEq.Size = new System.Drawing.Size(297, 36);
            this.textTypeEq.TabIndex = 17;
            // 
            // CheckTechnick
            // 
            this.CheckTechnick.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckTechnick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckTechnick.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckTechnick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckTechnick.FillColor = System.Drawing.Color.PeachPuff;
            this.CheckTechnick.Font = new System.Drawing.Font("News706 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTechnick.ForeColor = System.Drawing.Color.Black;
            this.CheckTechnick.Location = new System.Drawing.Point(804, 208);
            this.CheckTechnick.Name = "CheckTechnick";
            this.CheckTechnick.Size = new System.Drawing.Size(283, 36);
            this.CheckTechnick.TabIndex = 18;
            this.CheckTechnick.Text = "Выбрать вид техники";
            this.CheckTechnick.Click += new System.EventHandler(this.CheckTechnick_Click);
            // 
            // NewZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckTechnick);
            this.Controls.Add(this.textTypeEq);
            this.Controls.Add(this.textdate);
            this.Controls.Add(this.textfio);
            this.Controls.Add(this.combomaster);
            this.Controls.Add(this.texttel);
            this.Controls.Add(this.butAcceptZakaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewZakaz";
            this.Size = new System.Drawing.Size(1250, 730);
            ((System.ComponentModel.ISupportInitialize)(this.сделаНоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button butAcceptZakaz;
        private Guna.UI2.WinForms.Guna2TextBox texttel;
        private Guna.UI2.WinForms.Guna2ComboBox combomaster;
        private Guna.UI2.WinForms.Guna2TextBox textfio;
        private Guna.UI2.WinForms.Guna2DateTimePicker textdate;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private СделаНоDataSet сделаНоDataSet;
        private СделаНоDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource видтехникиBindingSource;
        private СделаНоDataSetTableAdapters.Вид_техникиTableAdapter вид_техникиTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox textTypeEq;
        private Guna.UI2.WinForms.Guna2Button CheckTechnick;
    }
}
