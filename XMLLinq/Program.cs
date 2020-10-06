using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLLinq
{
    class Weather // 모델 클래스 생성
    {
        public string Hour { get; set; }
        public string Day { get; set; }
        public string Wf { get; set; }
        public string Temp { get; set; }
        public string WdKor { get; set; }
        public string WfKor { get; set; }
        public string Tmn { get; set; }
        public string Tmx { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);  // 특정 URL에서 XML을 가져온다.
                                                     // XML에서 data 요소를 모두 선택한다.
            var xmlQuery = from item in xElement.Descendants("data")
                           select new Weather()  // 새로 생성한 Weather() 클래스 사용
                           {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdKor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           };
            foreach (var item in xmlQuery)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.Write(item.Tmx + "\t");
                Console.WriteLine();
            }
        }
    }
}
