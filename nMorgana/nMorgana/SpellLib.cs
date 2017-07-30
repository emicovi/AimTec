using System;
using System.Collections.Generic;

namespace nMorgana
{
	using Aimtec;
	using Aimtec.SDK;

	public enum Skilltype
	{
		Unknown = 0,
		Line = 1,
		Circle = 2,
		Cone = 3
	}

	public class SpellLib
	{
		public string HeroName { get; set; }
		public string SpellMenuName { get; set; }
		public SpellSlot Slot { get; set; }
		public Skilltype Type { get; set; }
		public float Radius { get; set; }
		public string SDataName { get; set; }
		public int DangerLevel { get; set; }

		public static List<SpellLib> GDList = new List<SpellLib>(); // Generic Dangerous List
		public static List<SpellLib> CCList = new List<SpellLib>(); // Crowd Control List
		public static List<SpellLib> SList = new List<SpellLib>();  // Silence List

		static SpellLib()
		{
			#region CCList
			CCList.Add(
				new SpellLib
				{
					HeroName = "Aatrox",
					SpellMenuName = "AatroxQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					SDataName = "AatroxQ",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Aatrox",
					SpellMenuName = "AatroxE",
					Slot = SpellSlot.E,
					Type = Skilltype.Cone,
					SDataName = "AatroxE",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Ahri",
					SpellMenuName = "AhriE",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					SDataName = "AhriSeduce",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Alistar",
					SpellMenuName = "AlistarQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					SDataName = "Pulverize",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Alistar",
					SpellMenuName = "AlistarW",
					Slot = SpellSlot.W,
					SDataName = "Headbutt",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Amumu",
					SpellMenuName = "AmumuQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					SDataName = "BandageToss",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Amumu",
					SpellMenuName = "AmumuR",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					SDataName = "CurseoftheSadMummy",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Anivia",
					SpellMenuName = "AniviaQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					SDataName = "FlashFrost",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Anivia",
					SpellMenuName = "AniviaR",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					SDataName = "GlacialStorm",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Annie",
					SpellMenuName = "AnnieR",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					SDataName = "InfernalGuardian",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Ashe",
					SpellMenuName = "AsheR",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					SDataName = "EnchantedCrystalArrow",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Ashe",
					SpellMenuName = "AsheW",
					Slot = SpellSlot.W,
					Type = Skilltype.Cone,
					SDataName = "Volley",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Azir",
					SpellMenuName = "AzirE",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					SDataName = "AzirE",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Azir",
					SpellMenuName = "AzirR",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					SDataName = "AzirR",
					DangerLevel = 5
				});
			CCList.Add(
			new SpellLib
			{
				HeroName = "Bard",
				SpellMenuName = "BardQ",
				Slot = SpellSlot.Q,
				Type = Skilltype.Line,
				SDataName = "BardQ",
				DangerLevel = 5
			});
			CCList.Add(
			new SpellLib
			{
				HeroName = "Bard",
				SpellMenuName = "BardR",
				Slot = SpellSlot.Q,
				Type = Skilltype.Line,
				SDataName = "BardR",
				DangerLevel = 5
			});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Blitzcrank",
					SpellMenuName = "BlitzQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					SDataName = "RocketGrab",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Blitzcrank",
					SpellMenuName = "BlitzE",
					Slot = SpellSlot.E,
					SDataName = "PowerFist",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Brand",
					SpellMenuName = "BrandQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					SDataName = "BrandQ",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Braum",
					SpellMenuName = "BraumQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					SDataName = "BraumQ",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Braum",
					SpellMenuName = "BraumR",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					SDataName = "BraumRWrapper",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Caitlyn",
					SpellMenuName = "90 Caliber Net",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					SDataName = "CaitlynEntrapment",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Cassiopeia",
					SpellMenuName = "Petrifying Gaze",
					Slot = SpellSlot.R,
					Type = Skilltype.Cone,
					SDataName = "CassiopeiaPetrifyingGaze",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Cho'gath",
					SpellMenuName = "Rupture",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					SDataName = "Rupture",
					DangerLevel = 5
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Darius",
					SpellMenuName = "Aprehend",
					Slot = SpellSlot.E,
					Type = Skilltype.Cone,
					SDataName = "DariusAxeGrabCone",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Diana",
					SpellMenuName = "Moonfall",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					SDataName = "DianaVortex",
					DangerLevel = 3
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "DrMundo",
					SpellMenuName = "Cleaver",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					SDataName = "InfectedCleaverMissileCast",
					DangerLevel = 3
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Draven",
					SpellMenuName = "Stand Aside",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					SDataName = "DravenDoubleShot",
					DangerLevel = 3
				});

