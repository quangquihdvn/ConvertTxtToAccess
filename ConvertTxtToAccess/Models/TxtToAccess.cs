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
            PAN1 = new Card { Length = Constants.TxtToAccessFieldLength.PAN1_LENGTH };
            PAN2 = new Card { Length = Constants.TxtToAccessFieldLength.PAN2_LENGTH };
            PAN3 = new Card { Length = Constants.TxtToAccessFieldLength.PAN3_LENGTH };
            PAN4 = new Card { Length = Constants.TxtToAccessFieldLength.PAN4_LENGTH };
            FROM = new Card { Length = Constants.TxtToAccessFieldLength.FROM_LENGTH };
            EXP_DATE = new Card { Length = Constants.TxtToAccessFieldLength.EXP_DATE_LENGTH };
            TRACK1 = new Card { Length = Constants.TxtToAccessFieldLength.TRACK1_LENGTH };
            TRACK2 = new Card { Length = Constants.TxtToAccessFieldLength.TRACK2_LENGTH };
            CVV2 = new Card { Length = Constants.TxtToAccessFieldLength.CVV2_LENGTH };
            CHIP = new Card { Length = Constants.TxtToAccessFieldLength.CHIP_LENGTH };
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
    }
}
