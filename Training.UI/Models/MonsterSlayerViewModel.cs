using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Training.UI.Models
{
    public class MonsterSlayerViewModel 
    {
        public int MonsterHealth { get; set; } = 100;
        public int PlayerHealth { get; set; } = 100;
        public int PlayerMaxHitModifier { get; set; } = 5;
        public int PlayerMinHitModifier { get; set; } = 12;
        public int MonsterMaxHitModifier { get; set; } = 8;
        public int MonsterMinHitModifier { get; set; } = 15;
        public int SpecialAttackMaximum { get; set; } = 3;

        public List<object> BattleLog { get; set; } = new List<object>();
    }
}
