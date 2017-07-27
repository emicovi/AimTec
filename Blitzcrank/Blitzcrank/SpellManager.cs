using System;
using System.Collections.Generic;
using Aimtec;
using Aimtec.SDK.Prediction.Skillshots;
using Spell = Aimtec.SDK.Spell;

namespace emicoviBlitzcrank
{

    public class SpellManager
    {

        private static readonly float MaxERange = 925;

        public static Dictionary<SpellSlot, SpellWrapper> Spells = new Dictionary<SpellSlot, SpellWrapper>();

        public static SpellWrapper Get(SpellSlot spellSlot)
        {
            return Spells[spellSlot];
        }
     

        static SpellManager()
        {
            Spells[SpellSlot.Q] = new SpellWrapper(SpellSlot.Q, 925);
            Spells[SpellSlot.R] = new SpellWrapper(SpellSlot.R, 600);


            Spells[SpellSlot.Q].SetSkillshot(0.25f, 70f, 1800f, true, SkillshotType.Line, false,
                HitChance.VeryHigh);
            Spells[SpellSlot.R].SetSkillshot(0.25f, 600f, float.MaxValue, false, SkillshotType.Circle, false,
                HitChance.VeryHigh);
        }

    }

}