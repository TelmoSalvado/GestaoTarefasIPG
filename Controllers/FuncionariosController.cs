using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoTarefasIPG.Models;

namespace GestãoTarefasIPG.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly GestaoTarefasIPGContext _context;

        public int TamanhoPagina = 7;

        public FuncionariosController(GestaoTarefasIPGContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index(int page = 1, string searchString = null)
        {
            var _contextFuncionario = _context.Funcionario.Include(f => f.Cargos);
            var Funcionario = from p in _contextFuncionario
                            select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                Funcionario = Funcionario.Where(p => p.Nome.Contains(searchString));
            }
            decimal nFuncionario = Funcionario.Count();
            int NUMERO_PAGINAS = ((int)nFuncionario / TamanhoPagina);

            if (nFuncionario % TamanhoPagina == 0)
            {
                NUMERO_PAGINAS -= 1;
            }

            FuncionarioViewModel vm = new FuncionarioViewModel
            {
                Funcionarios = Funcionario.OrderBy(p => p.Nome).Skip((page - 1) * TamanhoPagina).Take(TamanhoPagina),
                PaginaAtual = page,
                PrimeiraPagina = Math.Max(1, page - NUMERO_PAGINAS),
                TotalPaginas = (int)Math.Ceiling(nFuncionario / TamanhoPagina)
            };

            vm.UltimaPagina = Math.Min(vm.TotalPaginas, page + NUMERO_PAGINAS);
            vm.StringProcura = searchString;

            //var gestaoTarefasIPGContext = _context.Funcionario.Include(f => f.Cargos);
            //return View(await gestaoTarefasIPGContext.ToListAsync());
            return View(vm);
        }

        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario
                .Include(f => f.Cargos)
                .FirstOrDefaultAsync(m => m.FuncionarioId == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            ViewData["CargosId"] = new SelectList(_context.Cargos, "CargosId", "Nome");
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionarioId,Nome,Numero,Idade,Email,CargosId")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CargosId"] = new SelectList(_context.Cargos, "CargosId", "Nome", funcionario.CargosId);
            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            ViewData["CargosId"] = new SelectList(_context.Cargos, "CargosId", "Nome", funcionario.CargosId);
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuncionarioId,Nome,Numero,Idade,Email,CargosId")] Funcionario funcionario)
        {
            if (id != funcionario.FuncionarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.FuncionarioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CargosId"] = new SelectList(_context.Cargos, "CargosId", "Nome", funcionario.CargosId);
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario
                .Include(f => f.Cargos)
                .FirstOrDefaultAsync(m => m.FuncionarioId == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionario.FindAsync(id);
            _context.Funcionario.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioExists(int id)
        {
            return _context.Funcionario.Any(e => e.FuncionarioId == id);
        }
    }
}
