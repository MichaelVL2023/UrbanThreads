//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Metodos_Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Metodos_Pago()
        {
            this.Ventas = new HashSet<Ventas>();
        }
    
        public int ID_Metodo_Pago { get; set; }
        public int ID_Cliente { get; set; }
        public string Metodo_Pago { get; set; }
        public string Numero_Tarjeta { get; set; }
        public string Titular_Tarjeta { get; set; }
        public System.DateTime Fecha_Caducidad { get; set; }
        public string CVV { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
