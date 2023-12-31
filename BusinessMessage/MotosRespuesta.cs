using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaSoap.BusinessMessage
{
    public class MotosRespuesta
    {
        public List<Motos> Motosres { get; set; }

        public bool ActionResult { get; set; }

        public string Error { get; set; }
    }
}