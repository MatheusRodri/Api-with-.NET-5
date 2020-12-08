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
        [Column("dt_entrada", TypeName = "datetime")]
        public DateTime? DtEntrada { get; set; }
        [Column("dt_saida", TypeName = "datetime")]
        public DateTime? DtSaida { get; set; }
    }
}
