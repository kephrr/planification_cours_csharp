using plannificationCours.back.data.dto;
using plannificationCours.back.data.entities;
using plannificationCours.back.services;
using plannificationCours.front.views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace plannificationCours.presenter.impl
{
    public class SallePresenter : ISallePresenter
    {
        private ISalleServices salleService;
        private ISalleView view;
        private ObservableCollection<SalleDto> observableSalle = new ObservableCollection<SalleDto>() ;

        public SallePresenter(ISalleServices salleService, ISalleView view)
        {
            this.salleService = salleService;
            this.view = view;
            loadData();
            ActiveEventHandler();
            this.view.ShowForm();
        }

        public void ActiveEventHandler()
        {
            view.clickBtnAddEvent += AddSalleHandler;
            view.clickBtnDelEvent += DeleteSalleHandler;
            view.clickBtnUpEvent += EditSalleHandler;
            view.SelectSalleEvent += SelectClasseHandler;
        }

        public void AddSalleHandler(object sender, EventArgs e)
        {
            if (!view.IsEdit)
            {
                try
                {
                    string nomSalle = view.salleName;
                    int id = salleService.AddSalle(new Salle()
                    {
                        Libelle = nomSalle,
                        Etat = true
                    });
                    view.IsSuccessfull = id != 0;
                    if (view.IsSuccessfull)
                    {
                        observableSalle = salleService.GetObservables(salleService.GetAllSalle());
                        view.Message = "Salle ajouté avec succès";
                    }
                   
                }
                catch (Exception)
                {
                    view.IsSuccessfull = false;
                    view.Message = "Erreur d'ajout";

                }
            }

        }

        public void DeleteSalleHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void EditSalleHandler(object sender, EventArgs e)
        {
            if (view.IsEdit)
            {
                try
                {
                    string nomSalle = view.salleName;
                    int id = salleService.UpdateSalle(new Salle()
                    {
                        Id = view.SalleId,
                        Libelle = nomSalle,
                        Etat = true
                    });
                    view.IsSuccessfull = id != 0;
                    if (view.IsSuccessfull)
                    {
                        observableSalle = salleService.GetObservables(salleService.GetAllSalle());
                        view.Message = "Salle Modifié avec succès";
                        view.IsEdit=  false;
                      
                    }

                   

                }
                catch (Exception)
                {
                    view.IsSuccessfull = false;
                    view.Message = "Erreur Ajout";
                }
            }
        }

        public void loadData()
        {
            DataTable dt = salleService.GetAllSalle();
          

            foreach (DataRow row in dt.Rows)
            {
                Salle salle = new Salle
                {
                    // Remplacez "NomColonne" par le nom de la colonne approprié dans votre DataTable
                    Id = int.Parse(row.ItemArray[0].ToString()),
                    Libelle = row[1].ToString()
                    // Ajoutez d'autres propriétés si nécessaire
                };


                observableSalle.Add(new SalleDto(salle));
            }
            view.SetBindingSource(observableSalle);
        }

        public void SelectClasseHandler(object sender, EventArgs e)
        {
           view.IsEdit = true;

            view.SalleId = observableSalle.First().Id;
        }
    }
}
