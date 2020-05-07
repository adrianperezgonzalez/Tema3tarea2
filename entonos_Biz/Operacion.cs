using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entornos_bloque3aev2
{
    /// <summary>
    /// Se encarga de las operaciones (sumas restas y multiplicaciones)
    /// </summary>
     public class Operacion
    {
        // Declaracion de variables
        private double num1;
        private double num2;
        private readonly double CualEsMayor;

        // Atributos (no se si necesitas esto)
        public double Num1 { get { return num1; } set { num1 = value; } }
        public double Num2 { get { return num2; } set { num2 = value; } }

        // Constructor
        public Operacion()
        {
            // Inicializamos estableciendo el numero mayor
            // (no tengo claro si pide un metodo)
            if (this.num1 >= this.num2) { this.CualEsMayor = num1; }
            else { this.CualEsMayor = num2; }
        }

        /// <summary>
        /// Devuelve la resta el numero menor del mayor y muestra el dia de la semana actual
        /// </summary>
        /// <returns></returns>
        #region
        public double Resta()
        {
            if (CualEsMayor == this.num1) { return this.num1 -= this.num2; }
            else { return this.num2 -= this.num1; }
            // Es necesario llamar al metodo de la clase CosasDeFechas 
            // para mostrar el dia de la semana actual (Jordi)
        }

        /// <summary>
        /// Devuelve la suma de los dos numeros
        /// </summary>
        /// <returns></returns>
        public double Suma()
        {
            return this.num1 += this.num2;
        }

        /// <summary>
        /// Devuelve la multiplicacion de los dos numeros
        /// </summary>
        /// <returns></returns>
        public double Multiplicacion()
        {
            return (this.num1 * this.num2);
        }
        #endregion

    }
}
