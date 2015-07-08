using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLIIT.Core.BL;
using SLIIT.Core.DTO;


namespace SLIIT.Core.Entity
{
    public class User
    {
        public int RnUserID { get; set;}
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
