using UnityEngine;

namespace Lessons.Architecture
{
    public class BankRepository : Repository
    {
        private const string _key = "Bank_key";
        public int Coins { get; set; }

        public override void Initalize()
        {
            this.Coins = PlayerPrefs.GetInt( _key, 0 );
        }

        public override void Save()
        {
            PlayerPrefs.SetInt( _key, this.Coins );
        }
    }

}
