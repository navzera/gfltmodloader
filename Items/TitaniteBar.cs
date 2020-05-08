using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace gfl.Items
{
	public class TitaniteBar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Titanite Bar");
			Tooltip.SetDefault("Used to craft Epochal Guns");
		}
		
		public override void SetDefaults() {
			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 10;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar, 2);
			recipe.AddIngredient(ItemID.AdamantiteBar, 2);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanBurnInLava() {
			return true;
		}
	}
}
