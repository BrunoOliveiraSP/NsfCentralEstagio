using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_empresa")]
    public partial class TbEmpresa
    {
        public TbEmpresa()
        {
            TbEmpresaRepresentante = new HashSet<TbEmpresaRepresentante>();
            TbVaga = new HashSet<TbVaga>();
        }

        [Required]
        [Column("ds_cep", TypeName = "varchar(45)")]
        public string DsCep { get; set; }
        [Required]
        [Column("ds_cidade", TypeName = "varchar(45)")]
        public string DsCidade { get; set; }
        [Required]
        [Column("ds_cnpj", TypeName = "varchar(45)")]
        public string DsCnpj { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(45)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_estado", TypeName = "varchar(45)")]
        public string DsEstado { get; set; }
        [Column("ds_numero", TypeName = "varchar(45)")]
        public string DsNumero { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(45)")]
        public string DsTelefone { get; set; }
        [Key]
        [Column("idtb_empresa")]
        public int IdtbEmpresa { get; set; }
        [Required]
        [Column("nm_empresa", TypeName = "varchar(45)")]
        public string NmEmpresa { get; set; }

        [InverseProperty("TbEmpresaIdtbEmpresaNavigation")]
        public virtual ICollection<TbEmpresaRepresentante> TbEmpresaRepresentante { get; set; }
        [InverseProperty("TbEmpresaIdtbEmpresaNavigation")]
        public virtual ICollection<TbVaga> TbVaga { get; set; }
    }
}
