//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSlim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.detalleVentas = new HashSet<detalleVentas>();
        }
    
        public int IdProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> idCategorias { get; set; }
        public Nullable<int> idProveedor { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleVentas> detalleVentas { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}