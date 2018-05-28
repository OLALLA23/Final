using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumoWebApiCliente.Models
{
    public class ModeloClientes
    {
        ContextoClientes contexto;

            public ModeloClientes()
        {
            this.contexto = new ContextoClientes();
        }

        public IEnumerable<CLIENTES> GetClientes() //Método para obtener los clientes
        {
            var consulta = from datos in contexto.CLIENTES
                           select datos;
            return consulta;
        }

        public CLIENTES BuscarCliente(int idclientes)
        {
            CLIENTES clien = contexto.CLIENTES.Find(idclientes);
            return clien;
        }

        //METODO POST
        public void InsertarCliente(int idclientes, String nombre, String apellidos, String direccion, int? codigo, String email)
        {
            CLIENTES cliente = new CLIENTES();
            cliente.IDCLIENTE = idclientes;
            cliente.NOMBRE = nombre;
            cliente.APELLIDOS = apellidos;
            cliente.DIRECCION = direccion;
            cliente.CPOSTAL = codigo;
            cliente.EMAIL = email;
            this.contexto.CLIENTES.Add(cliente);
            this.contexto.SaveChanges();
        }

        //METODO PUT
        public void ModificarCliente(int idclientes, String nombre, String apellidos, String direccion, int? codigo, String email)
        {
            CLIENTES cliente = this.BuscarCliente(idclientes);
            cliente.IDCLIENTE = idclientes;
            cliente.NOMBRE = nombre;
            cliente.APELLIDOS = apellidos;
            cliente.DIRECCION = direccion;
            cliente.CPOSTAL = codigo;
            cliente.EMAIL = email;
            this.contexto.SaveChanges();
        }

        //METODO DELETE
        public void EliminarCliente(int idclientes)
        {
            CLIENTES cliente = this.BuscarCliente(idclientes);
            this.contexto.CLIENTES.Remove(cliente);
            this.contexto.SaveChanges();
        }

    }
}