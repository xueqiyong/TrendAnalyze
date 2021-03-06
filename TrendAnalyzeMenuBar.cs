﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendAnalyze
{
    class TrendAnalyzeMenuBar : MyPluginEngine.IMenuDef
    {
        #region IMenuDef 成员
        public string Caption
        {
            get { return "趋势预测"; }
        }

        public string Name
        {
            get { return "TrendAnalyzeMenu"; }
        }

        public long ItemCount
        {
            get { return 3; }
        }

        public void GetItemInfo(int pos, MyPluginEngine.ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "TrendAnalyze.frmGDPCmd";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "TrendAnalyze.frmPOPCmd";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "TrendAnalyze.frmTableCmd";
                    itemDef.Group = false;
                    break;
                default:
                    break;

            }
        }
        #endregion
    }
}
