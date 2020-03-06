using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_idioma")]
    public partial class TbIdioma
    {
        [Required]
        [Column("ds_escola", TypeName = "varchar(45)")]
        public string DsEscola { get; set; }
        [Required]
        [Column("ds_idioma", TypeName = "varchar(45)")]
        public string DsIdioma { get; set; }
        [Required]
        [Column("ds_nivel", TypeName = "varchar(45)")]
        public string DsNivel { get; set; }
        [Column("dt_conclusao", TypeName = "date")]
        public DateTime? DtConclusao { get; set; }
        [Column("dt_inicio", TypeName = "date")]
        public DateTime DtInicio { get; set; }
        [Key]
        [Column("idtb_idiomas")]
        public int IdtbIdiomas { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbIdioma))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
