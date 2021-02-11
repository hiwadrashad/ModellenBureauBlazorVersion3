using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Enums.BioMarker
{
    public enum Height
    {
        [Description("<140")]
        Belowonehundredfourty,
        [Description("140")]
        onehundredfourty,
        [Description("145")]
        onehundredfourtyfive,
        [Description("150")]
        onehundredfifty,
        [Description("155")]
        onehundredfiftyfive,
        [Description("160")]
        onehundredsixty,
        [Description("165")]
        onehundredsixtyfive,
        [Description("170")]
        onehundredseventy,
        [Description("175")]
        onehundredseventyfive,
        [Description("180")]
        onehundredeighty,
        [Description("185")]
        onehundredeightyfive,
        [Description("190")]
        onehundredninety,
        [Description("195")]
        onehundredninetyfive,
        [Description("200")]
        towhundred,
        [Description("200>")]
        abovetwohundred
    }
}
