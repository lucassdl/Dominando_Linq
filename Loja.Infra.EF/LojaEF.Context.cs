﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loja.Infra.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LojaEFEntities : DbContext
    {
        public LojaEFEntities()
            : base("name=LojaEFEntities")
        {
        }
    
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
    }
}
