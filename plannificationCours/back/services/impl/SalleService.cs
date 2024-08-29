using plannificationCours.back.data.dto;
using plannificationCours.back.data.entities;
using plannificationCours.back.data.repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace plannificationCours.back.services.impl
{
    public class SalleService : ISalleServices
    {

        private static  ISalleRepository salleRepository ;
        private static ISalleServices salleService = null;

        private SalleService()
        {
        }
        private SalleService(ISalleRepository repository)
        {
            salleRepository = repository;
        }
        public static ISalleServices GetInstance(ISalleRepository repository)
        {
            if(salleService == null)
            {
                salleService=  new SalleService(repository);
            }
            return salleService;
        }

        public int AddSalle(Salle salle)
        {
            return salleRepository.Add(salle);
        }

        public int DeleteSalle(int id)
        {
            return salleRepository.Delete(id);
        }

        public DataTable GetAllSalle()
        {
            return salleRepository.GetAll();
            
        }

        public int UpdateSalle(Salle salle)
        {
            return salleRepository.Update(salle);
        }
        public SalleDto GetRow(DataRow salle)
        {
            return new SalleDto(new Salle()
            {
                Id = int.Parse(salle.ItemArray[0].ToString()),
                Libelle = salle.ItemArray[1].ToString()
            });
                    
        }
        public ObservableCollection<SalleDto> GetObservables(DataTable dataTable)
        {
            ObservableCollection<SalleDto> salles = new ObservableCollection<SalleDto>();
            foreach (DataRow item in dataTable.Rows)
            {
                salles.Add(GetRow(item));
                
            }
            return salles;
        }
    }
}
