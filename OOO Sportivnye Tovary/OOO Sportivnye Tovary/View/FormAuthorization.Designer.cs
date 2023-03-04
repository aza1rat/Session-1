namespace OOO_Sportivnye_Tovary
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.TableLayoutPanelTemplateUpper = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelFormName = new System.Windows.Forms.Label();
            this.ButtonTemplateExit = new System.Windows.Forms.Button();
            this.TableLayoutPanelTemplateDowner = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelAuthoriztionMain = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TableLayoutPanelAuthorizationEnter = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonGuestAuthorization = new System.Windows.Forms.Button();
            this.ButtonAuthoriztion = new System.Windows.Forms.Button();
            this.TableLayoutPanelAuthorizationCaptcha = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.TextBoxCaptcha = new System.Windows.Forms.TextBox();
            this.TimerAuthorizationBlock = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanelTemplateUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.TableLayoutPanelAuthoriztionMain.SuspendLayout();
            this.TableLayoutPanelAuthorizationEnter.SuspendLayout();
            this.TableLayoutPanelAuthorizationCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).BeginInit();
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
            this.TableLayoutPanelTemplateUpper.Controls.Add(this.ButtonTemplateExit, 2, 0);
            this.TableLayoutPanelTemplateUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelTemplateUpper.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelTemplateUpper.Name = "TableLayoutPanelTemplateUpper";
            this.TableLayoutPanelTemplateUpper.RowCount = 1;
            this.TableLayoutPanelTemplateUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTemplateUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.TableLayoutPanelTemplateUpper.Size = new System.Drawing.Size(566, 56);
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
            this.LabelFormName.Location = new System.Drawing.Point(42, 0);
            this.LabelFormName.Name = "LabelFormName";
            this.LabelFormName.Size = new System.Drawing.Size(370, 56);
            this.LabelFormName.TabIndex = 1;
            this.LabelFormName.Text = "Авторизация";
            this.LabelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonTemplateExit
            // 
            this.ButtonTemplateExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTemplateExit.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.ButtonTemplateExit.Location = new System.Drawing.Point(418, 3);
            this.ButtonTemplateExit.Name = "ButtonTemplateExit";
            this.ButtonTemplateExit.Size = new System.Drawing.Size(145, 50);
            this.ButtonTemplateExit.TabIndex = 2;
            this.ButtonTemplateExit.Text = "Выход";
            this.ButtonTemplateExit.UseVisualStyleBackColor = true;
            this.ButtonTemplateExit.Click += new System.EventHandler(this.ButtonTemplateExit_Click);
            // 
            // TableLayoutPanelTemplateDowner
            // 
            this.TableLayoutPanelTemplateDowner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.TableLayoutPanelTemplateDowner.ColumnCount = 1;
            this.TableLayoutPanelTemplateDowner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTemplateDowner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelTemplateDowner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanelTemplateDowner.Location = new System.Drawing.Point(0, 386);
            this.TableLayoutPanelTemplateDowner.Name = "TableLayoutPanelTemplateDowner";
            this.TableLayoutPanelTemplateDowner.RowCount = 1;
            this.TableLayoutPanelTemplateDowner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTemplateDowner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TableLayoutPanelTemplateDowner.Size = new System.Drawing.Size(566, 64);
            this.TableLayoutPanelTemplateDowner.TabIndex = 1;
            // 
            // TableLayoutPanelAuthoriztionMain
            // 
            this.TableLayoutPanelAuthoriztionMain.ColumnCount = 2;
            this.TableLayoutPanelAuthoriztionMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelAuthoriztionMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelAuthoriztionMain.Controls.Add(this.TextBoxPassword, 1, 1);
            this.TableLayoutPanelAuthoriztionMain.Controls.Add(this.LabelLogin, 0, 0);
            this.TableLayoutPanelAuthoriztionMain.Controls.Add(this.LabelPassword, 0, 1);
            this.TableLayoutPanelAuthoriztionMain.Controls.Add(this.TextBoxLogin, 1, 0);
            this.TableLayoutPanelAuthoriztionMain.Controls.Add(this.TableLayoutPanelAuthorizationEnter, 1, 2);
            this.TableLayoutPanelAuthoriztionMain.Controls.Add(this.TableLayoutPanelAuthorizationCaptcha, 0, 2);
            this.TableLayoutPanelAuthoriztionMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAuthoriztionMain.Location = new System.Drawing.Point(0, 56);
            this.TableLayoutPanelAuthoriztionMain.Name = "TableLayoutPanelAuthoriztionMain";
            this.TableLayoutPanelAuthoriztionMain.RowCount = 3;
            this.TableLayoutPanelAuthoriztionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelAuthoriztionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelAuthoriztionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelAuthoriztionMain.Size = new System.Drawing.Size(566, 330);
            this.TableLayoutPanelAuthoriztionMain.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.TextBoxPassword.Location = new System.Drawing.Point(286, 113);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(277, 31);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(3, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(277, 110);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Логин:";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(3, 110);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(277, 110);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Пароль:";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.TextBoxLogin.Location = new System.Drawing.Point(286, 3);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(277, 31);
            this.TextBoxLogin.TabIndex = 2;
            // 
            // TableLayoutPanelAuthorizationEnter
            // 
            this.TableLayoutPanelAuthorizationEnter.ColumnCount = 1;
            this.TableLayoutPanelAuthorizationEnter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAuthorizationEnter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelAuthorizationEnter.Controls.Add(this.ButtonGuestAuthorization, 0, 1);
            this.TableLayoutPanelAuthorizationEnter.Controls.Add(this.ButtonAuthoriztion, 0, 0);
            this.TableLayoutPanelAuthorizationEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAuthorizationEnter.Location = new System.Drawing.Point(286, 223);
            this.TableLayoutPanelAuthorizationEnter.Name = "TableLayoutPanelAuthorizationEnter";
            this.TableLayoutPanelAuthorizationEnter.RowCount = 2;
            this.TableLayoutPanelAuthorizationEnter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelAuthorizationEnter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelAuthorizationEnter.Size = new System.Drawing.Size(277, 104);
            this.TableLayoutPanelAuthorizationEnter.TabIndex = 4;
            // 
            // ButtonGuestAuthorization
            // 
            this.ButtonGuestAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGuestAuthorization.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGuestAuthorization.Location = new System.Drawing.Point(3, 55);
            this.ButtonGuestAuthorization.Name = "ButtonGuestAuthorization";
            this.ButtonGuestAuthorization.Size = new System.Drawing.Size(271, 46);
            this.ButtonGuestAuthorization.TabIndex = 4;
            this.ButtonGuestAuthorization.Text = "Войти как гость";
            this.ButtonGuestAuthorization.UseVisualStyleBackColor = true;
            this.ButtonGuestAuthorization.Click += new System.EventHandler(this.ButtonGuestAuthorization_Click);
            // 
            // ButtonAuthoriztion
            // 
            this.ButtonAuthoriztion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAuthoriztion.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuthoriztion.Location = new System.Drawing.Point(3, 3);
            this.ButtonAuthoriztion.Name = "ButtonAuthoriztion";
            this.ButtonAuthoriztion.Size = new System.Drawing.Size(271, 46);
            this.ButtonAuthoriztion.TabIndex = 3;
            this.ButtonAuthoriztion.Text = "Войти";
            this.ButtonAuthoriztion.UseVisualStyleBackColor = true;
            this.ButtonAuthoriztion.Click += new System.EventHandler(this.ButtonAuthoriztion_Click);
            // 
            // TableLayoutPanelAuthorizationCaptcha
            // 
            this.TableLayoutPanelAuthorizationCaptcha.ColumnCount = 1;
            this.TableLayoutPanelAuthorizationCaptcha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAuthorizationCaptcha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelAuthorizationCaptcha.Controls.Add(this.PictureBoxCaptcha, 0, 0);
            this.TableLayoutPanelAuthorizationCaptcha.Controls.Add(this.TextBoxCaptcha, 0, 1);
            this.TableLayoutPanelAuthorizationCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAuthorizationCaptcha.Location = new System.Drawing.Point(3, 223);
            this.TableLayoutPanelAuthorizationCaptcha.Name = "TableLayoutPanelAuthorizationCaptcha";
            this.TableLayoutPanelAuthorizationCaptcha.RowCount = 2;
            this.TableLayoutPanelAuthorizationCaptcha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanelAuthorizationCaptcha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanelAuthorizationCaptcha.Size = new System.Drawing.Size(277, 104);
            this.TableLayoutPanelAuthorizationCaptcha.TabIndex = 5;
            // 
            // PictureBoxCaptcha
            // 
            this.PictureBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxCaptcha.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxCaptcha.Name = "PictureBoxCaptcha";
            this.PictureBoxCaptcha.Size = new System.Drawing.Size(271, 66);
            this.PictureBoxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCaptcha.TabIndex = 0;
            this.PictureBoxCaptcha.TabStop = false;
            // 
            // TextBoxCaptcha
            // 
            this.TextBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCaptcha.Location = new System.Drawing.Point(3, 75);
            this.TextBoxCaptcha.Name = "TextBoxCaptcha";
            this.TextBoxCaptcha.Size = new System.Drawing.Size(271, 26);
            this.TextBoxCaptcha.TabIndex = 1;
            // 
            // TimerAuthorizationBlock
            // 
            this.TimerAuthorizationBlock.Interval = 1000;
            this.TimerAuthorizationBlock.Tick += new System.EventHandler(this.TimerAuthorizationBlock_Tick);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.TableLayoutPanelAuthoriztionMain);
            this.Controls.Add(this.TableLayoutPanelTemplateDowner);
            this.Controls.Add(this.TableLayoutPanelTemplateUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthorization_FormClosed);
            this.TableLayoutPanelTemplateUpper.ResumeLayout(false);
            this.TableLayoutPanelTemplateUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.TableLayoutPanelAuthoriztionMain.ResumeLayout(false);
            this.TableLayoutPanelAuthoriztionMain.PerformLayout();
            this.TableLayoutPanelAuthorizationEnter.ResumeLayout(false);
            this.TableLayoutPanelAuthorizationCaptcha.ResumeLayout(false);
            this.TableLayoutPanelAuthorizationCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelTemplateUpper;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelFormName;
        private System.Windows.Forms.Button ButtonTemplateExit;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelTemplateDowner;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAuthoriztionMain;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAuthorizationEnter;
        private System.Windows.Forms.Button ButtonGuestAuthorization;
        private System.Windows.Forms.Button ButtonAuthoriztion;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAuthorizationCaptcha;
        private System.Windows.Forms.PictureBox PictureBoxCaptcha;
        private System.Windows.Forms.TextBox TextBoxCaptcha;
        private System.Windows.Forms.Timer TimerAuthorizationBlock;
    }
}

