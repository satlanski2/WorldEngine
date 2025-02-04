﻿using System;
using System.Collections.Generic;
using System.Text;

public static class GlobalVars
{
    public static WorldEngine.GameEngine GameEngine;
    public static System.Windows.Forms.Form GameForm;


    public static int getTVPrecisionDivider(MTV3D65.CONST_TV_LANDSCAPE_PRECISION Precision)
    {
        switch (Precision)
        {
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_LOWEST:
                return 256;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_ULTRA_LOW:
                return 128;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_VERY_LOW:
                return 64;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_LOW:
                return 32;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_HIGH:
                return 8;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_AVERAGE:
                return 16;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_BEST:
                return 4;
            case MTV3D65.CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_ULTRA:
                return 2;
            default:
                return -1;
        }
    }
}
