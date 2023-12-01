namespace СделаНо
{
    partial class Master
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butExit = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1063, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Бугай Дмитрий Александрович";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(962, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Мастер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастерская \"СделаНо\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.butExit);
            this.panel2.Controls.Add(this.butNewZak);
            this.panel2.Controls.Add(this.butSpr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 730);
            this.panel2.TabIndex = 2;
            // 
            // butExit
            // 
            this.butExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butExit.FillColor = System.Drawing.Color.PeachPuff;
            this.butExit.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.Color.Black;
            this.butExit.Location = new System.Drawing.Point(3, 644);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(245, 74);
            this.butExit.TabIndex = 10;
            this.butExit.Text = "Выход из программы";
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
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
            this.butNewZak.Location = new System.Drawing.Point(3, 165);
            this.butNewZak.Name = "butNewZak";
            this.butNewZak.Size = new System.Drawing.Size(245, 66);
            this.butNewZak.TabIndex = 6;
            this.butNewZak.Text = "Выполненные работы";
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
            this.butSpr.Location = new System.Drawing.Point(3, 90);
            this.butSpr.Name = "butSpr";
            this.butSpr.Size = new System.Drawing.Size(245, 69);
            this.butSpr.TabIndex = 5;
            this.butSpr.Text = "Затраченные материалы";
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 70);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1250, 730);
            this.panelContainer.TabIndex = 3;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button butExit;
        private Guna.UI2.WinForms.Guna2Button butNewZak;
        private Guna.UI2.WinForms.Guna2Button butSpr;
        private System.Windows.Forms.Panel panelContainer;
    }
}