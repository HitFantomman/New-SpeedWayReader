namespace MainForm.EditForms
{
    partial class FormEditCarsRFID
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
            this.label1 = new System.Windows.Forms.Label();
            this.BoxDateRecord = new System.Windows.Forms.TextBox();
            this.carscRFIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoxEPC = new System.Windows.Forms.ComboBox();
            this.BoxNumberCar = new System.Windows.Forms.ComboBox();
            this.BoxStatusActive = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carscRFIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата записи";
            // 
            // BoxDateRecord
            // 
            this.BoxDateRecord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carscRFIDBindingSource, "date_record", true));
            this.BoxDateRecord.Location = new System.Drawing.Point(199, 35);
            this.BoxDateRecord.Name = "BoxDateRecord";
            this.BoxDateRecord.Size = new System.Drawing.Size(271, 29);
            this.BoxDateRecord.TabIndex = 1;
            // 
            // carscRFIDBindingSource
            // 
            this.carscRFIDBindingSource.DataSource = typeof(DataModel.cars_c_RFID);
            // 
            // BoxEPC
            // 
            this.BoxEPC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carscRFIDBindingSource, "epc", true));
            this.BoxEPC.FormattingEnabled = true;
            this.BoxEPC.Location = new System.Drawing.Point(199, 70);
            this.BoxEPC.Name = "BoxEPC";
            this.BoxEPC.Size = new System.Drawing.Size(271, 30);
            this.BoxEPC.TabIndex = 2;
            // 
            // BoxNumberCar
            // 
            this.BoxNumberCar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carscRFIDBindingSource, "number_car", true));
            this.BoxNumberCar.FormattingEnabled = true;
            this.BoxNumberCar.Location = new System.Drawing.Point(199, 106);
            this.BoxNumberCar.Name = "BoxNumberCar";
            this.BoxNumberCar.Size = new System.Drawing.Size(271, 30);
            this.BoxNumberCar.TabIndex = 3;
            // 
            // BoxStatusActive
            // 
            this.BoxStatusActive.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carscRFIDBindingSource, "status_active", true));
            this.BoxStatusActive.FormattingEnabled = true;
            this.BoxStatusActive.Location = new System.Drawing.Point(199, 142);
            this.BoxStatusActive.Name = "BoxStatusActive";
            this.BoxStatusActive.Size = new System.Drawing.Size(271, 30);
            this.BoxStatusActive.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "EPC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер машины";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Активность";
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.Location = new System.Drawing.Point(356, 187);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(114, 32);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // FormEditCarsRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 230);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxStatusActive);
            this.Controls.Add(this.BoxNumberCar);
            this.Controls.Add(this.BoxEPC);
            this.Controls.Add(this.BoxDateRecord);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormEditCarsRFID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма редактирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditCarsRFID_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.carscRFIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxDateRecord;
        private System.Windows.Forms.ComboBox BoxEPC;
        private System.Windows.Forms.ComboBox BoxNumberCar;
        private System.Windows.Forms.ComboBox BoxStatusActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.BindingSource carscRFIDBindingSource;
    }
}