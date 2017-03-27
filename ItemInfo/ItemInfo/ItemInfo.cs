using System;
using System.Linq;

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

namespace ItemInfo
{
    [Plugin]
    public class Class1 : Plugin
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            Console.WriteLine("[ItemInfo] >> Enable!");
        }
        [Command(Name = "iv", Description = "Show Item Info")]
        public void Execute(Player player)
        {
            var handit = player.Inventory.GetItemInHand();
            var id = handit.Id;
            var name = handit.GetType().Name;
            var count = handit.Count;

            player.SendMessage($"§9ItemInfo > §fItem Id: §7{id}");
            player.SendMessage($"§9ItemInfo > §fItem Name: §7{name}");
            player.SendMessage($"§9ItemInfo > §fItem Count: §7{count}");
        }
        [Command(Name = "iv", Description = "Show Item Info")]
        public void Execute(Player player, string username)
        {
            Player target = null;
            foreach (var i in Context.LevelManager.Levels)
            {
                target = i.Players.ToList().Find(x => x.Value.Username.ToLower().Contains(username)).Value ?? null; break;
            }
            var handit = target.Inventory.GetItemInHand();
            var id = handit.Id;
            var name = handit.GetType().Name;
            var count = handit.Count;

            player.SendMessage($"§9ItemInfo > §fItem Id: §7{id}");
            player.SendMessage($"§9ItemInfo > §fItem Name: §7{name}");
            player.SendMessage($"§9ItemInfo > §fItem Count: §7{count}");
        }
    }
}
