﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace madurativas.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class madurativasEntities : DbContext
    {
        public madurativasEntities()
            : base("name=madurativasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<estudio> estudios { get; set; }
        public virtual DbSet<eval_riesgos> eval_riesgos { get; set; }
        public virtual DbSet<hitos_area_social> hitos_area_social { get; set; }
        public virtual DbSet<hitos_lenguaje> hitos_lenguaje { get; set; }
        public virtual DbSet<hitos_motricidad_fina> hitos_motricidad_fina { get; set; }
        public virtual DbSet<hitos_motricidad_gruesa> hitos_motricidad_gruesa { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<mchat> mchats { get; set; }
        public virtual DbSet<mchat_monitor_quest_1> mchat_monitor_quest_1 { get; set; }
        public virtual DbSet<mchat_monitor_quest_10> mchat_monitor_quest_10 { get; set; }
        public virtual DbSet<mchat_monitor_quest_11> mchat_monitor_quest_11 { get; set; }
        public virtual DbSet<mchat_monitor_quest_12> mchat_monitor_quest_12 { get; set; }
        public virtual DbSet<mchat_monitor_quest_13> mchat_monitor_quest_13 { get; set; }
        public virtual DbSet<mchat_monitor_quest_14> mchat_monitor_quest_14 { get; set; }
        public virtual DbSet<mchat_monitor_quest_15> mchat_monitor_quest_15 { get; set; }
        public virtual DbSet<mchat_monitor_quest_16> mchat_monitor_quest_16 { get; set; }
        public virtual DbSet<mchat_monitor_quest_17> mchat_monitor_quest_17 { get; set; }
        public virtual DbSet<mchat_monitor_quest_18> mchat_monitor_quest_18 { get; set; }
        public virtual DbSet<mchat_monitor_quest_19> mchat_monitor_quest_19 { get; set; }
        public virtual DbSet<mchat_monitor_quest_20> mchat_monitor_quest_20 { get; set; }
        public virtual DbSet<mchat_monitor_quest_6> mchat_monitor_quest_6 { get; set; }
        public virtual DbSet<mchat_monitor_quest_7> mchat_monitor_quest_7 { get; set; }
        public virtual DbSet<mchat_monitor_quest_8> mchat_monitor_quest_8 { get; set; }
        public virtual DbSet<mchat_monitor_quest_9> mchat_monitor_quest_9 { get; set; }
        public virtual DbSet<mchat_monitor_quest_3> mchat_monitor_quest_3 { get; set; }
        public virtual DbSet<mchat_monitor_quest_5> mchat_monitor_quest_5 { get; set; }
        public virtual DbSet<mchat_monitor_quest_2> mchat_monitor_quest_2 { get; set; }
        public virtual DbSet<mchat_monitor_quest_4> mchat_monitor_quest_4 { get; set; }
    }
}
