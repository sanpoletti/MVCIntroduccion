using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCIntroduccion.Models;

public partial class PruebaCpContext : DbContext
{
    public PruebaCpContext()
    {
    }

    public PruebaCpContext(DbContextOptions<PruebaCpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Credenciale> Credenciales { get; set; }

    public virtual DbSet<Cuile> Cuiles { get; set; }

    public virtual DbSet<DevolucionEnvioEdcucacion201022> DevolucionEnvioEdcucacion201022s { get; set; }

    public virtual DbSet<DevolucionEnvioEdcucacion261022> DevolucionEnvioEdcucacion261022s { get; set; }

    public virtual DbSet<EnvioEducacion031022> EnvioEducacion031022s { get; set; }

    public virtual DbSet<Enviorub2023> Enviorub2023s { get; set; }

    public virtual DbSet<Enviorub219> Enviorub219s { get; set; }

    public virtual DbSet<Enviorub220> Enviorub220s { get; set; }

    public virtual DbSet<Enviorub220b> Enviorub220bs { get; set; }

    public virtual DbSet<Enviorub221> Enviorub221s { get; set; }

    public virtual DbSet<Enviorub222> Enviorub222s { get; set; }

    public virtual DbSet<Enviorub222b> Enviorub222bs { get; set; }

    public virtual DbSet<Enviorub222c> Enviorub222cs { get; set; }

    public virtual DbSet<Enviorub222c1> Enviorub222cs1 { get; set; }

    public virtual DbSet<Enviorub222d> Enviorub222ds { get; set; }

    public virtual DbSet<Enviorub225250423> Enviorub225250423s { get; set; }

    public virtual DbSet<GestorBd> GestorBds { get; set; }

    public virtual DbSet<NuevosHogare> NuevosHogares { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<ReclamosEvaluado> ReclamosEvaluados { get; set; }

    public virtual DbSet<RegistrosApi> RegistrosApis { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuarios0> Usuarios0s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CPSERVERNEW; Initial Catalog=Prueba_CP ;  User ID=sandra;password=Ranelagh22 ; MultipleActiveResultSets=True;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Credenciale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("credenciales");

            entity.Property(e => e.AccessToken)
                .HasMaxLength(1000)
                .HasColumnName("access_token");
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
            entity.Property(e => e.RefreshToken)
                .HasMaxLength(1000)
                .HasColumnName("refresh_token");
            entity.Property(e => e.Secret)
                .HasMaxLength(100)
                .HasColumnName("secret");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Cuile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cuiles");

            entity.Property(e => e.Apeynom)
                .HasMaxLength(255)
                .HasColumnName("apeynom");
            entity.Property(e => e.Clave)
                .HasMaxLength(255)
                .HasColumnName("clave");
            entity.Property(e => e.Cuil)
                .HasMaxLength(255)
                .HasColumnName("cuil");
            entity.Property(e => e.Oficina).HasColumnName("oficina");
        });

        modelBuilder.Entity<DevolucionEnvioEdcucacion201022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DevolucionEnvioEdcucacion201022");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Año)
                .HasMaxLength(255)
                .HasColumnName("año");
            entity.Property(e => e.CondicionDatos)
                .HasMaxLength(255)
                .HasColumnName("condicion_datos");
            entity.Property(e => e.CueAnexo).HasColumnName("cue_anexo");
            entity.Property(e => e.Division)
                .HasMaxLength(255)
                .HasColumnName("division");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.EleveAlConsejo)
                .HasMaxLength(255)
                .HasColumnName("ELEVE AL CONSEJO");
            entity.Property(e => e.Establecimiento)
                .HasMaxLength(255)
                .HasColumnName("establecimiento");
            entity.Property(e => e.Expediente)
                .HasMaxLength(255)
                .HasColumnName("EXPEDIENTE");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.Goie)
                .HasMaxLength(255)
                .HasColumnName("GOIE");
            entity.Property(e => e.Idhogar).HasColumnName("idhogar");
            entity.Property(e => e.Idpersonahogar).HasColumnName("idpersonahogar");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("jornada");
            entity.Property(e => e.Nivel)
                .HasMaxLength(255)
                .HasColumnName("nivel");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Numpersona).HasColumnName("numpersona");
            entity.Property(e => e.ProgramaSocioeducativo)
                .HasMaxLength(255)
                .HasColumnName("PROGRAMA SOCIOEDUCATIVO");
            entity.Property(e => e.Tipodoc).HasColumnName("tipodoc");
            entity.Property(e => e.Turno)
                .HasMaxLength(255)
                .HasColumnName("turno");
        });

        modelBuilder.Entity<DevolucionEnvioEdcucacion261022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DevolucionEnvioEdcucacion261022");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Año)
                .HasMaxLength(255)
                .HasColumnName("año");
            entity.Property(e => e.CondicionDatos)
                .HasMaxLength(255)
                .HasColumnName("condicion_datos");
            entity.Property(e => e.CueAnexo).HasColumnName("cue_anexo");
            entity.Property(e => e.Division)
                .HasMaxLength(255)
                .HasColumnName("division");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.EleveAlConsejo)
                .HasMaxLength(255)
                .HasColumnName("eleve_al_consejo");
            entity.Property(e => e.Establecimiento)
                .HasMaxLength(255)
                .HasColumnName("establecimiento");
            entity.Property(e => e.Expediente)
                .HasMaxLength(255)
                .HasColumnName("expediente");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.Goie)
                .HasMaxLength(255)
                .HasColumnName("goie");
            entity.Property(e => e.Idhogar).HasColumnName("idhogar");
            entity.Property(e => e.Idpersonahogar).HasColumnName("idpersonahogar");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("jornada");
            entity.Property(e => e.Nivel)
                .HasMaxLength(255)
                .HasColumnName("nivel");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Numpersona).HasColumnName("numpersona");
            entity.Property(e => e.ProgramaSocioeducativo)
                .HasMaxLength(255)
                .HasColumnName("programa_socioeducativo");
            entity.Property(e => e.Tipodoc).HasColumnName("tipodoc");
            entity.Property(e => e.Turno)
                .HasMaxLength(255)
                .HasColumnName("turno");
        });

        modelBuilder.Entity<EnvioEducacion031022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EnvioEducacion031022");

            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.CuePrivadas)
                .HasMaxLength(255)
                .HasColumnName("Cue_Privadas");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.EscuelasPrivadas)
                .HasMaxLength(255)
                .HasColumnName("Escuelas_privadas");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_nac");
            entity.Property(e => e.Idpersonahogar).HasColumnName("idpersonahogar");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Numpersona).HasColumnName("numpersona");
            entity.Property(e => e.TipoDoc).HasColumnName("TipoDOc");
        });

        modelBuilder.Entity<Enviorub2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub2023");

            entity.Property(e => e.Altura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTURA");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.Calle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nrodoc).HasColumnName("nrodoc");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub219>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("enviorub219");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Nrodoc).HasColumnName("nrodoc");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Observacionesdoc).HasColumnName("observacionesdoc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.TElefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("tELEFONO_ALTERNATIVO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_RIB");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub220>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("enviorub220");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.F37).HasMaxLength(255);
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(255)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Observacionesdoc).HasColumnName("observacionesdoc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub220b>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub220b");

            entity.Property(e => e.Altura)
                .HasMaxLength(250)
                .HasColumnName("ALTURA");
            entity.Property(e => e.Alturaant)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ALTURAANT");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.Calle)
                .HasMaxLength(255)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Nrodoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrodoc");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(255)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub221>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("enviorub221");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(255)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.ObservacionesDoc).HasColumnName("observaciones doc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_rib");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub222>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub222");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento).HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.ObservacionesDoc).HasColumnName("observaciones doc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_RIB");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub222b>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub222b");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento).HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.ObservacionesDoc).HasColumnName("observaciones doc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_RIB");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub222c>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub222c", "BUENOSAIRES\\20314707150");

            entity.Property(e => e.Altura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTURA");
            entity.Property(e => e.Alturaant)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ALTURAANT");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.Calle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcaso)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idcaso");
            entity.Property(e => e.Idlote)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nrodoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrodoc");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub222c1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub222c");

            entity.Property(e => e.Altura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTURA");
            entity.Property(e => e.Alturaant)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ALTURAANT");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.Calle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcaso)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idcaso");
            entity.Property(e => e.Idlote)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nrodoc)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("nrodoc");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub222d>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enviorub222d");

            entity.Property(e => e.Altura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTURA");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.Calle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcaso).HasColumnName("idcaso");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nrodoc).HasColumnName("nrodoc");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Enviorub225250423>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("enviorub225_250423");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.Fechapedido)
                .HasColumnType("datetime")
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcaso)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idcaso");
            entity.Property(e => e.Idlote)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NroDoc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NumeroDocumento)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.ObservacionesDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("observaciones doc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoRib)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telefono_rib");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<GestorBd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gestor_bd");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<NuevosHogare>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NUEVOS_HOGARES$");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.F37).HasMaxLength(255);
            entity.Property(e => e.FechaNac).HasMaxLength(255);
            entity.Property(e => e.Fechapedido)
                .HasMaxLength(255)
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso)
                .HasMaxLength(255)
                .HasColumnName("idcaso");
            entity.Property(e => e.Idlote)
                .HasMaxLength(255)
                .HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NroDoc).HasMaxLength(255);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(255)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.ObservacionesDoc)
                .HasMaxLength(255)
                .HasColumnName("observaciones doc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoVwRibBeneficiariosFullAgregadaRub)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO (VW_RIB_BENEFICIARIOS_FULL_AGREGADA RUB)");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personas__3213E83F0505E850");

            entity.ToTable("personas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("fechaNac");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<ReclamosEvaluado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECLAMOS_EVALUADOS$");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(255)
                .HasColumnName("ASENTAMIENTO");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.BarrioSocial)
                .HasMaxLength(255)
                .HasColumnName("BARRIO_SOCIAL");
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.CalleAltura)
                .HasMaxLength(255)
                .HasColumnName("CALLE_ALTURA");
            entity.Property(e => e.Casa)
                .HasMaxLength(255)
                .HasColumnName("CASA");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(255)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Edificio)
                .HasMaxLength(255)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Escalera)
                .HasMaxLength(255)
                .HasColumnName("ESCALERA");
            entity.Property(e => e.F37).HasMaxLength(255);
            entity.Property(e => e.FechaNac).HasMaxLength(255);
            entity.Property(e => e.Fechapedido)
                .HasMaxLength(255)
                .HasColumnName("fechapedido");
            entity.Property(e => e.Franjahoraria)
                .HasMaxLength(255)
                .HasColumnName("franjahoraria");
            entity.Property(e => e.Habitacion)
                .HasMaxLength(255)
                .HasColumnName("HABITACION");
            entity.Property(e => e.IdRib).HasMaxLength(255);
            entity.Property(e => e.Idcaso)
                .HasMaxLength(255)
                .HasColumnName("idcaso");
            entity.Property(e => e.Idlote)
                .HasMaxLength(255)
                .HasColumnName("idlote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(255)
                .HasColumnName("MANZANA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NroDoc).HasMaxLength(255);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(255)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Observaciondomicilio)
                .HasMaxLength(255)
                .HasColumnName("observaciondomicilio");
            entity.Property(e => e.ObservacionesDoc)
                .HasMaxLength(255)
                .HasColumnName("observaciones doc");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(255)
                .HasColumnName("PASILLO");
            entity.Property(e => e.Piso)
                .HasMaxLength(255)
                .HasColumnName("PISO");
            entity.Property(e => e.Reclamo).HasMaxLength(255);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAlternativo)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO_ALTERNATIVO");
            entity.Property(e => e.TelefonoVwRibBeneficiariosFullAgregadaRub)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO (VW_RIB_BENEFICIARIOS_FULL_AGREGADA RUB)");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOMICILIO");
            entity.Property(e => e.Tira)
                .HasMaxLength(255)
                .HasColumnName("TIRA");
        });

        modelBuilder.Entity<RegistrosApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Registros_API");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Año)
                .HasMaxLength(255)
                .HasColumnName("año");
            entity.Property(e => e.CondicionDatos)
                .HasMaxLength(255)
                .HasColumnName("condicion_datos");
            entity.Property(e => e.CueAnexo).HasColumnName("cue_anexo");
            entity.Property(e => e.Division)
                .HasMaxLength(255)
                .HasColumnName("division");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.EleveAlConsejo)
                .HasMaxLength(255)
                .HasColumnName("eleve_al_consejo");
            entity.Property(e => e.Establecimiento)
                .HasMaxLength(255)
                .HasColumnName("establecimiento");
            entity.Property(e => e.Expediente)
                .HasMaxLength(255)
                .HasColumnName("expediente");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.Goie)
                .HasMaxLength(255)
                .HasColumnName("goie");
            entity.Property(e => e.Idhogar).HasColumnName("idhogar");
            entity.Property(e => e.Idpersonahogar).HasColumnName("idpersonahogar");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("jornada");
            entity.Property(e => e.Nivel)
                .HasMaxLength(255)
                .HasColumnName("nivel");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Numpersona).HasColumnName("numpersona");
            entity.Property(e => e.ProgramaSocioeducativo)
                .HasMaxLength(255)
                .HasColumnName("programa_socioeducativo");
            entity.Property(e => e.Tipodoc).HasColumnName("tipodoc");
            entity.Property(e => e.Turno)
                .HasMaxLength(255)
                .HasColumnName("turno");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table_1");

            entity.Property(e => e._1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("1");
            entity.Property(e => e._2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("2");
        });

        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.IdTarea).HasName("PK__Tarea__756A54026190A01F");

            entity.ToTable("Tarea");

            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83FB890D047");

            entity.ToTable("usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Usuarios0>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_usuarios");

            entity.ToTable("usuarios_0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Correo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
