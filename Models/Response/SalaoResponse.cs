
using System;

namespace sanPetersburgo.Models.Response
{
    public class SalaoResponse
    {
        public string Morador { get; set; }
        public DateTime? DataHorarioEntrada { get; set; }
         public DateTime? DataHorarioSaida { get; set; }
    }
}