using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class FacadeClass
    {
        private static SystemA systemA = new SystemA();
        private static SubSystemB subSystemB = new SubSystemB();


        public static void Operation()
        {
            systemA.MethodA();
            systemA.MethodB();
            systemA.MethodC();

            subSystemB.MethodD();
            subSystemB.MethodE();
        }
    }
}
