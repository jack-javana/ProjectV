using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace ProjectV.Items.Melee.Weapons
{ 
	public class TongueofDeath : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("All flies and mosquitoes tremble while looking at this sword");

		}

		public override void SetDefaults()
		{
			item.damage = 28;
			item.melee = true;
			item.width = 34;
			item.height = 34;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 5000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10 ); //Должен будет делаться и болотных слитков(хочешь можешь сделать эти слитки) и стрелять снарядом похожим на язык лягушки, который потом быстро возвращается назад
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
