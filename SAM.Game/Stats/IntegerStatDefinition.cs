//* Copyright (c) 2021 James Madison ( Or MysticJames)

namespace SAM.Game.Stats
{
    internal class IntegerStatDefinition : StatDefinition
    {
        public int MinValue;
        public int MaxValue;
        public int MaxChange;
        public bool IncrementOnly;
        public int DefaultValue;
    }
}
