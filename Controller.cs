using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSProject
{
    public class Controller
    {
        Model model;
        MainForm view;

        public Controller(Model theModel, MainForm theView)
        {
            this.model = theModel;
            this.view = theView;
        }

        public void AddCustomer(NewCustomer newCust)
        {
            model.AddCustomer(newCust);
        }

        public DataTable SearchCustomer(string param1, string param2)
        {
            DataTable queryResult = model.SearchCustomer(param1, param2);

            return queryResult;
        }
    }
}
