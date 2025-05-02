using System.Text.RegularExpressions;

namespace ActividadIntegradoraNro1.GUI
{
    public static partial class UtilidadesRegex
    {
        [GeneratedRegex(@"^[\p{L}]+$")]
        public static partial Regex SonSoloLetras();

        [GeneratedRegex(@"^[A-Z]{3}\d{3}$|^[A-Z]{2}\d{3}[A-Z]{2}$")]
        public static partial Regex PatenteArgentinaValida();

        [GeneratedRegex(@"^[\p{L}0-9\s]+$")]
        public static partial Regex LetrasYNumerosConEspacios();
    }
}