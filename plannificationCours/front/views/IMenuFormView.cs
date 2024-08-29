using plannificationCours.back.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.front.views
{
    public interface IMenuFormView
    {
        event EventHandler showViewSalle;

        User UserConnect { get; set; }

        public void ShowForm();

        public void HideForm();
    }
}
