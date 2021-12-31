﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAluNa.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }

    }
}
