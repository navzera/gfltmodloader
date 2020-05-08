using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace gfl.Items.Placeable
{
	public class GunFactory : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Gun Factory");
			Tooltip.SetDefault("Used to craft GFL guns and swap bars.");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.rare = -12;
			item.createTile = TileType<Tiles.GunFactory>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Campfire, 1);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
