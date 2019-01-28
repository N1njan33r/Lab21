using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab21.Models
{
    public class Session
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SessionID { get; set; }


    }
}