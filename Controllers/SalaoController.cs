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
    public class SalaoController
    {
        [HttpPost]
        public Models.TbSalao Salvar(Models.TbSalao salao){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();
            ctx.TbSalaos.Add(salao);
            ctx.SaveChanges();

            return salao;
        }
        [HttpGet]

        public List<Models.Response.SalaoResponse> Listar(){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();

            List<Models.TbSalao> salao = 
                ctx.TbSalaos
                .Include(x => x.IdMoradorNavigation)
                .ToList();

            List<Models.Response.SalaoResponse> response = 
                salao.Select(x => new Models.Response.SalaoResponse{
                    Morador = x.IdMoradorNavigation.NmMorador,
                    DataHorarioEntrada = x.DtEntrada,
                    DataHorarioSaida = x.DtSaida
                }).ToList();


            return response;
        }
    }
}