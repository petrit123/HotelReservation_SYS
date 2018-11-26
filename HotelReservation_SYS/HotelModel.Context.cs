﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservation_SYS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelEntities : DbContext
    {
        public HotelEntities()
            : base("name=HotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN> ADMINS { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public virtual DbSet<RESERVATION> RESERVATIONS { get; set; }
        public virtual DbSet<ROOMRATE> ROOMRATES { get; set; }
        public virtual DbSet<ROOM> ROOMS { get; set; }
        public virtual DbSet<ALL_CHECK_INS_TODAY> ALL_CHECK_INS_TODAY { get; set; }
        public virtual DbSet<GET_CUST_NAME_FOR_CANCEL> GET_CUST_NAME_FOR_CANCEL { get; set; }
        public virtual DbSet<ROOMS_NOT_CURRENTLY_IN_USE> ROOMS_NOT_CURRENTLY_IN_USE { get; set; }
    
        public virtual int SP_ADMINLOGINCHECK(string gET_ENTERED_USERNAME, string gET_ENTERED_PASSWORD, ObjectParameter gET_EXISTING_USERNAME, ObjectParameter gET_EXISTING_PASSWORD, ObjectParameter gET_FAILED_ATTEMPTS, ObjectParameter gET_BLOCKTIME)
        {
            var gET_ENTERED_USERNAMEParameter = gET_ENTERED_USERNAME != null ?
                new ObjectParameter("GET_ENTERED_USERNAME", gET_ENTERED_USERNAME) :
                new ObjectParameter("GET_ENTERED_USERNAME", typeof(string));
    
            var gET_ENTERED_PASSWORDParameter = gET_ENTERED_PASSWORD != null ?
                new ObjectParameter("GET_ENTERED_PASSWORD", gET_ENTERED_PASSWORD) :
                new ObjectParameter("GET_ENTERED_PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ADMINLOGINCHECK", gET_ENTERED_USERNAMEParameter, gET_ENTERED_PASSWORDParameter, gET_EXISTING_USERNAME, gET_EXISTING_PASSWORD, gET_FAILED_ATTEMPTS, gET_BLOCKTIME);
        }
    }
}