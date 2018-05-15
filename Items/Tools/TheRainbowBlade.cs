using Terraria.ID;
using Terraria.ModLoader;

namespace TheRainbowHero.Items
{
	public class TheRainbowBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Rainbow Blade");
			Tooltip.SetDefault("Kill 'em With Kindness");
		}
		public override void SetDefaults()
		{
            item.damage = 69;
            item.melee = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 15;
            item.useAnimation = 15;
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
