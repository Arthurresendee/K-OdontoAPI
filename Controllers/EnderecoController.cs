﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DRAKaysaResende.Data;
using DRAKaysaResende.Models;
using DRAKaysa.ViewModels;
using Microsoft.IdentityModel.Tokens;
using DRAKaysa.Services;

namespace DRAKaysa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly DataContext _context;

        public EnderecoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Endereco
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetAll()
        {
            try
            {
                var enderecos = await _context.Enderecos.ToListAsync();
                if (enderecos.IsNullOrEmpty())
                {
                    return NotFound("Não foi encontrado nenhum Endereço");
                }
                return Ok(enderecos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/Endereco/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetById(int id)
        {
            try
            {
                var endereco = await _context.Enderecos.FirstOrDefaultAsync(x => x.Id == id);
                if (endereco == null)
                {
                    return NotFound("Endereço não encontrado");
                }

                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/Endereco
        [HttpPost]
        public async Task<ActionResult<Endereco>> Post([FromBody] Endereco endereco)
        {
            try
            {
                await _context.Enderecos.AddAsync(endereco);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetById", new { id = endereco.Id }, endereco);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/Endereco/id
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Endereco endereco)
        {
            var end = await _context.Enderecos.FindAsync(id);
            if (end == null)
            {
                return NotFound("Endereço não encontrado.");
            }

            end.CEP = endereco.CEP;
            end.Rua = endereco.Rua;
            end.Bairro = endereco.Bairro;
            end.Cidade = endereco.Cidade;
            end.Estado = endereco.Estado;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        //api/Endereco/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var endereco = await _context.Enderecos.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            try
            {
                _context.Enderecos.Remove(endereco);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        [HttpGet("cep/{CEP}")]
        public async Task<ActionResult> GetByCEP(string cep)
        {
            try
            {
                var endereco = await _context.Enderecos.FirstOrDefaultAsync(x => x.CEP == cep);
                if (endereco == null)
                {
                    return NotFound("Usuario não encontrado");
                }
                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
