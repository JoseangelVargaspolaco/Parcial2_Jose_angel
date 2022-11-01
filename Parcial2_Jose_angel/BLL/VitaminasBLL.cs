using Microsoft.EntityFrameworkCore;
using Parcial2_Jose_angel.Models;
using Parcial2_Jose_angel.Data;
using System.Linq.Expressions;

namespace Parcial2_Jose_angel.BLL
{
    public class VitaminasBLL
    {
        private Contexto _contexto;

        public VitaminasBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Vitaminas? Buscar(int Id)
        {
            return _contexto.Vitaminas
                .Where(p => p.VitaminaId == Id)
                .AsNoTracking()
                .SingleOrDefault();
        }

        public List<Vitaminas> GetVitaminas(Expression<Func<Vitaminas, bool>> Criterio)
        {
            return _contexto.Vitaminas
                .AsNoTracking()
                .ToList();
        }
    }
}