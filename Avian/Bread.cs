using Terraria.ID;
using Terraria.ModLoader;

namespace AvesMod.Avian
{
    public class Bread : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bread");
			Tooltip.SetDefault(@"Increases all stats slightly
Ducks like it");
		}

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.rare = 2;
            item.maxStack = 30;

            item.useStyle = 2;
            item.useTime = item.useAnimation = 20;

            item.consumable = true;
            item.autoReuse = false;

            item.buffType = BuffID.WellFed;
            item.buffTime = 14400;
            item.UseSound = SoundID.Item2;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Hay, 5);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
