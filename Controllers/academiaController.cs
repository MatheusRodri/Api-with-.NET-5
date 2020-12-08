using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace sanPetersburgo.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class academiaController
    {
          [HttpPost]
        public Models.TbAcademium Salvar(Models.TbAcademium academia){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();
            ctx.TbAcademia.Add(academia);
            ctx.SaveChanges();

            return academia;
        }
         [HttpGet]
        public List<Models.Response.AcademiaResponse> Listar(){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();

            List<Models.TbAcademium> academia = 
                ctx.TbAcademia
                    .Include(x => x.IdMoradorNavigation)
                    .ToList();

            List<Models.Response.AcademiaResponse> response = 
                academia.Select(x=> new Models.Response.AcademiaResponse{
                    IdAcademia = x.IdAcademia,
                    IdMorador = x.IdMorador,
                    Morador =x.IdMoradorNavigation.NmMorador,
                    DataHorarioEntrada = new DateTime(2020,12,08,07,00,00),
                    DataHorarioSaida = new DateTime(2020,12,08,07,00,00)
                }).ToList();

                return response;
        }
        
    }
}