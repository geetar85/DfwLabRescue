using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfwLabRescue.Web.App_Start
{
    public class DbConfig
    {
        public static void LoadDb()
        {
            DB.Load();
        }
    }
}