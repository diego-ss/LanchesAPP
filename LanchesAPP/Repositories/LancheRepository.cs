using LanchesAPP.Context;
using LanchesAPP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesAPP.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l=>l.IsLanchePreferido).Include(c=> c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            var lanche = _context.Lanches.FirstOrDefault(l=> l.Id == lancheId);
            return lanche;
        }
    }
}
