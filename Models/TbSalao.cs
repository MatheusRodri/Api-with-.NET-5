using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace sanPetersburgo.Models
{
    [Table("tb_salao")]
    [Index(nameof(IdMorador), Name = "id_morador_idx")]
    public partial class TbSalao
    {
        [Key]
        [Column("id_salao")]
        public int IdSalao { get; set; }
        [Column("id_morador")]
        public int? IdMorador { get; set; }
        [Column("dt_entrada", TypeName = "datetime")]
        public DateTime? DtEntrada { get; set; }
        [Column("dt_saida", TypeName = "datetime")]
        public DateTime? DtSaida { get; set; }

        [ForeignKey(nameof(IdMorador))]
        [InverseProperty(nameof(TbMorador.TbSalaos))]
        public virtual TbMorador IdMoradorNavigation { get; set; }
    }
}
