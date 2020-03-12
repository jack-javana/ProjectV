using Terraria;
using Terraria.ModLoader;

namespace ProjectV.Items.Placeables.Ores
{
    public class CupidonOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Руда Купидона");
        }

        public override void SetDefaults()
        {
            item.createTile = mod.TileType("CupidonOre");
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.width = 13;
            item.height = 10;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 6, 0);
            item.rare = 3;
        }
    }
}