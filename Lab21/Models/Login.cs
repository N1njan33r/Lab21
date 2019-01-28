using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class Login
    {
        public int LoginID { get; set; }

        public virtual User User { get; set; }
    }
}