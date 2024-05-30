using ShipmentTracking.Data;
using System.Collections.Generic;
using System.Linq;

namespace ShipmentTracking.Entities.Interfaces
{
    public class EntityHandler<T> where T : class, IEntity
    {
        private ApplicationDbContext context;

        public EntityHandler()
        {
            context = new ApplicationDbContext();
        }

        public List<T> GetAllEntities()
        {
            return context.Set<T>().ToList();
        }

        public void EditEntity(int entityId, string value)
        {
            var entity = context.Set<T>().Find(entityId);
            if (entity != null)
            {
                entity.TextField = value;
                context.SaveChanges();
            }
        }

        public void DeleteEntity(int entityId)
        {
            var entity = context.Set<T>().Find(entityId);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
    }

}
