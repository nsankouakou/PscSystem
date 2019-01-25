using Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PscApi.Services
{
    public class CommonService
    {
        public readonly IHttpContextAccessor _accessor;

        private IRepositoryWrapper _service { get; set; }

        public CommonService(IRepositoryWrapper repository)
        {

        }

        public int GetConnexionValide(string strToken, string strIP = "")
        {
            return 1;
            //if (string.IsNullOrEmpty(strToken))
            //    return 0;

            //return TokenValide(strToken);
        }

        private int TokenValide(string strToken)
        {
            //var connexion = _service.Connexion.FindByCondition(c => c.Token == strToken).FirstOrDefault();
            //if (connexion == null)
            //    return 0;

            //int delai = (string.IsNullOrEmpty(Startup.Delai) ? 20 : Convert.ToInt32(Startup.Delai));

            //if (DateTime.Now > connexion.DateLastConnexion.Value.AddMinutes(delai))
            //    return 0;

            //connexion.DateLastConnexion = DateTime.Now;
            //_service.Connexion.Update(connexion);


            return 1;
        }

    }
}
