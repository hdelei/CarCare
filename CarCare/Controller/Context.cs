using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCare.Controller
{
    static class Context
    {
        static byte target, action;

        public static byte Target { get => target; set => target = value; }
        public static byte Action { get => action; set => action = value; }

        public static void SetContext(byte target, byte action)
        {
            Target = target;
            Action = action;
        }
    }
}
