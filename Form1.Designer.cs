
namespace bd
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyDBDataSet = new bd.CompanyDBDataSet();
            this.companyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new bd.CompanyDBDataSetTableAdapters.ЗаказыTableAdapter();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серийныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗавершенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаНалогаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.серийныйНомерDataGridViewTextBoxColumn,
            this.датаЗавершенияDataGridViewTextBoxColumn,
            this.ставкаНалогаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(176, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // companyDBDataSet
            // 
            this.companyDBDataSet.DataSetName = "CompanyDBDataSet";
            this.companyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyDBDataSetBindingSource
            // 
            this.companyDBDataSetBindingSource.DataSource = this.companyDBDataSet;
            this.companyDBDataSetBindingSource.Position = 0;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.companyDBDataSetBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // серийныйНомерDataGridViewTextBoxColumn
            // 
            this.серийныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.Name = "серийныйНомерDataGridViewTextBoxColumn";
            // 
            // датаЗавершенияDataGridViewTextBoxColumn
            // 
            this.датаЗавершенияDataGridViewTextBoxColumn.DataPropertyName = "Дата завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.Name = "датаЗавершенияDataGridViewTextBoxColumn";
            // 
            // ставкаНалогаDataGridViewTextBoxColumn
            // 
            this.ставкаНалогаDataGridViewTextBoxColumn.DataPropertyName = "Ставка налога";
            this.ставкаНалогаDataGridViewTextBoxColumn.HeaderText = "Ставка налога";
            this.ставкаНалогаDataGridViewTextBoxColumn.Name = "ставкаНалогаDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(845, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 150);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(679, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource companyDBDataSetBindingSource;
        private CompanyDBDataSet companyDBDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private CompanyDBDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗавершенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаНалогаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

