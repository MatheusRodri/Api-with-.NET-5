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

        [HttpPut]
        public void Alterar(Models.TbMorador morador){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();
            
            Models.TbMorador atual =  ctx.TbMoradors.First(x=> x.IdMorador == morador.IdMorador);
            atual.NmMorador = morador.NmMorador;
            atual.AptoMorador = morador.AptoMorador;
            atual.BlMorador = morador.BlMorador;
            atual.Email = morador.Email;
            atual.Senha = morador.Senha;
            atual.Morador = morador.Morador;
            atual.Sindico = morador.Sindico;
            atual.Porteiro = morador.Porteiro;

            ctx.SaveChanges();
        }


        [HttpDelete]
        public void Remover(Models.TbMorador morador){
            Models.sanpetersburgoContext ctx = new Models.sanpetersburgoContext();
            Models.TbMorador atual =  ctx.TbMoradors.First(x=> x.IdMorador == morador.IdMorador);

            ctx.TbMoradors.Remove(atual);

            ctx.SaveChanges();
        }
    }
}