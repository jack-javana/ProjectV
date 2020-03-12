using Terraria;
using Terraria.ModLoader;

namespace ProjectV.Items.Berserker
{
    public class ClassBerserker : ModPlayer
    {
        public float BerserkerDamage;
        public float BerserkerKnockback;
        public int BerserkerCrit;

        public static ClassBerserker ModPlayer(Player player)
        {
            return player.GetModPlayer<ClassBerserker>();
        }

        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

        private void ResetVariables()
        {
            BerserkerDamage = 0f;
            BerserkerKnockback = 0f;
            BerserkerCrit = 0;
        }
	}
}
