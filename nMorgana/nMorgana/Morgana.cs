using System.Collections.Generic;
using System.Linq;
using System.Drawing;


namespace nMorgana
{
	using Aimtec;

	using Aimtec.SDK;
	using Aimtec.SDK.Damage;
	using Aimtec.SDK.Events;
	using Aimtec.SDK.Prediction;
	using Aimtec.SDK.Prediction.Health;
	using Aimtec.SDK.Prediction.Skillshots;

	using Aimtec.SDK.Menu;
	using Aimtec.SDK.Menu.Components;
	using Aimtec.SDK.Orbwalking;
	using Aimtec.SDK.TargetSelector;
	using Aimtec.SDK.Util;
	using Aimtec.SDK.Util.Cache;
	using Aimtec.SDK.Extensions;

	using Spell = Aimtec.SDK.Spell;

	internal class Morgana
	{
		public static Menu Menu = new Menu("nMorgana", "nMorgana", true);
		public static Orbwalker Orbwalker = new Orbwalker();
		public static Obj_AI_Hero MyPlayer => ObjectManager.GetLocalPlayer();
		public static HealthPrediction HealthPrediction = new HealthPrediction();

		public static Spell Q;
		public static Spell W;
		public static Spell E;
		public static Spell R;



		public Morgana()
		{
			Q = new Spell(SpellSlot.Q, 1175);
			W = new Spell(SpellSlot.W, 900);
			E = new Spell(SpellSlot.E, 800);
			R = new Spell(SpellSlot.R, 625);

			Q.SetSkillshot(0.5f, 70, 1200, true, SkillshotType.Line, false, HitChance.VeryHigh);


			Orbwalker.Attach(Menu);

			var ComboMenu = new Menu("combo", "Combo");
			{
				ComboMenu.Add(new MenuBool("useq", "Use Q"));
				ComboMenu.Add(new MenuBool("usew", "Use W"));
				ComboMenu.Add(new MenuBool("user", "Use R"));
				ComboMenu.Add(new MenuSlider("minr", "Min.Enemy For R", 3,1, 5));
			}
			Menu.Add(ComboMenu);

			var HarassMenu = new Menu("harass", "Harass");
			{
				HarassMenu.Add(new MenuBool("harasq","Harass Q"));
				HarassMenu.Add(new MenuBool("harasw", "Harass W"));
				HarassMenu.Add(new MenuSlider("harasmin", "Min Mana For Harass",250,150,(int)MyPlayer.MaxMana));
			}
			Menu.Add(HarassMenu);

			var EMainMenu = new Menu("emain", "E Main Menu");
			{
				EMainMenu.Add(new MenuBool("usee", "Use E"));
				EMainMenu.Add(new MenuSlider("mine", "Min Mana For E", 200, 55, (int)MyPlayer.MaxMana));
			}
			Menu.Add(EMainMenu);

			/*var EUseOn = new Menu("euseon", "E Use On");
			{
				foreach (var a in ObjectManager.Get<Obj_AI_Hero>().Where(hero => hero.IsAlly).Select(hero => hero.ChampionName))
				{
					EUseOn.Add(new MenuBool("shield" + a, a, true));
				}
			}
			Menu.Add(EUseOn);

			var ESpells = new Menu("espells", "E Spells List");
			{
				foreach(var e in ObjectManager.Get<Obj_AI_Hero>().Where(hero => hero.IsEnemy))
				{
					foreach(var s in SpellLib.CCList)
					{
						if(s.HeroName == e.ChampionName)
						{
							ESpells.Add(new MenuBool(s.SDataName, s.SpellMenuName,true));
						}
					}
				}
			}
			Menu.Add(ESpells);
            */

			var KSMenu = new Menu("ks", "KillSteal");
			{
				KSMenu.Add(new MenuBool("ksq", "KS With Q",false));
				KSMenu.Add(new MenuSlider("minmana", "Min. Mana For Ks",150,100,(int)MyPlayer.MaxMana));
			}
			Menu.Add(KSMenu);

			
			
			Menu.Attach();

			Game.OnUpdate += Game_OnUpdate;
			Render.OnPresent += Render_OnPresent;
			//Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast;
		}


	  
       

