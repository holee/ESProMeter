using ESProMeter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Services
{
    public class BoqItemLineService
    {
        private static BoqItemLineRepository? boq;

        public static BoqItemLineRepository? GetInstance
        {
            get
            {
                if(boq == null)
                {
                    boq = new BoqItemLineRepository();
                }
                return boq;
            }
        }

    }
}
