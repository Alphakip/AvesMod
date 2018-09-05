using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvesMod.Avian
{
    public class AvesTerrarium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Avian Terrarium");
            Tooltip.SetDefault(@"Feed it bread and give it a calamity music
box, then watch the magic");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 32;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.rare = 7;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 5000;
            item.createTile = mod.TileType("AvesTerrariumTile");
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

        public override void AddRecipes()
        {
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "SpectralAvian", 1);
                recipe.AddIngredient(ItemID.Terrarium, 1);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
