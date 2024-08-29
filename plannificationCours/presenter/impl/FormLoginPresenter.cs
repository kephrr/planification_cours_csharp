using plannificationCours.back.data.entities;
using plannificationCours.back.services;
using plannificationCours.front.views;
using plannificationCours.front.views.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.presenter.impl
{
    public class FormLoginPresenter:IFormLoginPresenter
    {
        private ILoginFormView view;
        private IUserService userService;

        public FormLoginPresenter(ILoginFormView view, IUserService userService)
        {
            this.view = view;
            this.userService = userService;
            view.clickBtnAddConnexion += ConnexionHandler; 
        }

        public void ConnexionHandler(object sender, EventArgs e)
        {
           if(!String.IsNullOrEmpty(view.Login)&& !String.IsNullOrEmpty(view.Password))

            {
                if (userService!=null) {
                    User userConnect = userService.Connexion(view.Login, view.Password);
                    if (userConnect != null)
                    {
                        IMenuFormView menuFormView = new MenuFormView();
                        IFormMenuPresenter presenter = new FormMenuPresenter(menuFormView, userConnect);
                        view.HideForm();
                    }
                    else
                    {
                        view.ErrorMessage = "Login ou Mot de passe incorrect";
                    }
                }
                else
                {
                    view.ErrorMessage = "Nulle";
                }

            }
            else
            {
                view.ErrorMessage = "Login ou Mot de passe vide";
            }

        }
    }
}
