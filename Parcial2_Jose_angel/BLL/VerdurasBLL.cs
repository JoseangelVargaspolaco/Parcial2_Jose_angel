using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Parcial2_Jose_angel.Models;
using Parcial2_Jose_angel.Data;

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
                vitamina!.Existencia += item.Cantidad;
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

                vitamina!.Existencia -= item.Cantidad;
            }        
            contexto_.Database.ExecuteSqlRaw($"DELETE FROM VerdurasDetalle WHERE VerduraId={verdura.VerduraId};");

            foreach (var item in verdura.Detalle)
            {
                var vitamina = contexto_.Vitaminas.Find(item.VitaminaId);
                vitamina!.Existencia += item.Cantidad;
                

                contexto_.Entry(item).State = EntityState.Added;
            }

            contexto_.Entry(verdura).State = EntityState.Modified;

            var guardo = contexto_.SaveChanges() > 0;
            contexto_.Entry(verdura).State = EntityState.Detached;
            return guardo;
        }
        public bool Eliminar(Verduras verdura)
        {
            contexto_.Verduras.Add(verdura);
            
            foreach (var item in verdura.Detalle)
            {
                var vitamina = contexto_.Vitaminas.Find(item.VitaminaId);
                vitamina!.Existencia -= item.Cantidad;
                
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
        public List<Verduras> GetVerduras()
        {
            return contexto_.Verduras.AsNoTracking().ToList();
        }
    }
}