using plannificationCours.back.data.dto;
using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.services
{
    public interface ISalleServices
    {
        DataTable GetAllSalle();

        int AddSalle(Salle salle);

        int UpdateSalle(Salle salle);
        int DeleteSalle(int id);
        SalleDto GetRow(DataRow salle);


        ObservableCollection<SalleDto> GetObservables(DataTable dataTable);
        
    }
}
