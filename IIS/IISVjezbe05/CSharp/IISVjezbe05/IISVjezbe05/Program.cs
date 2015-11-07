using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IISvjezbe05
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("username", "Matija");
                reqparm.Add("passwd", "1234");
                byte[] bytes = client.UploadValues("http://ates-test.algebra.hr/iis/testSubmit.aspx", "POST", reqparm);
                string body = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(body);

                WebHeaderCollection wcHeaderCollection = client.ResponseHeaders;
                Console.WriteLine("\nHeaders:\n");

                for (int i = 0; i < wcHeaderCollection.Count; i++)
                {
                    Console.WriteLine(wcHeaderCollection.GetKey(i) + " = " + wcHeaderCollection.Get(i));
                }
            }
            Console.WriteLine();

            using (WebClient client = new WebClient())
            {
                string reply = client.DownloadString(@"http://ates-test.algebra.hr/iis/testSubmit.aspx?username=Matija&passwd=1234");
                Console.WriteLine(reply);
                WebHeaderCollection wcHeaderCollection = client.ResponseHeaders;
                Console.WriteLine("\nHeaders:\n");

                for (int i = 0; i < wcHeaderCollection.Count; i++)
                {
                    Console.WriteLine(wcHeaderCollection.GetKey(i) + " = " + wcHeaderCollection.Get(i));
                }
                Console.ReadKey();
            }
        }
    }
}

