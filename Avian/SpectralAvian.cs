using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvesMod.Avian
{
    public class SpectralAvian : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Avian");
            Tooltip.SetDefault("A rare duck with a fine taste in 8-bit music");
        }


        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (TooltipLine line2 in list)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(114, 243, 80);
                }
            }
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 30;
            item.noMelee = true;
            item.knockBack = 0;
            item.noUseGraphic = true;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = 7;
            item.consumable = true;
            item.autoReuse = true;
            item.makeNPC = (short)mod.NPCType("SpectralAvianNPC");
        }
    }
}
