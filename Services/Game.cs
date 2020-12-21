using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Services
{
    public class Game
    {
        public bool IsDev = false;
        
        //GUI quirks
        public event Action onChange;
        public void NotifyDataChanged() => onChange?.Invoke();

        public event Action<Radzen.NotificationMessage> onMessage;
        public void SendMessage(Radzen.NotificationMessage message) => onMessage?.Invoke(message);


        //Game stuff
        private Models.Account _account = new Models.Account();
        public Models.Account Account { get { return _account; } }
        private Models.Player _player = new Models.Player();
        public Models.Player Player { get { return _player; } }

        public Models.Settings Settings { get; } = new Models.Settings();

        public bool isGameLoaded { get; set; } = false;
        public int SaveSlot { get; set; } = 0;

        public bool[] isRepairActive { get; set; } = { false, false, false, false, false, false, false, false };

        private Random rng = new Random();


        public void LoadSave(Models.SaveModel save)
        {
            _player = save.Player;
            _account = save.Account;
        }

        public void RepairItems()
        {
            for(int i=0; i<Player.Items.Length; i++)
            {
                if (!Player.WorkstationUnlocked[i] || !isRepairActive[i])
                    continue;
                double expAmount = Player.Items[i].RepairItem(Player.RepairLevel,Player.GetAffintyBonus());
                int rollmax = (int)(125 - Player.RepairLevel);
                int exproll = rng.Next(0, 100);
                if (exproll < rollmax)
                {
                    Player.AwardEXP(expAmount);
                    SendMessage(Player.RareCurrencyRoll());
                    SendMessage(Player.AffintyRoll());
                }
                if (Player.Items[i].DmgCurrent <= 0)
                {
                    isRepairActive[i] = false;
                }
                    
            }
            NotifyDataChanged();
        }

        public void ReturnItem(int slot)
        {
            Player.Stats.AwardStat(Player.Items[slot].GetStatList());
            Player.Items[slot].isEmpty = true;
            Player.AddCurrency(Data.ShopData.Currency.Coins, Player.Items[slot].GetPrice());
        }




        public void BuyItem(Models.ShopItem shopItem)
        {
            if (Player.BuyItem(shopItem))
            {
                UnlockBoughtItem(shopItem);
                NotifyDataChanged();
            }
            else
            {
                Console.WriteLine("Can't Buy");
            }
        }


        private void UnlockBoughtItem(Models.ShopItem shopItem)
        {
            if(shopItem.Shop == Data.ShopData.Shop.Market)
            {
                for (int i = 0; i < Player.WorkstationUnlocked.Length; i++)
                {
                    if (shopItem.Name == Data.MarketData.shopItems[i].Name)
                    {
                        Player.WorkstationUnlocked[i] = true;
                        break;
                    }
                }
                Radzen.NotificationMessage message = new Radzen.NotificationMessage() { Summary = "Market Merchant", Duration = 2000, Severity=Radzen.NotificationSeverity.Success };
                message.Detail = "You bought " + shopItem.Name;
                SendMessage(message);
            }
            if (shopItem.Shop == Data.ShopData.Shop.BackAlley)
            {
                for(int i=0; i<6; i++)
                {
                    if(shopItem.Name == Data.BackAlleyData.shopItems[i].Name)
                    {
                        int roll = 0;
                        if(Data.BackAlleyData.RollChances[i] != 0) {
                            roll = rng.Next(0, Data.BackAlleyData.RollChances[i]);
                        }
                        Radzen.NotificationMessage message = new Radzen.NotificationMessage() { Summary = "Backalley Merchant", Duration = 2000 };
                        if (roll == 0)
                        {
                            Player.Affinties += 1;
                            message.Detail = "Nice you got one, now back to grinding.";
                            message.Severity = Radzen.NotificationSeverity.Success;
                            SendMessage(message);
                        }
                        else
                        {
                            message.Detail = "No affinty this time, better luck next time.";
                            message.Severity = Radzen.NotificationSeverity.Error;
                            SendMessage(message);
                        }
                    }
                }
            }
            if (shopItem.Shop == Data.ShopData.Shop.MasterworkGuild)
            {

            }
        }

        public string GetPageUrl(string url)
        {
            if (IsDev)
            {
                return url;
            }
            else
            {
                return "/RepairGame" + url;
            }
        }
    }

}
