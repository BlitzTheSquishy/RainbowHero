using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Items
{
	public class TheRainbowPick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Rainbow Pickaxe");
			Tooltip.SetDefault("Mine With Style");
		}

		public override void SetDefaults()
		{
			item.damage = 23;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.pick = 169;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 69000;
			item.rare = 13;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.expert = true;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 2);
			recipe.AddIngredient(ItemID.MythrilBar, 2);
			recipe.AddIngredient(ItemID.AdamantiteBar, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 2);
			recipe.AddIngredient(ItemID.OrichalcumBar, 2);
			recipe.AddIngredient(ItemID.TitaniumBar, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}