using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIIT.ITP.UI.HR
{
    public partial class PunchCard : SLLITPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetPageTitle = "Employee Attendence";
            SetPageSubTitle = string.Empty;            
        }
    }
}