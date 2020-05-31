using Laboratorio8.Clases;
using Laboratorio8.CustomEvent_Args;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio8
{
    public partial class Form1 : Form

    {
        int resultCounter = 0;
        //Evento para crear cine
        public event EventHandler<SendingCineEventArgs> CineSended;
        //Evento para crear recreacional
        public event EventHandler<SendingrecreacionalEventArgs> RecreacionalSended;
        //Evento para crear restaurant
        public event EventHandler<SendingRestaurantEventArgs> RestaurantSended;
        //Evento para crear local 
        public event EventHandler<SendingTiendaEventArgs> TiendaSended;
        //Evento para busqueda
        public event EventHandler<SendingTextEventArgs> Sendingtext;
        //Evento para traer cine
        public delegate string ReceiveCineEventHandler(object sender, SendingTextEventArgs args);
        public event ReceiveCineEventHandler RecivingCine;


        List<Panel> stackpanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        string identificadorcine = "";


        public Form1()
        {
            InitializeComponent();
            panels.Add("StartPanel",Panelinicio);
            panels.Add("Paneldeopciones", Paneldeopciones);
            //panels.Add("Paneldecine", Panelcine);
            
            



        }
        private void ShowLastPanel()
        {
            foreach(Panel panel in panels.Values)
            {
                if (panel != stackpanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }

            }
        }
        

        private void Agregarlocalbtn_Click(object sender, EventArgs e)
        {
            Paneldeopciones.Visible = true;
            
           
  
        }

        private void Enviaropcionbtn_Click(object sender, EventArgs e)
        {
            string opcion = Convert.ToString(this.Comboxopciones.SelectedItem);
            if (opcion == "Cine")
            {
                Panelcine.Show();
                Panelcine.Visible = true;
                Paneldeopciones.Hide();
                
            }
            else if (opcion == "Recreacional")
            {
                //Panelrecreacional.Visible = true;
                Panelrecreacional.Show();
                Panelrecreacional.Visible = true;
                Paneldeopciones.Hide();
             
            }
            else if (opcion == "Restaurant")
            {
                Panelrestaurant.Show();
                Panelrestaurant.Visible = true;
                Paneldeopciones.Hide();
                
               
            }

            else if (opcion == "Tienda")
            {
                Paneltienda.Show();
                Paneldeopciones.Hide();
            }

        }

        private void Crearcinebtn_Click(object sender, EventArgs e)
        {
            string nombredueño = Nombredueñotxt.Text;
            identificadorcine = Identificadortxt.Text;
            string horarioinicio = Horarioiniciotxt.Text;
            string horariocierre = Horariocierretxt.Text;
            string numerodesalas = Numerodesalastxt.Text;
            if (CineSended != null)
            {
                CineSended(this, new SendingCineEventArgs() { Nombreduenoenviado = nombredueño, Identificadorenviado = identificadorcine, Horarioinicioenviado = horarioinicio, Horariocierreenviado = horariocierre, Numerodesalasenviado = numerodesalas });
                MessageBox.Show("Cine creado");
                Panelcine.Visible = false;
            }
        }

        private void Crearlocalrecreacionalbtn_Click(object sender, EventArgs e)
        {
            string nombredueñorecreacional = Duenolocalrecreacionaltxt.Text;
            string identificadorrecreacional = Identificadorlocalrecreacionaltxt.Text;
            string horarioiniciorecre = horarioiniciolocalrecreacionaltxt.Text;
            string horariocierrerecre = Horariocierrelocalrereacionaltxt.Text;
            if (RecreacionalSended != null)
            {
                RecreacionalSended(this, new SendingrecreacionalEventArgs() { Nombreduenoenviado = nombredueñorecreacional, Identificadorenviado = identificadorrecreacional, Horarioinicioenviado = horarioiniciorecre, Horariocierreenviado = horariocierrerecre });
                MessageBox.Show("Local recreacional creado");
                Panelrecreacional.Visible = false;

            }
            
        }

        private void Crearrestaurantbtn_Click(object sender, EventArgs e)
        {
            string nombreduenorestaurant = Nombreduenorestauranttxt.Text;
            string identificadorrestaurant = Identificadorrestauranttxt.Text;
            string horarioiniciorestaurant = Horarioiniciorestauranttxt.Text;
            string horariocierrerestaurant = Horariocierrerestauranttxt.Text;
            string exclusividad =Convert.ToString( this.Incluirmesasexclusivascombobox.SelectedItem);
            if (RestaurantSended != null)
            {
                RestaurantSended(this, new SendingRestaurantEventArgs() { Nombreduenoenviado = nombreduenorestaurant, Identificadorenviado = identificadorrestaurant, Horarioinicioenviado = horarioiniciorestaurant, Horariocierreenviado = horariocierrerestaurant, Exlusividadenviado = exclusividad });
                MessageBox.Show("Restaurant creado");
                Panelrestaurant.Visible = false;
            }
        }

        private void Crearlocalbtn_Click(object sender, EventArgs e)
        {
            string nombreduenolocal = Nombreduenolocaltxt.Text;
            string identificadorlocal = identificadorlocaltxt.Text;
            string horarioiniciolocal = Horarioiniciolocaltxt.Text;
            string horariocierrelocal = Horarioterminlocaltxt.Text;
            string categoriastienda = Categoriastiendatxt.Text;
            if (TiendaSended != null)
            {
                TiendaSended(this, new SendingTiendaEventArgs() { Nombreduenoenviado = nombreduenolocal, Identificadorenviado = identificadorlocal, Horarioinicioenviado = horarioiniciolocal, Horariocierreenviado = horariocierrelocal, Categoriastiendaenviado = categoriastienda });
                MessageBox.Show("Tienda creada");
                Paneltienda.Visible = false;
            }

        }

        private void Revisarlocalbtn_Click(object sender, EventArgs e)
        {
            Paneldebusqueda.Show();
            Paneldebusqueda.Visible = true;
            
            


        }

        private void Verlocalesexistentesbtn_Click(object sender, EventArgs e)
        {
            Paneldetodosloslocales.Show();
            Paneldetodosloslocales.Visible = true;
            if (RecivingCine != null)
            {
                string Cinema = RecivingCine(this, new SendingTextEventArgs() { SendingTexttofind = identificadorcine });
                if (!Listboxdetodosloslocalesexistentes.Items.Contains(Cinema))
                {
                    Listboxdetodosloslocalesexistentes.Items.Add(Cinema);
                }


            }

        }

        private void Identificadordellocaltxt_TextChanged(object sender, EventArgs e)
        {
            string texto = Identificadordellocaltxt.Text;
            if (texto.Length >= 2)
            {
                CleanSearch();
                Noresult();
                if (Sendingtext != null)
                {
                    Sendingtext(this, new SendingTextEventArgs() { SendingTexttofind=texto});
                }

            }
        }
        private void Noresult()
        {
            Localesconeseidentificadorlistbox.Items.Add("No results for search criteria");
        }
        private void CleanSearch()
        {
            resultCounter = 0;
            Localesconeseidentificadorlistbox.Items.Clear();
        }
        public void UpdateResults(List<string> results)
        {
            if (results.Count > 0)
            {
                foreach (string result in results)
                {
                    if (resultCounter <= 50)
                    {
                        if (Localesconeseidentificadorlistbox.Items.Count > 0 && Localesconeseidentificadorlistbox.Items[0].Equals("No results for search criteria"))
                        {
                            Localesconeseidentificadorlistbox.Items.Add(result);
                            Localesconeseidentificadorlistbox.Items.RemoveAt(0);
                        }
                        else
                            Localesconeseidentificadorlistbox.Items.Add(result);
                        resultCounter++;
                    }
                }
            }
        }

        private void Volveriniciodesdebusquedabtn_Click(object sender, EventArgs e)
        {
            Paneldebusqueda.Visible = false;
        }

        private void btnvolverainicio_Click(object sender, EventArgs e)
        {
            Paneldetodosloslocales.Visible = false;
        }
    }
}
