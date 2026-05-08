using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccionCsharp.Models
{
    public class Multiplicacion
    {
        public int a {  get; set; }
        public int b { get; set; }
        public string res { get; set; }
        public int mul { get; set; }

        public void MultiplicacionRes()
        {
            this.res = "";
            this.mul = 0;

            for (int i = 0; i < b; i++)
            {
                
                this.res += a;

                this.mul += a;

                if (i < b - 1)
                {
                    this.res += " + ";
                }
            }
            this.res += " = " + this.mul;
        }
    }
}