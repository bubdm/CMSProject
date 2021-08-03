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
    public partial class NewCustomerFrm : Form
    {
        private Controller controller;

        public NewCustomerFrm()
        {
            InitializeComponent();
        }

        public void SetController(Controller theController)
        {
            this.controller = theController;
        }

        private void ClearForm(Control form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearForm(c);
                }
            }

            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            rbtn_Other.Checked = false;
        }

        private void NewCustomerFrm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string firstName = tb_firstName.Text;
            string lastName = tb_lastName.Text;
            string dob = field_dateOfBirth.Text;
            string emailAddress = tb_emailAddress.Text;
            string gender = "";
            Int64 phoneNo = Int64.Parse(tb_phone.Text);
            string address = tb_address.Text;
            string suburb = tb_suburb.Text;
            string city = cb_city.Text;
            string postCode = tb_postCode.Text;

            if (rbtn_Male.Checked)
            {
                gender = rbtn_Male.Text;
            }
            else if (rbtn_Female.Checked)
            {
                gender = rbtn_Female.Text;
            }
            else
            {
                gender = rbtn_Other.Text;
            }
            NewCustomer newCust = new NewCustomer(firstName, lastName, dob, emailAddress, gender, phoneNo, address, suburb, city, postCode);

            controller.AddCustomer(newCust);

            ClearForm(this);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm(this);
        }
    }

    public class NewCustomer
    {
        public string firstName;
        public string lastName;
        public string dob;
        public string emailAddress;
        public string gender;
        public Int64 phoneNumber;
        public string address;
        public string suburb;
        public string city;
        public string postCode;

        public NewCustomer(string theFirstName, string theLastName, string theDOB, string theEmailAddress, string theGender, Int64 thePhoneNumber, string theAddress, string theSuburb, string theCity, string thePostCode)
        {
            this.firstName = theFirstName;
            this.lastName = theLastName;
            this.dob = theDOB;
            this.emailAddress = theEmailAddress;
            this.gender = theGender;
            this.phoneNumber = thePhoneNumber;
            this.address = theAddress;
            this.suburb = theSuburb;
            this.city = theCity;
            this.postCode = thePostCode;
        }
    }
}
