﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace VerificationCode
{
    public class VerificationCodeOption
    {
        public List<string> Keys { get; set; }
        public string ImagePath { get; set; }

        public string SessionKey { get; set; } = "VerificationCodeKey";

        public string MessageTipFormat { get; set; } = "请根据顺序点击【{0}】";

        public int ImageHeight { get; set; } = 200;

        public int ImageWidth { get; set; } = 200;

        public int DeafaultCodeQty { get; set; } = 5;

        public int DeafaultCheckQty { get; set; } = 2;

        public List<Color> PenColor { get; set; } = new List<Color> { Color.Black, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };

        public int FontSize { get; set; } = 15;

        public List<string> FontFamilyName { get; set; } = new List<string> { "lnk Free", "Segoe Print", "Comic Sans MS", "MV Boli", "华文行楷" };

    }
}
