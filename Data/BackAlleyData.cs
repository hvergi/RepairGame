using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadnathRepairGame.Models;

namespace MadnathRepairGame.Data
{
    public class BackAlleyData
    {
        public static ShopItem[] shopItems =
        {
            new ShopItem("Affinty Roll",-1,1,"A one in 138 chance for an affinty in repairing",ShopData.Currency.RareCoins,ShopData.Shop.BackAlley),
            new ShopItem("Affinty Roll+",-1,3,"A one in 69 chance for an affinty in repairing",ShopData.Currency.RareCoins,ShopData.Shop.BackAlley),
            new ShopItem("Affinty Roll++",-1,7,"A one in 35 chance for an affinty in repairing",ShopData.Currency.RareCoins,ShopData.Shop.BackAlley),
            new ShopItem("Affinty Roll+++",-1,15,"A one in 18 chance for an affinty in repairing",ShopData.Currency.RareCoins,ShopData.Shop.BackAlley),
            new ShopItem("Affinty Roll++++",-1,31,"A one in 9 chance for an affinty in repairing",ShopData.Currency.RareCoins,ShopData.Shop.BackAlley),
            new ShopItem("Give Me an Affinty",-1,300,"One affinty in repairing",ShopData.Currency.RareCoins,ShopData.Shop.BackAlley),
        };

        public static int[] RollChances = { 138, 69, 35, 18, 9, 0 };
    }
}
