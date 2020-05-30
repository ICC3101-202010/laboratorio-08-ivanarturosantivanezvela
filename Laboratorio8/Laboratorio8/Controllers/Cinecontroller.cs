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
    class Cinecontroller
    {
        Form1 view;
        List<Cine> cine = new List<Cine>();
            
        public Cinecontroller(Form view)
        {
            this.view = view as Form1;
            this.view.CineSended += OnCineSended;
        }

        public void OnCineSended(object sender, SendingCineEventArgs e)
        {
            cine.Add(new Cine(e.Nombreduenoenviado, e.Identificadorenviado, e.Horarioinicioenviado, e.Horariocierreenviado, e.Numerodesalasenviado));

        }


    }
}
