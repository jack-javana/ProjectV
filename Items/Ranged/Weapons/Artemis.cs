using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectV.Items.Ranged.Weapons
{
    public class Artemis : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Лук Артемиды");
            Tooltip.SetDefault("Вы наполняетесь силой Богини охоты\nБожественное оружие");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 26;
            item.height = 62;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.rare = 10;
            item.noMelee = true;
            item.knockBack = 1f;
            item.value = Item.buyPrice(1, 0, 0, 0);
            item.UseSound = SoundID.Item5;
            item.autoReuse = true; 
            item.shoot = 1;
            item.shootSpeed = 16f;
            item.useAmmo = 40;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (Main.hardMode)
            {
                item.damage = 20;
            }
            if (NPC.downedMoonlord)
            {
                item.damage = 30;
            }
            int num = Main.rand.Next(25, 36);
            for (int i = 0; i < num; i++)
            {
                float num2 = speedX + (float)Main.rand.Next(-10, 11) * 0.05f;
                float num3 = speedY + (float)Main.rand.Next(-10, 11) * 0.05f;
                int num4 = Projectile.NewProjectile(position.X, position.Y, num2, num3, type, damage, knockBack, player.whoAmI, 0f, 0f);
                Main.projectile[num4].timeLeft = 180;
            }
            return false;
        }
    }
}