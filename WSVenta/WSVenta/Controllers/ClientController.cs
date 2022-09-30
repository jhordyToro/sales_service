using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WSVenta.Models;
using WSVenta.Models.Response;
using WSVenta.Models.Request;

namespace WSVenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta rp = new Respuesta();
            rp.Exito = 0;
            try
            {
                using(VentaContext db = new VentaContext())
                {
                    List<Client> oClient = new List<Client>();
                    oClient = db.Clients.ToList();
                    rp.Data = oClient;
                    rp.Exito = 1;
                }
            }
            catch(Exception ex) 
            {
                rp.Message = ex.Message;
            }
            return Ok(rp);
        }

        [HttpPost]
        public IActionResult Post(ClientRequest ClientR)
        {
            Respuesta rp = new Respuesta();
            rp.Exito = 0;
            try
            {
                using(VentaContext db = new VentaContext())
                {
                    Client oClient = new Client();
                    oClient.Name = ClientR.name;

                    db.Clients.Add(oClient);
                    db.SaveChanges();

                    rp.Exito = 1;

                }
            }catch (Exception ex)
            {
                rp.Message = ex.Message;
            }

            return Ok(rp);
        }

        [HttpPut]
        public IActionResult Put(ClientRequest ClientR)
        {
            Respuesta rp = new Respuesta();
            rp.Exito = 0;
            try
            {
                using (VentaContext db = new VentaContext())
                {
                    Client oClient = new Client();
                    oClient = db.Clients.Find(ClientR.id);
                    oClient.Name = ClientR.name;
                    
                    db.Entry(oClient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    
                    rp.Exito = 1;
                }
            }
            catch(Exception ex)
            {
                rp.Message = ex.Message;
            }
            return Ok(rp);
        }

        [HttpDelete]
        public IActionResult Delete(ClientRequest ClientR)
        {
            Respuesta rp = new Respuesta();
            rp.Exito = 0;

            try
            {
                using (VentaContext db = new VentaContext())
                {
                    Client oClient = new Client();
                    oClient = db.Clients.Find(ClientR.id);
                    db.Clients.Remove(oClient);
                    db.SaveChanges();

                    rp.Exito = 1;
                }

            }catch(Exception ex)
            {
                rp.Message = ex.Message;
            }
            return Ok(rp);
        }






    }
}
