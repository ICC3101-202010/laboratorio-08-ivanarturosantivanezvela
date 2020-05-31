using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8.Clases
{
    public class Cine
    {
        private string nombre_dueño;
        string identificador;
        string horario_inicio;
        string horario_cierre;
        string numero_de_salas;

        public Cine(string nombre_dueño, string identificador, string horario_inicio, string horario_cierre, string numero_de_salas)
        {
            this.nombre_dueño = nombre_dueño;
            this.Identificador = identificador;
            this.horario_inicio = horario_inicio;
            this.horario_cierre = horario_cierre;
            this.numero_de_salas = numero_de_salas;
        }

        public string Nombre_dueño { get => nombre_dueño; set => nombre_dueño = value; }
        public string Horario_inicio { get => horario_inicio; set => horario_inicio = value; }
        public string Horario_cierre { get => horario_cierre; set => horario_cierre = value; }
        public string Numero_de_salas { get => numero_de_salas; set => numero_de_salas = value; }
        public string Identificador { get => identificador; set => identificador = value; }

        public override string ToString()
        {
            return "Nombre dueño: " + Nombre_dueño + "  ||  " + "   Identificador cine :" + Identificador + " || " + " Horario inicio cine : " +Horario_inicio+ "||" + " Horario cierre cine : " +Horario_cierre+ "||" +" Numero de salas "+ Numero_de_salas;
        }
    }
}
