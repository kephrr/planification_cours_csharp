using plannificationCours.back.data.entities;
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
    /// Logique d'interaction pour MenuFormView.xaml
    /// </summary>
    public partial class MenuFormView : Window,IMenuFormView
    {
        private User userConnect;
        public MenuFormView()
        {
            InitializeComponent();
            btnMenuSalle.Click += delegate
            {
                showViewSalle.Invoke(this, EventArgs.Empty);
            };
        }

        public User UserConnect { get => userConnect; set => userConnect = value; }

        public event EventHandler showViewSalle;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //c'est bon je les ai mis dans l'interface //ces deux méthodes n'ont pas été défini dans l'interface
        public void ShowForm()
        {
            Show();
        }
        public void HideForm()
        {
            Hide();
        }
    }
}
