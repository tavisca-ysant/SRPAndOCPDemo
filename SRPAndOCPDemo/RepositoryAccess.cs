using System;
using System.Collections.Generic;
using System.Text;

namespace SRPAndOCPDemo
{
    public class RepositoryAccess
    {
        private IRepository _iRepository = RepositoryFactory.GetRepository("Database");
        private ILogger _iLogger = LoggerFactory.GetLogger("Database");
        public void GetEntity()
        {
            try
            {
                var entity = _iRepository.Retrieve(2);
            }
            catch(EntityDoesNotExist e)
            {
                _iLogger.log(e);
            }
        }
    }
}
