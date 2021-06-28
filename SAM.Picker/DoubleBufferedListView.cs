//* Copyright (c) 2021 James Madison ( Or MysticJames)

using System.Windows.Forms;

namespace SAM.Picker
{
    internal class DoubleBufferedListView : ListView
    {
        public DoubleBufferedListView()
        {
            base.DoubleBuffered = true;
        }
    }
}
