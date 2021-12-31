using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAluNa.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
