using Laboratorio8.Clases;
using Laboratorio8.CustomEvent_Args;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio8.Controllers
{
    public class Recreacionalcontroller
    {
        Form1 view;
        List<Recreacional> recreacional = new List<Recreacional>();

        public Recreacionalcontroller(Form view)
        {
            this.view = view as Form1;
            this.view.RecreacionalSended += Onrecreacionalsended;

        }
        public void Onrecreacionalsended(object sender , SendingrecreacionalEventArgs e)
        {
            recreacional.Add(new Recreacional(e.Nombreduenoenviado, e.Identificadorenviado, e.Horarioinicioenviado, e.Horariocierreenviado));

        }
    }
}
