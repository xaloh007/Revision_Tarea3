using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
        var manyPhrases = new StringBuilder();
        for (var i = 0; i< 10000; i++)
        {
            manyPhrases.Append(phrase);
        }
            //Console.WriteLine("tra" + manyPhrases);
}
}
