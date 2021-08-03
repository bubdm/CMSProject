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
    public partial class MainForm : Form
    {
        private Controller controller;
        private NewCustomerFrm ncForm;
        private NewProductFrm npForm;
        private SearchCustomerFrm scForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetController(Controller theController)
        {
            this.controller = theController;
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStripMain.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            /*if(username == "admin" && password == "admin")
            {
                menuStripMain.Visible = true;
                loginPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ncForm = new NewCustomerFrm();

            //Setting child forms controller object
            ncForm.SetController(this.controller);

            ncForm.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.npForm = new NewProductFrm();

            //Setting child forms controller object
            npForm.SetController(this.controller);

            npForm.Show();
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scForm = new SearchCustomerFrm();

            //Setting child forms controller object
            scForm.SetController(this.controller);

            scForm.Show();
        }
    }
}
