﻿namespace Magitek.Logic.BlueMage
{
    internal static class Buff
    {
        public static async Task<bool> OffGuard()
        {
            if(Spells.Surpanakha.Charges == 4)
            return await Spells.OffGuard.Cast(Core.Me.CurrentTarget);

            return false;
        }
    }
}