using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace sanPetersburgo.Models
{
    [Keyless]
    public partial class VmConsultarAcademium
    {
        [Required]
        [Column("nm_morador", TypeName = "varchar(70)")]
        public string NmMorador { get; set; }
        [Column("dt_entrada", TypeName = "date")]
        public DateTime? DtEntrada { get; set; }
        [Column("tm_entrada", TypeName = "time")]
        public TimeSpan? TmEntrada { get; set; }
        [Column("dt_saida", TypeName = "date")]
        public DateTime? DtSaida { get; set; }
        [Column("tm_saida", TypeName = "time")]
        public TimeSpan? TmSaida { get; set; }
    }
}
