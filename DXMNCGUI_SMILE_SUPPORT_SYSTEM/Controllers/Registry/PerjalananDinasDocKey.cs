﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_SMILE_SUPPORT_SYSTEM.Controllers.Registry
{
    public class PerjalananDinasDocKey : BaseRegistryID
    {
        protected override void Init()
        {
            this.myID = 20100;
            this.myDefaultValue = (object)1;
        }
    }
}