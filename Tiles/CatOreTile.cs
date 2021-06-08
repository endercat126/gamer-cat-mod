using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace GamerCatMod.Tiles
{
    public class CatOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = ItemType<Items.CatOre>();
            soundType = (int)SoundID.Tink;

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(114, 126, 148), name);

            minPick = 180;
            mineResist = 3;
        }
    }
}
