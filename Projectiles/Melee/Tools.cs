using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ProjectV.Projectiles.Melee
{
    public class Tools : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 9;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 250;
            projectile.tileCollide = true;
            aiType = 301; // это AI молота паладина, у него ванильный аи стайл = 3, значит 3 и указываем
            projectile.aiStyle = 3;
            
        }

		public override void AI()
		{
            projectile.velocity.X = projectile.velocity.X * 1.06f; // регулируй сопротивление
            projectile.velocity.Y = projectile.velocity.Y * 1.06f; // регулируй гравитацию
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2; //так как спрайт снаряда нарисован вертикально, то нужно использовать такой костыль чтобы в полёте лицом он летел гирозонтально 

        }
	}
}