using plannificationCours.back.data.enums;
using plannificationCours.back.data.repositories;
using plannificationCours.back.services;
using plannificationCours.front.views;
using plannificationCours.front.views.impl;
using plannificationCours.presenter;
using plannificationCours.presenter.impl;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace plannificationCours
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hide();

            IUserService userService = FabriqueServices.GetUserService(FabriqueRepositories.GetInstance(RepositoryName.UserRepository) as IUserRepository);
            ILoginFormView loginFormView = new  LoginFormView();
            IFormLoginPresenter formLoginPresenter = new FormLoginPresenter(loginFormView, userService);
            loginFormView.ShowForm();

            //ISalleServices salleService = FabriqueServices.GetSalleServices(FabriqueRepositories.GetInstance(RepositoryName.SalleRepository) as ISalleRepository) as ISalleServices;
            //ISalleView salleView = new SalleView();
            //ISallePresenter sallePresenter = new SallePresenter(salleService, salleView);

         

        }
    }
}