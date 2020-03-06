using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_atividades_complementares")]
    public partial class TbAtividadesComplementares
    {
        [Required]
        [Column("ds_atividades", TypeName = "varchar(45)")]
        public string DsAtividades { get; set; }
        [Required]
        [Column("ds_cidade", TypeName = "varchar(45)")]
        public string DsCidade { get; set; }
        [Required]
        [Column("ds_local", TypeName = "varchar(45)")]
        public string DsLocal { get; set; }
        [Required]
        [Column("ds_tipo", TypeName = "varchar(45)")]
        public string DsTipo { get; set; }
        [Column("dt_conclusao", TypeName = "date")]
        public DateTime? DtConclusao { get; set; }
        [Column("dt_inicio", TypeName = "date")]
        public DateTime DtInicio { get; set; }
        [Key]
        [Column("idtb_voluntariado")]
        public int IdtbVoluntariado { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbAtividadesComplementares))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
