using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8.Clases
{
    public class Recreacional
    {
        string nombre_dueño;
        string identificador;
        string horario_inicio;
        string horario_cierre;

        public Recreacional(string nombre_dueño, string identificador, string horario_inicio, string horario_cierre)
        {
            this.nombre_dueño = nombre_dueño;
            this.identificador = identificador;
            this.horario_inicio = horario_inicio;
            this.horario_cierre = horario_cierre;
        }

        public string Nombre_dueño { get => nombre_dueño; set => nombre_dueño = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Horario_inicio { get => horario_inicio; set => horario_inicio = value; }
        public string Horario_cierre { get => horario_cierre; set => horario_cierre = value; }

        public override string ToString()
        {
            return "Nombre dueño: " + Nombre_dueño + "  ||  " + " Identificador recreacional :" + Identificador + " || " + " Horario inicio recreacional : " + Horario_inicio + "||" + " Horario cierre recreacional : " + Horario_cierre ;
        }


    }
}
