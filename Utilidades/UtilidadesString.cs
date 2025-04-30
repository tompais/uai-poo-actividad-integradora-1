using ActividadIntegradoraNro1.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradoraNro1.Utilidades
{
    public static class UtilidadesString
    {
        public static bool TieneSoloLetras(this string str) => UtilidadesRegex.SonSoloLetras().IsMatch(str);
        public static bool TieneFormatoDePatenteArgentinaValida(this string str) => UtilidadesRegex.PatenteArgentinaValida().IsMatch(str);
    }
}
