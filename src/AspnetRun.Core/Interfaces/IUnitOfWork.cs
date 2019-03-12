﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspnetRun.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
        void Rollback();
    }
}
