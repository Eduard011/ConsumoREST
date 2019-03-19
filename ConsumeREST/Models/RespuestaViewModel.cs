using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeREST.Models
{
    public class RespuestaViewModel
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Empresa> Result { get; set; }
    }
}