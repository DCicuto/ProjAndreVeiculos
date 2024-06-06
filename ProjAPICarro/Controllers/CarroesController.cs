using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjAPICarro.Data;

namespace ProjAPICarro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroesController : ControllerBase
    {
        private readonly ProjAPICarroContext _context;

        public CarroesController(ProjAPICarroContext context)
        {
            _context = context;
        }

        // GET: api/Carroes
        
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Carro>>> GetCarro()
        {
          if (_context.Carro == null)
          {
              return NotFound();
          }
            return await _context.Carro.ToListAsync();
        }

        // GET: api/Carroes/5 aqui esse metodo retorna apenas um carro
        [HttpGet("{id}")]

        //sempre que temos um metodo async ele obrigatoriamente tem que ter seu par o await
        public async Task<ActionResult<Carro>> GetCarro(string id)
        {
          if (_context.Carro == null)
          {
              return NotFound();
          }
            var carro = await _context.Carro.FindAsync(id);//findAsync retorna um carro

            if (carro == null)
            {
                return NotFound();
            }

            return carro;
        }

        // PUT: api/Carroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarro(string id, Carro carro)
        {
            if (id != carro.Placa) //se o id que eu passar for diferente do id do carro
            {
                return BadRequest();
            }

            _context.Entry(carro).State = EntityState.Modified;//modifica o estado do carro

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Carroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Carro>> PostCarro(Carro carro)//aqui ele cria um carro
        {
          if (_context.Carro == null)//ai ele verifica se o carro é nulo
          {
              return Problem("Entity set 'ProjAPICarroContext.Carro'  is null.");//se for ele retorna um problema
          }
            _context.Carro.Add(carro);//aqui ele adiciona o carro
            try
            {
                await _context.SaveChangesAsync();//aqui ele salva as alterações
            }
            catch (DbUpdateException)//se der erro
            {
                if (CarroExists(carro.Placa))//se o carro existir
                {
                    return Conflict();//ele retorna conflito, porque o carro já existe
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCarro", new { id = carro.Placa }, carro);//ai ele retorna o carro criado, porque ele foi criado com sucesso
        }

        // DELETE: api/Carroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarro(string id)//aqui deleta um carro
        {
            if (_context.Carro == null)
            {
                return NotFound();
            }
            var carro = await _context.Carro.FindAsync(id);//aqui ele procura o carro
            if (carro == null)//se o carro não existir
            {
                return NotFound();//ele retorna not found
            }

            _context.Carro.Remove(carro);//aqui ele remove o carro
            await _context.SaveChangesAsync();//ai ele salva as alterações, no caso a remoção

            return NoContent();//e retorna no content, ou seja retorna nada
        }

        private bool CarroExists(string id)//aqui ele verifica se o carro existe
        {
            return (_context.Carro?.Any(e => e.Placa == id)).GetValueOrDefault();//se o carro existir ele retorna true, se não ele retorna false
        }
    }
}
