using System;
using System.Collections.Generic;
using Lol.Domain.Adapters.Requests;
using Lol.Domain.Adapters.Responses;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Domain.Factories;
using Lol.Infra.Context;
using Microsoft.AspNetCore.Mvc;

namespace Lol.Api.Controllers
{
    [ApiController]
    [Route("/lol/campeoes")]
    public class CampeaoController : ControllerBase
    {
        [HttpGet]
        public IActionResult RecuperaLista([FromServices] IRecuperarListaCampeao useCase)
        {
            try
            {
                IEnumerable<CampeaoResponse> campeoesResponse = CampeaoResponseFactory.Build(useCase.RecuperarLista());
                return Ok(campeoesResponse);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPorId([FromServices] IRecuperarCampeao useCase, string id)
        {
            try
            {
                CampeaoResponse campeaoResponse = CampeaoResponseFactory.Build(useCase.RecuperarPorId(id));
                return Ok(campeaoResponse);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }
        
        [HttpGet("duelar/{nomeCampeaoUm}/{nomeCampeaoDois}")]
        public IActionResult DuelarPorNome([FromServices] IDuelarCampeao useCase, string nomeCampeaoUm, string nomeCampeaoDois) 
        {
            string resultado = useCase.Duelar(nomeCampeaoUm, nomeCampeaoDois);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Adicionar([FromServices] IAdicionarCampeao useCase, [FromBody] CampeaoAdicionarRequest campeao)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                useCase.Adicionar(CampeaoEntityFactory.Build(campeao));
                return Created("", null);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Atualizar([FromServices] IAtualizarCampeao useCase, string id, [FromBody] CampeaoAtualizarRequest campeao)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                useCase.Atualizar(id, CampeaoEntityFactory.Build(campeao));
                return NoContent();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        
        [HttpDelete("{id}")]
        public IActionResult Excluir([FromServices] IExcluirCampeao useCase, string id)
        {
            try
            {
                useCase.Excluir(id);
                return NoContent();
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }
    }
}