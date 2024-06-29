using System.Text;

//Incluidas
using CodigosTest.BLL.Intefaces;
using System.Security.Cryptography;

namespace CodigosTest.BLL.Implementacion
{
    public class UtilidadesService : IUtilidadesService
    {
        public string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0, 6);
            return clave;
        }
        /// <summary>
        /// Conversión de Cadenas en SHA256
        /// </summary>
        /// <param name="texto">Cadena a Encriptar.</param>
        /// <returns>Cadena codificada.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ConvertirSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;

                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                {
                    sb.Append(b.ToString("X2"));
                }
            }
            return sb.ToString();
        }
    }
}
