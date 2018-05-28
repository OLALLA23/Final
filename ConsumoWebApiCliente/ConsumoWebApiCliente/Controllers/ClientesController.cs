using ConsumoWebApiCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConsumoWebApiCliente.Controllers
{
    public class ClientesController : ApiController
    {
        ModeloClientes modelo;

        public ClientesController()
        {
            this.modelo = new ModeloClientes();
        }
        // GET: api/Clientes
        public IEnumerable<CLIENTES> GetClientes()
        {
            return this.modelo.GetClientes();
        }

        // GET: api/Clientes/5
        public CLIENTES GetCliente(int id)
        {
            return this.modelo.BuscarCliente(id);
        }

        // POST: api/Clientes
        //INSERTAR CLIENTE
        public void Post(CLIENTES cliente)
        {
            this.modelo.InsertarCliente(cliente.IDCLIENTE, cliente.NOMBRE,cliente.APELLIDOS, cliente.DIRECCION, cliente.CPOSTAL, cliente.EMAIL);
        }

        // PUT: api/Clientes/5
        //MODIFICAR CLIENTE
        public void Put(int id, CLIENTES cliente)
        {
            this.modelo.ModificarCliente(cliente.IDCLIENTE, cliente.NOMBRE, cliente.APELLIDOS, cliente.DIRECCION, cliente.CPOSTAL, cliente.EMAIL);
        }
        
        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
            this.modelo.EliminarCliente(id);
        }
    }
}
