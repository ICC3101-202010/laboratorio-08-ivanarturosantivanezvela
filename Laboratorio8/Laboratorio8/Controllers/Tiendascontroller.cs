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
    public class Tiendascontroller
    {
        Form1 view;
        List<Tienda> Tiendas = new List<Tienda>();

        public Tiendascontroller(Form view)
        {
            this.view = view as Form1;
            this.view.TiendaSended += OnTiendaSended;
            this.view.Sendingtext += OnSearchTextChanged;
            
        }
        public void OnTiendaSended(object sender, SendingTiendaEventArgs e)
        {
            List<string> categorias = new List<string>();
            String[] separator = { "," };
            String[] categories = e.Categoriastiendaenviado.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach(string categorie in categories)
            {
                categorias.Add(categorie);
            }
            Tiendas.Add(new Tienda(e.Nombreduenoenviado, e.Identificadorenviado, e.Horarioinicioenviado, e.Horariocierreenviado, categorias));

        }
        public void OnSearchTextChanged(object sender, SendingTextEventArgs e)
        {
            List<Tienda> resultTiendas = new List<Tienda>();
            List<string> resultString = new List<string>();

            resultTiendas = Tiendas.Where(t =>
            t.Identificador.Contains(e.SendingTexttofind))
            .ToList();
            if (resultTiendas.Count > 0)
            {
                resultString.Add("-----Tiendas encontradas-----");
                foreach (Tienda s in resultTiendas)
                    resultString.Add(s.ToString());
            }
            view.UpdateResults(resultString);

        }


    }
}
