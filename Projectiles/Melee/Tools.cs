using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectV.Projectiles.Melee
{
    public class Tools : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 8;
        }

        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.width = 128;
            projectile.height = 128;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 240;
            // projectile.aiStyle = 3;
            // aiType = ProjectileID.Meteor1;
        }

        /*public override void AI()
        {
            // projectile.velocity.Y += projectile.velocity.Y + 0.01f; // добавляет гравитацию
            // projectile.velocity.X = projectile.velocity.X * 0.97f; // добавляет сопротивлению ветру
            // projectile.rotation += 0.4f * (float)projectile.direction; // вращение снаряда
            // projectile.rotation = projectile.velocity.ToRotation(); // положение снаряда
            // Lighting.AddLight(projectile.Center, 10f, 10f, 3f); // свечение снаряда в пикселях

            //projectile.velocity.X = projectile.velocity.X * 0.985f;
            //projectile.velocity.Y = projectile.velocity.Y * 0.985f;
            //Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 173, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f, 0, default(Color), 1f);
        }*/
    }
}