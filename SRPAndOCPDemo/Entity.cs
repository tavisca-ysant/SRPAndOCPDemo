using System;
namespace SRPAndOCPDemo
{
    public class Entity
    {

        private int _primaryKey;
        public int GetPrimaryKey()
        {
            return _primaryKey;
        }

        private string _record;

        public Entity()
        {
            _record = null;
        }
        
        public Entity(string record)
        {
            _record = record;
        }

    }
}