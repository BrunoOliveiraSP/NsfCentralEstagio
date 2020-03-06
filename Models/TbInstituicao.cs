using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_instituicao")]
    public partial class TbInstituicao
    {
        [Required]
        [Column("ds_cidade", TypeName = "varchar(45)")]
        public string DsCidade { get; set; }
        [Required]
        [Column("ds_cnpj", TypeName = "varchar(45)")]
        public string DsCnpj { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_representante", TypeName = "varchar(100)")]
        public string DsRepresentante { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(45)")]
        public string DsTelefone { get; set; }
        [Key]
        [Column("idtb_instituicao")]
        public int IdtbInstituicao { get; set; }
        [Required]
        [Column("nm_nome", TypeName = "varchar(45)")]
        public string NmNome { get; set; }
    }
}
