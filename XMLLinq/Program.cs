using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);  // 특정 URL에서 XML을 가져온다.
            Console.WriteLine(xElement);
        }
    }
}
