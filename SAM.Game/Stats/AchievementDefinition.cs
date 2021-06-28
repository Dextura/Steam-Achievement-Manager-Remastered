﻿//* Copyright (c) 2021 James Madison ( Or MysticJames)

namespace SAM.Game.Stats
{
    internal class AchievementDefinition
    {
        public string Id;
        public string Name;
        public string Description;
        public string IconNormal;
        public string IconLocked;
        public bool IsHidden;
        public int Permission;

        public override string ToString()
        {
            return string.Format(
                System.Globalization.CultureInfo.CurrentCulture,
                "{0}: {1}",
                this.Name ?? this.Id ?? base.ToString(),
                this.Permission);
        }
    }
}
