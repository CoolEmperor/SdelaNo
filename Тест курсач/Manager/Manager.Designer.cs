namespace СделаНо
{
    partial class Manager
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.butExit = new Guna.UI2.WinForms.Guna2Button();
			this.butDel = new Guna.UI2.WinForms.Guna2Button();
			this.butZakRep = new Guna.UI2.WinForms.Guna2Button();
			this.butZakDiag = new Guna.UI2.WinForms.Guna2Button();
			this.butNewZak = new Guna.UI2.WinForms.Guna2Button();
			this.butSpr = new Guna.UI2.WinForms.Guna2Button();
			this.panelContainer = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1064, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(332, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Бугай Дмитрий Александрович";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(931, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Менеджер:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ремонт компьютерной техники";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.PeachPuff;
			this.panel2.Controls.Add(this.butExit);
			this.panel2.Controls.Add(this.butDel);
			this.panel2.Controls.Add(this.butZakRep);
			this.panel2.Controls.Add(this.butZakDiag);
			this.panel2.Controls.Add(this.butNewZak);
			this.panel2.Controls.Add(this.butSpr);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 70);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 730);
			this.panel2.TabIndex = 1;
			// 
			// butExit
			// 
			this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.butExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butExit.FillColor = System.Drawing.Color.Salmon;
			this.butExit.Font = new System.Drawing.Font("News706 BT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butExit.ForeColor = System.Drawing.Color.Black;
			this.butExit.Location = new System.Drawing.Point(12, 652);
			this.butExit.Name = "butExit";
			this.butExit.Size = new System.Drawing.Size(224, 66);
			this.butExit.TabIndex = 10;
			this.butExit.Text = "Сменить пользователя";
			this.butExit.Click += new System.EventHandler(this.butExit_Click);
			// 
			// butDel
			// 
			this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butDel.FillColor = System.Drawing.Color.PeachPuff;
			this.butDel.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butDel.ForeColor = System.Drawing.Color.Black;
			this.butDel.Location = new System.Drawing.Point(1, 350);
			this.butDel.Name = "butDel";
			this.butDel.Size = new System.Drawing.Size(245, 55);
			this.butDel.TabIndex = 12;
			this.butDel.Text = "Выдача заказа";
			this.butDel.Click += new System.EventHandler(this.butDel_Click);
			// 
			// butZakRep
			// 
			this.butZakRep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butZakRep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butZakRep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butZakRep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butZakRep.FillColor = System.Drawing.Color.PeachPuff;
			this.butZakRep.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold);
			this.butZakRep.ForeColor = System.Drawing.Color.Black;
			this.butZakRep.Location = new System.Drawing.Point(2, 281);
			this.butZakRep.Name = "butZakRep";
			this.butZakRep.Size = new System.Drawing.Size(245, 63);
			this.butZakRep.TabIndex = 8;
			this.butZakRep.Text = "Заказы в ремонте";
			this.butZakRep.Click += new System.EventHandler(this.butZakRep_Click);
			// 
			// butZakDiag
			// 
			this.butZakDiag.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butZakDiag.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butZakDiag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butZakDiag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butZakDiag.FillColor = System.Drawing.Color.PeachPuff;
			this.butZakDiag.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butZakDiag.ForeColor = System.Drawing.Color.Black;
			this.butZakDiag.Location = new System.Drawing.Point(3, 194);
			this.butZakDiag.Name = "butZakDiag";
			this.butZakDiag.Size = new System.Drawing.Size(241, 81);
			this.butZakDiag.TabIndex = 7;
			this.butZakDiag.Text = "Заказы на диагностике";
			this.butZakDiag.Click += new System.EventHandler(this.butZakDiag_Click);
			// 
			// butNewZak
			// 
			this.butNewZak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butNewZak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butNewZak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butNewZak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butNewZak.FillColor = System.Drawing.Color.PeachPuff;
			this.butNewZak.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butNewZak.ForeColor = System.Drawing.Color.Black;
			this.butNewZak.Location = new System.Drawing.Point(3, 133);
			this.butNewZak.Name = "butNewZak";
			this.butNewZak.Size = new System.Drawing.Size(245, 55);
			this.butNewZak.TabIndex = 6;
			this.butNewZak.Text = "Новый заказ";
			this.butNewZak.Click += new System.EventHandler(this.butNewZak_Click);
			// 
			// butSpr
			// 
			this.butSpr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butSpr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butSpr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butSpr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butSpr.FillColor = System.Drawing.Color.PeachPuff;
			this.butSpr.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butSpr.ForeColor = System.Drawing.Color.Black;
			this.butSpr.Location = new System.Drawing.Point(3, 72);
			this.butSpr.Name = "butSpr";
			this.butSpr.Size = new System.Drawing.Size(245, 55);
			this.butSpr.TabIndex = 5;
			this.butSpr.Text = "Справочники";
			this.butSpr.Click += new System.EventHandler(this.butSpr_Click);
			// 
			// panelContainer
			// 
			this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelContainer.AutoSize = true;
			this.panelContainer.Location = new System.Drawing.Point(250, 70);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(1250, 730);
			this.panelContainer.TabIndex = 2;
			// 
			// Manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1500, 800);
			this.Controls.Add(this.panelContainer);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Manager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Менеджер";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Manager_Resize);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button butSpr;
        private Guna.UI2.WinForms.Guna2Button butZakRep;
        private Guna.UI2.WinForms.Guna2Button butZakDiag;
        private Guna.UI2.WinForms.Guna2Button butNewZak;
        private Guna.UI2.WinForms.Guna2Button butExit;
        private Guna.UI2.WinForms.Guna2Button butDel;
    }
}

