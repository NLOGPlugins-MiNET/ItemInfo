using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Plugins.Commands;
using MiNET.Items;
using MiNET.Blocks;
using MiNET.Utils;

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
        public void iv(Player player)
        {
            var id = player.Inventory.GetItemInHand().Id;
            /* var minetname = player.Inventory.GetItemInHand().ToString();
            string Sep = ".";
            char[] Seps = Sep.ToArray();
            string[] strs = minetname.Split(Seps, StringSplitOptions.RemoveEmptyEntries);
            string name = strs[2];  */

            player.SendMessage($"§9ItemInfo > §fItem Id: §7{id}");
            //player.SendMessage($"§9ItemInfo > §fItem Name: §7{player.Inventory.GetItemInHand().ToString()}");
        }
    }
}
