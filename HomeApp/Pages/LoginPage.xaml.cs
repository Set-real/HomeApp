using System;
using System.Linq;
using Xamarin.Forms;

namespace HomeApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        // Константа для текста кнопки
        public const string BUTTON_TEXT = "Войти";
        // Переменная счетчика
        public static int loginCouner = 0;
        public LoginPage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.UWP)
            {
                loginButton.CornerRadius = 0;
            }
        }

        /// <summary>
        /// По клику обрабатываем счётчик и выводим разные сообщения
        /// </summary>
        private void Login_Click(object sender, EventArgs e)
        {
            if (loginCouner == 0)
            {
                // Если первая попытка - просто меняем сообщения
                loginButton.Text = $"Выполняется вход..";
            }
            else if (loginCouner > 5) // Слишком много попыток - показываем ошибку
            {
                // Деактивируем кнопку
                loginButton.IsEnabled = false;

                // Получаем последний дочерний элемент, используя свойство Children, затем выполняем распаковку
                var infoMessage = (Label)stackLayout.Children.Last();
                // Задаем текст элемента
                infoMessage.Text = "Слишком много попыток! Попробуйте позже";
                // задаем красный цвет сообщения
                infoMessage.TextColor = Color.FromRgb(255, 0, 0);

            }
            else
            {
                // Изменяем текст кнопки и показываем количество попыток входа
                loginButton.Text = $"Выполняется вход...   Попыток входа: {loginCouner}";
            }

            // Увеличиваем счетчик
            loginCouner += 1;
        }
    }
}