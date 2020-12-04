using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

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
        
    }
}