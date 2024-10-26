using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMetodosDePago
    {
        private DMetodosDePago dMetodosDePago = new DMetodosDePago();
        public String Registrar(Metodos_Pago metodos_pagos) 
        {
            return dMetodosDePago.Registrar(metodos_pagos);
        }
        public List<Metodos_Pago> ListarTodo(int dni)
        {
            return dMetodosDePago.ListarTodo(dni);
        }
    }
}
