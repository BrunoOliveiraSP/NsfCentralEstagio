using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace nsfcentralestagio.Models
{
    public partial class centralestagio_dbContext : DbContext
    {
        public centralestagio_dbContext()
        {
        }

        public centralestagio_dbContext(DbContextOptions<centralestagio_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAtividadesComplementares> TbAtividadesComplementares { get; set; }
        public virtual DbSet<TbCandidato> TbCandidato { get; set; }
        public virtual DbSet<TbCertificado> TbCertificado { get; set; }
        public virtual DbSet<TbContrato> TbContrato { get; set; }
        public virtual DbSet<TbCurriculo> TbCurriculo { get; set; }
        public virtual DbSet<TbEmpresa> TbEmpresa { get; set; }
        public virtual DbSet<TbEmpresaRepresentante> TbEmpresaRepresentante { get; set; }
        public virtual DbSet<TbExperienciaProfissional> TbExperienciaProfissional { get; set; }
        public virtual DbSet<TbFormacaoAcademica> TbFormacaoAcademica { get; set; }
        public virtual DbSet<TbIdioma> TbIdioma { get; set; }
        public virtual DbSet<TbInformacaoPessoal> TbInformacaoPessoal { get; set; }
        public virtual DbSet<TbInstituicao> TbInstituicao { get; set; }
        public virtual DbSet<TbQualificacaoProfissional> TbQualificacaoProfissional { get; set; }
        public virtual DbSet<TbVaga> TbVaga { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=centralestagio_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAtividadesComplementares>(entity =>
            {
                entity.HasKey(e => e.IdtbVoluntariado)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_voluntariado_tb_curriculo_idx");

                entity.Property(e => e.DsAtividades)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCidade)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsLocal)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTipo)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbAtividadesComplementares)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_voluntariado_tb_curriculo");
            });

            modelBuilder.Entity<TbCandidato>(entity =>
            {
                entity.HasKey(e => e.IdtbCandidatos)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_candidato_tb_curriculo1_idx");

                entity.HasIndex(e => e.TbVagaIdtbVagas)
                    .HasName("fk_tb_candidato_tb_vaga1_idx");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsSituacao)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbCandidato)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_candidato_tb_curriculo1");

                entity.HasOne(d => d.TbVagaIdtbVagasNavigation)
                    .WithMany(p => p.TbCandidato)
                    .HasForeignKey(d => d.TbVagaIdtbVagas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_candidato_tb_vaga1");
            });

            modelBuilder.Entity<TbCertificado>(entity =>
            {
                entity.HasKey(e => e.IdtbCertificado)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_certificado_tb_curriculo1_idx");

                entity.Property(e => e.DsCertificado)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbCertificado)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_certificado_tb_curriculo1");
            });

            modelBuilder.Entity<TbContrato>(entity =>
            {
                entity.HasKey(e => e.IdtbContrato)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCandidatoIdtbCandidatos)
                    .HasName("fk_tb_contrato_tb_candidato1_idx");

                entity.Property(e => e.DsAtividades)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsDias)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HrEntrada)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HrSaida)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TpContrato)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VlBolsa)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VlBolsaExtenso)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCandidatoIdtbCandidatosNavigation)
                    .WithMany(p => p.TbContrato)
                    .HasForeignKey(d => d.TbCandidatoIdtbCandidatos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_contrato_tb_candidato1");
            });

            modelBuilder.Entity<TbCurriculo>(entity =>
            {
                entity.HasKey(e => e.IdtbCurriculo)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsUsuario)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdtbEmpresa)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCidade)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCnpj)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEstado)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsNumero)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NmEmpresa)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbEmpresaRepresentante>(entity =>
            {
                entity.HasKey(e => e.IdtbEmpresaFuncionarios)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbEmpresaIdtbEmpresa)
                    .HasName("fk_tb_empresa_representante_tb_empresa1_idx");

                entity.Property(e => e.DsCargo)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NmRepresentante)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbEmpresaIdtbEmpresaNavigation)
                    .WithMany(p => p.TbEmpresaRepresentante)
                    .HasForeignKey(d => d.TbEmpresaIdtbEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_empresa_representante_tb_empresa1");
            });

            modelBuilder.Entity<TbExperienciaProfissional>(entity =>
            {
                entity.HasKey(e => e.IdtbExperienciaa)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_experiencia_profissional_tb_curriculo1_idx");

                entity.Property(e => e.DsAtividades)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCargo)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEmpresa)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbExperienciaProfissional)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_experiencia_profissional_tb_curriculo1");
            });

            modelBuilder.Entity<TbFormacaoAcademica>(entity =>
            {
                entity.HasKey(e => e.IdtbFormAcadmc)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_formacao_academica_tb_curriculo1_idx");

                entity.Property(e => e.DsCargaHoraria)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsConteudo)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEscola)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTipoEnsino)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTipoEscola)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DtConclusao)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DtInicio)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NmCurso)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbFormacaoAcademica)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_formacao_academica_tb_curriculo1");
            });

            modelBuilder.Entity<TbIdioma>(entity =>
            {
                entity.HasKey(e => e.IdtbIdiomas)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_idioma_tb_curriculo1_idx");

                entity.Property(e => e.DsEscola)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsIdioma)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsNivel)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbIdioma)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_idioma_tb_curriculo1");
            });

            modelBuilder.Entity<TbInformacaoPessoal>(entity =>
            {
                entity.HasKey(e => e.IdtbInfoPessoais)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_informacao_pessoal_tb_curriculo1_idx");

                entity.Property(e => e.DsCelular)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCidade)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEstadoCivil)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsGit)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsLinkPortfolio)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsLinkedin)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsNome)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsNumero)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbInformacaoPessoal)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_informacao_pessoal_tb_curriculo1");
            });

            modelBuilder.Entity<TbInstituicao>(entity =>
            {
                entity.HasKey(e => e.IdtbInstituicao)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCidade)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCnpj)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsRepresentante)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NmNome)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbQualificacaoProfissional>(entity =>
            {
                entity.HasKey(e => e.IdtbQualificProf)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbCurriculoIdtbCurriculo)
                    .HasName("fk_tb_qualificacao_profissional_tb_curriculo1_idx");

                entity.Property(e => e.DsNivel)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsNome)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbCurriculoIdtbCurriculoNavigation)
                    .WithMany(p => p.TbQualificacaoProfissional)
                    .HasForeignKey(d => d.TbCurriculoIdtbCurriculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_qualificacao_profissional_tb_curriculo1");
            });

            modelBuilder.Entity<TbVaga>(entity =>
            {
                entity.HasKey(e => e.IdtbVagas)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TbEmpresaIdtbEmpresa)
                    .HasName("fk_tb_vaga_tb_empresa1_idx");

                entity.Property(e => e.BlVa)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BlVr)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BlVt)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCargo)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsCurso)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsIdioma)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsPerfil)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsRequisitos)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DsSexo)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VlBolsa)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.TbEmpresaIdtbEmpresaNavigation)
                    .WithMany(p => p.TbVaga)
                    .HasForeignKey(d => d.TbEmpresaIdtbEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_vaga_tb_empresa1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
