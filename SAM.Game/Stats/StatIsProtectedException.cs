//* Copyright (c) 2021 James Madison ( Or MysticJames)

using System;
using System.Runtime.Serialization;

namespace SAM.Game.Stats
{
    [Serializable]
    internal class StatIsProtectedException : Exception
    {
        public StatIsProtectedException()
        {
        }

        public StatIsProtectedException(string message)
            : base(message)
        {
        }

        public StatIsProtectedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected StatIsProtectedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
