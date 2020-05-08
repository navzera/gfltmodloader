using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace gfl.Tiles
{
	public class GunFactory : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = false;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Gun Factory");
			AddMapEntry(new Color(102, 102, 99), name);
			//dustType = DustType<Sparkle>();
			disableSmartCursor = true;
			adjTiles = new int[] { mod.TileType("GunFactory") };
		}
		
		/*public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}*/

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 32, 16, ItemType<Items.Placeable.GunFactory>());
		}
	}
}
