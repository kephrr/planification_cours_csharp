using plannificationCours.back.data.entities;
using plannificationCours.back.data.enums;
using plannificationCours.back.data.repositories;
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
    public class FormMenuPresenter : IFormMenuPresenter
    {
        public IMenuFormView view;

        public FormMenuPresenter(IMenuFormView view, User userConnect)
        {
            this.view = view;
            this.view.UserConnect = userConnect;
            view.showViewSalle += ShowSalleHandler;
            this.view.ShowForm();
        }

        public void ShowSalleHandler(object sender, EventArgs e)
        {
            // IMenuFormView view = 
            ISalleView salleView = SalleView.GetInstance(view as MenuFormView);
            ISalleRepository salleRepository = FabriqueRepositories.GetInstance(RepositoryName.SalleRepository) as ISalleRepository;
            ISalleServices salleServices = FabriqueServices.GetSalleServices(salleRepository);
            ISallePresenter sallePresenter = new SallePresenter(salleServices, salleView);
        }
    }
}
