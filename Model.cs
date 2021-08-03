using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CMSProject
{
    public class Model
    {
        private Database db;
        private Controller controller;

        public Model(Database theDB)
        {
            this.db = theDB;
        }

        public void SetController(Controller theController)
        {
            this.controller = theController;
        }

        public void AddCustomer(NewCustomer newCust)
        {
            string sql = String.Format("INSERT INTO Customers (firstName, lastName, dateOfBirth, emailAddress, phoneNumber, streetAddress, suburb, city, postCode) VALUES " +
                        "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", 
                        newCust.firstName, newCust.lastName, newCust.dob, newCust.emailAddress, newCust.phoneNumber, newCust.address, newCust.suburb, newCust.city, newCust.postCode);

            db.Execute(sql);
        }

        public DataTable SearchCustomer(string param1, string param2)
        {
            string sql = String.Format("SELECT * FROM Customers WHERE lastName LIKE '{0}' OR dateOfBirth LIKE '{1}';", param1, param2);

            DataTable queryResult = db.Select(sql);

            return queryResult;
        }
    }
}
