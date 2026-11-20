using System;

namespace WinAppDiseños
{
    internal static class AutenticacionLocal
    {
        internal static bool Validar(string usuario, string clave, string usuarioConfigurado, string claveConfigurada)
        {
            if (String.IsNullOrWhiteSpace(usuarioConfigurado) || String.IsNullOrWhiteSpace(claveConfigurada)
                || claveConfigurada.Length < 12 || claveConfigurada.ToUpperInvariant().Contains("CONFIGURAR"))
                return false;
            return String.Equals(usuario, usuarioConfigurado, StringComparison.Ordinal)
                && String.Equals(clave, claveConfigurada, StringComparison.Ordinal);
        }
    }
}
