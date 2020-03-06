using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_curriculo")]
    public partial class TbCurriculo
    {
        public TbCurriculo()
        {
            TbAtividadesComplementares = new HashSet<TbAtividadesComplementares>();
            TbCandidato = new HashSet<TbCandidato>();
            TbCertificado = new HashSet<TbCertificado>();
            TbExperienciaProfissional = new HashSet<TbExperienciaProfissional>();
            TbFormacaoAcademica = new HashSet<TbFormacaoAcademica>();
            TbIdioma = new HashSet<TbIdioma>();
            TbInformacaoPessoal = new HashSet<TbInformacaoPessoal>();
            TbQualificacaoProfissional = new HashSet<TbQualificacaoProfissional>();
        }

        [Required]
        [Column("ds_senha", TypeName = "varchar(45)")]
        public string DsSenha { get; set; }
        [Required]
        [Column("ds_usuario", TypeName = "varchar(45)")]
        public string DsUsuario { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "date")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Key]
        [Column("idtb_curriculo")]
        public int IdtbCurriculo { get; set; }

        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbAtividadesComplementares> TbAtividadesComplementares { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbCandidato> TbCandidato { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbCertificado> TbCertificado { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbExperienciaProfissional> TbExperienciaProfissional { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbFormacaoAcademica> TbFormacaoAcademica { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbIdioma> TbIdioma { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbInformacaoPessoal> TbInformacaoPessoal { get; set; }
        [InverseProperty("TbCurriculoIdtbCurriculoNavigation")]
        public virtual ICollection<TbQualificacaoProfissional> TbQualificacaoProfissional { get; set; }
    }
}
