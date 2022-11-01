using Microsoft.EntityFrameworkCore;
using Parcial2_Jose_angel.Models;
using Parcial2_Jose_angel.Data;

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
        public string GetDescripcion(int vitamina)
        {
            var vitaminas = _contexto.Vitaminas
            .Where(c => c.VitaminaId == vitamina)
            .AsNoTracking()
            .SingleOrDefault();

            return vitaminas!.Descripcion;
        }

        public List<Vitaminas> GetVitaminas()
        {
            return _contexto.Vitaminas
                .AsNoTracking()
                .ToList();
        }
    }
}