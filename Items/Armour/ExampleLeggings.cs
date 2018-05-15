using Terraria;
using Terraria.ModLoader;

namespace ExampleMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ExampleLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Walking on rainbows"
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 13;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
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