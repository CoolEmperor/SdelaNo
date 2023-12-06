namespace Тест_курсач.Manager
{
    partial class AcceptZakaz
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
            this.butZakaz = new Guna.UI2.WinForms.Guna2Button();
            this.butBack = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // butZakaz
            // 
            this.butZakaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butZakaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butZakaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butZakaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butZakaz.FillColor = System.Drawing.Color.PeachPuff;
            this.butZakaz.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butZakaz.ForeColor = System.Drawing.Color.Black;
            this.butZakaz.Location = new System.Drawing.Point(1001, 658);
            this.butZakaz.Name = "butZakaz";
            this.butZakaz.Size = new System.Drawing.Size(226, 50);
            this.butZakaz.TabIndex = 28;
            this.butZakaz.Text = "Выбор заказа";
            this.butZakaz.Click += new System.EventHandler(this.butZakaz_Click);
            // 
            // butBack
            // 
            this.butBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butBack.FillColor = System.Drawing.Color.PeachPuff;
            this.butBack.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.Black;
            this.butBack.Location = new System.Drawing.Point(1001, 658);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(226, 50);
            this.butBack.TabIndex = 27;
            this.butBack.Text = "Вернуться назад";
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1250, 630);
            this.panelContainer.TabIndex = 26;
            // 
            // AcceptZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butZakaz);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.panelContainer);
            this.Name = "AcceptZakaz";
            this.Size = new System.Drawing.Size(1250, 730);
            this.Load += new System.EventHandler(this.AcceptZakaz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button butZakaz;
        private Guna.UI2.WinForms.Guna2Button butBack;
        private System.Windows.Forms.Panel panelContainer;
    }
}
