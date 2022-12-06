namespace МакДональдс
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveTxtButton = new System.Windows.Forms.Button();
            this.LoadTxtButton = new System.Windows.Forms.Button();
            this.SerializeJsonButton = new System.Windows.Forms.Button();
            this.DeserializeJsonButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.kcalDataGridViewTextBoxColumn,
            this.collectionStatusDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productClassBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(26, 68);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(975, 699);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Найдешевший товар",
            "Найдорожчий товар ",
            "Товар в колекції "});
            this.comboBox1.Location = new System.Drawing.Point(12, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(297, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(165, 38);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Шукати ";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(495, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(177, 38);
            this.Add.TabIndex = 3;
            this.Add.Text = "Додати товар";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(695, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(184, 38);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Видалити товар";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1510, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Про програму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1622, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Секунд";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveTxtButton
            // 
            this.SaveTxtButton.Location = new System.Drawing.Point(1076, 13);
            this.SaveTxtButton.Name = "SaveTxtButton";
            this.SaveTxtButton.Size = new System.Drawing.Size(189, 37);
            this.SaveTxtButton.TabIndex = 8;
            this.SaveTxtButton.Text = "Зберегти в .txt";
            this.SaveTxtButton.UseVisualStyleBackColor = true;
            this.SaveTxtButton.Click += new System.EventHandler(this.SaveTxtButton_Click);
            // 
            // LoadTxtButton
            // 
            this.LoadTxtButton.Location = new System.Drawing.Point(1284, 13);
            this.LoadTxtButton.Name = "LoadTxtButton";
            this.LoadTxtButton.Size = new System.Drawing.Size(193, 39);
            this.LoadTxtButton.TabIndex = 9;
            this.LoadTxtButton.Text = "Вивантажити з .txt";
            this.LoadTxtButton.UseVisualStyleBackColor = true;
            this.LoadTxtButton.Click += new System.EventHandler(this.LoadTxtButton_Click);
            // 
            // SerializeJsonButton
            // 
            this.SerializeJsonButton.Location = new System.Drawing.Point(1076, 83);
            this.SerializeJsonButton.Name = "SerializeJsonButton";
            this.SerializeJsonButton.Size = new System.Drawing.Size(189, 44);
            this.SerializeJsonButton.TabIndex = 10;
            this.SerializeJsonButton.Text = "Серіалізувати в JSON";
            this.SerializeJsonButton.UseVisualStyleBackColor = true;
            this.SerializeJsonButton.Click += new System.EventHandler(this.SerializeJsonButton_Click);
            // 
            // DeserializeJsonButton
            // 
            this.DeserializeJsonButton.Location = new System.Drawing.Point(1284, 83);
            this.DeserializeJsonButton.Name = "DeserializeJsonButton";
            this.DeserializeJsonButton.Size = new System.Drawing.Size(193, 44);
            this.DeserializeJsonButton.TabIndex = 11;
            this.DeserializeJsonButton.Text = "Десеріалізувати JSON";
            this.DeserializeJsonButton.UseVisualStyleBackColor = true;
            this.DeserializeJsonButton.Click += new System.EventHandler(this.DeserializeJsonButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва товару";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // kcalDataGridViewTextBoxColumn
            // 
            this.kcalDataGridViewTextBoxColumn.DataPropertyName = "Kcal";
            this.kcalDataGridViewTextBoxColumn.HeaderText = "Калорійність";
            this.kcalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kcalDataGridViewTextBoxColumn.Name = "kcalDataGridViewTextBoxColumn";
            this.kcalDataGridViewTextBoxColumn.Width = 150;
            // 
            // collectionStatusDataGridViewTextBoxColumn
            // 
            this.collectionStatusDataGridViewTextBoxColumn.DataPropertyName = "CollectionStatus";
            this.collectionStatusDataGridViewTextBoxColumn.HeaderText = "В/не(в) колекції";
            this.collectionStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collectionStatusDataGridViewTextBoxColumn.Name = "collectionStatusDataGridViewTextBoxColumn";
            this.collectionStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // productClassBindingSource
            // 
            this.productClassBindingSource.DataSource = typeof(МакДональдс.ProductClass);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1076, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Оновити ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 810);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeserializeJsonButton);
            this.Controls.Add(this.SerializeJsonButton);
            this.Controls.Add(this.LoadTxtButton);
            this.Controls.Add(this.SaveTxtButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "МакДональдс ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.BindingSource productClassBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SaveTxtButton;
        private System.Windows.Forms.Button LoadTxtButton;
        private System.Windows.Forms.Button SerializeJsonButton;
        private System.Windows.Forms.Button DeserializeJsonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

