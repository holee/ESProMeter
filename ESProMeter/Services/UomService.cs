using ESProMeter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Services
{
    public class UomService
    {
        private static UomRepository repository=null;

        public static UomRepository GetInstance
        {
            get
            {
                if (repository == null)
                {
                    repository = new UomRepository();
                }
                return repository;
            }
        }
    }
}
