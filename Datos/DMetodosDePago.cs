using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMetodosDePago
    {
        public String Registrar(Metodos_Pago metodos_pagos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Metodos_Pago.Add(metodos_pagos);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public List<Metodos_Pago> ListarTodo(int id)
        {
            List<Metodos_Pago> metodos_pagos = new List<Metodos_Pago>();
            try
            {
                 using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    metodos_pagos = context.Metodos_Pago.Where(c => c.ID_Cliente.Equals(id)).ToList();
                }
                return metodos_pagos;
            }
            catch (Exception ex)
            {
                return metodos_pagos;
            }

        }

    }
}


