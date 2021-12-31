using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAluNa.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }

    }
}
