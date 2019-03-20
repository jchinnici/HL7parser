using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7prog
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var currentFileData = File.ReadAllText("HL7.txt");
            LoadDatabase(currentFileData);
            Console.Read();



        }
        static void LoadDatabase(string text)
        {
            var lines = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var details = line.Split('|');
                var newRecord = new MSH();
                newRecord.encodingCharacters = details[1];
                newRecord.sendingApplication = details[2];
                newRecord.sendingFacility = details[3];
                newRecord.receivingFacility = details[5];
                newRecord.dateTime = DateTime.ParseExact(details[6], "yyyyMMddHHmm", CultureInfo.CurrentCulture);
                newRecord.messageType = details[7];
                newRecord.messageID = details[8];
                newRecord.processingID = details[9];

                Console.Write(newRecord.ToString());
                


            }
        }
    }
}
