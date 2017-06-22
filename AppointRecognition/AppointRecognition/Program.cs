using AppointRecognition.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] a = { "9", "10", "11", "12", "1", "2", "3", "4", "5", "6" };
            String[] b = { "san francisco", "san jose", "santa clara", "oakland", "fremont", "cupertino", "dublin", "pleasanton", "san ramon", "livermore", "sunnyvale" };
            String[] c = { "15", "30", "45", "60", "75", "90", "120" };
            String[] d = { "jessner", "peptide", "lactic", "glycolic", "hydrating", "vitamin c", "pumpkin", "salicylic", "tca peels", "retinol treatments" };
            String[] e = { "consultation", "hair system", "system service", "system coloring", "system service and color", "system styling", "system repair", "cut-in personal system"};
            Appointment app = new Appointment();
            Console.WriteLine("What can I do for you?");
            String answer = (Console.ReadLine().ToLower());
            for (int g = 0; g < 11; g++)
            {
                if (answer.Contains("appoint") || answer.Contains("schedule") || (answer.Contains("book")) ||
                    answer.Contains("cut"))
                {
                    app.appt(a, b, c, d, e);
                    return;
                }
                else
                {
                    Console.Write("Sorry, I cannot do that.");
                    Console.WriteLine(" What else can I do for you?");
                    String answer2 = (Console.ReadLine().ToLower());
                    if (answer2.Contains("appoint") || answer2.Contains("schedule") || (answer2.Contains("book")) ||
                    answer2.Contains("cut"))
                    {
                        app.appt(a, b, c, d, e);
                        return;
                    }
                }
            }
        }
    } 
}
