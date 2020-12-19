using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json;

namespace MadnathRepairGame.Systems
{
    public class SaveSystem
    {
        private const string Account = "Account";
        private const string Player = "Player";

        public static string CreateSaveString(Models.SaveModel save)
        {
            save.Account.IsSaveValid = true;
            save.Account.LastSaveDate = DateTime.Now;
            save.Account.LastGameVersion = Models.Settings.GameVersion;
            return Compress(CreateSaveJson(save));
        }

        public static Models.SaveModel ReadSaveString(string saveString)
        {

            return GetSaveFromJson(Decompress(saveString));
        }


        public static string CreateSaveJson(Models.SaveModel save)
        {
            Dictionary<string, object> saveData = new Dictionary<string, object>();
            saveData.Add(Player, save.Player);
            saveData.Add(Account, save.Account);
            return JsonConvert.SerializeObject(save);
        }

        public static Models.SaveModel GetSaveFromJson(string saveString)
        {
            return JsonConvert.DeserializeObject<Models.SaveModel>(saveString);
        }
        public static string Compress(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    msi.CopyTo(gs);
                }
                return Convert.ToBase64String(mso.ToArray());
            }
        }

        public static string Decompress(string s)
        {
            var bytes = Convert.FromBase64String(s);
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    gs.CopyTo(mso);
                }
                return Encoding.Unicode.GetString(mso.ToArray());
            }
        }


    }
}
