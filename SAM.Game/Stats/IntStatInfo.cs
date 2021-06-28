//* Copyright (c) 2021 James Madison ( Or MysticJames)

namespace SAM.Game.Stats
{
    internal class IntStatInfo : StatInfo
    {
        public int OriginalValue;
        public int IntValue;

        public override object Value
        {
            get { return this.IntValue; }
            set
            {
                var i = int.Parse((string)value, System.Globalization.CultureInfo.CurrentCulture);

                if ((this.Permission & 2) != 0 &&
                    this.IntValue != i)
                {
                    throw new StatIsProtectedException();
                }

                this.IntValue = i;
            }
        }

        public override bool IsModified
        {
            get { return this.IntValue != this.OriginalValue; }
        }
    }
}
