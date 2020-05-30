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
        //Evento para enviar cine
        public event EventHandler<SendingCineEventArgs> CineSended;



        List<Panel> stackpanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();


        public Form1()
        {
            InitializeComponent();
            panels.Add("StartPanel",Panelinicio);
            panels.Add("Paneldeopciones", Paneldeopciones);
            panels.Add("Paneldecine", Panelcine);
            panels.Add("Panelrecreacional", Panellocalrecreacional);



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
            if (opcion == "Recreacional")
            {
                Panellocalrecreacional.Visible = true;             
                Paneldeopciones.Visible = false;
                Panelinicio.Visible = false;
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
    }
}
