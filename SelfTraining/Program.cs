using System;
using System.Collections.Generic;
using System.Reflection;
namespace selfTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var aObj = new ProtoType("1", "a", 10, 10);
            // Console.WriteLine(aObj.GetType().GetFields().Length);
            // foreach (var x in aObj.GetType().GetMembers()) {
            foreach (var x in aObj.GetType().GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(x);
            }
            var bObj = CloneModel<ProtoType>(aObj);
            // var bObj = (ProtoType) Util.CloneObject(aObj);
            aObj.setX(20);
            // Console.WriteLine("aObj, x -> " + aObj.getX());
            // Console.WriteLine("bObj, x -> " + bObj.getX());
        }

        public static T CloneModel<T>(T oModel)
        {
            var oRes = default(T);
            var oType = typeof(T);

            oRes = (T)Activator.CreateInstance(oType);

            PropertyInfo[] propList = oType.GetProperties();

            foreach (var oProp in propList)
            {
                // Console.WriteLine(oProp);
                var oVal = oProp.GetValue(oModel);
                oProp.SetValue(oRes, oVal);
            }

            return oRes;
        }
    }
}
