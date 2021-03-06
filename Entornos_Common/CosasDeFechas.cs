﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace entornos_bloque3aev2
{
    /// <summary>
    /// Esta clase es para manejar fechas
    /// </summary>
    public class CosasDeFechas
    {
        private DateTime cumpleanyos;
        /// <summary>
        /// Este metodo sirve para que te diga el dia de la semana que es dependiendo la fecha pasada por parametro
        /// </summary>
        /// 
        /// <returns>
        /// un string con el dia de la semana en español
        /// </returns>
        public DateTime Cumpleanyos { get; set; }

        #region Cosas de Fechas
        public CosasDeFechas(DateTime dates)
        {
            cumpleanyos = dates;
        }
        public string DiaSemana(DateTime fecha)
        {

            string dia=fecha.ToString("dddd",
                              new CultureInfo("es-ES"));
            return dia;

        }
        /// <summary>
        /// Este metodo sirve para que te diga cuantos dias faltan hasta tu cumpleaños
        /// </summary>
        /// <returns>
        /// Retorna un int de cuantos dias faltan
        /// </returns>
        public int CuantoFalta()
        {
            DateTime hoy= DateTime.Today;
            DateTime proxima = cumpleanyos.AddYears(hoy.Year - cumpleanyos.Year);

            if (proxima < hoy)
                proxima = proxima.AddYears(1);

            int dia = (proxima- hoy).Days;
            return dia;

        }

        #endregion
    }
}
