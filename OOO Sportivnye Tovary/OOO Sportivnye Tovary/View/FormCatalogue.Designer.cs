namespace OOO_Sportivnye_Tovary
{
    partial class FormCatalogue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogue));
            this.TableLayoutPanelTemplateUpper = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelFormName = new System.Windows.Forms.Label();
            this.TableLayoutPanelCatalogueBack = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCatalogueUser = new System.Windows.Forms.Label();
            this.ButtonCatalogueExit = new System.Windows.Forms.Button();
            this.TableLayoutPanelTemplateDowner = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelCatalogueMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxCost = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCatalogue = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelProductDisplay = new System.Windows.Forms.Label();
            this.TableLayoutPanelTemplateUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.TableLayoutPanelCatalogueBack.SuspendLayout();
            this.TableLayoutPanelCatalogueMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelTemplateUpper
            // 
            this.TableLayoutPanelTemplateUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.TableLayoutPanelTemplateUpper.ColumnCount = 3;
            this.TableLayoutPanelTemplateUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.TableLayoutPanelTemplateUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.5F));
            this.TableLayoutPanelTemplateUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.TableLayoutPanelTemplateUpper.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.TableLayoutPanelTemplateUpper.Controls.Add(this.LabelFormName, 1, 0);
            this.TableLayoutPanelTemplateUpper.Controls.Add(this.TableLayoutPanelCatalogueBack, 2, 0);
            this.TableLayoutPanelTemplateUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelTemplateUpper.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelTemplateUpper.Name = "TableLayoutPanelTemplateUpper";
            this.TableLayoutPanelTemplateUpper.RowCount = 1;
            this.TableLayoutPanelTemplateUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTemplateUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.TableLayoutPanelTemplateUpper.Size = new System.Drawing.Size(1262, 56);
            this.TableLayoutPanelTemplateUpper.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::OOO_Sportivnye_Tovary.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelFormName
            // 
            this.LabelFormName.AutoSize = true;
            this.LabelFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFormName.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFormName.Location = new System.Drawing.Point(91, 0);
            this.LabelFormName.Name = "LabelFormName";
            this.LabelFormName.Size = new System.Drawing.Size(833, 56);
            this.LabelFormName.TabIndex = 1;
            this.LabelFormName.Text = "Каталог";
            this.LabelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanelCatalogueBack
            // 
            this.TableLayoutPanelCatalogueBack.ColumnCount = 2;
            this.TableLayoutPanelCatalogueBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCatalogueBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCatalogueBack.Controls.Add(this.LabelCatalogueUser, 0, 0);
            this.TableLayoutPanelCatalogueBack.Controls.Add(this.ButtonCatalogueExit, 1, 0);
            this.TableLayoutPanelCatalogueBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelCatalogueBack.Location = new System.Drawing.Point(930, 3);
            this.TableLayoutPanelCatalogueBack.Name = "TableLayoutPanelCatalogueBack";
            this.TableLayoutPanelCatalogueBack.RowCount = 1;
            this.TableLayoutPanelCatalogueBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCatalogueBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelCatalogueBack.Size = new System.Drawing.Size(329, 50);
            this.TableLayoutPanelCatalogueBack.TabIndex = 2;
            // 
            // LabelCatalogueUser
            // 
            this.LabelCatalogueUser.AutoSize = true;
            this.LabelCatalogueUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCatalogueUser.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCatalogueUser.Location = new System.Drawing.Point(3, 0);
            this.LabelCatalogueUser.Name = "LabelCatalogueUser";
            this.LabelCatalogueUser.Size = new System.Drawing.Size(158, 50);
            this.LabelCatalogueUser.TabIndex = 3;
            this.LabelCatalogueUser.Text = "Каталог";
            // 
            // ButtonCatalogueExit
            // 
            this.ButtonCatalogueExit.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.ButtonCatalogueExit.Location = new System.Drawing.Point(167, 3);
            this.ButtonCatalogueExit.Name = "ButtonCatalogueExit";
            this.ButtonCatalogueExit.Size = new System.Drawing.Size(159, 44);
            this.ButtonCatalogueExit.TabIndex = 2;
            this.ButtonCatalogueExit.Text = "Назад";
            this.ButtonCatalogueExit.UseVisualStyleBackColor = true;
            this.ButtonCatalogueExit.Click += new System.EventHandler(this.ButtonCatalogueExit_Click);
            // 
            // TableLayoutPanelTemplateDowner
            // 
            this.TableLayoutPanelTemplateDowner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.TableLayoutPanelTemplateDowner.ColumnCount = 1;
            this.TableLayoutPanelTemplateDowner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTemplateDowner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelTemplateDowner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanelTemplateDowner.Location = new System.Drawing.Point(0, 609);
            this.TableLayoutPanelTemplateDowner.Name = "TableLayoutPanelTemplateDowner";
            this.TableLayoutPanelTemplateDowner.RowCount = 1;
            this.TableLayoutPanelTemplateDowner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTemplateDowner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelTemplateDowner.Size = new System.Drawing.Size(1262, 64);
            this.TableLayoutPanelTemplateDowner.TabIndex = 1;
            // 
            // TableLayoutPanelCatalogueMain
            // 
            this.TableLayoutPanelCatalogueMain.ColumnCount = 1;
            this.TableLayoutPanelCatalogueMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCatalogueMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TableLayoutPanelCatalogueMain.Controls.Add(this.DGVCatalogue, 0, 1);
            this.TableLayoutPanelCatalogueMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelCatalogueMain.Location = new System.Drawing.Point(0, 56);
            this.TableLayoutPanelCatalogueMain.Name = "TableLayoutPanelCatalogueMain";
            this.TableLayoutPanelCatalogueMain.RowCount = 2;
            this.TableLayoutPanelCatalogueMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelCatalogueMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TableLayoutPanelCatalogueMain.Size = new System.Drawing.Size(1262, 553);
            this.TableLayoutPanelCatalogueMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.6051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.280254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.369427F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.66879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98726F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.28662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.971338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxSearch, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxManufacturer, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxDiscount, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCost, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelProductDisplay, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.TextBoxSearch.Location = new System.Drawing.Point(1101, 3);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(152, 28);
            this.TextBoxSearch.TabIndex = 9;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1026, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 49);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поиск";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComboBoxManufacturer
            // 
            this.ComboBoxManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.ComboBoxManufacturer.FormattingEnabled = true;
            this.ComboBoxManufacturer.Location = new System.Drawing.Point(834, 3);
            this.ComboBoxManufacturer.Name = "ComboBoxManufacturer";
            this.ComboBoxManufacturer.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxManufacturer.TabIndex = 6;
            this.ComboBoxManufacturer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCost_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(696, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Производитель";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComboBoxDiscount
            // 
            this.ComboBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.ComboBoxDiscount.FormattingEnabled = true;
            this.ComboBoxDiscount.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-10%",
            "11-14%",
            ">=15%"});
            this.ComboBoxDiscount.Location = new System.Drawing.Point(562, 3);
            this.ComboBoxDiscount.Name = "ComboBoxDiscount";
            this.ComboBoxDiscount.Size = new System.Drawing.Size(128, 28);
            this.ComboBoxDiscount.TabIndex = 5;
            this.ComboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCost_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(482, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скидка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComboBoxCost
            // 
            this.ComboBoxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCost.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.ComboBoxCost.FormattingEnabled = true;
            this.ComboBoxCost.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.ComboBoxCost.Location = new System.Drawing.Point(303, 3);
            this.ComboBoxCost.Name = "ComboBoxCost";
            this.ComboBoxCost.Size = new System.Drawing.Size(173, 28);
            this.ComboBoxCost.TabIndex = 3;
            this.ComboBoxCost.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCost_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Стоимость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DGVCatalogue
            // 
            this.DGVCatalogue.AllowUserToAddRows = false;
            this.DGVCatalogue.AllowUserToDeleteRows = false;
            this.DGVCatalogue.BackgroundColor = System.Drawing.Color.White;
            this.DGVCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCatalogue.ColumnHeadersVisible = false;
            this.DGVCatalogue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGVCatalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCatalogue.Location = new System.Drawing.Point(3, 58);
            this.DGVCatalogue.Name = "DGVCatalogue";
            this.DGVCatalogue.ReadOnly = true;
            this.DGVCatalogue.RowHeadersWidth = 51;
            this.DGVCatalogue.RowTemplate.Height = 24;
            this.DGVCatalogue.Size = new System.Drawing.Size(1256, 492);
            this.DGVCatalogue.TabIndex = 1;
            this.DGVCatalogue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCatalogue_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 125;
            // 
            // LabelProductDisplay
            // 
            this.LabelProductDisplay.AutoSize = true;
            this.LabelProductDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.LabelProductDisplay.Location = new System.Drawing.Point(3, 0);
            this.LabelProductDisplay.Name = "LabelProductDisplay";
            this.LabelProductDisplay.Size = new System.Drawing.Size(83, 20);
            this.LabelProductDisplay.TabIndex = 10;
            this.LabelProductDisplay.Text = "Показано:";
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.TableLayoutPanelCatalogueMain);
            this.Controls.Add(this.TableLayoutPanelTemplateDowner);
            this.Controls.Add(this.TableLayoutPanelTemplateUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormCatalogue";
            this.Text = "Просмотр каталога";
            this.Load += new System.EventHandler(this.FormCatalogue_Load);
            this.TableLayoutPanelTemplateUpper.ResumeLayout(false);
            this.TableLayoutPanelTemplateUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.TableLayoutPanelCatalogueBack.ResumeLayout(false);
            this.TableLayoutPanelCatalogueBack.PerformLayout();
            this.TableLayoutPanelCatalogueMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalogue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelTemplateUpper;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelFormName;
        private System.Windows.Forms.Button ButtonCatalogueExit;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelTemplateDowner;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCatalogueMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxCost;
        private System.Windows.Forms.ComboBox ComboBoxManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCatalogueBack;
        private System.Windows.Forms.Label LabelCatalogueUser;
        private System.Windows.Forms.DataGridView DGVCatalogue;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label LabelProductDisplay;
    }
}

