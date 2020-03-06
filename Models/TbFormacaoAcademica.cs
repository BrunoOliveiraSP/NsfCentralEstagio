using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_formacao_academica")]
    public partial class TbFormacaoAcademica
    {
        [Required]
        [Column("ds_carga_horaria", TypeName = "varchar(45)")]
        public string DsCargaHoraria { get; set; }
        [Column("ds_conteudo", TypeName = "varchar(45)")]
        public string DsConteudo { get; set; }
        [Required]
        [Column("ds_escola", TypeName = "varchar(45)")]
        public string DsEscola { get; set; }
        [Required]
        [Column("ds_tipo_ensino", TypeName = "varchar(45)")]
        public string DsTipoEnsino { get; set; }
        [Required]
        [Column("ds_tipo_escola", TypeName = "varchar(45)")]
        public string DsTipoEscola { get; set; }
        [Column("dt_conclusao", TypeName = "varchar(45)")]
        public string DtConclusao { get; set; }
        [Required]
        [Column("dt_inicio", TypeName = "varchar(45)")]
        public string DtInicio { get; set; }
        [Key]
        [Column("idtb_form_acadmc")]
        public int IdtbFormAcadmc { get; set; }
        [Required]
        [Column("nm_curso", TypeName = "varchar(45)")]
        public string NmCurso { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbFormacaoAcademica))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
