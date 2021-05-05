namespace Converter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Converter
    {
        public double ConvertCupToDl(double cup)
        {
            return cup * 2.4;
        }

        public double ConvertTableSpoonToDl(double tablespoon)
        {
            return tablespoon * 0.147868;
        }
    }
}
