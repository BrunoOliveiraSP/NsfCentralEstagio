using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_qualificacao_profissional")]
    public partial class TbQualificacaoProfissional
    {
        [Column("ds_nivel", TypeName = "varchar(45)")]
        public string DsNivel { get; set; }
        [Required]
        [Column("ds_nome", TypeName = "varchar(100)")]
        public string DsNome { get; set; }
        [Key]
        [Column("idtb_qualific_prof")]
        public int IdtbQualificProf { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbQualificacaoProfissional))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
