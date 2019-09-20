using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Herencia
{
    public class Empleado : Persona
    {
        #region "Atributos"
        string puesto;
        #endregion

        #region "Propiedades"
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        #endregion

        //Constructor de la clase
        public Empleado()
        {

        }
    }
}
