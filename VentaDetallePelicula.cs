//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pryStreaingUnicah
{
    using System;
    using System.Collections.Generic;
    
    public partial class VentaDetallePelicula
    {
        public long PKVentaDetalle { get; set; }
        public long FKIdVenta { get; set; }
        public long FKIdPelicula { get; set; }
    
        public virtual Peliculas Peliculas { get; set; }
        public virtual VentaPelicula VentaPelicula { get; set; }
    }
}
