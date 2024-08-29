using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace plannificationCours.front.views.impl
{
    /// <summary>
    /// Logique d'interaction pour LoginFormView.xaml
    /// </summary>
    public partial class LoginFormView : Window,ILoginFormView
    {
        private string message;

       

        public LoginFormView()
        {
            InitializeComponent();
            btnConnexion.Click += delegate
            {
                clickBtnAddConnexion.Invoke(this, EventArgs.Empty);
            };
        }


        public string ErrorMessage { get => message; set => message = value; }
        public string Login { get => inputLogin.Text.Trim(); set => throw new NotImplementedException(); }
        public string Password { get => inputPassword1.Text.Trim(); set => throw new NotImplementedException(); }


        public event EventHandler clickBtnAddConnexion;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {

        }

        public void HideForm()
        {
            Hide();
        }
        public void ShowForm()
        {
            Show();
        }
    }
}
