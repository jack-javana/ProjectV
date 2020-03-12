using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace ProjectV.Items.Berserker.Weapons
{
	public abstract class BerserkerWeapon : ModItem
	{
        public virtual void SafeSetDefaults()
		{
		}

		public sealed override void SetDefaults()
		{
			SafeSetDefaults();
			item.melee = false;
			item.ranged = false;
			item.magic = false;
			item.thrown = false;
			item.summon = false;
		}

		public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
		{
			add += ClassBerserker.ModPlayer(player).BerserkerDamage;
        }

		public override void GetWeaponKnockback(Player player, ref float knockback)
		{
			knockback += ClassBerserker.ModPlayer(player).BerserkerKnockback;
		}

		public override void GetWeaponCrit(Player player, ref int crit)
		{
            crit += ClassBerserker.ModPlayer(player).BerserkerCrit;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
            TooltipLine BerserkerWeapon = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
			if (BerserkerWeapon != null)
			{
                string[] splitText = BerserkerWeapon.text.Split(' ');
				string damageValue = splitText.First();
				string damageWord = splitText.Last();
                BerserkerWeapon.text = damageValue + " неистовый урон";
			}
        }
    }
}