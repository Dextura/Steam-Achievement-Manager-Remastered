//* Copyright (c) 2021 James Madison ( Or MysticJames)
using System.Drawing;

namespace SAM.Picker
{
    internal class LogoInfo
    {
        public readonly uint Id;
        public readonly Bitmap Bitmap;

        public LogoInfo(uint id, Bitmap bitmap)
        {
            this.Id = id;
            this.Bitmap = bitmap;
        }
    }
}
