using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aimtec;
using Aimtec.SDK;
using Aimtec.SDK.Events;

namespace nMorgana
{
	class Program
	{
		static void Main(string[] args)
		{
			GameEvents.GameStart += GameEvents_Start;
		}

		private static void GameEvents_Start()
		{
			if (ObjectManager.GetLocalPlayer().ChampionName != "Morgana")
				return;
			var Morgana = new Morgana();

		}
	}
}
