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
    public partial class NewProductFrm : Form
    {
        private Controller controller;

        public NewProductFrm()
        {
            InitializeComponent();
        }

        public void SetController(Controller theController)
        {
            this.controller = theController;
        }
    }
}
