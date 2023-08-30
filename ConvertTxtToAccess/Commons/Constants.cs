using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTxtToAccess.Commons
{
    public class Constants
    {
        public class TxtToAccessFieldLength
        {
            public const int PAN1_LENGTH = 4;
            public const int PAN2_LENGTH = 4;
            public const int PAN3_LENGTH = 4;
            public const int PAN4_LENGTH = 4;
            public const int FROM_LENGTH = 5;
            public const int EXP_DATE_LENGTH = 5;
            public const int NAME_LENGTH = 22;
            public const int TRACK1_LENGTH = 76;
            public const int TRACK2_LENGTH = 32;
            public const int CVV2_LENGTH = 3;
            public const int CHIP_LENGTH = 96;

        }

        public class TxtToAccessFieldStartIndex
        {
            public const int PAN1_START = 8;
            public const int PAN2_START = 12;
            public const int PAN3_START = 16;
            public const int PAN4_START = 20;
            public const int FROM_START = 28;
            public const int EXP_DATE_START = 34;
            public const int NAME_START = 45;
            public const int TRACK1_START = 178;
            public const int TRACK2_START = 290;
            public const int CVV2_START = 91;
            public const int CHIP_START = 344;

        }
    }
}
