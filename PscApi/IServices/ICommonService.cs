using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PscApi.IServices
{
   public  interface ICommonService
    {
        int GetConnexionValide(string strToken, string strIP = "");
        int TokenValide(string strToken);
    }
}
