using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entornos_bloque3aev2
{
    public class Cadena
    {
        #region Variables y atributos
        // Declaracion de variables
        private string cadenaTexto;

        // Atributos (no se si necesitas esto)
        public string CadenaTexto { get { return cadenaTexto; } set { cadenaTexto = value; } }
        #endregion

        // Constructor
        public Cadena(string cadena)
        {
            this.cadenaTexto = cadena;
        }


        #region Metodos de Caracteres
        /// <summary>
        /// Devuelve el primer caracter de la cadena de texto
        /// </summary>
        /// <returns></returns>
        public char ExtraerPrimerCaracter()
        {
            return this.cadenaTexto[0];
        }

        /// <summary>
        /// Devuelve el ultimo caracter de la cadena de texto
        /// </summary>
        /// <returns></returns>
        public char ExtraerUltimoCaracter()
        {
            return this.cadenaTexto[cadenaTexto.Length-1];
        }
        
        /// <summary>
        /// Devuelve el caracter conforme a la posicion pasada por parametro
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public char ExtraerCaracterConcreto(int position)
        {
            return this.cadenaTexto[position];
        }
        #endregion
    }
}
