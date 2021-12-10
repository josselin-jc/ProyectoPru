
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Proyecto.Models.WS;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class AccesoController : ApiController
    {
        [HttpGet]
        public Reply HelloWord()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.menssage = "Hola Mundo";

            return oR;
        }

        [HttpPost]
        public Reply Login([FromBody]AccessViewModel model)
        {
            Reply oR = new Reply();
            oR.result = 0;
            try
            {
                //ambito 
                using(CarritoBDEntities db = new CarritoBDEntities())
                {
                    //busca el usuario y verifica que exista
                    var lst = db.Tabla_Usuario.Where(d => d.correoelectronico == model.correoelectronico && d.password == model.password && d.idEstado == 1);
                // validación si existe el usuario
                if (lst.Count() > 0)
                    {
                        oR.result = 1;
                        oR.data = Guid.NewGuid().ToString();
                    }
                    else
                    {
                        oR.message = "Datos incorrectos,verifique el correo electrónico y la contraseña";
                    }
                
                }

            }catch(Exception ex)
            {
                oR.result = 0;
                oR.menssage = "Ocurrio un Error";
            }
            return oR;
        }
    }
}
