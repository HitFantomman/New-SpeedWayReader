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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNumberCar = new System.Windows.Forms.TextBox();
            this.ViewHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.historyvisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datevisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbercarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typevisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyvisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(16, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Текущие настройки";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ViewHistory.AutoGenerateColumns = false;
            this.ViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datevisitDataGridViewTextBoxColumn,
            this.numbercarDataGridViewTextBoxColumn,
            this.typevisitDataGridViewTextBoxColumn});
            this.ViewHistory.DataSource = this.historyvisitBindingSource;
            this.ViewHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewHistory.Location = new System.Drawing.Point(0, 123);
            this.ViewHistory.Name = "ViewHistory";
            this.ViewHistory.Size = new System.Drawing.Size(957, 373);
            this.ViewHistory.TabIndex = 3;
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
            // historyvisitBindingSource
            // 
            this.historyvisitBindingSource.DataSource = typeof(DataModel.history_visit);
            // 
            // datevisitDataGridViewTextBoxColumn
            // 
            this.datevisitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datevisitDataGridViewTextBoxColumn.DataPropertyName = "date_visit";
            this.datevisitDataGridViewTextBoxColumn.HeaderText = "Дата проезда";
            this.datevisitDataGridViewTextBoxColumn.Name = "datevisitDataGridViewTextBoxColumn";
            // 
            // numbercarDataGridViewTextBoxColumn
            // 
            this.numbercarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numbercarDataGridViewTextBoxColumn.DataPropertyName = "number_car";
            this.numbercarDataGridViewTextBoxColumn.HeaderText = "Номер машины";
            this.numbercarDataGridViewTextBoxColumn.Name = "numbercarDataGridViewTextBoxColumn";
            // 
            // typevisitDataGridViewTextBoxColumn
            // 
            this.typevisitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typevisitDataGridViewTextBoxColumn.DataPropertyName = "type_visit";
            this.typevisitDataGridViewTextBoxColumn.HeaderText = "Тип проезда";
            this.typevisitDataGridViewTextBoxColumn.Name = "typevisitDataGridViewTextBoxColumn";
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MenuMain);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuMain;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyvisitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNumberCar;
        private System.Windows.Forms.DataGridView ViewHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn datevisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbercarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typevisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historyvisitBindingSource;
    }
}