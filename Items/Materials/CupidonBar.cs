using Terraria;
using Terraria.ModLoader;

namespace ProjectV.Items.Materials
{
    public class CupidonBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Слиток Купидона");
            Tooltip.SetDefault("Олицетворение божественной любви");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 45, 0, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(null, "CupidonOre", 4);
            modRecipe.AddTile(16);
            modRecipe.SetResult(this, 1);
            modRecipe.AddRecipe();
        }
    }
}
