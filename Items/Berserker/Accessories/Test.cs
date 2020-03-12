using Terraria;
using Terraria.ModLoader;

namespace ProjectV.Items.Berserker.Accessories
{
    public class Test : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Увеличивает урон и крит на 10%");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            ClassBerserker berserker = player.GetModPlayer<ClassBerserker>();
            berserker.BerserkerDamage += 0.10f;
            berserker.BerserkerCrit += 10;
        }
    }
}