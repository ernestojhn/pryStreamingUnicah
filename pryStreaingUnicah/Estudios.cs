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
    
    public partial class Estudios
    {
        public int IdEstudios { get; set; }
        public string NombreEstudio { get; set; }
        public System.DateTime FechaFundacion { get; set; }
        public byte FKPais { get; set; }
        public bool EstadoEstudio { get; set; }
    
        public virtual Paises Paises { get; set; }
    }
}
