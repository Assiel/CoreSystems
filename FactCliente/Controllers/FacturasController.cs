using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Datos;
using Entidades;

namespace FactCliente.Controllers
{
    [RoutePrefix("api/operaciones")]
    public class FacturasController : ApiController
    {
        private FactClienteDbContext db = new FactClienteDbContext();


        [Route("Clientes")]
        [HttpGet]
        public HttpResponseMessage GetFacturas(HttpRequestMessage request)
        {
            HttpResponseMessage response = null;

            List<Clientes> lstClientes = new List<Clientes>();
            try
            {
                lstClientes = db.Clientes.ToList();
                response = request.CreateResponse(HttpStatusCode.OK, lstClientes);
            }
            catch (DbUpdateException ex)
            {
                response = request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }

        [Route("DetalleFacturas/{FacturasId?}")]
        [HttpGet] 
        public HttpResponseMessage GetDetalleFacturas(HttpRequestMessage request,int FacturasId)
        {
            HttpResponseMessage response = null;

            List<DetalleFacturas> lstDetalleFact= new List<DetalleFacturas>();
            try
            {
                lstDetalleFact = db.DetalleFactura.Where(x=>x.FacturasId==FacturasId).ToList();
                response = request.CreateResponse(HttpStatusCode.OK, lstDetalleFact);
            }
            catch (DbUpdateException ex)
            {
                response = request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }

        [Route("Facturas/{ClienteId?}")]
        [HttpGet]
        public HttpResponseMessage GetFacturas(HttpRequestMessage request,int ClienteId)
        {
            HttpResponseMessage response =null;
            
            List<Facturas> lstFacturas = new List<Facturas>();
            try
            {
                lstFacturas= db.Facturas.Where(x => x.ID == ClienteId).ToList();
                response = request.CreateResponse(HttpStatusCode.OK, lstFacturas);
            }
            catch (DbUpdateException ex)
            {              
                response = request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch (Exception ex)
            {                
                response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
    }
}