			CCList.Add(
			   new SpellLib
			   {
				   HeroName = "Elise",
				   SpellMenuName = "Cocoon",
				   Slot = SpellSlot.E,
				   Type = Skilltype.Line,
				   SDataName = "DravenDoubleShot",
				   DangerLevel = 3
			   });

			CCList.Add(
				new SpellLib
				{
					HeroName = "Evelynn",
					SpellMenuName = "Agony's Embrace",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "EvelynnR",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Fizz",
					SpellMenuName = "Chum the Waters",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "FizzMarinerDoomMissile",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Fizz",
					 SpellMenuName = "Playful Trickster",
					 Slot = SpellSlot.E,
					 Type = Skilltype.Line,
					 DangerLevel = 3,
					 SDataName = "FizzJump",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Galio",
					SpellMenuName = "Winds of War",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "GalioResoluteSmite",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Galio",
					SpellMenuName = "Hero's Entrance",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "GalioIdolOfDurand",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Gnar",
					SpellMenuName = "Boomerang Throw",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "GnarQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Gnar",
					SpellMenuName = "Bouldar Toss",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "GnarBigQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Gnar",
					SpellMenuName = "Wallop",
					Slot = SpellSlot.W,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "GnarBigW",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Gnar",
					SpellMenuName = "GNAR!",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "GnarR",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Gragas",
					SpellMenuName = "Barrel Roll",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "GragasQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Gragas",
					SpellMenuName = "Body Slam",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "GragasE",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Gragas",
					SpellMenuName = "Explosive Cask",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "GragasR",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Heimerdinger",
					SpellMenuName = "Electron Storm Grenade",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "HeimerdingerE",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Hecarim",
					 SpellMenuName = "Onslaught of Shadows",
					 Slot = SpellSlot.R,
					 Type = Skilltype.Circle,
					 DangerLevel = 5,
					 SDataName = "HecarimUlt",
				 });
			CCList.Add(
				  new SpellLib
				  {
					  HeroName = "Hecarim",
					  SpellMenuName = "Devestating Charge",
					  Slot = SpellSlot.E,
					  Type = Skilltype.Circle,
					  DangerLevel = 3,
					  SDataName = "HecarimRamp",
				  });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Janna",
					SpellMenuName = "Howling Gale",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "HowlingGale",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Janna",
					 SpellMenuName = "Zephyr",
					 Slot = SpellSlot.W,
					 DangerLevel = 3,
					 SDataName = "ReapTheWhirlwind",
				 });
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Jax",
					 SpellMenuName = "Counter Strike",
					 Slot = SpellSlot.E,
					 Type = Skilltype.Line,
					 DangerLevel = 5,
					 SDataName = "JaxCounterStrike",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "JarvanIV",
					SpellMenuName = "Dragon Strike",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "JarvanIVDragonStrike",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Jayce",
					SpellMenuName = "Thundering Blow",
					Slot = SpellSlot.E,
					DangerLevel = 3,
					SDataName = "JayceThunderingBlow",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Jinx",
					SpellMenuName = "Zap!",
					Slot = SpellSlot.W,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "JinxW",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Jinx",
					SpellMenuName = "Chompers!",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 4,
					SDataName = "JinxE",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Karma",
					SpellMenuName = "Inner Flame (Mantra)",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "KarmaQMantra",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Karma",
					 SpellMenuName = "Sprit Bond",
					 Slot = SpellSlot.W,
					 DangerLevel = 3,
					 SDataName = "KarmaQMantra",
				 });

			CCList.Add(
				new SpellLib
				{
					HeroName = "Kassadin",
					SpellMenuName = "Force Pulse",
					Slot = SpellSlot.E,
					Type = Skilltype.Cone,
					DangerLevel = 3,
					SDataName = "ForcePulse",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Khazix",
					SpellMenuName = "Void Spikes",
					Slot = SpellSlot.W,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "KhazixW",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Kayle",
					SpellMenuName = "Reckoning",
					Slot = SpellSlot.Q,
					DangerLevel = 3,
					SDataName = "JudicatorReckoning",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "KogMaw",
					SpellMenuName = "Void Ooze",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "KogMawVoidOoze",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Leblanc",
					SpellMenuName = "Soul Shackle",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "LeblancSoulShackle",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Leblanc",
					SpellMenuName = "Soul Shackle (Mimic)",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "LeblancSoulShackleM",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "LeeSin",
					SpellMenuName = "Dragon's Rage",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "BlindMonkRKick",
				});
			CCList.Add(
new SpellLib
{
	HeroName = "Leona",
	SpellMenuName = "Zenith Blade",
	Slot = SpellSlot.E,
	Type = Skilltype.Line,
	DangerLevel = 3,
	SDataName = "LeonaZenithBlade",
});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Leona",
					 SpellMenuName = "Shield of Daybreak",
					 Slot = SpellSlot.Q,
					 DangerLevel = 3,
					 SDataName = "LeonaShieldOfDaybreak",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Leona",
					SpellMenuName = "Solar Flare",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "LeonaSolarFlare",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Lissandra",
					SpellMenuName = "Ice Shard",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "LissandraQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Lissandra",
					SpellMenuName = "Ring of Frost",
					Slot = SpellSlot.W,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "LissandraW",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Lulu",
					SpellMenuName = "Glitterlance",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "LuluQ"
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Lulu",
					SpellMenuName = "Glitterlance: Extended",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "LuluQMissileTwo"
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Lux",
					SpellMenuName = "Light Binding",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "LuxLightBinding",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Lux",
					SpellMenuName = "Lucent Singularity",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "LuxLightStrikeKugel",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Lux",
					SpellMenuName = "Final Spark",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "LuxMaliceCannon",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Malphite",
					SpellMenuName = "Unstoppable Force",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "UFSlash",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Malphite",
					 SpellMenuName = "Sismic Shard",
					 Slot = SpellSlot.Q,
					 Type = Skilltype.Circle,
					 DangerLevel = 3,
					 SDataName = "SismicShard",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Malzahar",
					SpellMenuName = "Nether Grasp",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "AlZaharNetherGrasp",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Maokai",
					 SpellMenuName = "Twisted Advance",
					 Slot = SpellSlot.W,
					 DangerLevel = 3,
					 SDataName = "MaokaiUnstableGrowth",
				 });
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Maokai",
					 SpellMenuName = "Arcane Smash",
					 Slot = SpellSlot.Q,
					 DangerLevel = 3,
					 SDataName = "MaokaiTrunkLine",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Morgana",
					SpellMenuName = "Dark Binding",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "DarkBindingMissile",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Mordekaiser",
					 SpellMenuName = "Children of the Grave",
					 Slot = SpellSlot.Q,
					 DangerLevel = 5,
					 SDataName = "MordekaiserChildrenOfTheGrave",
				 });
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Wukong",
					 SpellMenuName = "Cyclone",
					 Slot = SpellSlot.R,
					 Type = Skilltype.Circle,
					 DangerLevel = 5,
					 SDataName = "MonkeyKingSpinToWin",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nami",
					SpellMenuName = "Aqua Prision",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "NamiQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nasus",
					SpellMenuName = "Wither",
					Slot = SpellSlot.Q,
					DangerLevel = 3,
					SDataName = "NasusW",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Karthus",
					SpellMenuName = "Wall of Pain",
					Slot = SpellSlot.Q,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "KarthusWallOfPain",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nami",
					SpellMenuName = "Tidal Wave",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "NamiR",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nautilus",
					SpellMenuName = "Dredge Line",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "NautilusAnchorDragMissile",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nautilus",
					SpellMenuName = "Riptide",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "NautilusSplashZone",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nautilus",
					SpellMenuName = "Depth Charge",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "NautilusGrandLine",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Nidalee",
					SpellMenuName = "Javelin Toss",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "JavelinToss",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Olaf",
					SpellMenuName = "Undertow",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "OlafAxeThrowCast",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Orianna",
					SpellMenuName = "Command: Dissonance ",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "OrianaDissonanceCommand",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Orianna",
					SpellMenuName = "OrianaDetonateCommand",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "OrianaDetonateCommand",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Quinn",
					SpellMenuName = "Blinding Assault",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "QuinnQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Rammus",
					SpellMenuName = "Puncturing Taunt",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "PuncturingTaunt",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Rengar",
					SpellMenuName = "Bola Strike (Emp)",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "RengarEFinal",
				});

			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Fiddlesticks",
					 SpellMenuName = "Terrify",
					 Slot = SpellSlot.Q,
					 DangerLevel = 3,
					 SDataName = "Terrify",
				 });
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Renekton",
					 SpellMenuName = "Ruthless Predator",
					 Slot = SpellSlot.W,
					 DangerLevel = 3,
					 SDataName = "RenektonPreExecute",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Riven",
					SpellMenuName = "Ki Burst",
					Slot = SpellSlot.W,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "RivenMartyr"
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Rumble",
					SpellMenuName = "RumbleGrenade",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "RumbleGrenade",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Rumble",
					SpellMenuName = "RumbleCarpetBombM",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 4,
					SDataName = "RumbleCarpetBombMissile",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Ryze",
					SpellMenuName = "Rune Prision",
					Slot = SpellSlot.W,
					DangerLevel = 3,
					SDataName = "RunePrison",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Sejuani",
					SpellMenuName = "Arctic Assault",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "SejuaniArcticAssault",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Sejuani",
					SpellMenuName = "Glacial Prision",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "SejuaniGlacialPrisonStart",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Singed",
					SpellMenuName = "Mega Adhesive",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "MegaAdhesive",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Singed",
					SpellMenuName = "Fling",
					Slot = SpellSlot.E,
					DangerLevel = 2,
					SDataName = "Fling",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Nocturne",
					SpellMenuName = "Unspeakable Horror",
					Slot = SpellSlot.E,
					DangerLevel = 3,
					SDataName = "NocturneUnspeakableHorror",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Shen",
					SpellMenuName = "ShenShadowDash",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "ShenShadowDash",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Shyvana",
					SpellMenuName = "ShyvanaTransformCast",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "ShyvanaTransformCast",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Skarner",
					SpellMenuName = "Fracture",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "SkarnerFractureMissile",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Skarner",
					SpellMenuName = "Impale",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "SkarnerFractureMissile",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Pantheon",
					SpellMenuName = "Aegis of Zeonia",
					Slot = SpellSlot.W,
					DangerLevel = 3,
					SDataName = "PantheonW",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Pantheon",
					 SpellMenuName = "Heroic Charge",
					 Slot = SpellSlot.W,
					 DangerLevel = 3,
					 SDataName = "PoppyHeroicCharge",
				 });
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Nunu",
					 SpellMenuName = "Ice Blast",
					 Slot = SpellSlot.E,
					 DangerLevel = 3,
					 SDataName = "Ice Blast",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Sona",
					SpellMenuName = "Crescendo",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "SonaCrescendo",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Swain",
					SpellMenuName = "Nevermove",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "SwainShadowGrasp",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Syndra",
					SpellMenuName = "Scatter the Weak",
					Slot = SpellSlot.E,
					Type = Skilltype.Cone,
					DangerLevel = 5,
					SDataName = "SyndraE",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Thresh",
					SpellMenuName = "Death Sentence",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "ThreshQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Thresh",
					SpellMenuName = "Flay",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "ThreshEFlay",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Tristana",
					SpellMenuName = "Buster Shot",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "BusterShot",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Trundle",
					SpellMenuName = "Pillar of Ice",
					Slot = SpellSlot.E,
					DangerLevel = 3,
					SDataName = "TrundleCircle",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Trundle",
					SpellMenuName = "Subjugate",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "TrundlePain",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Tryndamere",
					SpellMenuName = "Mocking Shout",
					Slot = SpellSlot.W,
					DangerLevel = 3,
					SDataName = "MockingShout",
				});

			CCList.Add(
				new SpellLib
				{
					HeroName = "Twitch",
					SpellMenuName = "Venom Cask",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "TwitchVenomCaskMissile",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Urgot",
					SpellMenuName = "Corrosive Charge",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "UrgotPlasmaGrenadeBoom",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Varus",
					SpellMenuName = "Hail of Arrowws",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "VarusE",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Varus",
					SpellMenuName = "Chain of Corruption",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "VarusR",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Veigar",
					SpellMenuName = "Event Horizon",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "VeigarEventHorizon",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Velkoz",
					SpellMenuName = "VelkozQ",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "VelkozQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Velkoz",
					SpellMenuName = "Plasma Fission",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "VelkozQSplit",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Velkoz",
					SpellMenuName = "Tectonic Disruption",
					Slot = SpellSlot.E,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "VelkozE",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Vi",
					SpellMenuName = "Vault Breaker",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "ViQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Vi",
					SpellMenuName = "Assault and Battery",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "ViR",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Viktor",
					SpellMenuName = "Gravity Field",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 5,
					SDataName = "ViktorGravitonField",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Vayne",
					SpellMenuName = "Condemn",
					Slot = SpellSlot.E,
					DangerLevel = 3,
					SDataName = "Vayne Condemn",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Warwick",
					SpellMenuName = "Infinite Duress",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "InfiniteDuress",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Xerath",
					SpellMenuName = "Eye of Destruction",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "XerathArcaneBarrage2",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Xerath",
					SpellMenuName = "Shocking Orb",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "XerathMageSpearMissile",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "XinZhao",
					SpellMenuName = "Three Talon Strike",
					Slot = SpellSlot.Q,
					DangerLevel = 3,
					SDataName = "XinZhaoComboTarget",
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "XinZhao",
					 SpellMenuName = "Audacious Charge",
					 Slot = SpellSlot.E,
					 DangerLevel = 4,
					 SDataName = "XinZhaoSweep",
				 });
			CCList.Add(
				  new SpellLib
				  {
					  HeroName = "XinZhao",
					  SpellMenuName = "Crescent Sweep",
					  Slot = SpellSlot.R,
					  Type = Skilltype.Circle,
					  DangerLevel = 5,
					  SDataName = "XinZhaoParry",
				  });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Yasuo",
					SpellMenuName = "yasuoq2",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "yasuoq2",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Yasuo",
					SpellMenuName = "yasuoq3w",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "yasuoq3w",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Yasuo",
					SpellMenuName = "yasuoq",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "yasuoq",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Zac",
					SpellMenuName = "Stretching Strike",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 2,
					SDataName = "ZacQ",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Zac",
					SpellMenuName = "Lets Bounce!",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "ZacR",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Zed",
					SpellMenuName = "Death Mark",
					Slot = SpellSlot.R,
					DangerLevel = 5,
					SDataName = "ZedUlt",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Ziggs",
					SpellMenuName = "Satchel Charge",
					Slot = SpellSlot.W,
					Type = Skilltype.Circle,
					DangerLevel = 2,
					SDataName = "ZiggsW",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Zyra",
					SpellMenuName = "Grasping Roots",
					Slot = SpellSlot.E,
					Type = Skilltype.Line,
					DangerLevel = 5,
					SDataName = "ZyraGraspingRoots",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Zyra",
					SpellMenuName = "Stranglethorns",
					Slot = SpellSlot.R,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "ZyraBrambleZone",
				});
			CCList.Add(
				new SpellLib
				{
					HeroName = "Taric",
					SpellMenuName = "Dazzle",
					Slot = SpellSlot.E,
					SDataName = "Dazzle",
					DangerLevel = 5
				});
			CCList.Add(
				 new SpellLib
				 {
					 HeroName = "Yoric",
					 SpellMenuName = "Omen of Pestilence",
					 Slot = SpellSlot.W,
					 DangerLevel = 3,
					 SDataName = "YorickDecayed",
				 });
			CCList.Add(
				new SpellLib
				{
					HeroName = "Yasuo",
					SpellMenuName = "Steel Tempest (3)",
					Slot = SpellSlot.W,
					DangerLevel = 3,
					SDataName = "YasuoQ3",
				});
			#endregion

			#region SList
			SList.Add(
				new SpellLib
				{
					HeroName = "Fiddlesticks",
					SpellMenuName = "Dark Wind",
					Slot = SpellSlot.E,
					DangerLevel = 3,
					SDataName = "FiddlesticksDarkWind",
				});
			SList.Add(
				new SpellLib
				{
					HeroName = "Blitzcrank",
					SpellMenuName = "Static Field",
					Slot = SpellSlot.R,
					Type = Skilltype.Circle,
					DangerLevel = 3,
					SDataName = "StaticField",

				});
			SList.Add(
				new SpellLib
				{
					HeroName = "Chogath",
					SpellMenuName = "Feral Scream",
					Slot = SpellSlot.W,
					Type = Skilltype.Cone,
					DangerLevel = 3,
					SDataName = "FeralScream",

				});
			SList.Add(
				new SpellLib
				{
					HeroName = "Malzahar",
					SpellMenuName = "Call of the Void",
					Slot = SpellSlot.Q,
					Type = Skilltype.Line,
					DangerLevel = 3,
					SDataName = "MalZaharCalloftheVoid",
				});
			SList.Add(
				new SpellLib
				{
					HeroName = "Talon",
					SpellMenuName = "Cutthroat",
					Slot = SpellSlot.E,
					DangerLevel = 3,
					SDataName = "TalonCutthroat",
				});
			SList.Add(
				 new SpellLib
				 {
					 HeroName = "Garen",
					 SpellMenuName = "Decisive Strike",
					 Slot = SpellSlot.Q,
					 DangerLevel = 3,
					 SDataName = "GarenQ",
				 });
			SList.Add(
				  new SpellLib
				  {
					  HeroName = "Viktor",
					  SpellMenuName = "Chaos Storm",
					  Slot = SpellSlot.R,
					  DangerLevel = 3,
					  SDataName = "ViktorChaosStorm",
				  });
			SList.Add(
				   new SpellLib
				   {
					   HeroName = "Soraka",
					   SpellMenuName = "Equinox",
					   Slot = SpellSlot.E,
					   Type = Skilltype.Circle,
					   DangerLevel = 2,
					   SDataName = "SorakaE",
				   });
			#endregion

			#region GDList

			#endregion
		}
	}
}

