
using System;

namespace sanPetersburgo.Models.Response
{
    public class AcademiaResponse
    {
        public int? IdAcademia { get; set; }
        public int? IdMorador { get; set; }
        public string Morador { get; set; }
        public DateTime? DataHorarioEntrada { get; set; }
         public DateTime? DataHorarioSaida { get; set; }
        
    }
}