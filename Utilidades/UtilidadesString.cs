using ActividadIntegradoraNro1.GUI;

namespace ActividadIntegradoraNro1.Utilidades
{
    public static class UtilidadesString
    {
        public static bool TieneSoloLetras(this string str) => UtilidadesRegex.SonSoloLetras().IsMatch(str);
        public static bool TieneFormatoDePatenteArgentinaValida(this string str) => UtilidadesRegex.PatenteArgentinaValida().IsMatch(str);
        public static bool TieneLetrasYNumerosConEspacios(this string str) => UtilidadesRegex.LetrasYNumerosConEspacios().IsMatch(str);
    }
}
