//* Copyright (c) 2021 James Madison ( Or MysticJames)

using System;

namespace SAM.Game.Stats
{
    [Flags]
    internal enum StatFlags
    {
        None = 0,
        IncrementOnly = 1 << 0,
        Protected = 1 << 1,
        UnknownPermission = 1 << 2,
    }
}
