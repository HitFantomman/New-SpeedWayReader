namespace MainForm
{
    partial class Settings
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BoxConnect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListStatus = new System.Windows.Forms.ListBox();
            this.BtnBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.AutoSize = true;
            this.BtnConnect.Location = new System.Drawing.Point(172, 59);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(149, 39);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Подключиться";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BoxConnect
            // 
            this.BoxConnect.Location = new System.Drawing.Point(172, 22);
            this.BoxConnect.Name = "BoxConnect";
            this.BoxConnect.Size = new System.Drawing.Size(281, 29);
            this.BoxConnect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Подключение";
            // 
            // ListStatus
            // 
            this.ListStatus.FormattingEnabled = true;
            this.ListStatus.ItemHeight = 22;
            this.ListStatus.Location = new System.Drawing.Point(468, 25);
            this.ListStatus.Name = "ListStatus";
            this.ListStatus.Size = new System.Drawing.Size(311, 400);
            this.ListStatus.TabIndex = 3;
            // 
            // BtnBD
            // 
            this.BtnBD.AutoSize = true;
            this.BtnBD.Location = new System.Drawing.Point(31, 358);
            this.BtnBD.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnBD.Name = "BtnBD";
            this.BtnBD.Size = new System.Drawing.Size(192, 39);
            this.BtnBD.TabIndex = 4;
            this.BtnBD.Text = "Хранилище данных";
            this.BtnBD.UseVisualStyleBackColor = true;
            this.BtnBD.Click += new System.EventHandler(this.BtnBD_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 430);
            this.Controls.Add(this.BtnBD);
            this.Controls.Add(this.ListStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxConnect);
            this.Controls.Add(this.BtnConnect);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки считывателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox BoxConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListStatus;
        private System.Windows.Forms.Button BtnBD;
    }
}