using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace sanPetersburgo.Models
{
    [Table("tb_morador")]
    public partial class TbMorador
    {
        public TbMorador()
        {
            TbComunicados = new HashSet<TbComunicado>();
            TbSalaos = new HashSet<TbSalao>();
        }

        [Key]
        [Column("id_morador")]
        public int IdMorador { get; set; }
        
        [Column("nm_morador", TypeName = "varchar(70)")]
        public string NmMorador { get; set; }
        [Column("apto_morador")]
        public int AptoMorador { get; set; }
        [Column("bl_morador")]
        public int BlMorador { get; set; }
        [Column("email", TypeName = "varchar(65)")]
        public string Email { get; set; }
        [Column("senha", TypeName = "varchar(45)")]
        public string Senha { get; set; }
        [Column("morador")]
        public bool? Morador { get; set; }
        [Column("sindico")]
        public bool? Sindico { get; set; }
        [Column("porteiro")]
        public bool? Porteiro { get; set; }

        [InverseProperty(nameof(TbComunicado.IdMoradorNavigation))]
        public virtual ICollection<TbComunicado> TbComunicados { get; set; }
        [InverseProperty(nameof(TbSalao.IdMoradorNavigation))]
        public virtual ICollection<TbSalao> TbSalaos { get; set; }
    }
}
