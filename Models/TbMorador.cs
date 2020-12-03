using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace sanPetersburgo.Models
{
    [Table("tb_morador")]
    public partial class TbMorador
    {
        public TbMorador()
        {
            TbAcademia = new HashSet<TbAcademium>();
            TbComunicados = new HashSet<TbComunicado>();
            TbSalaos = new HashSet<TbSalao>();
        }

        [Key]
        [Column("id_morador")]
        public int IdMorador { get; set; }
        [Required]
        [Column("nm_morador", TypeName = "varchar(70)")]
        public string NmMorador { get; set; }
        [Column("apto_morador")]
        public int AptoMorador { get; set; }
        [Column("bl_morador")]
        public int BlMorador { get; set; }
        [Column("morador")]
        public bool? Morador { get; set; }
        [Column("sindico")]
        public bool? Sindico { get; set; }
        [Column("porteiro")]
        public bool? Porteiro { get; set; }

        [InverseProperty(nameof(TbAcademium.IdMoradorNavigation))]
        public virtual ICollection<TbAcademium> TbAcademia { get; set; }
        [InverseProperty(nameof(TbComunicado.IdMoradorNavigation))]
        public virtual ICollection<TbComunicado> TbComunicados { get; set; }
        [InverseProperty(nameof(TbSalao.IdMoradorNavigation))]
        public virtual ICollection<TbSalao> TbSalaos { get; set; }
    }
}
