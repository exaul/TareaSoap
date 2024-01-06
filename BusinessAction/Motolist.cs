using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TareaSoap.BusinessMessage;

namespace TareaSoap.BusinessAction
{
    public class Motolist
    {
        public static List<Motos> motos = new List<Motos>()
        {
            new Motos() { Id = 1, NombresMotos= "Honda" },
            new Motos() { Id = 2, NombresMotos= "Harley Davidson" },
            new Motos() { Id = 3, NombresMotos= "Ducati" },
        };

        public static MotosRespuesta GetAllMotos()
        {
            return new MotosRespuesta() { Motosres = motos };
        }

        public static MotosRespuesta GetMotoById(int id)
        {
            Motos moto = motos.FirstOrDefault(m => m.Id == id);
            return new MotosRespuesta() { Motosres = (moto != null) ? new List<Motos> { moto } : null };
        }

        public static MotosRespuesta AddMoto(string nombresMotos)
        {
            Motos moto = new Motos() { NombresMotos = nombresMotos };
            moto.Id = motos.Count + 1;
            motos.Add(moto);
            return new MotosRespuesta() { Motosres = new List<Motos> { moto } };
        }

        public static MotosRespuesta UpdateMoto(int id, string nombresMotos)
        {
            Motos existingMoto = motos.FirstOrDefault(m => m.Id == id);
            if (existingMoto != null)
            {
                existingMoto.NombresMotos = nombresMotos;
                return new MotosRespuesta() { Motosres = new List<Motos> { existingMoto } };
            }
            else
            {
                return new MotosRespuesta() { Error = "Moto no encontrada" };
            }
        }

        public static MotosRespuesta DeleteMoto(int id)
        {
            Motos motoToDelete = motos.FirstOrDefault(m => m.Id == id);
            if (motoToDelete != null)
            {
                motos.Remove(motoToDelete);
                return new MotosRespuesta() { ActionResult = true };
            }
            else
            {
                return new MotosRespuesta() { Error = "Moto no encontrada" };
            }
        }
    }
}