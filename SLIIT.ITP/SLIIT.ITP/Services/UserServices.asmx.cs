using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.IO;
using System.Web.Script.Serialization;
using System.Transactions; //if transaction manager is used only
using System.Net.Mail;
using SLIIT.Core;
using SLIIT.Core.BL;

namespace SLIIT.ITP.Services
{
    /// <summary>
    /// Summary description for UserServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class UserServices : System.Web.Services.WebService
    {
        #region WebMethods
        

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string GetUserByID()
        {
            //return new SLIIT.Core.UserBL;
            return string.Empty;
        }

        #endregion

        #region PrivateMethods
        
        #endregion
    }
}
