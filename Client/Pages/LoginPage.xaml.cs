using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client.Pages
{
    /// <summary>
    /// Lógica de interacción para SignUpPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateCards())
            {
                ShowMessage("Validando la autenticidad de los datos", "Credenciales válidas");
            }
        }

        private void BtnLogInInvite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {

        }
        public Boolean ValidateCards()
        {
            string nickname = TbNickname.Text;
            string password = PsbPassword.Password;

            // Verifica si el campo "nickname" está vacío o supera los 40 caracteres.

            Boolean isValid = true;
            if (string.IsNullOrWhiteSpace(nickname) || nickname.Length > 40)
            {

                isValid = false;
            }

            // Verifica si el campo "password" está vacío o supera los 40 caracteres.
            if (string.IsNullOrWhiteSpace(password) || password.Length > 40)
            {

                isValid = false;
            }

            // Si ninguno de los campos tiene problemas, entonces los datos son válidos.
            return true;
        }

        private void ShowMessage(string message, string title)
        {

            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private bool AreValidStrings(string username, string password)
        {
            var isValid = false;
            if (Regex.IsMatch(username, "^[a-zA-Z0-9]*$") && Regex.IsMatch(password, "^[a-zA-Z0-9]*$"))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
