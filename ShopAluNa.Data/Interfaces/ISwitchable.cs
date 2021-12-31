using ShopAluNa.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAluNa.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
