using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database db = new Database("localhost", "cmsdb", "root", "");
            MainForm view = new MainForm();

            //Model instantiated with database object passed into model constructor
            Model model = new Model(db);

            //Controller instantiated with model and view objects passed into constructor
            Controller controller = new Controller(model, view);

            //Setting correct instance of controller object
            view.SetController(controller);
            model.SetController(controller);

            Application.Run(view);
        }
    }
}
