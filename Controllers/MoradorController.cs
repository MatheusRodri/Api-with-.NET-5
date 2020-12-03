using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace sanPetersburgo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoradorController
    {

        [HttpPost]
        public Models.TbMorador Salvar(Models.TbMorador morador){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();
            ctx.TbMoradors.Add(morador);
            ctx.SaveChanges();

            return morador;
        }
        [HttpGet]
        public List<Models.TbMorador> Listar(){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();

          List<Models.TbMorador> moradores =  ctx.TbMoradors.ToList();

          return moradores;
        }
    }
}