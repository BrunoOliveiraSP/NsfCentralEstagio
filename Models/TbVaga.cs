using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nsfcentralestagio.Models
{
    [Table("tb_vaga")]
    public partial class TbVaga
    {
        public TbVaga()
        {
            TbCandidato = new HashSet<TbCandidato>();
        }

        [Column("bl_ativo")]
        public bool BlAtivo { get; set; }
        [Column("bl_va", TypeName = "varchar(45)")]
        public string BlVa { get; set; }
        [Column("bl_vr", TypeName = "varchar(45)")]
        public string BlVr { get; set; }
        [Column("bl_vt", TypeName = "varchar(45)")]
        public string BlVt { get; set; }
        [Required]
        [Column("ds_cargo", TypeName = "varchar(45)")]
        public string DsCargo { get; set; }
        [Required]
        [Column("ds_curso", TypeName = "varchar(45)")]
        public string DsCurso { get; set; }
        [Column("ds_idioma", TypeName = "varchar(45)")]
        public string DsIdioma { get; set; }
        [Column("ds_perfil", TypeName = "varchar(200)")]
        public string DsPerfil { get; set; }
        [Column("ds_requisitos", TypeName = "varchar(45)")]
        public string DsRequisitos { get; set; }
        [Required]
        [Column("ds_sexo", TypeName = "varchar(45)")]
        public string DsSexo { get; set; }
        [Key]
        [Column("idtb_vagas")]
        public int IdtbVagas { get; set; }
        [Column("tb_empresa_idtb_empresa")]
        public int TbEmpresaIdtbEmpresa { get; set; }
        [Required]
        [Column("vl_bolsa", TypeName = "varchar(45)")]
        public string VlBolsa { get; set; }

        [ForeignKey(nameof(TbEmpresaIdtbEmpresa))]
        [InverseProperty(nameof(TbEmpresa.TbVaga))]
        public virtual TbEmpresa TbEmpresaIdtbEmpresaNavigation { get; set; }
        [InverseProperty("TbVagaIdtbVagasNavigation")]
        public virtual ICollection<TbCandidato> TbCandidato { get; set; }
    }
}