        /*private void Obj_AI_Base_OnProcessSpellCast(Obj_AI_Base sender, Obj_AI_BaseMissileClientDataEventArgs args)
		{
			if (Menu["emenu"]["usee"].Enabled && MyPlayer.Mana >= Menu["emain"]["mine"].Value)
			{
				if (sender.Type == GameObjectType.obj_AI_Hero && sender.IsEnemy)
				{
					var target = ObjectManager.Get<Obj_AI_Hero>().Where(her => her.IsAlly).OrderBy(h => h.Distance(args.End));

					foreach (var a in target)
					{
						foreach (var spell in SpellLib.CCList)
						{
							if (spell.SDataName == sender.SpellBook.GetSpell(args.SpellSlot).SpellData.Name)
							{
								switch (spell.Type)
								{
									case Skilltype.Circle:
										if (a.Distance(args.End) <= 250f && E.Ready)
										{
											if (Menu["espells"][spell.SDataName].Enabled && Menu["euseon"]["shield" + a.ChampionName].Enabled)
												E.CastOnUnit(a);

										}
										break;

									case Skilltype.Line:
										if (a.Distance(args.End) <= 100f && E.Ready)
										{
											if (Menu["espells"][spell.SDataName].Enabled && Menu["euseon"]["shield" + a.ChampionName].Enabled)
												E.CastOnUnit(a);
										}
										break;
									case Skilltype.Unknown:
										if (E.Ready && (a.Distance(args.End) <= 600f || a.Distance(sender.Position) <= 600f))
											if (a.ChampionName != MyPlayer.ChampionName && a.Distance(MyPlayer.Position) < E.Range)
											{
												if (Menu["espells"][spell.SDataName].Enabled && Menu["euseon"]["shield" + a.ChampionName].Enabled)
													E.CastOnUnit(a);
											}
											else
											{
												if (Menu["espells"][spell.SDataName].Enabled && Menu["euseon"]["shield" + a.ChampionName].Enabled)
													E.CastOnUnit(a);
											}
										break;
								}
							}
						}
					}
				}
			}
		}
        */

        private void Game_OnUpdate()
		{
			;
			if (MyPlayer.IsDead)
				return;

			if (Orbwalker.Mode == OrbwalkingMode.Combo)
				Combo();

			if (Orbwalker.Mode == OrbwalkingMode.Mixed)
				Harass();

			KS();
		}

		private void OnProcessSpellCast(Obj_AI_Base sender, SpellBookCastSpellEventArgs args)
		{
			
		}

		private void Combo()
		{
			if (Menu["combo"]["user"].Enabled && R.Ready)
			{
				var besttarget = TargetSelector.GetTarget(R.Range);

				if (besttarget.IsValidTarget(R.Range) && besttarget.CountEnemyHeroesInRange(R.Range) >= Menu["combo"]["minr"].As<MenuSlider>().Value)
				{
					R.Cast();
				}
			}


			if (Menu["combo"]["useq"].Enabled && Q.Ready)
			{
				var besttarget = TargetSelector.GetTarget(Q.Range);
			    var prediction = Q.GetPrediction(besttarget);

                if (besttarget.IsValidTarget(Q.Range) && (prediction.HitChance >= HitChance.VeryHigh))
				{
						Q.Cast(besttarget);
					
				}	

			}


			if (Menu["combo"]["usew"].Enabled && W.Ready)
			{
				        var target = TargetSelector.GetTarget(W.Range);
						var predic = W.GetPrediction(target);
						if (predic.HitChance >= HitChance.VeryHigh)
							W.Cast(target);
			}

		}
		private void Harass()
		{
			if(Menu["harass"]["harasq"].Enabled && MyPlayer.Mana >= Menu["harass"]["harasmin"].Value && Q.Ready)
			{
			    var besttarget = TargetSelector.GetTarget(Q.Range);
			    var prediction = Q.GetPrediction(besttarget);
			    if (besttarget.IsValidTarget(Q.Range) && (prediction.HitChance >= HitChance.VeryHigh))
			    {
			        Q.Cast(besttarget);

			    }
            }
			if (Menu["harass"]["harasw"].Enabled && MyPlayer.Mana >= Menu["harass"]["harasmin"].Value && W.Ready)
			{
			    var target = TargetSelector.GetTarget(W.Range);
			    var predic = W.GetPrediction(target);
			    if (predic.HitChance >= HitChance.VeryHigh)
			        W.Cast(target);
            }
		}

		private void KS()
		{
			if(Menu["ks"]["ksq"].Enabled && Q.Ready && MyPlayer.Mana >= Menu["ks"]["minmana"].As<MenuSlider>().Value)
			{
				
				foreach(Obj_AI_Hero enemy in GameObjects.EnemyHeroes)
				{
				    var ksc = 	GameObjects.EnemyHeroes.FirstOrDefault(x => MyPlayer.GetSpellDamage(enemy, SpellSlot.Q) > enemy.Health + enemy.MagicalShield + 10 && enemy.IsValidTarget(Q.Range));
					if (ksc == null)
					{
						return;
					}
				    var besttarget = TargetSelector.GetTarget(Q.Range);
				    var prediction = Q.GetPrediction(besttarget);
				    if (besttarget.IsValidTarget(Q.Range) && (prediction.HitChance >= HitChance.VeryHigh))
				    {
				        Q.Cast(besttarget);

				    }
				    return;
				}
				
			}
			
		}

		private void Render_OnPresent()
		{
			
				Render.Circle(MyPlayer.Position, Q.Range, 30, Color.Purple);
			
				Render.Circle(MyPlayer.Position, W.Range, 30, Color.Purple);
			
				Render.Circle(MyPlayer.Position, R.Range, 30, Color.Red);
			
		}
		}
		   }







		






	

