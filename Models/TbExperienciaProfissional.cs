using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_experiencia_profissional")]
    public partial class TbExperienciaProfissional
    {
        [Required]
        [Column("ds_atividades", TypeName = "varchar(200)")]
        public string DsAtividades { get; set; }
        [Required]
        [Column("ds_cargo", TypeName = "varchar(45)")]
        public string DsCargo { get; set; }
        [Required]
        [Column("ds_empresa", TypeName = "varchar(45)")]
        public string DsEmpresa { get; set; }
        [Column("dt_entrada", TypeName = "date")]
        public DateTime DtEntrada { get; set; }
        [Column("dt_saida", TypeName = "date")]
        public DateTime? DtSaida { get; set; }
        [Key]
        [Column("idtb_experienciaa")]
        public int IdtbExperienciaa { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbExperienciaProfissional))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
