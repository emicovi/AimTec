using Aimtec;
using System.Linq;
using Aimtec.SDK.Menu;
using Aimtec.SDK.Util;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Extensions;
using Spell = Aimtec.SDK.Spell;
using Aimtec.SDK.TargetSelector;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Prediction.Skillshots;
using System.Drawing;

namespace emicoviBlitzcrank
{
    internal class emicoviBlitzcrank
    {
        public static Menu Main = new Menu("Index", "emicovi Blitzcrank", true);
        public static Orbwalker Orbwalker = new Orbwalker();
        public static Obj_AI_Hero Blitzcrank => ObjectManager.GetLocalPlayer();
        //private static Spell _q, _e, _r;

        public emicoviBlitzcrank()
        {
            /*
            
            
            _q = new Spell(SpellSlot.Q, 925f);
            _e = new Spell(SpellSlot.E);
            _r = new Spell(SpellSlot.R, 600);

            _q.SetSkillshot(0.25f, 70f, 1800f, true, SkillshotType.Line);
            _r.SetSkillshot(0.25f, 600f, float.MaxValue, false, SkillshotType.Circle);
        
            */


            Orbwalker.Attach(Main);

            /*Combo Menu*/
            var combo = new Menu("combo", "Combo")
            {
                new MenuBool("q", "Use Combo Q"),
                new MenuBool("e", "Use Combo E"),
                new MenuBool("r", "Use Combo R"),
                new MenuSliderBool("r", "Use Combo R - Minimum enemies for R", true, 3, 1, 5),
            };
            var whiteList = new Menu("whiteList", "Q White List");
            {
                foreach (var enemies in GameObjects.EnemyHeroes)
                {
                    whiteList.Add(new MenuBool("qWhiteList" + enemies.ChampionName.ToLower(), enemies.ChampionName));
                }
            }
            Main.Add(whiteList);
            Main.Add(combo);


            /*Harass Menu*/
            /*var harass = new Menu("harass", "Harass")
            {
                new MenuBool("autoHarass", "Auto Harass", false),
                new MenuSliderBool("q", "Use Q / if Mana >= x%", true, 100, 0, 300),
                new MenuSliderBool("e", "Use E / if Mana >= x%", true, 100, 0, 300),
            };
            Main.Add(harass);
            */

            /*Drawings Menu*/
            var drawings = new Menu("drawings", "Drawings")
            {
                new MenuBool("q", "Draw Q"),
                new MenuBool("e", "Draw E", false),
                new MenuBool("r", "Draw R")
            };
            Main.Add(drawings);
            Main.Attach();

            Game.OnUpdate += Game_OnUpdate;
            Render.OnPresent += Drawings;
        }

        /*Drawings*/
        private static void Drawings()
        {

            if (Main["drawings"]["q"].As<MenuBool>().Enabled)
            {
                Render.Circle(Blitzcrank.Position, SpellManager.Get(SpellSlot.Q).Range, 180, Color.Green);
            }
            if (Main["drawings"]["e"].As<MenuBool>().Enabled)
            {
                Render.Circle(Blitzcrank.Position, SpellManager.Get(SpellSlot.E).Range, 180, Color.Green);
            }
            if (Main["drawings"]["r"].As<MenuBool>().Enabled)
            {
                Render.Circle(Blitzcrank.Position, SpellManager.Get(SpellSlot.R).Range, 180, Color.Green);
            }
        }

        private static void Game_OnUpdate()
        {
            if (Blitzcrank.IsDead || MenuGUI.IsChatOpen()) return;
            switch (Orbwalker.Mode)
            {
                case OrbwalkingMode.Combo:
                    Combo();
                    break;
            }
            //if (Main["harass"]["autoHarass"].As<MenuBool>().Enabled)
           // {
                //BlitzQ();
                //BlitzE();
           // }
        }

        /*Combo*/
        private static void Combo()
        {
            var target = TargetSelector.GetTarget(SpellManager.Get(SpellSlot.Q).Range);

            if (Main["combo"]["q"].As<MenuBool>().Enabled &&
                Main["whiteList"]["qWhiteList" + target.ChampionName.ToLower()].As<MenuBool>().Enabled &&
                target.IsInRange(SpellManager.Get(SpellSlot.Q).Range) && target.IsValidTarget() &&
                SpellManager.Get(SpellSlot.Q).Ready)
            {
                SpellManager.Get(SpellSlot.Q).CastMob();
            }

            if (Main["combo"]["e"].As<MenuBool>().Enabled && target.IsValidTarget() &&
                SpellManager.Get(SpellSlot.E).Ready)
            {
                SpellManager.Get(SpellSlot.E).CastMob();
            }

            if (Main["combo"]["r"].As<MenuBool>().Enabled && Blitzcrank.CountEnemyHeroesInRange(SpellManager.Get(SpellSlot.R).Range - 50) >=
                Main["combo"]["r"].As<MenuSliderBool>().Value)
            {
                SpellManager.Get(SpellSlot.R).CastMob();
            }

            //BlitzQ();
            //BlitzE();
            //BlitzR();
        }

        /*private static void BlitzQ()
        {
            var target = TargetSelector.GetTarget(_q.Range);

            if (target == null) return;
            var prediction = _q.GetPrediction(target);

            if (Main["combo"]["q"].As<MenuBool>().Enabled && Main["whiteList"]["qWhiteList" + target.ChampionName.ToLower()].As<MenuBool>().Enabled && target.IsInRange(_q.Range) && target.IsValidTarget() && !target.HasBuff("threshQ") && _q.Ready)
            {
                if (prediction.HitChance >= HitChance.High && target.Distance(Blitzcrank.ServerPosition) > 400)
                {
                    _q.Cast(prediction.UnitPosition);
                }
            }
        }


        private static void BlitzE()
        {
            var target = TargetSelector.GetTarget(_e.Range);
            if (target == null) return;

            if (Main["combo"]["e"].As<MenuBool>().Enabled && target.IsInRange(_e.Range) && _e.Ready)
            {           
                    _e.Cast(target);
            }
        }

        private static void BlitzR()
        {
            if (Main["combo"]["r"].As<MenuSliderBool>().Enabled && Blitzcrank.CountEnemyHeroesInRange(_r.Range - 50) >= Main["combo"]["r"].As<MenuSliderBool>().Value)
            {
                _r.Cast();
            }
        }
    */

    }
}