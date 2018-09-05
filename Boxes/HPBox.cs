using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace AvesMod.Boxes
{
    public class HPBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Higher Abyss Chiptune Box");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("HPBox");
            item.width = 32;
            item.height = 22;
            item.rare = 4;
            item.value = 10000;
            item.accessory = true;
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
            if (AvesMod.Instance.CalamityLoaded)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "Bread", 1);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("HigherAbyssMusicbox"));
                recipe.AddTile(null, "AvesTerrariumTile");
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}