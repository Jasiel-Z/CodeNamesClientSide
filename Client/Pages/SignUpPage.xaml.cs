using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Linq;
using System.Text;
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
    /// Lógica de interacción para LoginPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

       

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = TB_Nickname.Text;
            string email = TB_Email.Text;
            string password = TB_Password.Text;
            ServiceReference1.IDatabaseService client = new ServiceReference1.DatabaseServiceClient();
            client.AddUserAccountToDatabase(username, email, password);

            TB_Email.Clear();
            TB_Password.Clear();
            TB_Nickname.Clear();

            MessageBox.Show("El registro del usuario se ha realizado con éxito", "Registro Exitoso");

        }
    }
}
