﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DXMNCGUI_SMILE_SUPPORT_SYSTEM.API.PDSB.Models
{
    public class ResultAccount
    {
        public string responseCode { get; set; }
        public string account_number { get; set; }
        public string messages { get; set; }
    }
}