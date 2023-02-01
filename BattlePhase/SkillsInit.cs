using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class SkillsInit
    {
        static Dictionary<string, Skills> _SkillList;

        public static Dictionary<string, Skills> SkillList { get => _SkillList; }
        static SkillsInit()
        {
            _SkillList = new Dictionary<string, Skills>()
            {
                {"Heavy Slash", new Skills(10,5)},
            };
        }

    }
}
