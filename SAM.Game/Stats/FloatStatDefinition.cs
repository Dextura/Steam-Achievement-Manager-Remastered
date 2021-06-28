//* Copyright (c) 2021 James Madison ( Or MysticJames)

namespace SAM.Game.Stats
{
    internal class FloatStatDefinition : StatDefinition
    {
        public float MinValue;
        public float MaxValue;
        public float MaxChange;
        public bool IncrementOnly;
        public float DefaultValue;
    }
}
