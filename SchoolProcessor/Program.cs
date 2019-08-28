using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Libraries;
using static System.Configuration.ConfigurationManager;
using Data;

namespace SchoolProcessor
{
    class Program
    {
        static void Main(string[] args)
        {

            var source = AppSettings["SourceDirectory"]??string.Empty;
            var target = AppSettings["TargetDirectory"]??string.Empty;

            if (source=="" || target=="")
            {
                Console.WriteLine("application is not configured.  Add settings to App config");
                return;
            }

            if (!(Directory.Exists(source) && Directory.Exists(target)))
            {
                Console.WriteLine("source and target directories must exist");
            }

            var service = new SchoolService(new FileSchoolRepository(source));

            var fileName = Path.Combine( target ,(Guid.NewGuid().ToString("N")) + ".txt");

            File.WriteAllText(fileName,service.School.ToString());


        }
    }
}
