using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TareaSoap.BusinessMessage;

namespace TareaSoap.BusinessAction
{
    public class Motolist
    {
        public static MotosRespuesta GetAllMotos()
        {
            var motos = new List<Motos>()
            {
                new Motos()
                {
                    NombresMotos= "Honda"
                },
                new Motos()
                {
                    NombresMotos= "Harley Davidson"
                },
                new Motos()
                {
                    NombresMotos= "Ducati"
                },
            };
            return new MotosRespuesta()
            {
                Motosres = motos
            };
        }

    }
}