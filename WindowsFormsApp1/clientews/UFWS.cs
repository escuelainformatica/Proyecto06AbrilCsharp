using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.modelo;
using Newtonsoft.Json;


namespace WindowsFormsApp1.clientews
{
    class UFWS
    {
        public async static Task<ObtenerUF> obtener()
        {
            var resultado = new ObtenerUF();
            // 1) conectarme a la pagina
            using (var client = new HttpClient())
            {
                var conexion = await client.GetAsync(
                    "https://mindicador.cl/api/uf");
                var contenido = await conexion.Content.ReadAsStringAsync();

                resultado = JsonConvert.DeserializeObject<ObtenerUF>(contenido);
            }


            return resultado;

        }
    }
}
