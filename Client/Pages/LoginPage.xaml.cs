using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            var username = TbNickname.Text;
            var password = PsbPassword.Password;
            if (!String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(password))
            {
                if (AreValidStrings(username, password) && AreTooLongStrings(username, password))
                {
                    try
                    {
                       // LoginAction(username, password);
                    }
                    catch (EndpointNotFoundException ex)
                    {
                        //Log.Error($"{ex.Message}");
                        //MessageBox.Show(Properties.Resources.GENERAL_NOCONNECTION_MESSAGE, Properties.Resources.GENERAL_ERROR_TITLE, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (CommunicationObjectFaultedException ex)
                    {
                        //Log.Error($"{ex.Message}");
                        //MessageBox.Show(Properties.Resources.GENERAL_NOCONNECTION_MESSAGE, Properties.Resources.GENERAL_ERROR_TITLE, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (TimeoutException ex)
                    {
                        //Log.Error($"{ex.Message}");
                       // MessageBox.Show(Properties.Resources.GENERAL_NOCONNECTION_MESSAGE, Properties.Resources.GENERAL_ERROR_TITLE, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    finally
                    {
                        //client.Abort();
                    }
                }
                else
                {
                   // MessageBox.Show(Properties.Resources.LOGIN_INVALIDFORMAT_MESSAGE, Properties.Resources.GENERAL_WARNING_TITLE, MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                //MessageBox.Show(Properties.Resources.LOGIN_NOUSERORPASSWORD_MESSAGE, Properties.Resources.GENERAL_WARNING_TITLE, MessageBoxButton.OK, MessageBoxImage.Warning);
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
        private bool AreTooLongStrings(string username, string password)
        {
            var isntTooLong = false;
            if (username.Length <= 45 || password.Length <= 16)
            {
                isntTooLong = true;
            }
            return isntTooLong;
        }
    }
}
