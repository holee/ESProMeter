using ESProMeter.DataAccess;
using ESProMeter.IVews;
using ESProMeter.Models;
using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Repository
{
    public class AddressRepository
    {
        public long AddressCreate(ITAddressInfo model)
        {
            return DataUtility.GetInstance.UseProcedure("[ADDRESS_sp_INSERT]")
                        .InsertGetId<long, dynamic>(new
                        {
                            model.ADDRESS,
                            model.PROVINCE,
                            model.COUNTRY
                        });
        }

        public long AddressUpdate(TAddressInfo model)
        {
            return DataUtility.GetInstance.UseProcedure("[ADDRESS_sp_UPDATE]")
                        .InsertOrUpdate<dynamic>(new
                        {
                            model.ID,
                            model.ADDRESS,
                            model.PROVINCE,
                            model.COUNTRY
                        });
        }

    }
}
