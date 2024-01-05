using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TareaSoap.BusinessAction;
using TareaSoap.BusinessMessage;

namespace TareaSoap
{
    /// <summary>
    /// Descripción breve de Lista
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Lista : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public MotosRespuesta GetAllMotos()
        {
            return Motolist.GetAllMotos();
        }

        [WebMethod]
        public MotosRespuesta GetMotoById(int id)
        {
            return Motolist.GetMotoById(id);
        }

        [WebMethod]
        public MotosRespuesta AddMoto(Motos moto)
        {
            return Motolist.AddMoto(moto);
        }

        [WebMethod]
        public MotosRespuesta UpdateMoto(Motos moto)
        {
            return Motolist.UpdateMoto(moto);
        }

        [WebMethod]
        public MotosRespuesta DeleteMoto(int id)
        {
            return Motolist.DeleteMoto(id);
        }
    }
}
