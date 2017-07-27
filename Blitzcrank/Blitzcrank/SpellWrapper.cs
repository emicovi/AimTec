﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aimtec;
using Aimtec.SDK.Damage;
using Aimtec.SDK.Extensions;
using Aimtec.SDK.Prediction.Collision;
using Aimtec.SDK.Prediction.Skillshots;
using Aimtec.SDK.TargetSelector;
using Spell = Aimtec.SDK.Spell;

namespace emicoviBlitzcrank
{

    public class SpellWrapper : Spell
    {

        private readonly int _deviation;

        public SpellWrapper(SpellSlot slot, int deviation) : base(slot)
        {
            _deviation = deviation;
        }

        public SpellWrapper(SpellSlot slot, int deviation, float range) : base(slot, range)
        {
            _deviation = deviation;
        }

        public void DrawRange(Color color)
        {
            if (!IsOnCooldown())
            {
                Render.Circle(ObjectManager.GetLocalPlayer().Position, Range, 30, color);
            }
        }

        public bool IsOnCooldown()
        {
            return Game.ClockTime - ObjectManager.GetLocalPlayer().SpellBook.GetSpell(Slot).CooldownEnd < 0;
        }

        public bool CanKill(Obj_AI_Base target)
        {
            double potentionalDamage = ObjectManager.GetLocalPlayer().GetSpellDamage(target, Slot);
            return target.Health < potentionalDamage;
        }

        public bool CastMob()
        {
            return CastMob(TargetSelector.GetTarget(Range));
        }

        public bool CastMob(Obj_AI_Base mob)
        {
            if (mob == null || !mob.IsValid || !mob.IsEnemy || mob.IsDead)
            {
                return false;
            }

            PredictionOutput predictionOutput = Prediction.GetPrediction(GetPredictionInput(mob));
            Obj_AI_Base invalidCollisionUnit =
                predictionOutput.CollisionObjects.FirstOrDefault(objAiBase => objAiBase.IsMinion);
            if (invalidCollisionUnit != null)
            {
                return false;
            }

            if (predictionOutput.HitChance < HitChance.VeryHigh)
            {
                return false;
            }

            return Cast(Utils.RandomizeVector(predictionOutput.CastPosition, _deviation));
        }

    }

}