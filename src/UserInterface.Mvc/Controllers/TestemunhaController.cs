﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopDown.TopFramework.BusinessRules;
using Brato.Entities;

namespace Brato.UserInterface.Controllers
{
    public class TestemunhaController : Controller
    {
        IRules<TestemunhaEntity, int> rules = null;
        public TestemunhaController()
        {
            rules = RulesManager.CreateByEntity<TestemunhaEntity, int>();
        }
        public ActionResult IncTestemunha()
        {
            ViewData["UF"] = (new List<SelectListItem>());
            ViewData["Municipio"] = (new List<SelectListItem>());
            ViewData["Bairro"] = (new List<SelectListItem>());
            ViewData["Logradouro"] = (new List<SelectListItem>());
            return View();
        }

        public JsonResult SalvarTestemunha(TestemunhaEntity entity)
        {
            IList<string> erros = Validar(entity);

            if (erros.Any())
            {
                return new JsonResult()
                {
                    Data = new { Sucesso = false, Erros = erros }
                };
            }
            else
            {
                EnderecoEntity endereco = new EnderecoEntity()
                {
                    IdLogradouro = entity.Pessoa.Logradouro
                };

                endereco.IdLogradouro.IdBairro = entity.Pessoa.Bairro;
                endereco.IdLogradouro.IdBairro.IdMunicipio = entity.Pessoa.Municipio;
                endereco.IdLogradouro.IdBairro.IdMunicipio.Uf = entity.Pessoa.UF;
                endereco.IdComplemento = new ComplementoEntity();
                endereco.IdComplemento.Descricao = entity.Pessoa.Complemento;
                endereco.Numero = entity.Pessoa.Numero;

                var complementoRules = RulesManager.CreateByEntity<ComplementoEntity, int>();
                var complemento = endereco.IdComplemento;
                complementoRules.Create(complemento);
                complementoRules.Flush();
                endereco.IdComplemento = complemento;

                var enderecoRules = RulesManager.CreateByEntity<EnderecoEntity, int>();
                enderecoRules.Create(endereco);
                enderecoRules.Flush();

                entity.Pessoa.IdEndereco = endereco;
                var pessoaRules = RulesManager.CreateByEntity<PessoaEntity, int>();
                pessoaRules.Create(entity.Pessoa);
                pessoaRules.Refresh(entity.Pessoa);

                rules.Create(entity);
                return new JsonResult()
                {
                    Data = new { Sucesso = true }
                };
            }
        }

        private IList<string> Validar(TestemunhaEntity entity)
        {
            IList<string> erros = new List<string>();

            if (string.IsNullOrEmpty(entity.Pessoa.Cpf))
                erros.Add("O campo 'CPF' é obrigatório");
            if (string.IsNullOrEmpty(entity.Pessoa.Nome))
                erros.Add("O campo 'Nome' é obrigatório");
            if (string.IsNullOrEmpty(entity.Pessoa.Sexo))
                erros.Add("O campo 'Sexo' é obrigatório");

            if (entity.Pessoa.UF != null && string.IsNullOrEmpty(entity.Pessoa.UF.Uf))
                erros.Add("O campo 'UF' é obrigatório");
            if (entity.Pessoa.Municipio != null && entity.Pessoa.Municipio.IdMunicipio == 0)
                erros.Add("O campo 'Município' é obrigatório");
            if (entity.Pessoa.Bairro != null && entity.Pessoa.Bairro.IdBairro == 0)
                erros.Add("O campo 'Bairro' é obrigatório");
            if (entity.Pessoa.Logradouro != null && entity.Pessoa.Logradouro.IdLogradouro == 0)
                erros.Add("O campo 'Logradouro' é obrigatório");
            if (string.IsNullOrEmpty(entity.Pessoa.Numero))
                erros.Add("O campo 'Número' é obrigatório");

            return erros;
        }
    }
}
