using System;
using System.Collections.Generic;
using System.Text;

namespace SRPAndOCPDemo
{
    public interface IRepository
    {
        void Insert(Entity entity);

        Entity Retrieve(int primaryKey);

        List<Entity> Display();
    }
}
