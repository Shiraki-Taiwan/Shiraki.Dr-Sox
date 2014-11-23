using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiraki.Dr_Sox
{
    public enum OrderStatus
    {
        NONE = 0,
        PROCESSING = 1,
        SHIPPING = 2,
        SETTLED = 4,
        RETURN = 8,
        REFUND = 16
    }
}
