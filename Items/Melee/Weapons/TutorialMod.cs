using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectV.Items.Melee.Weapons
{
	public class TutorialMod : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("GGGG");
			
		}

		public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.useStyle = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 22;
            item.useTime = 22;
            item.width = 40;
            item.height = 40;
            item.UseSound = SoundID.Item1;
            item.knockBack = 4f;
            item.shoot = mod.ProjectileType("Tools");
            item.shootSpeed = 8f;
        }
    }
}