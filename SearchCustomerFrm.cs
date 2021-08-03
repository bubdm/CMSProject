using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSProject
{
    public partial class SearchCustomerFrm : Form
    {
        private Controller controller;

        public SearchCustomerFrm()
        {
            InitializeComponent();
        }

        public void SetController(Controller theController)
        {
            this.controller = theController;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string lastName = tb_lastName.Text;
            string dateOfBirth = tb_dateOfBirth.Text;

            var result = controller.SearchCustomer(lastName, dateOfBirth);

            data_searchResults.DataSource = result;
        }
    }
}
