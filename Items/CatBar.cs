using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace GamerCatMod.Items
{
	public class CatBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Catstone Bar");
		}

		public override void SetDefaults()
		{
			item.width = 15;
			item.height = 12;
			item.rare = ItemRarityID.Lime;
			item.value = Item.sellPrice(gold: 1, silver: 20);

			item.autoReuse = true;
			item.useTurn = true;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;

			item.consumable = true;
			item.maxStack = 999;

			item.createTile = TileType<Tiles.CatBars>();
			item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("CatOre"), 4);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
