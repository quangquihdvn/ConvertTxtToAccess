using ConvertTxtToAccess.Commons;
using ConvertTxtToAccess.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTxtToAccess.Models
{
    public class TxtToAccess
    {
        public TxtToAccess()
        {
            PAN1 = new Card { Length = Constants.TxtToAccessFieldLength.PAN1_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.PAN1_START };
            PAN2 = new Card { Length = Constants.TxtToAccessFieldLength.PAN2_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.PAN2_START };
            PAN3 = new Card { Length = Constants.TxtToAccessFieldLength.PAN3_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.PAN3_START };
            PAN4 = new Card { Length = Constants.TxtToAccessFieldLength.PAN4_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.PAN4_START };
            FROM = new Card { Length = Constants.TxtToAccessFieldLength.FROM_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.FROM_START };
            EXP_DATE = new Card { Length = Constants.TxtToAccessFieldLength.EXP_DATE_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.EXP_DATE_START };
            TRACK1 = new Card { Length = Constants.TxtToAccessFieldLength.TRACK1_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.TRACK1_START };
            TRACK2 = new Card { Length = Constants.TxtToAccessFieldLength.TRACK2_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.TRACK2_START };
            CVV2 = new Card { Length = Constants.TxtToAccessFieldLength.CVV2_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.CVV2_START };
            CHIP = new Card { Length = Constants.TxtToAccessFieldLength.CHIP_LENGTH, StartIndex = Constants.TxtToAccessFieldStartIndex.CHIP_START };
        }

        public Card PAN1 { get; set; }
        public Card PAN2 { get; set; }
        public Card PAN3 { get; set; }
        public Card PAN4 { get; set; }
        public Card FROM { get; set; }
        public Card EXP_DATE { get; set; }
        public Card NAME { get; set; }
        public Card TRACK1 { get; set; }
        public Card TRACK2 { get; set; }
        public Card CVV2 { get; set; }
        public Card CHIP { get; set; }

        public void SetValue(string line)
        {
            PAN1.SubValue(line);
            PAN2.SubValue(line);
            PAN3.SubValue(line);
            PAN4.SubValue(line);
            FROM.SubValue(line);
            EXP_DATE.SubValue(line);
            NAME.SubValue(line);
            TRACK1.SubValue(line);
            TRACK2.SubValue(line);
            CVV2.SubValue(line);
            CHIP.SubValue(line);
        }
    }
}
