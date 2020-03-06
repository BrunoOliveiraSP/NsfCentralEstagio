using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_informacao_pessoal")]
    public partial class TbInformacaoPessoal
    {
        [Required]
        [Column("ds_celular", TypeName = "varchar(45)")]
        public string DsCelular { get; set; }
        [Required]
        [Column("ds_cep", TypeName = "varchar(45)")]
        public string DsCep { get; set; }
        [Required]
        [Column("ds_cidade", TypeName = "varchar(45)")]
        public string DsCidade { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(45)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_estado_civil", TypeName = "varchar(45)")]
        public string DsEstadoCivil { get; set; }
        [Column("ds_git", TypeName = "varchar(200)")]
        public string DsGit { get; set; }
        [Column("ds_link_portfolio", TypeName = "varchar(200)")]
        public string DsLinkPortfolio { get; set; }
        [Column("ds_linkedin", TypeName = "varchar(200)")]
        public string DsLinkedin { get; set; }
        [Column("ds_nascimento", TypeName = "date")]
        public DateTime DsNascimento { get; set; }
        [Required]
        [Column("ds_nome", TypeName = "varchar(100)")]
        public string DsNome { get; set; }
        [Required]
        [Column("ds_numero", TypeName = "varchar(45)")]
        public string DsNumero { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(45)")]
        public string DsRg { get; set; }
        [Column("ds_telefone", TypeName = "varchar(45)")]
        public string DsTelefone { get; set; }
        [Key]
        [Column("idtb_info_pessoais")]
        public int IdtbInfoPessoais { get; set; }
        [Column("tb_curriculo_idtb_curriculo")]
        public int TbCurriculoIdtbCurriculo { get; set; }

        [ForeignKey(nameof(TbCurriculoIdtbCurriculo))]
        [InverseProperty(nameof(TbCurriculo.TbInformacaoPessoal))]
        public virtual TbCurriculo TbCurriculoIdtbCurriculoNavigation { get; set; }
    }
}
