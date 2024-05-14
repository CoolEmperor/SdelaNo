namespace СделаНо
{
    partial class MasterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelContainer = new System.Windows.Forms.Panel();
			this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.butZakaz = new Guna.UI2.WinForms.Guna2Button();
			this.butExit = new Guna.UI2.WinForms.Guna2Button();
			this.butBack = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.RosyBrown;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1500, 70);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1083, 22);
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
			this.label2.Location = new System.Drawing.Point(982, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Мастер:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ремонт компьютерной техники";
			// 
			// panelContainer
			// 
			this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelContainer.Location = new System.Drawing.Point(0, 70);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(1500, 700);
			this.panelContainer.TabIndex = 3;
			// 
			// заказBindingSource
			// 
			this.заказBindingSource.DataMember = "Заказ";
			// 
			// butZakaz
			// 
			this.butZakaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butZakaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butZakaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butZakaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butZakaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butZakaz.FillColor = System.Drawing.Color.PeachPuff;
			this.butZakaz.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butZakaz.ForeColor = System.Drawing.Color.Black;
			this.butZakaz.Location = new System.Drawing.Point(1004, 788);
			this.butZakaz.Name = "butZakaz";
			this.butZakaz.Size = new System.Drawing.Size(226, 50);
			this.butZakaz.TabIndex = 19;
			this.butZakaz.Text = "Выбор заказа";
			this.butZakaz.Click += new System.EventHandler(this.butZakaz_Click);
			// 
			// butExit
			// 
			this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butExit.FillColor = System.Drawing.Color.Salmon;
			this.butExit.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
			this.butExit.ForeColor = System.Drawing.Color.Black;
			this.butExit.Location = new System.Drawing.Point(1236, 788);
			this.butExit.Name = "butExit";
			this.butExit.Size = new System.Drawing.Size(252, 50);
			this.butExit.TabIndex = 18;
			this.butExit.Text = "Сменить пользователя";
			this.butExit.Click += new System.EventHandler(this.butExit_Click);
			// 
			// butBack
			// 
			this.butBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.butBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.butBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.butBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.butBack.FillColor = System.Drawing.Color.PeachPuff;
			this.butBack.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butBack.ForeColor = System.Drawing.Color.Black;
			this.butBack.Location = new System.Drawing.Point(1004, 788);
			this.butBack.Name = "butBack";
			this.butBack.Size = new System.Drawing.Size(226, 50);
			this.butBack.TabIndex = 20;
			this.butBack.Text = "Вернуться назад";
			this.butBack.Click += new System.EventHandler(this.butBack_Click);
			// 
			// MasterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1500, 850);
			this.Controls.Add(this.butBack);
			this.Controls.Add(this.butZakaz);
			this.Controls.Add(this.butExit);
			this.Controls.Add(this.panelContainer);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MasterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Мастер";
			this.Load += new System.EventHandler(this.Master_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private Guna.UI2.WinForms.Guna2Button butZakaz;
        private Guna.UI2.WinForms.Guna2Button butExit;
        private Guna.UI2.WinForms.Guna2Button butBack;
    }
}