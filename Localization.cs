using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization
{
    public class OldLocalization
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class NewLocalization
    {
        public string Font { get; set; }
        public bool LeftToRight { get; set; }
        public double Version { get; set; }
        public double Ratio { get; set; }
        public string Lang { get; set; }
        public List<OldLocalization> Translations { get; set; }
    }

}
