using Microsoft.EntityFrameworkCore;
using Parcial2_Jose_angel.Models;
using Parcial2_Jose_angel.Data;
using System.Linq.Expressions;

namespace Parcial2_Jose_angel.BLL
{
    public class VerdurasBLL
    {
        private Contexto contexto_;

        public VerdurasBLL(Contexto contexto)
        {
            contexto_ = contexto;
        }
        public bool Existe(int Id)
        {
            return contexto_.Verduras.Any(c => c.VerduraId == Id);
        }
        public bool Guardar(Verduras verdura)
        {
            bool paso = false;

            if (!Existe(verdura.VerduraId))
                paso = Insertar(verdura);
            else
                paso = Modificar(verdura);
                return paso;

        }
        private bool Insertar(Verduras verdura)
        {
            contexto_.Verduras.Add(verdura);
            
            foreach (var item in verdura.Detalle)
            {
                var vitamina = contexto_.Vitaminas.Find(item.VitaminaId);
            }
            
            bool insertar = contexto_.SaveChanges() >0;
            contexto_.Entry(verdura).State = EntityState.Detached;
            return insertar;           
        }
            
        private bool Modificar(Verduras verdura)
        {
            var anterior = contexto_.Verduras
            .Where(c => c.VerduraId == verdura.VerduraId)
            .Include(c => c.Detalle)
            .AsNoTracking()
            .SingleOrDefault();

            foreach (var item in anterior!.Detalle)
            {
                var vitamina = contexto_.Vitaminas.Find(item.VitaminaId);
                contexto_.Entry(item).State = EntityState.Added;
            }        
            contexto_.Database.ExecuteSqlRaw($"DELETE FROM VerdurasDetalle WHERE VerduraId={verdura.VerduraId}");

            contexto_.Entry(verdura).State = EntityState.Modified;
            contexto_.Entry(verdura).State = EntityState.Detached;
            
            return contexto_.SaveChanges() > 0;
        }
        public bool Eliminar(Verduras verdura)
        {
            contexto_.Verduras.Add(verdura);
            
            foreach (var item in verdura.Detalle)
            {
                var vitamina = contexto_.Vitaminas.Find(item.VitaminaId);
            }
            contexto_.Entry(verdura).State = EntityState.Deleted;

            bool elimino = contexto_.SaveChanges() > 0;
            contexto_.Entry(verdura).State = EntityState.Detached;
                
            return elimino;
        } 
        public Verduras? Buscar(int verdura)
        {
            return contexto_.Verduras
            .Include(c => c.Detalle)
            .Where(c => c.VerduraId == verdura)
            .AsNoTracking()
            .SingleOrDefault();
        }
        public List<Verduras> GetVerduras(Expression<Func<Verduras, bool>> Criterio)
        {
            return contexto_.Verduras
            .AsNoTracking()
            .ToList();
        }
    }
}