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
            this.view.Sendingtext += OnSearchTextChanged;
        }

        public void OnCineSended(object sender, SendingCineEventArgs e)
        {
            cine.Add(new Cine(e.Nombreduenoenviado, e.Identificadorenviado, e.Horarioinicioenviado, e.Horariocierreenviado, e.Numerodesalasenviado));

        }
        public void OnSearchTextChanged(object sender, SendingTextEventArgs e)
        {
            List<Cine> resultCines = new List<Cine>();
            List<string> resultString = new List<string>();

            resultCines = cine.Where(t =>
            t.Identificador.Contains(e.SendingTexttofind))
            .ToList();
            if (resultCines.Count > 0)
            {
                resultString.Add("-----Cines encontrados-----");
                foreach (Cine s in resultCines)
                    resultString.Add(s.ToString());
            }
            view.UpdateResults(resultString);

        }


    }
}
