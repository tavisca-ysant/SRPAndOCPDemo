using System;
using System.Collections.Generic;
using System.Text;

namespace SRPAndOCPDemo
{
    public class Database : IRepository
    {
        private List<Entity> _entitySet = new List<Entity>();
        private static int _primaryKey = 1;
        public List<Entity> Display()
        {
            return _entitySet;
        }

        public void Insert(Entity entity)
        {
            _entitySet.Add(entity);
            _primaryKey++;
        }

        public Entity Retrieve(int primaryKey)
        {
            foreach(var entity in _entitySet)
            {
                if (entity.GetPrimaryKey() == primaryKey)
                    return entity;
            }
            throw new EntityDoesNotExist();
        }
    }
}
