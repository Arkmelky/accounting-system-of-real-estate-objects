using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SupportEntities
{
    public enum EnumObjectType
    {
        House = 1,
        Apartment = 2,
        Homestead = 3,
        CommercialProperty = 4
    }

    public enum EnumServiceType
    {
        Sale = 1,
        Rent = 2,
        Barter = 3,
    }

    public enum EnumKindOfCalculating
    {
        Cahs = 1,
        BankTransfer = 2
    }

    public enum EnumObjectState
    {
        Opened = 1,
        Closed = 2
    }
}
