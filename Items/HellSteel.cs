using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace gfl.Items
{
	public class HellSteel : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hell Steel");
			Tooltip.SetDefault("Used to craft Rare Guns");
		}
		
		public override void SetDefaults() {
			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 9;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddIngredient(ItemID.LeadBar, 1);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}

		public override bool CanBurnInLava() {
			return false;
		}
	}
}
