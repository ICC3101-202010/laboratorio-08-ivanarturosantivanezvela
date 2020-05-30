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
        //Evento para crear cine
        public event EventHandler<SendingCineEventArgs> CineSended;
        //Evento para crear recreacional
        public event EventHandler<SendingrecreacionalEventArgs> RecreacionalSended;
        //Evento para crear restaurant
        public event EventHandler<SendingRestaurantEventArgs> RestaurantSended;




        List<Panel> stackpanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();


        public Form1()
        {
            InitializeComponent();
            panels.Add("StartPanel",Panelinicio);
            panels.Add("Paneldeopciones", Paneldeopciones);
            panels.Add("Paneldecine", Panelcine);
            
            



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
                Panelcine.Visible = true;
                Paneldeopciones.Visible = false;

            }
            else if (opcion == "Recreacional")
            {
                Panelrecreacional.Visible = true;
                Paneldeopciones.Visible = false;
                Panelcine.Visible = false;
              
             
            }
            else if (opcion == "Restaurant")
            {
                Panelrestaurant.Visible = true;
                Paneldeopciones.Visible = false;
            }

        }

        private void Crearcinebtn_Click(object sender, EventArgs e)
        {
            string nombredueño = Nombredueñotxt.Text;
            string identificador = Identificadortxt.Text;
            string horarioinicio = Horarioiniciotxt.Text;
            string horariocierre = Horariocierretxt.Text;
            string numerodesalas = Numerodesalastxt.Text;
            if (CineSended != null)
            {
                CineSended(this, new SendingCineEventArgs() { Nombreduenoenviado = nombredueño, Identificadorenviado = identificador, Horarioinicioenviado = horarioinicio, Horariocierreenviado = horariocierre, Numerodesalasenviado = numerodesalas });
                MessageBox.Show("Cine creado");
                stackpanels.Add(Panelinicio);
                ShowLastPanel();
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
    }
}
