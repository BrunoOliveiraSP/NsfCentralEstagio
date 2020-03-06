using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_empresa_representante")]
    public partial class TbEmpresaRepresentante
    {
        [Required]
        [Column("ds_cargo", TypeName = "varchar(45)")]
        public string DsCargo { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(45)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(45)")]
        public string DsTelefone { get; set; }
        [Key]
        [Column("idtb_empresa_funcionarios")]
        public int IdtbEmpresaFuncionarios { get; set; }
        [Required]
        [Column("nm_representante", TypeName = "varchar(100)")]
        public string NmRepresentante { get; set; }
        [Column("tb_empresa_idtb_empresa")]
        public int TbEmpresaIdtbEmpresa { get; set; }

        [ForeignKey(nameof(TbEmpresaIdtbEmpresa))]
        [InverseProperty(nameof(TbEmpresa.TbEmpresaRepresentante))]
        public virtual TbEmpresa TbEmpresaIdtbEmpresaNavigation { get; set; }
    }
}
