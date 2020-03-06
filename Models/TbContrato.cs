using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_contrato")]
    public partial class TbContrato
    {
        [Required]
        [Column("ds_atividades", TypeName = "varchar(200)")]
        public string DsAtividades { get; set; }
        [Required]
        [Column("ds_dias", TypeName = "varchar(45)")]
        public string DsDias { get; set; }
        [Column("dt_documento", TypeName = "date")]
        public DateTime DtDocumento { get; set; }
        [Column("dt_fim", TypeName = "date")]
        public DateTime DtFim { get; set; }
        [Column("dt_inicio", TypeName = "date")]
        public DateTime DtInicio { get; set; }
        [Required]
        [Column("hr_entrada", TypeName = "varchar(45)")]
        public string HrEntrada { get; set; }
        [Required]
        [Column("hr_saida", TypeName = "varchar(45)")]
        public string HrSaida { get; set; }
        [Column("hr_semanal")]
        public int HrSemanal { get; set; }
        [Key]
        [Column("idtb_contrato")]
        public int IdtbContrato { get; set; }
        [Column("tb_candidato_idtb_candidatos")]
        public int TbCandidatoIdtbCandidatos { get; set; }
        [Required]
        [Column("tp_contrato", TypeName = "varchar(45)")]
        public string TpContrato { get; set; }
        [Required]
        [Column("vl_bolsa", TypeName = "varchar(45)")]
        public string VlBolsa { get; set; }
        [Required]
        [Column("vl_bolsa_extenso", TypeName = "varchar(45)")]
        public string VlBolsaExtenso { get; set; }

        [ForeignKey(nameof(TbCandidatoIdtbCandidatos))]
        [InverseProperty(nameof(TbCandidato.TbContrato))]
        public virtual TbCandidato TbCandidatoIdtbCandidatosNavigation { get; set; }
    }
}
