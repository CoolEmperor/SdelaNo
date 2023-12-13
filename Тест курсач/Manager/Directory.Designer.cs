namespace СделаНо
{
    partial class Directory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butMat = new Guna.UI2.WinForms.Guna2Button();
            this.butWork = new Guna.UI2.WinForms.Guna2Button();
            this.butMod = new Guna.UI2.WinForms.Guna2Button();
            this.butUs = new Guna.UI2.WinForms.Guna2Button();
            this.butTech = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.butMat);
            this.panel1.Controls.Add(this.butWork);
            this.panel1.Controls.Add(this.butMod);
            this.panel1.Controls.Add(this.butUs);
            this.panel1.Controls.Add(this.butTech);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 70);
            this.panel1.TabIndex = 0;
            // 
            // butMat
            // 
            this.butMat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butMat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butMat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butMat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butMat.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.butMat.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMat.ForeColor = System.Drawing.Color.Black;
            this.butMat.Location = new System.Drawing.Point(982, 12);
            this.butMat.Name = "butMat";
            this.butMat.Size = new System.Drawing.Size(180, 45);
            this.butMat.TabIndex = 4;
            this.butMat.Text = "Материалы";
            this.butMat.Click += new System.EventHandler(this.butMat_Click);
            // 
            // butWork
            // 
            this.butWork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butWork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butWork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butWork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butWork.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.butWork.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butWork.ForeColor = System.Drawing.Color.Black;
            this.butWork.Location = new System.Drawing.Point(707, 12);
            this.butWork.Name = "butWork";
            this.butWork.Size = new System.Drawing.Size(236, 45);
            this.butWork.TabIndex = 3;
            this.butWork.Text = "Вид ремонтных работ";
            this.butWork.Click += new System.EventHandler(this.butWork_Click);
            // 
            // butMod
            // 
            this.butMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butMod.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.butMod.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMod.ForeColor = System.Drawing.Color.Black;
            this.butMod.Location = new System.Drawing.Point(521, 12);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(180, 45);
            this.butMod.TabIndex = 2;
            this.butMod.Text = "Модель";
            this.butMod.Click += new System.EventHandler(this.butMod_Click);
            // 
            // butUs
            // 
            this.butUs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butUs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butUs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butUs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butUs.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.butUs.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUs.ForeColor = System.Drawing.Color.Black;
            this.butUs.Location = new System.Drawing.Point(292, 12);
            this.butUs.Name = "butUs";
            this.butUs.Size = new System.Drawing.Size(180, 45);
            this.butUs.TabIndex = 1;
            this.butUs.Text = "Тип устройств";
            this.butUs.Click += new System.EventHandler(this.butUs_Click);
            // 
            // butTech
            // 
            this.butTech.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTech.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTech.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTech.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTech.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.butTech.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTech.ForeColor = System.Drawing.Color.Black;
            this.butTech.Location = new System.Drawing.Point(74, 12);
            this.butTech.Name = "butTech";
            this.butTech.Size = new System.Drawing.Size(180, 45);
            this.butTech.TabIndex = 0;
            this.butTech.Text = "Вид техники";
            this.butTech.Click += new System.EventHandler(this.butTech_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 70);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1250, 660);
            this.panelContainer.TabIndex = 1;
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Directory";
            this.Size = new System.Drawing.Size(1250, 730);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button butTech;
        private Guna.UI2.WinForms.Guna2Button butMat;
        private Guna.UI2.WinForms.Guna2Button butWork;
        private Guna.UI2.WinForms.Guna2Button butMod;
        private Guna.UI2.WinForms.Guna2Button butUs;
        private System.Windows.Forms.Panel panelContainer;
    }
}
