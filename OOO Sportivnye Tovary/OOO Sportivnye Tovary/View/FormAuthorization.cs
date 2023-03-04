using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOO_Sportivnye_Tovary.Classes;
using OOO_Sportivnye_Tovary.Entities;

namespace OOO_Sportivnye_Tovary
{
    public partial class FormAuthorization : Form
    {
        private String rigthCaptchaText;
        private int secondsOfBlock;
        public FormAuthorization()
        {
            InitializeComponent();
            try
            {
                Helper.ModelDB.Database.Connection.Open();
                MessageBox.Show("Подключение к БД прошло успешно", "Подключено к БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при подключении к БД",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ButtonAuthoriztion_Click(object sender, EventArgs e)
        {
            if (TextBoxCaptcha.Text != rigthCaptchaText && rigthCaptchaText != null)
            {
                ButtonAuthoriztion.Enabled =
                ButtonGuestAuthorization.Enabled = false;
                SetCaptha();
                TimerAuthorizationBlock.Start();
                return;
            }
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                SetCaptha();
                return;
            }
            var user = Helper.ModelDB.User.Where(u => u.UserLogin == login && u.UserPassword == password).FirstOrDefault();
            if (user != null)
            {
                var role = Helper.ModelDB.Role.Where(r => r.RoleID == user.UserRole).First();
                Helper.GetRole(role.RoleName);
                Helper.User = user;
                MessageBox.Show("Успешный вход под ролью:" +
                    Helper.UserRole.ToString(), "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCatalogue formCatalogue = new FormCatalogue();
                this.Hide();
                formCatalogue.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не найден:", "Провальная попытка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetCaptha();
                return;
            }

        }

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Helper.ModelDB.Database.Connection.Close();
                MessageBox.Show("Отключение от БД прошло успешно", "Отключено от БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при отключении от БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonTemplateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCaptha()
        {
            rigthCaptchaText = GenerateTextCaptcha(4);
            GenerateCaptcha(rigthCaptchaText);
        }

        private void ButtonGuestAuthorization_Click(object sender, EventArgs e)
        {
            if (TextBoxCaptcha.Text != rigthCaptchaText && rigthCaptchaText != null)
            {
                ButtonAuthoriztion.Enabled =
                ButtonGuestAuthorization.Enabled = false;
                SetCaptha();
                TimerAuthorizationBlock.Start();
                return;
            }
            Helper.User = null;
            MessageBox.Show("Успешный вход под ролью: Гость", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormCatalogue formCatalogue = new FormCatalogue();
            this.Hide();
            formCatalogue.ShowDialog();
            this.Show();
        }

        private void GenerateCaptcha(string captchaText)
        {
            int fontSize = 18;
            int symbolPlaceX = 0;
            int symbolPlaceY;
            Random random = new Random();
            Bitmap captchaBitmap = new Bitmap(PictureBoxCaptcha.Width, PictureBoxCaptcha.Height);
            Graphics captchaGraphics = Graphics.FromImage(captchaBitmap);
            Font captchaFont = new Font("Georgia", fontSize);
            captchaGraphics.Clear(Color.White);
            captchaGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < captchaText.Length; i++)
            {
                symbolPlaceX = random.Next(symbolPlaceX + fontSize / 2, symbolPlaceX + fontSize * 2);
                symbolPlaceY = random.Next(0, PictureBoxCaptcha.Height - fontSize * 2);
                captchaGraphics.DrawString(captchaText[i].ToString(), captchaFont, Brushes.Black, symbolPlaceX, symbolPlaceY);
                captchaGraphics.DrawLine(Pens.Black, symbolPlaceX, symbolPlaceY, random.Next(symbolPlaceX, PictureBoxCaptcha.Width),
                    random.Next(symbolPlaceY, PictureBoxCaptcha.Height));
            }
            captchaGraphics.Flush();
            PictureBoxCaptcha.Image = captchaBitmap;


        }

        private string GenerateTextCaptcha(int length)
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string generated = "";
            Random randomSymbol = new Random();
            for (int i = 0; i < length; i++)
            {
                int gettedSymbol = randomSymbol.Next(0, 36);
                generated += symbols[gettedSymbol];
            }
            return generated;
        }

        private void TimerAuthorizationBlock_Tick(object sender, EventArgs e)
        {
            secondsOfBlock++;
            if (secondsOfBlock == 10)
            {
                ButtonAuthoriztion.Enabled = true;
                ButtonGuestAuthorization.Enabled = true;
                secondsOfBlock = 0;
                SetCaptha();
                MessageBox.Show("Повторите ввод капчи", "Повторная попытка",MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimerAuthorizationBlock.Stop();
            }
        }
    }
}
