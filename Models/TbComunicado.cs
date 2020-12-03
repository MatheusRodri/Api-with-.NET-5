using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace sanPetersburgo.Models
{
    [Table("tb_comunicado")]
    [Index(nameof(IdMorador), Name = "id_morador_idx")]
    public partial class TbComunicado
    {
        [Key]
        [Column("id_comunicado")]
        public int IdComunicado { get; set; }
        [Column("id_morador")]
        public int? IdMorador { get; set; }
        [Column("tx_comunicado", TypeName = "longtext")]
        public string TxComunicado { get; set; }
        [Column("dt_comunicado", TypeName = "date")]
        public DateTime DtComunicado { get; set; }

        [ForeignKey(nameof(IdMorador))]
        [InverseProperty(nameof(TbMorador.TbComunicados))]
        public virtual TbMorador IdMoradorNavigation { get; set; }
    }
}
