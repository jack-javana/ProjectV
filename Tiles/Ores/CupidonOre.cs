using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ProjectV.Tiles.Ores
{
    public class CupidonOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 450;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Руда Купидона");
            AddMapEntry(new Color(255, 158, 197), name);

            dustType = 84;
            drop = mod.ItemType("CupidonOre");
            soundType = 21;
            mineResist = 2f;
            minPick = 65;
		}
	}
}
