using AppointRecognition.Domain;
using System;
using System.Collections;
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
            String[] a = { "9 am", "10 am", "11 am", "12 pm", "1 pm", "2 pm", "3 pm", "4 pm", "5 pm", "6 pm", "9am", "10am", "11am", "12pm", "1pm", "2pm", "3pm", "4pm", "5pm", "6pm" };
            String[] b = { "san francisco", "san jose", "santa clara", "oakland", "fremont", "cupertino", "dublin", "pleasanton", "san ramon", "livermore", "sunnyvale" };
            String[] c = { "15", "30", "45", "60", "75", "90", "120" };
            String[] d = { "jessner", "peptide", "lactic", "glycolic", "hydrating", "vitamin c", "pumpkin", "salicylic", "tca peels", "retinol treatments" };
            String[] e = { "consultation", "hair system", "system service and color", "system service", "system coloring", "system styling", "system repair", "cut-in personal system" };
            String[] f = { "swedish", "reflexology", "ashiatsu oriental bar", "shiatsu", "therapeutic", "sport", "medical", "hot stone" };
            String[] g = { "french manicure and pedicure", "french manicure", "french pedicure", "spa manicure and pedicure", "spa manicure", "spa pedicure", "manicure and pedicure", "manicure", "pedicure", "polish change", "full set acrylic", "acrylic fill", "pink and white full set", "nail replacement", "gel nails full set", "silk nails full set", "french fill", "french full set" };
            String[] m = { "hands and feet", "feet and hands", "hands", "feet" };
            String[] n = { "women's blow-dry", "women's styling with flat-curling iron", "women's haircut and blow-dry", "women's haircut with flat-curling iron", "women's haircut with thermal press", "women's haircut", "child's haircut and style", "keratin treatment relaxer", "brazilian blowout relaxer", "conditioning treatment", "special occasions", "up-dos", "consultation", "implementation",
                         "touchup, cut and thermal press", "touchup, cut and flat/curling iron", "touchup, cut and blow-dry", "touchup and thermal press", "touchup and flat/curling iron", "touchup and blow-dry", "touchup and cut", "touchup", 
                         "color correction", "color, partial highlight, cut and thermal press", "color, partial highlight, cut and flat/curling iron", "color, partial highlight, cut and blow-dry", "color, partial highlight and cut", "color and partial highlight", "color, full highlight, cut and thermal press", "color, full highlight, cut and flat/curling iron", "color, full highlight, cut and blow-dry", "color, full highlight and thermal press", "color, full highlight and flat/curling iron", "color, full highlight and blow-dry", "color, full highlight and cut", "color and full highlight", "color, cut and thermal press", "color, cut and flat/curling iron", "color, cut and blow-dry", "color and thermal press", "color and thermal press", "color and flat/curling iron", "color and blow-dry", "color and haircut", "color",
                         "partial highlight, touch-up, cut and thermal press", "partial highlight, touch-up, cut and flat/curling iron", "partial highlight, touch-up, cut and blow-dry", "partial highlight, touch-up and thermal press", "partial highlight, touch-up and flat/curling iron", "partial highlight, touch-up and blow-dry", "partial highlight, touch-up and cut", "partial highlight and touch-up", "partial highlight, cut and thermal press", "partial highlight, cut and flat/curling iron", "partial highlight, cut and blow-dry", "partial highlight and thermal press", "partial highlight and flat/curling iron", "partial highlight and blow-dry", "partial highlight and cut", "partial highlight", 
                         "highlight, touch-up, cut and thermal press", "highlight, touch-up, cut and flat/curling iron", "highlight, touch-up, cut and blow-dry", "highlight, touch-up and thermal press", "highlight, touch-up and flat/curling iron", "highlight, touch-up and blow-dry", "highlight, touch-up and cut", "highlight and touch-up", "highlight, cut and thermal press", "highlight, cut and flat/curling iron", "highlight, cut and blow-dry", "highlight and thermal press", "highlight and flat/curling iron", "highlight and blow-dry", "highlight and cut", "highlight", 
                         "consultation", "hair system", "system service and color", "system service", "system coloring", "system styling", "system repair", "cut-in personal system",
                         "french manicure and pedicure", "french manicure", "french pedicure", "spa manicure and pedicure", "spa manicure", "spa pedicure", "manicure and pedicure", "manicure", "pedicure", "polish change-hands and feet", "polish change-hands", "polish change-feet", "full set acrylic-hands and feet", "full set acrylic-hands", "full set acrylic-feet", "acrylic fill-hands and feet", "acrylic fill-hands", "acrylic fill-feet", "pink and white full set-hands and feet", "pink and white full set-hands", "pink and white full set-feet", "nail replacement", "gel nails full set-hands and feet", "gel nails full set-hands", "gel nails full set-feet", "silk nails full set-hands and feet", "silk nails full set-hands", "silk nails full set-feet", "french fill", "french full set",
                         "swedish massage-15", "swedish massage-30", "swedish massage-45", "swedish massage-60", "swedish massage-75", "swedish massage-90", "swedish massage-120", "reflexology massage-15", "reflexology massage-30", "reflexology massage-45", "reflexology massage-60", "reflexology massage-75", "reflexology massage-90", "reflexology massage-120", "shiatsu massage-15", "shiatsu massage-30", "shiatsu massage-45", "shiatsu massage-60", "shiatsu massage-75", "shiatsu massage-90", "shiatsu massage-120", "therapeutic massage-15", "therapeutic massage-30", "therapeutic massage-45", "therapeutic massage-60", "therapeutic massage-75", "therapeutic massage-90", "therapeutic massage-120", "sport massage-15", "sport massage-30", "sport massage-45", "sport massage-60", "sport massage-75", "sport massage-90", "sport massage-120", "medical massage-15", "medical massage-30", "medical massage-45", "medical massage-60", "medical massage-75", "medical massage-90", "medical massage-120", "hot stone massage-15", "hot stone massage-30", "hot stone massage-45", "hot stone massage-60", "hot stone massage-75", "hot stone massage-90", "hot stone massage-120", "ashiatsu oriental bar massage-30", "ashiatsu oriental bar massage-45", "ashiatsu oriental bar massage-60", "ashiatsu oriental bar massage-75", "ashiatsu oriental bar massage-90", "ashiatsu oriental bar massage-120",
                         "15 minute swedish massage", "30 minute swedish massage", "45 minute swedish massage", "60 minute swedish massage", "75 minute swedish massage", "90 minute swedish massage", "120 minute swedish massage", "15 minute reflexology massage", "30 minute reflexology massage", "45 minute reflexology massage", "60 minute reflexology massage", "75 minute reflexology massage", "90 minute reflexology massage", "120 minute reflexology massage", "15 minute shiatsu massage", "30 minute shiatsu massage", "45 minute shiatsu massage", "60 minute shiatsu massage", "75 minute shiatsu massage", "90 minute shiatsu massage", "120 minute shiatsu massage", "15 minute therapeutic massage", "30 minute therapeutic massage", "45 minute therapeutic massage", "60 minute therapeutic massage", "75 minute therapeutic massage", "90 minute therapeutic massage", "120 minute therapeutic massage", "15 minute sport massage", "30 minute sport massage", "45 minute sport massage", "60 minute sport massage", "75 minute sport massage", "90 minute sport massage", "120 minute sport massage", "15 minute medical massage", "30 minute medical massage", "45 minute medical massage", "60 minute medical massage", "75 minute medical massage", "90 minute medical massage", "120 minute medical massage", "15 minute hot stone massage", "30 minute hot stone massage", "45 minute hot stone massage", "60 minute hot stone massage", "75 minute hot stone massage", "90 minute hot stone massage", "120 minute hot stone massage", "30 minute ashiatsu oriental bar massage", "45 minute ashiatsu oriental bar massage", "60 minute ashiatsu oriental bar massage", "75 minute ashiatsu oriental bar massage", "90 minute ashiatsu oriental bar massage", "120 minute ashiatsu oriental bar massage",
                         "swedish massage for 15 minutes", "swedish massage for 30 minutes", "swedish massage for 45 minutes", "swedish massage for 60 minutes", "swedish massage for 75 minutes", "swedish massage for 90 minutes", "swedish massage for 120 minutes", "reflexology massage for 15 minutes", "reflexology massage for 30 minutes", "reflexology massage for 45 minutes", "reflexology massage for 60 minutes", "reflexology massage for 75 minutes", "reflexology massage for 90 minutes", "reflexology massage for 120 minutes", "shiatsu massage for 15 minutes", "shiatsu massage for 30 minutes", "shiatsu massage for 45 minutes", "shiatsu massage for 60 minutes", "shiatsu massage for 75 minutes", "shiatsu massage for 90 minutes", "shiatsu massage for 120 minutes", "therapeutic massage for 15 minutes", "therapeutic massage for 30 minutes", "therapeutic massage for 45 minutes", "therapeutic massage for 60 minutes", "therapeutic massage for 75 minutes", "therapeutic massage for 90 minutes", "therapeutic massage for 120 minutes", "sport massage for 15 minutes", "sport massage for 30 minutes", "sport massage for 45 minutes", "sport massage for 60 minutes", "sport massage for 75 minutes", "sport massage for 90 minutes", "sport massage for 120 minutes", "medical massage for 15 minutes", "medical massage for 30 minutes", "medical massage for 45 minutes", "medical massage for 60 minutes", "medical massage for 75 minutes", "medical massage for 90 minutes", "medical massage for 120 minutes", "hot stone massage for 15 minutes", "hot stone massage for 30 minutes", "hot stone massage for 45 minutes", "hot stone massage for 60 minutes", "hot stone massage for 75 minutes", "hot stone massage for 90 minutes", "hot stone massage for 120 minutes", "ashiatsu oriental bar massage for 30 minutes", "ashiatsu oriental bar massage for 45 minutes", "ashiatsu oriental bar massage for 60 minutes", "ashiatsu oriental bar massage for 75 minutes", "ashiatsu oriental bar massage for 90 minutes", "ashiatsu oriental bar massage for 120 minutes",
                         "jessner", "peptide", "lactic", "glycolic", "hydrating", "vitamin c", "pumpkin", "salicylic", "tca peels", "retinol treatments", "facial with extractions", "black facial", "microdermabrasion","facial",
                         "spray tanning-air brush" };
            String[] o = { "1/1", "1/2", "1/3", "1/4", "1/5", "1/6", "1/7", "1/8", "1/9", "1/10", "1/11", "1/12", "1/13", "1/14", "1/15", "1/16", "1/17", "1/18", "1/19", "1/20", "1/21", "1/22", "1/23", "1/24", "1/25", "1/26", "1/27", "1/28", "1/29", "1/30", "1/31",
                         "2/1", "2/2", "2/3", "2/4", "2/5", "2/6", "2/7", "2/8", "2/9", "2/10", "2/11", "2/12", "2/13", "2/14", "2/15", "2/16", "2/17", "2/18", "2/19", "2/20", "2/21", "2/22", "2/23", "2/24", "2/25", "2/26", "2/27", "2/28", "2/29",
                         "3/1", "3/2", "3/3", "3/4", "3/5", "3/6", "3/7", "3/8", "3/9", "3/10", "3/11", "3/12", "3/13", "3/14", "3/15", "3/16", "3/17", "3/18", "3/19", "3/20", "3/21", "3/22", "3/23", "3/24", "3/25", "3/26", "3/27", "3/28", "3/29", "3/30", "3/31",
                         "4/1", "4/2", "4/3", "4/4", "4/5", "4/6", "4/7", "4/8", "4/9", "4/10", "4/11", "4/12", "4/13", "4/14", "4/15", "4/16", "4/17", "4/18", "4/19", "4/20", "4/21", "4/22", "4/23", "4/24", "4/25", "4/26", "4/27", "4/28", "4/29", "4/30",
                         "5/1", "5/2", "5/3", "5/4", "5/5", "5/6", "5/7", "5/8", "5/9", "5/10", "5/11", "5/12", "5/13", "5/14", "5/15", "5/16", "5/17", "5/18", "5/19", "5/20", "5/21", "5/22", "5/23", "5/24", "5/25", "5/26", "5/27", "5/28", "5/29", "5/30", "5/31",
                         "6/1", "6/2", "6/3", "6/4", "6/5", "6/6", "6/7", "6/8", "6/9", "6/10", "6/11", "6/12", "6/13", "6/14", "6/15", "6/16", "6/17", "6/18", "6/19", "6/20", "6/21", "6/22", "6/23", "6/24", "6/25", "6/26", "6/27", "6/28", "6/29", "6/30",
                         "7/1", "7/2", "7/3", "7/4", "7/5", "7/6", "7/7", "7/8", "7/9", "7/10", "7/11", "7/12", "7/13", "7/14", "7/15", "7/16", "7/17", "7/18", "7/19", "7/20", "7/21", "7/22", "7/23", "7/24", "7/25", "7/26", "7/27", "7/28", "7/29", "7/30", "7/31",
                         "8/1", "8/2", "8/3", "8/4", "8/5", "8/6", "8/7", "8/8", "8/9", "8/10", "8/11", "8/12", "8/13", "8/14", "8/15", "8/16", "8/17", "8/18", "8/19", "8/20", "8/21", "8/22", "8/23", "8/24", "8/25", "8/26", "8/27", "8/28", "8/29", "8/30", "8/31",
                         "9/1", "9/2", "9/3", "9/4", "9/5", "9/6", "9/7", "9/8", "9/9", "9/10", "9/11", "9/12", "9/13", "9/14", "9/15", "9/16", "9/17", "9/18", "9/19", "9/20", "9/21", "9/22", "9/23", "9/24", "9/25", "9/26", "9/27", "9/28", "9/29", "9/30",
                         "10/1", "10/2", "10/3", "10/4", "10/5", "10/6", "10/7", "10/8", "10/9", "10/10", "10/11", "10/12", "10/13", "10/14", "10/15", "10/16", "10/17", "10/18", "10/19", "10/20", "10/21", "10/22", "10/23", "10/24", "10/25", "10/26", "10/27", "10/28", "10/29", "10/30", "10/31",
                         "11/1", "11/2", "11/3", "11/4", "11/5", "11/6", "11/7", "11/8", "11/9", "11/10", "11/11", "11/12", "11/13", "11/14", "11/15", "11/16", "11/17", "11/18", "11/19", "11/20", "11/21", "11/22", "11/23", "11/24", "11/25", "11/26", "11/27", "11/28", "11/29", "11/30",
                         "12/1", "12/2", "12/3", "12/4", "12/5", "12/6", "12/7", "12/8", "12/9", "12/10", "12/11", "12/12", "12/13", "12/14", "12/15", "12/16", "12/17", "12/18", "12/19", "12/20", "12/21", "12/22", "12/23", "12/24", "12/25", "12/26", "12/27", "12/28", "12/29", "12/30", "12/31"
                         };
            Appointment app = new Appointment();
            Console.WriteLine("What can I do for you?");
            String answer = (Console.ReadLine().ToLower());
            for (int h = 0; h < 11; h++)
            {
                // Time, City, and Date
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        for (int l = o.Length - 1; l >= 0; l--)
                        {
                            for (int k = 0; k < n.Length; k++)
                            {
                                if (answer.Contains(n[k]) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                                {
                                    app.servicewcitywtimewdate(a[i], b[j], n[k], o[l]);
                                    return;
                                }
                            }
                            if (answer.Contains("women") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptwomenwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("child") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptcutchildwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("keratin") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptcutrelaxerkeratinwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("brazil") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptcutrelaxerbrazilwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("relaxer") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptcutrelaxerwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("condition") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptcutconditioningwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if ((answer.Contains("special") || (answer.Contains("up-do"))) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(b[j]))
                            {
                                app.apptspecialwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if ((answer.Contains("extension") || (answer.Contains("weaving"))) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptextensionwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("cut") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptcutwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptmakeupanalysiswcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("application") && answer.Contains(b[j]) && answer.Contains(a[i]) && answer.Contains(o[l]))
                            {
                                app.apptmakeupapplicationwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("wedding") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptmakeupweddingwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("makeup") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptmakeupwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            if (answer.Contains("hair replace") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptreplacewcitywtimewdate(a[i], b[j], e, o[l]);
                                return;
                            }
                            for (int k = 0; k < g.Length; k++)
                            {
                                for (int y = 0; y < m.Length; y++)
                                {
                                    if (answer.Contains(g[k]) && answer.Contains(m[y]) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                                    {
                                        app.apptnailchoosewcitywtimewdate(a[i], b[j], g[k], m[y], o[l]);
                                        Console.ReadLine();
                                        return;
                                    }
                                }
                            }
                            for (int k = 0; k < g.Length; k++)
                            {
                                if (answer.Contains(g[k]) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                                {
                                    app.apptnailchoosemaniwcitywtimewdate(a[i], b[j], g[k], o[l]);
                                    Console.ReadLine();
                                    return;
                                }
                            }
                            if (answer.Contains("nail") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptnailwcitywtimewdate(a[i], b[j], o[l]);
                                return;
                            }
                            for (int k = 0; k < f.Length; k++)
                            {
                                if (answer.Contains(f[k]) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                                {
                                    app.apptmassageservicewcitywtimewdate(a[i], b[j], f[k], c, o[l]);
                                    return;
                                }
                            }
                            if (answer.Contains("massage") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptmassagewcitywtimewdate(a[i], b[j], c, o[l]);
                                return;
                            }
                            if (answer.Contains("exfol") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptskinexfolwcitywtimewdate(a[i], b[j], d, o[l]);
                                return;
                            }
                            if (answer.Contains("skin") && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptskinwcitywtimewdate(a[i], b[j], d, o[l]);
                                return;
                            }
                            if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(a[i]) && answer.Contains(b[j]) && answer.Contains(o[l]))
                            {
                                app.apptwcitywtimewdate(a[i], b[j], c, d, e, o[l]);
                                return;
                            }
                        }
                    }
                }



                //City and Date
                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = o.Length - 1; j >= 0; j--)
                    {
                        for (int k = 0; k < n.Length; k++)
                        {
                            if (answer.Contains(n[k]) && answer.Contains(b[i]) && answer.Contains(o[j]))
                            {
                                app.servicewcitywdate(a, b[i], n[k], o[j]);
                                return;
                            }
                        }
                        if (answer.Contains("women") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptwomenwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("child") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutchildwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("keratin") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutrelaxerkeratinwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("brazil") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutrelaxerbrazilwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("relaxer") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutrelaxerwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("condition") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutconditioningwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if ((answer.Contains("special") || (answer.Contains("up-do"))) && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptspecialwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if ((answer.Contains("extension") || (answer.Contains("weaving"))) && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptextensionwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("cut") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupanalysiswcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("application") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupapplicationwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("wedding") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupweddingwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("makeup") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        if (answer.Contains("hair replace") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptreplacewcitywdate(a, b[i], e, o[j]);
                            return;
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            for (int l = 0; l < m.Length; l++)
                            {
                                if (answer.Contains(g[k]) && answer.Contains(m[l]) && answer.Contains(b[i]) && answer.Contains(o[j]))
                                {
                                    app.apptnailchoosewcitywdate(a, b[i], g[k], m[l], o[j]);
                                    Console.ReadLine();
                                    return;
                                }
                            }
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            if (answer.Contains(g[k]) && answer.Contains(b[i]) && answer.Contains(o[j]))
                            {
                                app.apptnailchoosemaniwcitywdate(a, b[i], g[k], o[j]);
                                Console.ReadLine();
                                return;
                            }
                        }
                        if (answer.Contains("nail") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptnailwcitywdate(a, b[i], o[j]);
                            return;
                        }
                        for (int k = 0; k < f.Length; k++)
                        {
                            if (answer.Contains(f[k]) && answer.Contains(b[i]) && answer.Contains(o[j]))
                            {
                                app.apptmassageservicewcitywdate(a, b[i], f[k], c, o[j]);
                                return;
                            }
                        }
                        if (answer.Contains("massage") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptmassagewcitywdate(a, b[i], c, o[j]);
                            return;
                        }
                        if (answer.Contains("exfol") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptskinexfolwcitywdate(a, b[i], d, o[j]);
                            return;
                        }
                        if (answer.Contains("skin") && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptskinwcitywdate(a, b[i], d, o[j]);
                            return;
                        }
                        if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(b[i]) && answer.Contains(o[j]))
                        {
                            app.apptwcitywdate(a, b[i], c, d, e, o[j]);
                            return;
                        }
                    }
                }




                //Time and Date
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = o.Length - 1; j >= 0; j--)
                    {
                        for (int k = 0; k < n.Length; k++)
                        {
                            if (answer.Contains(n[k]) && answer.Contains(a[i]) && answer.Contains(o[j]))
                            {
                                app.servicewtimewdate(a[i], b, n[k], o[j]);
                                return;
                            }
                        }
                        if (answer.Contains("women") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptwomenwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("child") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutchildwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("keratin") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutrelaxerkeratinwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("relaxer") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutrelaxerwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("brazil") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutrelaxerbrazilwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("condition") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutconditioningwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if ((answer.Contains("special") || (answer.Contains("up-do"))) && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptspecialwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if ((answer.Contains("extension") || (answer.Contains("weaving"))) && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptextensionwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("cut") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("application") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupapplicationwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupanalysiswtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("wedding") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupweddingwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("makeup") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptmakeupwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        if (answer.Contains("hair replace") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptreplacewtimewdate(a[i], b, e, o[j]);
                            return;
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            for (int l = 0; l < m.Length; l++)
                            {
                                if (answer.Contains(g[k]) && answer.Contains(m[l]) && answer.Contains(a[i]) && answer.Contains(o[j]))
                                {
                                    app.apptnailchoosewtimewdate(a[i], b, g[k], m[l], o[j]);
                                    Console.ReadLine();
                                    return;
                                }
                            }
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            if (answer.Contains(g[k]) && answer.Contains(a[i]) && answer.Contains(o[j]))
                            {
                                app.apptnailchoosemaniwtimewdate(a[i], b, g[k], o[j]);
                                Console.ReadLine();
                                return;
                            }
                        }
                        if (answer.Contains("nail") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptnailwtimewdate(a[i], b, o[j]);
                            return;
                        }
                        for (int k = 0; k < f.Length; k++)
                        {
                            if (answer.Contains(f[k]) && answer.Contains(a[i]) && answer.Contains(o[j]))
                            {
                                app.apptmassageservicewtimewdate(a[i], b, f[k], c, o[j]);
                                return;
                            }
                        }
                        if (answer.Contains("massage") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptmassagewtimewdate(a[i], b, c, o[j]);
                            return;
                        }
                        if (answer.Contains("exfol") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptskinexfolwtimewdate(a[i], b, d, o[j]);
                            return;
                        }
                        if (answer.Contains("skin") && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptskinwtimewdate(a[i], b, d, o[j]);
                            return;
                        }
                        if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(a[i]) && answer.Contains(o[j]))
                        {
                            app.apptcutwtimewdate(a[i], b, o[j]);
                            return;
                        }
                    }
                }









                //Time and City       
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        for (int k = 0; k < n.Length; k++)
                        {
                            if (answer.Contains(n[k]) && answer.Contains(a[i]) && answer.Contains(b[j]))
                            {
                                app.servicewcitywtime(a[i], b[j], n[k], o);
                                return;
                            }
                        }
                        if (answer.Contains("women") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptwomenwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("child") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutchildwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("keratin") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutrelaxerkeratinwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("brazil") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutrelaxerbrazilwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("relaxer") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutrelaxerwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("condition") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutconditioningwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if ((answer.Contains("special") || (answer.Contains("up-do"))) && answer.Contains(a[i]) && (answer.Contains(b[j])))
                        {
                            app.apptspecialwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if ((answer.Contains("extension") || (answer.Contains("weaving"))) && answer.Contains(a[i]) && (answer.Contains(b[j])))
                        {
                            app.apptextensionwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if ((answer.Contains("cut")) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupanalysiswcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("application") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupapplicationwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("wedding") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupweddingwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("makeup") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if (answer.Contains("hair replace") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptreplacewcitywtime(a[i], b[j], e, o);
                            return;
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            for (int l = 0; l < m.Length; l++)
                            {
                                if ((answer.Contains(g[k])) && (answer.Contains(m[l])) && answer.Contains(a[i]) && (answer.Contains(b[j])))
                                {
                                    app.apptnailchoosewcitywtime(a[i], b[j], g[k], m[l], o);
                                    Console.ReadLine();
                                    return;
                                }
                            }
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            if ((answer.Contains(g[k])) && (answer.Contains(a[i])) && (answer.Contains(b[j])))
                            {
                                app.apptnailchoosemaniwcitywtime(a[i], b[j], g[k], o);
                                Console.ReadLine();
                                return;
                            }
                        }
                        if (answer.Contains("nail") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptnailwcitywtime(a[i], b[j], o);
                            return;
                        }
                        for (int k = 0; k < f.Length; k++)
                        {
                            if (answer.Contains(f[k]) && answer.Contains(a[i]) && answer.Contains(b[j]))
                            {
                                app.apptmassageservicewcitywtime(a[i], b[j], f[k], c, o);
                                return;
                            }
                        }
                        if (answer.Contains("massage") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmassagewcitywtime(a[i], b[j], c, o);
                            return;
                        }
                        if (answer.Contains("exfol") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptskinexfolwcitywtime(a[i], b[j], d, o);
                            return;
                        }
                        if (answer.Contains("skin") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptskinwcitywtime(a[i], b[j], d, o);
                            return;
                        }
                        if (answer.Contains("tan") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.appttanwcitywtime(a[i], b[j], o);
                            return;
                        }
                        if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptwcitywtime(a[i], b[j], c, d, e, o);
                            return;
                        }
                    }
                }







                //Time

                for (int i = 0; i < a.Length; i++)
                {
                    for (int k = 0; k < n.Length; k++)
                    {
                        if (answer.Contains(n[k]) && answer.Contains(a[i]))
                        {
                            app.servicewtime(a[i], b, n[k], o);
                            return;
                        }
                    }
                    if (answer.Contains("women") && answer.Contains(a[i]))
                    {
                        app.apptwomenwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("child") && answer.Contains(a[i]))
                    {
                        app.apptcutchildwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("keratin") && answer.Contains(a[i]))
                    {
                        app.apptcutrelaxerkeratinwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("brazil") && answer.Contains(a[i]))
                    {
                        app.apptcutrelaxerbrazilwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("relaxer") && answer.Contains(a[i]))
                    {
                        app.apptcutrelaxerwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("condition") && answer.Contains(a[i]))
                    {
                        app.apptcutconditioningwtime(a[i], b, o);
                        return;
                    }
                    if ((answer.Contains("special") || (answer.Contains("up-do"))) && (answer.Contains(a[i])))
                    {
                        app.apptspecialwtime(a[i], b, o);
                        return;
                    }
                    if ((answer.Contains("extension") || (answer.Contains("weaving"))) && (answer.Contains(a[i])))
                    {
                        app.apptextensionwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("cut") && answer.Contains(a[i]))
                    {
                        app.apptcutwtime(a[i], b, o);
                        return;
                    }
                    if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(a[i]))
                    {
                        app.apptmakeupanalysiswtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("application") && answer.Contains(a[i]))
                    {
                        app.apptmakeupapplicationwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("wedding") && answer.Contains(a[i]))
                    {
                        app.apptmakeupweddingwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("makeup") && answer.Contains(a[i]))
                    {
                        app.apptmakeupwtime(a[i], b, o);
                        return;
                    }
                    if (answer.Contains("hair replace") && answer.Contains(a[i]))
                    {
                        app.apptreplacewtime(a[i], b, e, o);
                        return;
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        for (int l = 0; l < m.Length; l++)
                        {
                            if ((answer.Contains(g[k])) && (answer.Contains(m[l])) && (answer.Contains(a[i])))
                            {
                                app.apptnailchoosewtime(a[i], b, g[k], m[l], o);
                                Console.ReadLine();
                                return;
                            }
                        }
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        if ((answer.Contains(g[k])) && (answer.Contains(a[i])))
                        {
                            app.apptnailchoosemaniwtime(a[i], b, g[k], o);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (answer.Contains("nail") && answer.Contains(a[i]))
                    {
                        app.apptnailwtime(a[i], b, o);
                        return;
                    }
                    for (int k = 0; k < f.Length; k++)
                    {
                        if (answer.Contains(f[k]) && answer.Contains(a[i]))
                        {
                            app.apptmassageservicewtime(a[i], b, f[k], c, o);
                            return;
                        }
                    }
                    if (answer.Contains("massage") && answer.Contains(a[i]))
                    {
                        app.apptmassagewtime(a[i], b, c, o);
                        return;
                    }
                    if (answer.Contains("exfol") && answer.Contains(a[i]))
                    {
                        app.apptskinexfolwtime(a[i], b, d, o);
                        return;
                    }
                    if (answer.Contains("skin") && answer.Contains(a[i]))
                    {
                        app.apptskinwtime(a[i], b, d, o);
                        return;
                    }
                    if (answer.Contains("tan") && answer.Contains(a[i]))
                    {
                        app.appttanwtime(a[i], b, o);
                        return;
                    }
                    if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(a[i]))
                    {
                        app.apptwtime(a[i], b, c, d, e, o);
                        return;
                    }
                }












                // City
                for (int i = 0; i < b.Length; i++)
                {
                    for (int k = 0; k < n.Length; k++)
                    {
                        if (answer.Contains(n[k]) && answer.Contains(b[i]))
                        {
                            app.servicewcity(a, b[i], n[k], o);
                            return;
                        }
                    }
                    if (answer.Contains("women") && answer.Contains(b[i]))
                    {
                        app.apptwomenwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("child") && answer.Contains(b[i]))
                    {
                        app.apptcutchildwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("keratin") && answer.Contains(b[i]))
                    {
                        app.apptcutrelaxerkeratinwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("brazil") && answer.Contains(b[i]))
                    {
                        app.apptcutrelaxerbrazilwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("relaxer") && answer.Contains(b[i]))
                    {
                        app.apptcutrelaxerwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("condition") && answer.Contains(b[i]))
                    {
                        app.apptcutconditioningwcity(a, b[i], o);
                        return;
                    }
                    if ((answer.Contains("special") || (answer.Contains("up-do"))) && (answer.Contains(b[i])))
                    {
                        app.apptspecialwcity(a, b[i], o);
                        return;
                    }
                    if ((answer.Contains("extension") || (answer.Contains("weaving"))) && (answer.Contains(b[i])))
                    {
                        app.apptextensionwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("cut") && answer.Contains(b[i]))
                    {
                        app.apptcutwcity(a, b[i], o);
                        return;
                    }
                    if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(b[i]))
                    {
                        app.apptmakeupanalysiswcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("application") && answer.Contains(b[i]))
                    {
                        app.apptmakeupapplicationwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("wedding") && answer.Contains(b[i]))
                    {
                        app.apptmakeupweddingwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("makeup") && answer.Contains(b[i]))
                    {
                        app.apptmakeupwcity(a, b[i], o);
                        return;
                    }
                    if (answer.Contains("hair replace") && answer.Contains(b[i]))
                    {
                        app.apptreplacewcity(a, b[i], e, o);
                        return;
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        for (int l = 0; l < m.Length; l++)
                        {
                            if ((answer.Contains(g[k])) && (answer.Contains(m[l])) && (answer.Contains(b[i])))
                            {
                                app.apptnailchoosewcity(a, b[i], g[k], m[l], o);
                                Console.ReadLine();
                                return;
                            }
                        }
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        if ((answer.Contains(g[k])) && (answer.Contains(b[i])))
                        {
                            app.apptnailchoosemaniwcity(a, b[i], g[k], o);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (answer.Contains("nail") && answer.Contains(b[i]))
                    {
                        app.apptnailwcity(a, b[i], o);
                        return;
                    }
                    for (int k = 0; k < f.Length; k++)
                    {
                        if (answer.Contains(f[k]) && answer.Contains(b[i]))
                        {
                            app.apptmassageservicewcity(a, b[i], f[k], c, o);
                            return;
                        }
                    }
                    if (answer.Contains("massage") && answer.Contains(b[i]))
                    {
                        app.apptmassagewcity(a, b[i], c, o);
                        return;
                    }
                    if (answer.Contains("exfol") && answer.Contains(b[i]))
                    {
                        app.apptskinexfolwcity(a, b[i], d, o);
                        return;
                    }
                    if (answer.Contains("skin") && answer.Contains(b[i]))
                    {
                        app.apptskinwcity(a, b[i], d, o);
                        return;
                    }
                    if (answer.Contains("tan") && answer.Contains(b[i]))
                    {
                        app.appttanwcity(a, b[i], o);
                        return;
                    }
                    if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(b[i]))
                    {
                        app.apptwcity(a, b[i], c, d, e, o);
                        return;
                    }
                }



                //Date
                for (int i = o.Length - 1; i >= 0; i--)
                {
                    for (int k = 0; k < n.Length; k++)
                    {
                        if (answer.Contains(n[k]) && answer.Contains(o[i]))
                        {
                            app.servicewdate(a, b, n[k], o[i]);
                            return;
                        }
                    }
                    if (answer.Contains("women") && answer.Contains(o[i]))
                    {
                        app.apptwomenwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("child") && answer.Contains(o[i]))
                    {
                        app.apptcutchildwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("keratin") && answer.Contains(o[i]))
                    {
                        app.apptcutrelaxerkeratinwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("brazil") && answer.Contains(o[i]))
                    {
                        app.apptcutrelaxerbrazilwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("relaxer") && answer.Contains(o[i]))
                    {
                        app.apptcutrelaxerwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("condition") && answer.Contains(o[i]))
                    {
                        app.apptcutconditioningwdate(a, b, o[i]);
                        return;
                    }
                    if ((answer.Contains("special") || (answer.Contains("up-do"))) && answer.Contains(o[i]))
                    {
                        app.apptspecialwdate(a, b, o[i]);
                        return;
                    }
                    if ((answer.Contains("extension") || (answer.Contains("weaving"))) && answer.Contains(o[i]))
                    {
                        app.apptextensionwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("cut") && answer.Contains(o[i]))
                    {
                        app.apptcutwdate(a, b, o[i]);
                        return;
                    }
                    if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(o[i]))
                    {
                        app.apptmakeupanalysiswdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("application") && answer.Contains(o[i]))
                    {
                        app.apptmakeupapplicationwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("wedding") && answer.Contains(o[i]))
                    {
                        app.apptmakeupweddingwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("makeup") && answer.Contains(o[i]))
                    {
                        app.apptmakeupwdate(a, b, o[i]);
                        return;
                    }
                    if (answer.Contains("hair replace") && answer.Contains(o[i]))
                    {
                        app.apptreplacewdate(a, b, e, o[i]);
                        return;
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        for (int l = 0; l < m.Length; l++)
                        {
                            if (answer.Contains(g[k]) && answer.Contains(m[l]) && answer.Contains(o[i]))
                            {
                                app.apptnailchoosewdate(a, b, g[k], m[l], o[i]);
                                Console.ReadLine();
                                return;
                            }
                        }
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        if (answer.Contains(g[k]) && answer.Contains(o[i]))
                        {
                            app.apptnailchoosemaniwdate(a, b, g[k], o[i]);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (answer.Contains("nail") && answer.Contains(o[i]))
                    {
                        app.apptnailwdate(a, b, o[i]);
                        return;
                    }
                    for (int k = 0; k < f.Length; k++)
                    {
                        if (answer.Contains(f[k]) && answer.Contains(o[i]))
                        {
                            app.apptmassageservicewdate(a, b, f[k], c, o[i]);
                            return;
                        }
                    }
                    if (answer.Contains("massage") && answer.Contains(o[i]))
                    {
                        app.apptmassagewdate(a, b, c, o[i]);
                        return;
                    }
                    if (answer.Contains("exfol") && answer.Contains(o[i]))
                    {
                        app.apptskinexfolwdate(a, b, d, o[i]);
                        return;
                    }
                    if (answer.Contains("skin") && answer.Contains(o[i]))
                    {
                        app.apptskinwdate(a, b, d, o[i]);
                        return;
                    }
                    if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(o[i]))
                    {
                        app.apptwdate(a, b, c, d, e, o[i]);
                        return;
                    }
                }




                //No Info
                for (int k = 0; k < n.Length; k++)
                {
                    if (answer.Contains(n[k]))
                    {
                        app.service(a, b, n[k], o);
                        return;
                    }
                }
                if (answer.Contains("women"))
                {
                    app.apptwomen(a, b, o);
                    return;
                }
                if (answer.Contains("child"))
                {
                    app.apptcutchild(a, b, o);
                    return;
                }
                if (answer.Contains("keratin"))
                {
                    app.apptcutrelaxerkeratin(a, b, o);
                    return;
                }
                if (answer.Contains("brazil"))
                {
                    app.apptcutrelaxerbrazil(a, b, o);
                    return;
                }
                if (answer.Contains("relaxer"))
                {
                    app.apptcutrelaxer(a, b, o);
                    return;
                }
                if (answer.Contains("condition"))
                {
                    app.apptcutconditioning(a, b, o);
                    return;
                }
                if (answer.Contains("special") || (answer.Contains("up-do")))
                {
                    app.apptspecial(a, b, o);
                    return;
                }
                if (answer.Contains("extension") || answer.Contains("weaving"))
                {
                    app.apptextension(a, b, o);
                    return;
                }
                if (answer.Contains("cut"))
                {
                    app.apptcut(a, b, o);
                    return;
                }
                if (answer.Contains("analysis") || (answer.Contains("instruction")))
                {
                    app.apptmakeupanalysis(a, b, o);
                    return;
                }
                if (answer.Contains("application"))
                {
                    app.apptmakeupapplication(a, b, o);
                    return;
                }
                if (answer.Contains("wedding"))
                {
                    app.apptmakeupwedding(a, b, o);
                    return;
                }
                if (answer.Contains("makeup"))
                {
                    app.apptmakeup(a, b, o);
                    return;
                }
                if (answer.Contains("hair replace"))
                {
                    app.apptreplace(a, b, e, o);
                    return;
                }
                for (int k = 0; k < g.Length; k++)
                {
                    for (int l = 0; l < m.Length; l++)
                    {
                        if ((answer.Contains(g[k])) && (answer.Contains(m[l])))
                        {
                            app.apptnailchoose(a, b, g[k], m[l], o);
                            Console.ReadLine();
                            return;
                        }
                    }
                }
                for (int k = 0; k < g.Length; k++)
                {
                    if ((answer.Contains(g[k])))
                    {
                        app.apptnailchoosemani(a, b, g[k], o);
                        Console.ReadLine();
                        return;
                    }
                }
                if (answer.Contains("nail"))
                {
                    app.apptnail(a, b, o);
                    return;
                }
                for (int k = 0; k < f.Length; k++)
                {
                    if (answer.Contains(f[k]))
                    {
                        app.apptmassageservice(a, b, f[k], c, o);
                        return;
                    }
                }
                if (answer.Contains("massage"))
                {
                    app.apptmassage(a, b, c, o);
                    return;
                }
                if (answer.Contains("exfol"))
                {
                    app.apptskinexfol(a, b, d, o);
                    return;
                }
                if (answer.Contains("skin"))
                {
                    app.apptskin(a, b, d, o);
                    return;
                }
                if (answer.Contains("tan"))
                {
                    app.appttan(a, b, o);
                    return;
                }
                if (answer.Contains("appoint") || answer.Contains("schedule") || (answer.Contains("book")))
                {
                    app.appt(a, b, c, d, e, o);
                    return;
                }
                if ((answer.Contains("exit")) || (answer.Contains("end")) || (answer.Contains("terminate")) || (answer.Contains("suspend")) || (answer.Contains("bye")))
                {
                    return;
                }
                else
                {
                    Console.Write("Sorry, I cannot do that.");
                    Console.WriteLine(" What else can I do for you?");
                    String answer2 = (Console.ReadLine().ToLower());
                    if (answer2.Contains("appoint") || answer2.Contains("schedule") || (answer2.Contains("book")))
                    {
                        app.appt(a, b, c, d, e, o);
                        return;
                    }
                    if ((answer2.Contains("exit")) || (answer2.Contains("end")) || (answer2.Contains("terminate")) || (answer2.Contains("suspend")) || (answer2.Contains("bye")))
                    {
                        return;
                    }
                }
            }
        }
    }
}
