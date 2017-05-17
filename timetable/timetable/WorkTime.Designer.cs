namespace timetable
{
    partial class WorkTime
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
            this.pROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new timetable.masterDataSet();
            this.pROJECTTableAdapter = new timetable.masterDataSetTableAdapters.PROJECTTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fKPROJECTREFERENCEPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_MONTHSTableAdapter = new timetable.masterDataSetTableAdapters.PROJECT_MONTHSTableAdapter();
            this.fKPROJECTREFERENCEPROJECT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_HOURSTableAdapter = new timetable.masterDataSetTableAdapters.PROJECT_HOURSTableAdapter();
            this.eMPLOYEESTableAdapter = new timetable.masterDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.HoursField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEPROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEPROJECT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursField)).BeginInit();
            this.SuspendLayout();
            // 
            // pROJECTBindingSource
            // 
            this.pROJECTBindingSource.DataMember = "PROJECT";
            this.pROJECTBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTTableAdapter
            // 
            this.pROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(678, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "Запази";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(456, 529);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "Затвори";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Отработени часове:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Извършена дейност:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Дата:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(492, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 135);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(411, 36);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.eMPLOYEESBindingSource;
            this.listBox2.DisplayMember = "EMPLOYEE_NAME";
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(246, 101);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 352);
            this.listBox2.TabIndex = 12;
            this.listBox2.ValueMember = "EMPLOYEE_NAME";
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.masterDataSetBindingSource;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.pROJECTBindingSource;
            this.listBox1.DisplayMember = "PROJECT_NAME";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(24, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 352);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "PROJECT_NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Служител :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Проект :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 14;
            // 
            // fKPROJECTREFERENCEPROJECTBindingSource
            // 
            this.fKPROJECTREFERENCEPROJECTBindingSource.DataMember = "FK_PROJECT__REFERENCE_PROJECT";
            this.fKPROJECTREFERENCEPROJECTBindingSource.DataSource = this.pROJECTBindingSource;
            // 
            // pROJECT_MONTHSTableAdapter
            // 
            this.pROJECT_MONTHSTableAdapter.ClearBeforeFill = true;
            // 
            // fKPROJECTREFERENCEPROJECT1BindingSource
            // 
            this.fKPROJECTREFERENCEPROJECT1BindingSource.DataMember = "FK_PROJECT__REFERENCE_PROJECT1";
            this.fKPROJECTREFERENCEPROJECT1BindingSource.DataSource = this.pROJECTBindingSource;
            // 
            // pROJECT_HOURSTableAdapter
            // 
            this.pROJECT_HOURSTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // HoursField
            // 
            this.HoursField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursField.Location = new System.Drawing.Point(492, 417);
            this.HoursField.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HoursField.Name = "HoursField";
            this.HoursField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HoursField.Size = new System.Drawing.Size(120, 36);
            this.HoursField.TabIndex = 5;
            // 
            // WorkTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 654);
            this.Controls.Add(this.HoursField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WorkTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEPROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEPROJECT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource pROJECTBindingSource;
        private masterDataSetTableAdapters.PROJECTTableAdapter pROJECTTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fKPROJECTREFERENCEPROJECTBindingSource;
        private masterDataSetTableAdapters.PROJECT_MONTHSTableAdapter pROJECT_MONTHSTableAdapter;
        private System.Windows.Forms.BindingSource fKPROJECTREFERENCEPROJECT1BindingSource;
        private masterDataSetTableAdapters.PROJECT_HOURSTableAdapter pROJECT_HOURSTableAdapter;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private masterDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.NumericUpDown HoursField;
    }
}