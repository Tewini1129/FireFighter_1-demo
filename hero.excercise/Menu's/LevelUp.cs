using FireFighter_1;
using FireFIghter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    public class LevelUpRewards
    {
        public static void LevelUp(Player user)
        {
            user.Progress++;
            user.Hp = user.Hp * user.Progress;
            user.MaxHp = user.MaxHp * user.Progress;
            user.EnergyLevel += user.Progress;
            user.MaxEnergyLevel += user.Progress;
            user.RegulareDamage = user.RegulareDamage * user.Progress;
            user.MaxShield = user.MaxShield * user.Progress;
            user.Shield = user.Shield * user.Progress;
        }
    }
}
