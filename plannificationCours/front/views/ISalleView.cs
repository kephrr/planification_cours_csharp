using plannificationCours.back.data.dto;
using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace plannificationCours.front.views
{
    public interface ISalleView : IView
    {
        string Message { get; set; }
        bool IsEdit {get; set;}

        bool IsSuccessfull { get; set;}


        //Donnees manipulées par la vue

        int SalleId { get; set;}

        string salleName { get; set; }

        //events déclenche dans la vue

        event EventHandler clickBtnAddEvent;

        event EventHandler clickBtnDelEvent;

        event EventHandler SelectSalleEvent;
        event EventHandler clickBtnUpEvent;


        //Methodes de chargement des donnees dans la vue
        public void SetBindingSource(ObservableCollection<SalleDto> salleList);
        

    }
}
