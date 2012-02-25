using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace CustomSecurityExampleMVC30.Models
{
    public class CustomPrincipal : IPrincipal
    {
        public CustomPrincipal(CustomIdentity identity)
        {
            this.Identity = identity;
        }

        #region IPrincipal Members

        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            return true; // everyone's a winner
        }

        #endregion
    }


    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string name)
        {
            this.Name = name;
        }

        #region IIdentity Members

        public string AuthenticationType
        {
            get { return "Custom"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(this.Name); }
        }

        public string Name { get; private set; }

        #endregion
    }

    public static class SimpleSessionPersister
    {
        static string usernameSessionVar = "username";
        public static string Username
        {
            get
            {
                if (HttpContext.Current == null) return string.Empty;
                if (HttpContext.Current.Session[usernameSessionVar] != null)
                    return HttpContext.Current.Session[usernameSessionVar] as string;
                return null;
            }
            set { HttpContext.Current.Session[usernameSessionVar] = value; }
        }
    }
}