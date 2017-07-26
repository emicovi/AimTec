using System;
using Aimtec;
using Aimtec.SDK.Events;

namespace emicoviBlitzcrank
{
    internal class Program
    {
        private static void Main()
        {
            GameEvents.GameStart += OnLoadingComplete;
        }
        private static void OnLoadingComplete()
        {
            if (ObjectManager.GetLocalPlayer().ChampionName != "Blitzcrank") return;
            var unused = new emicoviBlitzcrank();
            Console.WriteLine("emicovi Blitzcrank loaded");
        }
    }
}