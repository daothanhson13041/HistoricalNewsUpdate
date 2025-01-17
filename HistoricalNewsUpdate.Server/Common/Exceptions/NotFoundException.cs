﻿using System;

namespace HistoricalNewsUpdate.Common.Exceptions
{
    /// <summary>
    /// Exception type for not found exceptions
    /// </summary>
    public class NotFoundException : Exception
    {
        public NotFoundException()
        { }

        public NotFoundException(string message)
            : base(message)
        { }

        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
