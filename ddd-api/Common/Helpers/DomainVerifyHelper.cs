using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Helpers
{
    public static class DomainVerifyHelper
    {

        public static void VerifyExists(object objToVerify, string objName)
        {
            if (objToVerify == null) { }
                //DefaultException(objName);
        }

        //public static void VerifyExists(IEnumerable<object> objToVerify, string objName)
        //{
        //    if (objToVerify == null || !objToVerify.Any())
        //        DefaultExceptionForLists(objName);
        //}

        //public static void VerifyExists(IQueryable<object> objToVerify, string objName)
        //{
        //    if (objToVerify == null)
        //        DefaultExceptionForLists(objName);
        //}

        //public static void DefaultException(string objName)
        //{
        //    throw new DomainNotFoundException(string.Format("{0} {1}", objName, "não encontrado(a)."));
        //}

        //public static void DefaultExceptionForLists(string objName)
        //{
        //    throw new DomainNotFoundException(string.Format("{0} {1}", objName, "não encontrados(as)."));
        //}
    }
}
