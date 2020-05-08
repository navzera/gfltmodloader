using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace gfl
{
	public class gfl : Mod
	{
		public gfl()
		{
		}
		
		public override void AddRecipes()
		{
			// Changes Iron Bar to Lead Bar at Gun Factory and vice versa.
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.LeadBar, 1);
			recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LeadBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.IronBar, 1);
			recipe.AddRecipe(); 
			
			// Changes Tin Bar to Copper Bar at Gun Factory and vice versa.
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TinBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.CopperBar, 1);
			recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CopperBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.TinBar, 1);
			recipe.AddRecipe(); 
			
			// Gold to plat
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.PlatinumBar, 1);
			recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.GoldBar, 1);
			recipe.AddRecipe(); 
			
			// Silver to Tungsten
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SilverBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.TungstenBar, 1);
			recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.SilverBar, 1);
			recipe.AddRecipe(); 
			
			// Demonite to Crimtane
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DemoniteBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.CrimtaneBar, 1);
			recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CrimtaneBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.DemoniteBar, 1);
			recipe.AddRecipe(); 
			
			// Cobalt to Palladium
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CobaltBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.PalladiumBar, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PalladiumBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.CobaltBar, 1);
			recipe.AddRecipe();
			
			// Mythril to Orichalcum
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.MythrilBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.OrichalcumBar, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.OrichalcumBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.MythrilBar, 1);
			recipe.AddRecipe();
			
			// Adamantite to Titanium
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.AdamantiteBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.TitaniumBar, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TitaniumBar, 1);
			recipe.AddTile(this.TileType("GunFactory"));
			recipe.SetResult(ItemID.AdamantiteBar, 1);
			recipe.AddRecipe();
			
			
		}
	}
}
