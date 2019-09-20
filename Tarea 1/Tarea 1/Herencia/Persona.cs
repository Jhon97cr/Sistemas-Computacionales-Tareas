using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Herencia
{
    public class Persona
    {
        #region "atributos"
        string nombre;
        int edad;
        string lugarresidencia;
        int cedula;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string LugarResidencia
        {
            get { return lugarresidencia; }
            set { lugarresidencia = value; }
        }

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        #endregion

        //Constructor de la clase
        public Persona()
        {

        }
    }
}
