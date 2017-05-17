namespace timetable
{
    partial class EditProject
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
            System.Windows.Forms.Label pROJECT_NAMELabel;
            System.Windows.Forms.Label pROJECT_BEGINLabel;
            System.Windows.Forms.Label pROJECT_ENDLabel;
            System.Windows.Forms.Label pROJECT_MAXHOURSLabel;
            System.Windows.Forms.Label pROJECT_DESCRIPTIONLabel1;
            System.Windows.Forms.Label pROJECT_IDLabel;
            this.masterDataSet = new timetable.masterDataSet();
            this.pROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTTableAdapter = new timetable.masterDataSetTableAdapters.PROJECTTableAdapter();
            this.tableAdapterManager = new timetable.masterDataSetTableAdapters.TableAdapterManager();
            this.pROJECT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pROJECT_BEGINDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pROJECT_ENDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pROJECT_MAXHOURSTextBox = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pROJECT_DESCRIPTIONRichTextBox = new System.Windows.Forms.RichTextBox();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new timetable.masterDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.pROJECT_IDTextBox = new System.Windows.Forms.TextBox();
            pROJECT_NAMELabel = new System.Windows.Forms.Label();
            pROJECT_BEGINLabel = new System.Windows.Forms.Label();
            pROJECT_ENDLabel = new System.Windows.Forms.Label();
            pROJECT_MAXHOURSLabel = new System.Windows.Forms.Label();
            pROJECT_DESCRIPTIONLabel1 = new System.Windows.Forms.Label();
            pROJECT_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pROJECT_NAMELabel
            // 
            pROJECT_NAMELabel.AutoSize = true;
            pROJECT_NAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pROJECT_NAMELabel.Location = new System.Drawing.Point(66, 59);
            pROJECT_NAMELabel.Name = "pROJECT_NAMELabel";
            pROJECT_NAMELabel.Size = new System.Drawing.Size(206, 29);
            pROJECT_NAMELabel.TabIndex = 3;
            pROJECT_NAMELabel.Text = "Име на проекта:";
            // 
            // pROJECT_BEGINLabel
            // 
            pROJECT_BEGINLabel.AutoSize = true;
            pROJECT_BEGINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pROJECT_BEGINLabel.Location = new System.Drawing.Point(66, 116);
            pROJECT_BEGINLabel.Name = "pROJECT_BEGINLabel";
            pROJECT_BEGINLabel.Size = new System.Drawing.Size(186, 29);
            pROJECT_BEGINLabel.TabIndex = 5;
            pROJECT_BEGINLabel.Text = "Начална Дата:";
            // 
            // pROJECT_ENDLabel
            // 
            pROJECT_ENDLabel.AutoSize = true;
            pROJECT_ENDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pROJECT_ENDLabel.Location = new System.Drawing.Point(66, 170);
            pROJECT_ENDLabel.Name = "pROJECT_ENDLabel";
            pROJECT_ENDLabel.Size = new System.Drawing.Size(172, 29);
            pROJECT_ENDLabel.TabIndex = 7;
            pROJECT_ENDLabel.Text = "Крайна Дата:";
            // 
            // pROJECT_MAXHOURSLabel
            // 
            pROJECT_MAXHOURSLabel.AutoSize = true;
            pROJECT_MAXHOURSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pROJECT_MAXHOURSLabel.Location = new System.Drawing.Point(66, 220);
            pROJECT_MAXHOURSLabel.Name = "pROJECT_MAXHOURSLabel";
            pROJECT_MAXHOURSLabel.Size = new System.Drawing.Size(257, 29);
            pROJECT_MAXHOURSLabel.TabIndex = 13;
            pROJECT_MAXHOURSLabel.Text = "Максимални часове:";
            // 
            // pROJECT_DESCRIPTIONLabel1
            // 
            pROJECT_DESCRIPTIONLabel1.AutoSize = true;
            pROJECT_DESCRIPTIONLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pROJECT_DESCRIPTIONLabel1.Location = new System.Drawing.Point(66, 272);
            pROJECT_DESCRIPTIONLabel1.Name = "pROJECT_DESCRIPTIONLabel1";
            pROJECT_DESCRIPTIONLabel1.Size = new System.Drawing.Size(136, 29);
            pROJECT_DESCRIPTIONLabel1.TabIndex = 16;
            pROJECT_DESCRIPTIONLabel1.Text = "Описание:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTBindingSource
            // 
            this.pROJECTBindingSource.AllowNew = true;
            this.pROJECTBindingSource.DataMember = "PROJECT";
            this.pROJECTBindingSource.DataSource = this.masterDataSet;
            // 
            // pROJECTTableAdapter
            // 
            this.pROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.PROJECT_HOURSTableAdapter = null;
            this.tableAdapterManager.PROJECT_MONTHSTableAdapter = null;
            this.tableAdapterManager.PROJECTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = timetable.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECT_NAMETextBox
            // 
            this.pROJECT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTBindingSource, "PROJECT_NAME", true));
            this.pROJECT_NAMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROJECT_NAMETextBox.Location = new System.Drawing.Point(371, 56);
            this.pROJECT_NAMETextBox.Name = "pROJECT_NAMETextBox";
            this.pROJECT_NAMETextBox.Size = new System.Drawing.Size(220, 36);
            this.pROJECT_NAMETextBox.TabIndex = 1;
            // 
            // pROJECT_BEGINDateTimePicker
            // 
            this.pROJECT_BEGINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pROJECTBindingSource, "PROJECT_BEGIN", true));
            this.pROJECT_BEGINDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROJECT_BEGINDateTimePicker.Location = new System.Drawing.Point(371, 110);
            this.pROJECT_BEGINDateTimePicker.Name = "pROJECT_BEGINDateTimePicker";
            this.pROJECT_BEGINDateTimePicker.Size = new System.Drawing.Size(412, 36);
            this.pROJECT_BEGINDateTimePicker.TabIndex = 2;
            // 
            // pROJECT_ENDDateTimePicker
            // 
            this.pROJECT_ENDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pROJECTBindingSource, "PROJECT_END", true));
            this.pROJECT_ENDDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROJECT_ENDDateTimePicker.Location = new System.Drawing.Point(371, 164);
            this.pROJECT_ENDDateTimePicker.Name = "pROJECT_ENDDateTimePicker";
            this.pROJECT_ENDDateTimePicker.Size = new System.Drawing.Size(412, 36);
            this.pROJECT_ENDDateTimePicker.TabIndex = 3;
            // 
            // pROJECT_MAXHOURSTextBox
            // 
            this.pROJECT_MAXHOURSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTBindingSource, "PROJECT_MAXHOURS", true));
            this.pROJECT_MAXHOURSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROJECT_MAXHOURSTextBox.Location = new System.Drawing.Point(371, 217);
            this.pROJECT_MAXHOURSTextBox.Name = "pROJECT_MAXHOURSTextBox";
            this.pROJECT_MAXHOURSTextBox.Size = new System.Drawing.Size(100, 36);
            this.pROJECT_MAXHOURSTextBox.TabIndex = 5;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(635, 440);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(180, 60);
            this.update.TabIndex = 7;
            this.update.Text = "Обнови";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(422, 440);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(180, 60);
            this.back.TabIndex = 8;
            this.back.Text = "Отказ";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pROJECT_DESCRIPTIONRichTextBox
            // 
            this.pROJECT_DESCRIPTIONRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTBindingSource, "PROJECT_DESCRIPTION", true));
            this.pROJECT_DESCRIPTIONRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROJECT_DESCRIPTIONRichTextBox.Location = new System.Drawing.Point(371, 269);
            this.pROJECT_DESCRIPTIONRichTextBox.Name = "pROJECT_DESCRIPTIONRichTextBox";
            this.pROJECT_DESCRIPTIONRichTextBox.Size = new System.Drawing.Size(412, 126);
            this.pROJECT_DESCRIPTIONRichTextBox.TabIndex = 6;
            this.pROJECT_DESCRIPTIONRichTextBox.Text = "";
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.masterDataSet;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // pROJECT_IDLabel
            // 
            pROJECT_IDLabel.AutoSize = true;
            pROJECT_IDLabel.Location = new System.Drawing.Point(103, 30);
            pROJECT_IDLabel.Name = "pROJECT_IDLabel";
            pROJECT_IDLabel.Size = new System.Drawing.Size(93, 17);
            pROJECT_IDLabel.TabIndex = 17;
            pROJECT_IDLabel.Text = "PROJECT ID:";
            pROJECT_IDLabel.Visible = false;
            // 
            // pROJECT_IDTextBox
            // 
            this.pROJECT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTBindingSource, "PROJECT_ID", true));
            this.pROJECT_IDTextBox.Location = new System.Drawing.Point(202, 27);
            this.pROJECT_IDTextBox.Name = "pROJECT_IDTextBox";
            this.pROJECT_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.pROJECT_IDTextBox.TabIndex = 18;
            this.pROJECT_IDTextBox.Visible = false;
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 641);
            this.Controls.Add(pROJECT_IDLabel);
            this.Controls.Add(this.pROJECT_IDTextBox);
            this.Controls.Add(pROJECT_DESCRIPTIONLabel1);
            this.Controls.Add(this.pROJECT_DESCRIPTIONRichTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(pROJECT_MAXHOURSLabel);
            this.Controls.Add(this.pROJECT_MAXHOURSTextBox);
            this.Controls.Add(pROJECT_ENDLabel);
            this.Controls.Add(this.pROJECT_ENDDateTimePicker);
            this.Controls.Add(pROJECT_BEGINLabel);
            this.Controls.Add(this.pROJECT_BEGINDateTimePicker);
            this.Controls.Add(pROJECT_NAMELabel);
            this.Controls.Add(this.pROJECT_NAMETextBox);
            this.Name = "EditProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редакция на проект";
            this.Load += new System.EventHandler(this.EditProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource pROJECTBindingSource;
        private masterDataSetTableAdapters.PROJECTTableAdapter pROJECTTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox pROJECT_NAMETextBox;
        private System.Windows.Forms.DateTimePicker pROJECT_BEGINDateTimePicker;
        private System.Windows.Forms.DateTimePicker pROJECT_ENDDateTimePicker;
        private System.Windows.Forms.TextBox pROJECT_MAXHOURSTextBox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RichTextBox pROJECT_DESCRIPTIONRichTextBox;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private masterDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.TextBox pROJECT_IDTextBox;
    }
}