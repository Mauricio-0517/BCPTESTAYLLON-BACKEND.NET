﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BCPTESTAYLLON.Models
{
    public partial class BCPTESTAYLLONContext : DbContext
    {
        public BCPTESTAYLLONContext()
        {
        }

        public BCPTESTAYLLONContext(DbContextOptions<BCPTESTAYLLONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Cuenta> Cuenta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdIn);

                entity.ToTable("CLIENTE");

                entity.Property(e => e.IdIn).HasColumnName("ID_IN");

                entity.Property(e => e.DocumentoVc).HasColumnName("DOCUMENTO_VC");

                entity.Property(e => e.DomicilioVc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DOMICILIO_VC");

                entity.Property(e => e.EstadoCivilVc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO_CIVIL_VC");

                entity.Property(e => e.FechaNacimientoDt)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_NACIMIENTO_DT");

                entity.Property(e => e.FechaRegistroDt)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO_DT");

                entity.Property(e => e.MaternoVc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MATERNO_VC");

                entity.Property(e => e.NacionalidadVc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NACIONALIDAD_VC");

                entity.Property(e => e.NombresVc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES_VC");

                entity.Property(e => e.PaternoVc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PATERNO_VC");

                entity.Property(e => e.UsuarioRegistroVc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_REGISTRO_VC");
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.IdIn);

                entity.ToTable("CUENTA");

                entity.Property(e => e.IdIn).HasColumnName("ID_IN");

                entity.Property(e => e.FechaRegistroDt)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO_DT");

                entity.Property(e => e.FkClienteIdIn).HasColumnName("FK_CLIENTE_ID_IN");

                entity.Property(e => e.NombreCuentaVc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CUENTA_VC");

                entity.Property(e => e.SucursalVc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUCURSAL_VC");

                entity.Property(e => e.TipoCuentaVc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CUENTA_VC");

                entity.Property(e => e.TipoMonedaVc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_MONEDA_VC");

                entity.Property(e => e.UsaurioRegistroVc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USAURIO_REGISTRO_VC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
