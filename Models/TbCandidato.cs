using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_candidato")]
    public partial class TbCandidato
    {
        public TbCandidato()
        {
            TbContrato = new HashSet<TbContrato>();
        }

        [Column("bl_passou")]
        public bool BlPassou { get; set; }
        [Column("ds_observacao", TypeName = "varchar(100)")]
        public string DsObservacao { get; set; }
        [Required]
        [Column("ds_situacao", TypeName = "varchar(45)")]
        public string DsSituacao { get; set; }
        [Column("dt_entrevista", TypeName = "datetime")]
        public DateTime DtEntrevista { get; set; }
        [Key]
        [Column("idtb_candidatos")]
        public int IdtbCandidatos { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }
        [Column("tb_vaga_idtb_vagas")]
        public int TbVagaIdtbVagas { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbCandidato))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
        [ForeignKey(nameof(TbVagaIdtbVagas))]
        [InverseProperty(nameof(TbVaga.TbCandidato))]
        public virtual TbVaga TbVagaIdtbVagasNavigation { get; set; }
        [InverseProperty("TbCandidatoIdtbCandidatosNavigation")]
        public virtual ICollection<TbContrato> TbContrato { get; set; }
    }
}
