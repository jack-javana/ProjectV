using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TutorialMod.Items
{
    public class Tools : ModProjectile
    {
        

        public override Color? GetAlpha(Color lightColor) { return Color.White; }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 9;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 250;
            projectile.tileCollide = true;


        }

        public override void AI()
        {
            projectile.velocity.Y = projectile.velocity.Y + 0.1f; 
            if (projectile.velocity.Y > 16f) 
            {
                projectile.velocity.Y = 16f;
            }

            projectile.ai[0] += 1f; 
            if (projectile.ai[0] >= 15f)
            {
                projectile.ai[0] = 15f;
                projectile.velocity.Y = projectile.velocity.Y + 0.1f;
            }

            if (Main.rand.Next(5) == 0) 
            {

                int choice = Main.rand.Next(3);
                if (choice == 0) 
                {
                    choice = 57;
                }
                else if (choice == 1)
                {
                    choice = 57;
                }
                else
                {
                    choice = 58;
                }
                Vector2 projectilePosition = projectile.position;
                projectilePosition -= projectile.velocity * 0.25f;
                int dust = Dust.NewDust(projectilePosition, 1, 1, 76, 0f, 0f, 0, default(Color), 1f);
            }




            Lighting.AddLight(projectile.Center, 1f, 1f, 1f);
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2; 
        }


    }
}