using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace studentsApp.Models
{
    public partial class schoolAppDBContext : DbContext
    {
        public schoolAppDBContext()
        {
        }

        public schoolAppDBContext(DbContextOptions<schoolAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; } = null!;
        public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=schoolAppDB;Trusted_Connection=True; Encrypt=false");
            }
        }
       */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.ToTable("Curso");

                entity.Property(e => e.CursoTitulo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.EstudianteMatricula)
                    .HasName("PK__Estudian__F40FD4FD00E64D53");

                entity.ToTable("Estudiante");

                entity.Property(e => e.EstudianteCurso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstudianteEstado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstudianteFoto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstudianteNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstudianteSexo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstudianteTelefono)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.UsuarioCorreo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioEstado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
