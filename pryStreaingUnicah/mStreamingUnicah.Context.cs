﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StreamingUnicahEntities : DbContext
    {
        public StreamingUnicahEntities()
            : base("name=StreamingUnicahEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Clasificaciones> Clasificaciones { get; set; }
        public DbSet<Estudios> Estudios { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<TiposPeliculas> TiposPeliculas { get; set; }
        public DbSet<Perfiles> Perfiles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<ModuloPrincipal> ModuloPrincipal { get; set; }
        public DbSet<PerfilModulo> PerfilModulo { get; set; }
        public DbSet<Modulos> Modulos { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<VentaDetallePelicula> VentaDetallePelicula { get; set; }
        public DbSet<VentaPelicula> VentaPelicula { get; set; }
        public DbSet<DevolucionDetalle> DevolucionDetalle { get; set; }
        public DbSet<DevolucionesPeliculas> DevolucionesPeliculas { get; set; }
        public DbSet<TO10CantidadVendida> TO10CantidadVendida { get; set; }
        public DbSet<TOP10VentaPeliculas> TOP10VentaPeliculas { get; set; }
        public DbSet<TotalTipoPeliculas> TotalTipoPeliculas { get; set; }
    }
}
