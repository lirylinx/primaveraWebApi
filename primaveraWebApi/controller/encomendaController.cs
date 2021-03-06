﻿using primaveraApi.crud;
using primaveraApi.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace primaveraWebApi
{
    public class EncomendaController : ApiController
    {
        // Get api/encomenda
        public List<Encomenda> Get()
        {
            EncomendaCRUD encomendaCrud = new EncomendaCRUD();
            List<Encomenda> listaEncomenda = encomendaCrud.read();
            return listaEncomenda;
        }

        // Get api/encomenda/id
        public List<Encomenda> Get(String id)
        {
            EncomendaCRUD encomendaCrud = new EncomendaCRUD();
            List<Encomenda> listaEncomenda = encomendaCrud.readByVendedor(id);
            return listaEncomenda;
        }
        // POST api/encomenda
        public String Post(Encomenda encomenda)
        {



            EncomendaCRUD encomendaCRUD = new EncomendaCRUD();
            bool rv = encomendaCRUD.create(encomenda);
            String resultado;
            if ( rv == true )
            {
                resultado = "sucesso";
            } else
            {
                resultado = "erro";

            }



            return resultado;
        }

        // PUT api/encomenda/id
        public void put(int id, [FromBody]string value)
        {

        }

        //DELETE api/encomenda/id
        public void Delete(int id )
        {

        }

    }
}
