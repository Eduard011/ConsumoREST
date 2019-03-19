using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConsumeREST.Models;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ConsumeREST.Extensiones
{
    public class ConsumoServicios
    {
        private readonly string url = @"";
        public ConsumoServicios(int service)
        {
            switch (service)
            {
                case 1:
                    url = @"http://18.206.47.239:5555/rest/Control_Ingresos/servicios/Conceptos/getConceptos";
                    break;
                case 2:
                    url = @"http://18.206.47.239:5555/rest/Control_Ingresos/servicios/Tipos_Cuenta/getTiposCuenta";
                    break;
                case 3:
                    url = @"http://18.206.47.239:5555/rest/Control_Ingresos/servicios/Empresas/getEmpresas";
                    break;
                case 4:
                    url = @"http://18.206.47.239:5555/rest/Control_Ingresos/servicios/Convenios/getConvenios";
                    break;
                case 5:
                    url = @"http://18.206.47.239:5555/rest/Control_Ingresos/servicios/Canales_Venta/getCanalesVenta";
                    break;
                case 6:
                    url = @"http://18.206.47.239:5555/rest/Control_Ingresos/servicios/Tipos_Venta/getTiposVenta";
                    break;
            }
        }

        public Principal ConsumirREST()
        {
            Principal principal = new Principal();

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream);
                    string json = reader.ReadToEnd();
                    reader.Close();
                    stream.Close();
                    principal = JsonConvert.DeserializeObject<Principal>(json);
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                principal = new Principal();
            }

            return principal;
        }
    }
}