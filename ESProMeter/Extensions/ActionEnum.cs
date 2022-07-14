using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Extensions
{

    public enum ItemTypeEnum
    {
        Item,
        Boq
    }

    public enum ActionEnum
    {
        New=1,
        Edit=2,
        CreateACopyItem=3,
        CreateACopyBoqItem=4,
        Delete=5
    }
}
