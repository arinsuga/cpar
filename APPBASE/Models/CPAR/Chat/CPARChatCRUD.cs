﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    [Table("CPAR01CHATCPAR")]
    public class CPARChat : CRUD
    {
        public string DTA_STS { get; set; }
        public string CPAR_RUID { get; set; }
        public string USR_RUID { get; set; }
        public string CHAT_DESC_PLAIN { get; set; }
        public string CHAT_DESC_FMT { get; set; }
    } //End public class CPARChat : CRUD
} //End namespace APPBASE.Models

