using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_certificado")]
    public partial class TbCertificado
    {
        [Required]
        [Column("ds_certificado", TypeName = "varchar(45)")]
        public string DsCertificado { get; set; }
        [Required]
        [Column("dt_certificado", TypeName = "varchar(45)")]
        public string DtCertificado { get; set; }
        [Key]
        [Column("idtb_certificado")]
        public int IdtbCertificado { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbCertificado))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
