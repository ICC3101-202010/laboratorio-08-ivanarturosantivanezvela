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
    class RestaurantController
    {

        Form1 view;
        List<Restaurant> restaurants = new List<Restaurant>();
        
        public RestaurantController(Form view)
        {
            this.view = view as Form1;
            this.view.RestaurantSended += OnrestaurantSended;
            this.view.Sendingtext += OnSearchTextChanged;


        }
        public void OnrestaurantSended(object source, SendingRestaurantEventArgs e)
        {

            restaurants.Add(new Restaurant(e.Nombreduenoenviado, e.Identificadorenviado, e.Horarioinicioenviado, e.Horariocierreenviado, e.Exlusividadenviado));

        }
        public void OnSearchTextChanged(object sender, SendingTextEventArgs e)
        {
            List<Restaurant> resultResataurant = new List<Restaurant>();
            List<string> resultString = new List<string>();

            resultResataurant = restaurants.Where(t =>
            t.Identificador.Contains(e.SendingTexttofind))
            .ToList();
            if (resultResataurant.Count > 0)
            {
                resultString.Add("-----Restaurant encontrados-----");
                foreach (Restaurant s in resultResataurant)
                    resultString.Add(s.ToString());
            }
            view.UpdateResults(resultString);

        }
    }
}
