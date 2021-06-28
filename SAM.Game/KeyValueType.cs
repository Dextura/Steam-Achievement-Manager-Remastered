﻿//* Copyright (c) 2021 James Madison ( Or MysticJames)

namespace SAM.Game
{
    internal enum KeyValueType : byte
    {
        None = 0,
        String = 1,
        Int32 = 2,
        Float32 = 3,
        Pointer = 4,
        WideString = 5,
        Color = 6,
        UInt64 = 7,
        End = 8,
    }
}
