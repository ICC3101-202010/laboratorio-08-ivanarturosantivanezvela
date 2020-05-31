using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8.Clases
{    
    public class Tienda
    {
        private string nombre_dueño;
        string identificador;
        string horario_inicio;
        string horario_cierre;
        List<string> tiendas;

        public Tienda(string nombre_dueño, string identificador, string horario_inicio, string horario_cierre, List<string> tiendas)
        {
            this.Nombre_dueño = nombre_dueño;
            this.Identificador = identificador;
            this.Horario_inicio = horario_inicio;
            this.Horario_cierre = horario_cierre;
            this.Tiendas = tiendas;
        }

        public string Nombre_dueño { get => nombre_dueño; set => nombre_dueño = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Horario_inicio { get => horario_inicio; set => horario_inicio = value; }
        public string Horario_cierre { get => horario_cierre; set => horario_cierre = value; }
        public List<string> Tiendas { get => tiendas; set => tiendas = value; }

        public override string ToString()
        {   string tiendas= "";
            foreach(string t in Tiendas)
            {
                tiendas=tiendas +","+ t;
            }
           
            return "Nombre dueño: " + Nombre_dueño + "  ||  " + "   Identificador tienda :" + Identificador + " || " + " Horario inicio tienda : " + Horario_inicio + "||" + " Horario cierre tienda : " + Horario_cierre + "||" + " Tiendas: " + tiendas;
        }



    }
}
