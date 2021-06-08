using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace GamerCatMod.Items
{
	public class CatOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Catstone Ore");
		}

		public override void SetDefaults()
		{
			item.width = 8;
			item.height = 8;
			item.rare = ItemRarityID.Lime;
			item.value = Item.sellPrice(silver: 80);

			item.autoReuse = true;
			item.useTurn = true;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;

			item.consumable = true;
			item.maxStack = 999;

			item.createTile = TileType < Tiles.CatOreTile>();
			item.placeStyle = 0;
		}
	}
}
