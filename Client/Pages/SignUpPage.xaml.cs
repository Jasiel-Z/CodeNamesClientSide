using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace Client.Pages
{
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new LoginPage());
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = TB_Nickname.Text;
            string email = TB_Email.Text;
            string password = TB_Password.Text;
            string confirmPassword = TB_ConfirmPassword.Text;

            // Aquí puedes agregar la lógica para validar los campos del formulario de registro.
            if (ValidateRegistration(username, email, password, confirmPassword))
            {
                // Llamar al servicio web o realizar el registro en la base de datos.
                ServiceReference1.IDatabaseService client = new ServiceReference1.DatabaseServiceClient();
                client.AddUserAccountToDatabase(username, email, password);

                // Limpiar los campos de entrada después del registro.
                TB_Email.Clear();
                TB_Password.Clear();
                
                TB_Nickname.Clear();

                // Mostrar un mensaje de registro exitoso.
                MessageBox.Show("El registro del usuario se ha realizado con éxito", "Registro Exitoso");
            }
            else
            {
                // Mostrar un mensaje de error si la validación falla.
                MessageBox.Show("Por favor, complete todos los campos correctamente", "Error de Registro");
            }
        }

        public bool ValidateRegistration(string username, string email, string password, string confirmPassword)
        {
            bool isValid = true; // Inicializar como verdadero y cambiar solo si hay un problema.

            // Validaciones específicas para el formulario de registro.
            if (string.IsNullOrWhiteSpace(username) || username.Length > 40)
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length > 40)
            {
                isValid = false;
            }

            if (password != confirmPassword)
            {
                isValid = false;
            }

            return isValid;
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^\w+([-+.']\w+)*@(gmail.com|hotmail.com|outlook.com|estudiantes.uv.mx)$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}