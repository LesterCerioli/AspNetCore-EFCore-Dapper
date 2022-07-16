﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6_EFCore_Dapper.Data.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
