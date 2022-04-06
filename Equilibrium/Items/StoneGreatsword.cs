using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Equilibrium.Items
{
	public class StoneGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("StoneGreatsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The sword is falling apart, it is barely usable");
		}

		public override void SetDefaults()
		{
			Item.damage = 11;
			Item.DamageType = DamageClass.Melee;
			Item.width = 65;
			Item.height = 65;
			Item.useTime = 33;
			Item.useAnimation = 33;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 14);
			recipe.AddIngredient(ItemID.Wood, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}