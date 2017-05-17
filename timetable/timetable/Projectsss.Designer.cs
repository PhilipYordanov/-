namespace timetable
{
    partial class Projectsss
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PROJECT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTMAXHOURSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new timetable.masterDataSet();
            this.pROJECTHOURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTTableAdapter = new timetable.masterDataSetTableAdapters.PROJECTTableAdapter();
            this.pROJECT_HOURSTableAdapter = new timetable.masterDataSetTableAdapters.PROJECT_HOURSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTHOURSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROJECT_ID,
            this.pROJECTNAMEDataGridViewTextBoxColumn,
            this.pROJECTBEGINDataGridViewTextBoxColumn,
            this.pROJECTENDDataGridViewTextBoxColumn,
            this.pROJECTSTATUSDataGridViewTextBoxColumn,
            this.pROJECTMAXHOURSDataGridViewTextBoxColumn,
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROJECTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 311);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Търсене по:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Данни за проекта";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(383, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 36);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.Search);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(635, 539);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 68);
            this.button3.TabIndex = 49;
            this.button3.Text = "Добави нов";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(442, 539);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 68);
            this.button5.TabIndex = 50;
            this.button5.Text = "Затвори";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Отворени",
            "Затворени"});
            this.comboBox1.Location = new System.Drawing.Point(383, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 37);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.SearchByStatus);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Име",
            "Статус"});
            this.comboBox2.Location = new System.Drawing.Point(229, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 37);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PROJECT_ID
            // 
            this.PROJECT_ID.DataPropertyName = "PROJECT_ID";
            this.PROJECT_ID.HeaderText = "ID";
            this.PROJECT_ID.Name = "PROJECT_ID";
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "Име на проекта";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            // 
            // pROJECTBEGINDataGridViewTextBoxColumn
            // 
            this.pROJECTBEGINDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.HeaderText = "Дата на започване";
            this.pROJECTBEGINDataGridViewTextBoxColumn.Name = "pROJECTBEGINDataGridViewTextBoxColumn";
            // 
            // pROJECTENDDataGridViewTextBoxColumn
            // 
            this.pROJECTENDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.HeaderText = "Дата на приключване";
            this.pROJECTENDDataGridViewTextBoxColumn.Name = "pROJECTENDDataGridViewTextBoxColumn";
            // 
            // pROJECTSTATUSDataGridViewTextBoxColumn
            // 
            this.pROJECTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Name = "pROJECTSTATUSDataGridViewTextBoxColumn";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROJECTMAXHOURSDataGridViewTextBoxColumn
            // 
            this.pROJECTMAXHOURSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_MAXHOURS";
            this.pROJECTMAXHOURSDataGridViewTextBoxColumn.HeaderText = "Максимални часове";
            this.pROJECTMAXHOURSDataGridViewTextBoxColumn.Name = "pROJECTMAXHOURSDataGridViewTextBoxColumn";
            // 
            // pROJECTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pROJECTDESCRIPTIONDataGridViewTextBoxColumn";
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
            // pROJECTHOURSBindingSource
            // 
            this.pROJECTHOURSBindingSource.DataMember = "PROJECT_HOURS";
            this.pROJECTHOURSBindingSource.DataSource = this.masterDataSet;
            // 
            // pROJECTTableAdapter
            // 
            this.pROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // pROJECT_HOURSTableAdapter
            // 
            this.pROJECT_HOURSTableAdapter.ClearBeforeFill = true;
            // 
            // Projectsss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 662);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Projectsss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проекти";
            this.Load += new System.EventHandler(this.Projectsss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTHOURSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource pROJECTBindingSource;
        private masterDataSetTableAdapters.PROJECTTableAdapter pROJECTTableAdapter;
        private System.Windows.Forms.BindingSource pROJECTHOURSBindingSource;
        private masterDataSetTableAdapters.PROJECT_HOURSTableAdapter pROJECT_HOURSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROJECT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTMAXHOURSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
    }
}