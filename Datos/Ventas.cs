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
    
    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            this.Detalles_Venta = new HashSet<Detalles_Venta>();
        }
    
        public int ID_Venta { get; set; }
        public int ID_Cliente { get; set; }
        public System.DateTime Fecha_Venta { get; set; }
        public string Estado_Venta { get; set; }
        public decimal Total_Venta { get; set; }
        public int ID_Metodo_Pago { get; set; }
        public decimal Costo_Envio { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalles_Venta> Detalles_Venta { get; set; }
        public virtual Metodos_Pago Metodos_Pago { get; set; }
    }
}
