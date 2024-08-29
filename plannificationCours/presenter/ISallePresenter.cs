using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.presenter
{
    public interface ISallePresenter
    {
        void loadData();

        void AddSalleHandler(object sender, EventArgs e);

        void EditSalleHandler(object sender, EventArgs e);

        void DeleteSalleHandler(object sender, EventArgs e);

        void SelectClasseHandler(object sender, EventArgs e);

        public void ActiveEventHandler();
    }
}
