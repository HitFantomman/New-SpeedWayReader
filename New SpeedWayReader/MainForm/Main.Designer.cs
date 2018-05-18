namespace MainForm
{
    partial class Main
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
            this.BtnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNumberCar = new System.Windows.Forms.TextBox();
            this.ViewHistory = new System.Windows.Forms.DataGridView();
            this.MainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.TimerTags = new System.Windows.Forms.Timer(this.components);
            this.date_visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSettings
            // 
            this.BtnSettings.AutoSize = true;
            this.BtnSettings.Location = new System.Drawing.Point(16, 29);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(193, 39);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "Текущие настройки";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Распознанный номер";
            // 
            // BoxNumberCar
            // 
            this.BoxNumberCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxNumberCar.Location = new System.Drawing.Point(730, 58);
            this.BoxNumberCar.Name = "BoxNumberCar";
            this.BoxNumberCar.Size = new System.Drawing.Size(193, 26);
            this.BoxNumberCar.TabIndex = 2;
            this.BoxNumberCar.Text = "Неопознанный номер";
            this.BoxNumberCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewHistory
            // 
            this.ViewHistory.AllowUserToAddRows = false;
            this.ViewHistory.AllowUserToDeleteRows = false;
            this.ViewHistory.AllowUserToResizeColumns = false;
            this.ViewHistory.AllowUserToResizeRows = false;
            this.ViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_visit,
            this.number_car,
            this.type_visit,
            this.access});
            this.ViewHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewHistory.Location = new System.Drawing.Point(0, 123);
            this.ViewHistory.Name = "ViewHistory";
            this.ViewHistory.ReadOnly = true;
            this.ViewHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ViewHistory.Size = new System.Drawing.Size(957, 373);
            this.ViewHistory.TabIndex = 3;
            this.ViewHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewHistory_MouseClick);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = typeof(DataModel.history_visit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "История обнаружения меток:";
            // 
            // MenuMain
            // 
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(957, 24);
            this.MenuMain.TabIndex = 5;
            this.MenuMain.Text = "menuStrip1";
            // 
            // TimerTags
            // 
            this.TimerTags.Tick += new System.EventHandler(this.TimerTags_Tick);
            // 
            // date_visit
            // 
            this.date_visit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_visit.HeaderText = "Дата проезда";
            this.date_visit.Name = "date_visit";
            // 
            // number_car
            // 
            this.number_car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number_car.HeaderText = "Номер машины";
            this.number_car.Name = "number_car";
            // 
            // type_visit
            // 
            this.type_visit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type_visit.HeaderText = "Тип проезда";
            this.type_visit.Name = "type_visit";
            // 
            // access
            // 
            this.access.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.access.HeaderText = "Доступ";
            this.access.Name = "access";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewHistory);
            this.Controls.Add(this.BoxNumberCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.MenuMain);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuMain;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNumberCar;
        private System.Windows.Forms.DataGridView ViewHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.Timer TimerTags;
        private System.Windows.Forms.BindingSource MainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn access;
    }
}