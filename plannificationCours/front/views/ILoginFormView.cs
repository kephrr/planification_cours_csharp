using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.front.views
{
    public interface ILoginFormView
    {
        string ErrorMessage { get; set; }

        string Login {  get; set; }
        string Password { get; set; }

        event EventHandler clickBtnAddConnexion;

        void HideForm();

        void ShowForm();
    }
}
