using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace gfl.Items
{
	public class LunarAlloy : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lunar Alloy");
			Tooltip.SetDefault("Used to craft Legendary Guns");
		}
		
		public override void SetDefaults() {
			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 11;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddIngredient(mod.ItemType("TitaniteBar"), 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanBurnInLava() {
			return true;
		}
	}
}
