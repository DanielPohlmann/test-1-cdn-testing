﻿namespace CandidateTesting.DanielHelerPohlmann.Core.DomainObjects
{
    public class FileException : Exception
    {
        public FileException()
        { }

        public FileException(string message) : base(message)
        { }

        public FileException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
