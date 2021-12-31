using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAluNa.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
