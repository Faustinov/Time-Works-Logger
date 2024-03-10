using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class MainFormModel
    {
        public DateTime GeneralDateTime { get; set; }
        public DateTime FullWorkTime { get; set; }
        public DateTime RemainingWorkTime { get; set; }
        public List<DateTime> SpentTimes { get; set; }
        public bool ExistData { get; set; }
    }
}
