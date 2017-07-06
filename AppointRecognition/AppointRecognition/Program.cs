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
            String[] m = { "hands and feet", "feet and hands", "hands", "feet"};
            String[] n = { "women's blow-dry", "women's styling with flat-curling iron", "women's haircut and blow-dry", "women's haircut with flat-curling iron", "women's haircut with thermal press", "women's haircut", "child's haircut and style", "keratin treatment relaxer", "brazilian blowout relaxer", "conditioning treatment", "special occasions", "up-dos", "consultation extensions/weaving", "implementation extensions/weaving",
                         "touchup, cut and thermal press", "touchup, cut and flat/curling iron", "touchup, cut and blow-dry", "touchup and thermal press", "touchup and flat/curling iron", "touchup and blow-dry", "touchup",
                         "color correction", "color, partial highlight, cut and thermal press", "color, partial highlight, cut and flat/curling iron", "color, partial highlight, cut and blow-dry", "color, partial highlight and cut", "color and partial highlight", "color, full highlight, cut and thermal press", "color, full highlight, cut and flat/curling iron", "color, full highlight, cut and blow-dry", "color, full highlight and thermal press", "color, full highlight and flat/curling iron", "color, full highlight and blow-dry", "color, full highlight and cut", "color and full highlight", "color, cut and thermal press", "color, cut and flat/curling iron", "color, cut and blow-dry", "color and thermal press", "color and thermal press", "color and flat/curling iron", "color and blow-dry", "color and haircut", "color",
                         "partial highlight, touch-up, cut and thermal press", "partial highlight, touch-up, cut and flat/curling iron", "partial highlight, touch-up, cut and blow-dry", "partial highlight, touch-up and thermal press", "partial highlight, touch-up and flat/curling iron", "partial highlight, touch-up and blow-dry", "partial highlight, touch-up and cut", "partial highlight and touch-up", "partial highlight, cut and thermal press", "partial highlight, cut and flat/curling iron", "partial highlight, cut and blow-dry", "partial highlight and thermal press", "partial highlight and flat/curling iron", "partial highlight and blow-dry", "partial highlight and cut", "partial highlight", 
                         "highlight, touch-up, cut and thermal press", "highlight, touch-up, cut and flat/curling iron", "highlight, touch-up, cut and blow-dry", "highlight, touch-up and thermal press", "highlight, touch-up and flat/curling iron", "highlight, touch-up and blow-dry", "highlight, touch-up and cut", "highlight and touch-up", "highlight, cut and thermal press", "highlight, cut and flat/curling iron", "highlight, cut and blow-dry", "highlight and thermal press", "highlight and flat/curling iron", "highlight and blow-dry", "highlight and cut", "highlight", 
                         "analysis and instruction", "application", "wedding",
                         "consultation", "hair system", "system service and color", "system service", "system coloring", "system styling", "system repair", "cut-in personal system",
                         "french manicure and pedicure", "french manicure", "french pedicure", "spa manicure and pedicure", "spa manicure", "spa pedicure", "manicure and pedicure", "manicure", "pedicure", "polish change-hands and feet", "polish change-hands", "polish change-feet", "full set acrylic-hands and feet", "full set acrylic-hands", "full set acrylic-feet", "acrylic fill-hands and feet", "acrylic fill-hands", "acrylic fill-feet", "pink and white full set-hands and feet", "pink and white full set-hands", "pink and white full set-feet", "nail replacement", "gel nails full set-hands and feet", "gel nails full set-hands", "gel nails full set-feet", "silk nails full set-hands and feet", "silk nails full set-hands", "silk nails full set-feet", "french fill", "french full set",
                         "swedish massage-15", "swedish massage-30", "swedish massage-45", "swedish massage-60", "swedish massage-75", "swedish massage-90", "swedish massage-120", "reflexology massage-15", "reflexology massage-30", "reflexology massage-45", "reflexology massage-60", "reflexology massage-75", "reflexology massage-90", "reflexology massage-120", "shiatsu massage-15", "shiatsu massage-30", "shiatsu massage-45", "shiatsu massage-60", "shiatsu massage-75", "shiatsu massage-90", "shiatsu massage-120", "therapeutic massage-15", "therapeutic massage-30", "therapeutic massage-45", "therapeutic massage-60", "therapeutic massage-75", "therapeutic massage-90", "therapeutic massage-120", "sport massage-15", "sport massage-30", "sport massage-45", "sport massage-60", "sport massage-75", "sport massage-90", "sport massage-120", "medical massage-15", "medical massage-30", "medical massage-45", "medical massage-60", "medical massage-75", "medical massage-90", "medical massage-120", "hot stone massage-15", "hot stone massage-30", "hot stone massage-45", "hot stone massage-60", "hot stone massage-75", "hot stone massage-90", "hot stone massage-120", "ashiatsu oriental bar massage-30", "ashiatsu oriental bar massage-45", "ashiatsu oriental bar massage-60", "ashiatsu oriental bar massage-75", "ashiatsu oriental bar massage-90", "ashiatsu oriental bar massage-120",
                         "15 minute swedish massage", "30 minute swedish massage", "45 minute swedish massage", "60 minute swedish massage", "75 minute swedish massage", "90 minute swedish massage", "120 minute swedish massage", "15 minute reflexology massage", "30 minute reflexology massage", "45 minute reflexology massage", "60 minute reflexology massage", "75 minute reflexology massage", "90 minute reflexology massage", "120 minute reflexology massage", "15 minute shiatsu massage", "30 minute shiatsu massage", "45 minute shiatsu massage", "60 minute shiatsu massage", "75 minute shiatsu massage", "90 minute shiatsu massage", "120 minute shiatsu massage", "15 minute therapeutic massage", "30 minute therapeutic massage", "45 minute therapeutic massage", "60 minute therapeutic massage", "75 minute therapeutic massage", "90 minute therapeutic massage", "120 minute therapeutic massage", "15 minute sport massage", "30 minute sport massage", "45 minute sport massage", "60 minute sport massage", "75 minute sport massage", "90 minute sport massage", "120 minute sport massage", "15 minute medical massage", "30 minute medical massage", "45 minute medical massage", "60 minute medical massage", "75 minute medical massage", "90 minute medical massage", "120 minute medical massage", "15 minute hot stone massage", "30 minute hot stone massage", "45 minute hot stone massage", "60 minute hot stone massage", "75 minute hot stone massage", "90 minute hot stone massage", "120 minute hot stone massage", "30 minute ashiatsu oriental bar massage", "45 minute ashiatsu oriental bar massage", "60 minute ashiatsu oriental bar massage", "75 minute ashiatsu oriental bar massage", "90 minute ashiatsu oriental bar massage", "120 minute ashiatsu oriental bar massage",
                         "swedish massage for 15 minutes", "swedish massage for 30 minutes", "swedish massage for 45 minutes", "swedish massage for 60 minutes", "swedish massage for 75 minutes", "swedish massage for 90 minutes", "swedish massage for 120 minutes", "reflexology massage for 15 minutes", "reflexology massage for 30 minutes", "reflexology massage for 45 minutes", "reflexology massage for 60 minutes", "reflexology massage for 75 minutes", "reflexology massage for 90 minutes", "reflexology massage for 120 minutes", "shiatsu massage for 15 minutes", "shiatsu massage for 30 minutes", "shiatsu massage for 45 minutes", "shiatsu massage for 60 minutes", "shiatsu massage for 75 minutes", "shiatsu massage for 90 minutes", "shiatsu massage for 120 minutes", "therapeutic massage for 15 minutes", "therapeutic massage for 30 minutes", "therapeutic massage for 45 minutes", "therapeutic massage for 60 minutes", "therapeutic massage for 75 minutes", "therapeutic massage for 90 minutes", "therapeutic massage for 120 minutes", "sport massage for 15 minutes", "sport massage for 30 minutes", "sport massage for 45 minutes", "sport massage for 60 minutes", "sport massage for 75 minutes", "sport massage for 90 minutes", "sport massage for 120 minutes", "medical massage for 15 minutes", "medical massage for 30 minutes", "medical massage for 45 minutes", "medical massage for 60 minutes", "medical massage for 75 minutes", "medical massage for 90 minutes", "medical massage for 120 minutes", "hot stone massage for 15 minutes", "hot stone massage for 30 minutes", "hot stone massage for 45 minutes", "hot stone massage for 60 minutes", "hot stone massage for 75 minutes", "hot stone massage for 90 minutes", "hot stone massage for 120 minutes", "ashiatsu oriental bar massage for 30 minutes", "ashiatsu oriental bar massage for 45 minutes", "ashiatsu oriental bar massage for 60 minutes", "ashiatsu oriental bar massage for 75 minutes", "ashiatsu oriental bar massage for 90 minutes", "ashiatsu oriental bar massage for 120 minutes",
                         "jessner", "peptide", "lactic", "glycolic", "hydrating", "vitamin c", "pumpkin", "salicylic", "tca peels", "retinol treatments", "facial with extractions", "black facial", "microdermabrasion","facial",
                         "spray tanning-air brush"};
            Appointment app = new Appointment();
            Console.WriteLine("What can I do for you?");
            String answer = (Console.ReadLine().ToLower());
            for (int h = 0; h < 11; h++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        for (int k = 0; k < n.Length; k++)
                        {
                            if (answer.Contains(n[k]) && answer.Contains(a[i]) && answer.Contains(b[j]))
                            {
                                app.servicewcitywtime(a[i], b[j], n[k]);
                                return;
                            }
                        }
                        if (answer.Contains("women") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptwomenwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("child") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutchildwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("keratin") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutrelaxerkeratinwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("brazil") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutrelaxerbrazilwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("relaxer") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutrelaxerwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("condition") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutconditioningwcitywtime(a[i], b[j]);
                            return;
                        }
                        if ((answer.Contains("special") || (answer.Contains("up-do"))) && answer.Contains(a[i]) && (answer.Contains(b[j])))
                        {
                            app.apptspecialwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("consult") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptextensionconsultwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("implement") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptextensionimplementwcitywtime(a[i], b[j]);
                            return;
                        }
                        if ((answer.Contains("extension") || (answer.Contains("weaving"))) && answer.Contains(a[i]) && (answer.Contains(b[j])))
                        {
                            app.apptextensionwcitywtime(a[i], b[j]);
                            return;
                        }
                        if ((answer.Contains("cut")) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcutwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("touch") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.appttouchwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("color") && !(answer.Contains("system")) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptcolorwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("partial") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptpartialwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("highlight") && !(answer.Contains("partial")) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.appthighlightwcitywtime(a[i], b[j]);
                            return;
                        }
                        if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupanalysiswcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("application") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupapplicationwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("wedding") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupweddingwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("makeup") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmakeupwcitywtime(a[i], b[j]);
                            return;
                        }
                        for (int k = 0; k < e.Length; k++)
                        {
                            if (answer.Contains(e[k]) && answer.Contains(a[i]) && answer.Contains(b[j]))
                            {
                                app.apptreplaceservicewcitywtime(a[i], b[j], e[k]);
                                return;
                            }
                        }
                        if (answer.Contains("hair replace") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptreplacewcitywtime(a[i], b[j], e);
                            return;
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            for (int l = 0; l < m.Length; l++)
                            {
                                if ((answer.Contains(g[k])) && (answer.Contains(m[l])) && answer.Contains(a[i]) && (answer.Contains(b[j])))
                                {
                                    app.apptnailchoosewcitywtime(a[i], b[j], g[k], m[l]);
                                    Console.ReadLine();
                                    return;
                                }
                            }
                        }
                        for (int k = 0; k < g.Length; k++)
                        {
                            if ((answer.Contains(g[k])) && (answer.Contains(a[i])) && (answer.Contains(b[j])))
                            {
                                app.apptnailchoosemaniwcitywtime(a[i], b[j], g[k]);
                                Console.ReadLine();
                                return;
                            }
                        }
                        if (answer.Contains("nail") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptnailwcitywtime(a[i], b[j]);
                            return;
                        }
                        for (int k = 0; k < f.Length; k++)
                        {
                            if (answer.Contains(f[k]) && answer.Contains(a[i]) && answer.Contains(b[j]))
                            {
                                app.apptmassageservicewcitywtime(a[i], b[j], f[k], c);
                                return;
                            }
                        }
                        if (answer.Contains("massage") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptmassagewcitywtime(a[i], b[j], c);
                            return;
                        }
                        for (int k = 0; k < d.Length; k++)
                        {
                            if (answer.Contains(d[k]) && answer.Contains(a[i]) && answer.Contains(b[j]))
                            {
                                app.apptskinexfolservicewcitywtime(a[i], b[j], d[k]);
                                return;
                            }
                        }
                        if (answer.Contains("exfol") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptskinexfolwcitywtime(a[i], b[j], d);
                            return;
                        }
                        if (answer.Contains("back facial") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptbackfacialwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("microderm") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptskinfacialmicrodermwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("facial") && (answer.Contains("extract")) && answer.Contains(a[i]) && answer.Contains(b[i]))
                        {
                            app.apptskinfacialextractwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("facial") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptskinfacialwcitywtime(a[i], b[j]);
                            return;
                        }
                        if (answer.Contains("skin") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptskinwcitywtime(a[i], b[j], d);
                            return;
                        }
                        if (answer.Contains("tan") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.appttanwcitywtime(a[i], b[j]);
                            return;
                        }
                        if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptwcitywtime(a[i], b[j], c, d, e);
                            return;
                        }
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    for (int k = 0; k < n.Length; k++)
                    {
                        if (answer.Contains(n[k]) && answer.Contains(a[i]))
                        {
                            app.servicewtime(a[i], b, n[k]);
                            return;
                        }
                    }
                    if (answer.Contains("women") && answer.Contains(a[i]))
                    {
                        app.apptwomenwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("child") && answer.Contains(a[i]))
                    {
                        app.apptcutchildwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("keratin") && answer.Contains(a[i]))
                    {
                        app.apptcutrelaxerkeratinwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("brazil") && answer.Contains(a[i]))
                    {
                        app.apptcutrelaxerbrazilwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("relaxer") && answer.Contains(a[i]))
                    {
                        app.apptcutrelaxerwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("condition") && answer.Contains(a[i]))
                    {
                        app.apptcutconditioningwtime(a[i], b);
                        return;
                    }
                    if ((answer.Contains("special") || (answer.Contains("up-do"))) && (answer.Contains(a[i])))
                    {
                        app.apptspecialwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("consult") && answer.Contains(a[i]))
                    {
                        app.apptextensionconsultwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("implement") && answer.Contains(a[i]))
                    {
                        app.apptextensionimplementwtime(a[i], b);
                        return;
                    }
                    if ((answer.Contains("extension") || (answer.Contains("weaving"))) && (answer.Contains(a[i])))
                    {
                        app.apptextensionwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("cut") && answer.Contains(a[i]))
                    {
                        app.apptcutwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("touch") && answer.Contains(a[i]))
                    {
                        app.appttouchwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("color") && !(answer.Contains("system")) && answer.Contains(a[i]))
                    {
                        app.apptcolorwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("partial") && answer.Contains(a[i]))
                    {
                        app.apptpartialwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("highlight") && !(answer.Contains("partial")) && answer.Contains(a[i]))
                    {
                        app.appthighlightwtime(a[i], b);
                        return;
                    }
                    if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(a[i]))
                    {
                        app.apptmakeupanalysiswtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("application") && answer.Contains(a[i]))
                    {
                        app.apptmakeupapplicationwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("wedding") && answer.Contains(a[i]))
                    {
                        app.apptmakeupweddingwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("makeup") && answer.Contains(a[i]))
                    {
                        app.apptmakeupwtime(a[i], b);
                        return;
                    }
                    for (int k = 0; k < e.Length; k++)
                    {
                        if (answer.Contains(e[k]) && answer.Contains(a[i]))
                        {
                            app.apptreplaceservicewtime(a[i], b, e[k]);
                            return;
                        }
                    }
                    if (answer.Contains("hair replace") && answer.Contains(a[i]))
                    {
                        app.apptreplacewtime(a[i], b, e);
                        return;
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        for (int l = 0; l < m.Length; l++)
                        {
                            if ((answer.Contains(g[k])) && (answer.Contains(m[l])) && (answer.Contains(a[i])))
                            {
                                app.apptnailchoosewtime(a[i], b, g[k], m[l]);
                                Console.ReadLine();
                                return;
                            }
                        }
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        if ((answer.Contains(g[k])) && (answer.Contains(a[i])))
                        {
                            app.apptnailchoosemaniwtime(a[i], b, g[k]);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (answer.Contains("nail") && answer.Contains(a[i]))
                    {
                        app.apptnailwtime(a[i], b);
                        return;
                    }
                    for (int k = 0; k < f.Length; k++)
                    {
                        if (answer.Contains(f[k]) && answer.Contains(a[i]))
                        {
                            app.apptmassageservicewtime(a[i], b, f[k], c);
                            return;
                        }
                    }
                    if (answer.Contains("massage") && answer.Contains(a[i]))
                    {
                        app.apptmassagewtime(a[i], b, c);
                        return;
                    }
                    for (int k = 0; k < d.Length; k++)
                    {
                        if (answer.Contains(d[k]) && answer.Contains(a[i]))
                        {
                            app.apptskinexfolservicewtime(a[i], b, d[k]);
                            return;
                        }
                    }
                    if (answer.Contains("exfol") && answer.Contains(a[i]))
                    {
                        app.apptskinexfolwtime(a[i], b, d);
                        return;
                    }
                    if (answer.Contains("back facial") && answer.Contains(a[i]))
                    {
                        app.apptbackfacialwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("microderm") && answer.Contains(a[i]))
                    {
                        app.apptskinfacialmicrodermwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("facial") && (answer.Contains("extract")) && answer.Contains(a[i]))
                    {
                        app.apptskinfacialextractwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("facial") && answer.Contains(a[i]))
                    {
                        app.apptskinfacialwtime(a[i], b);
                        return;
                    }
                    if (answer.Contains("skin") && answer.Contains(a[i]))
                    {
                        app.apptskinwtime(a[i], b, d);
                        return;
                    }
                    if (answer.Contains("tan") && answer.Contains(a[i]))
                    {
                        app.appttanwtime(a[i], b);
                        return;
                    }
                    if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(a[i]))
                    {
                        app.apptwtime(a[i], b, c, d, e);
                        return;
                    }
                }
                for (int i = 0; i < b.Length; i++)
                {
                    for (int k = 0; k < n.Length; k++)
                    {
                        if (answer.Contains(n[k]) && answer.Contains(b[i]))
                        {
                            app.servicewcity(a, b[i], n[k]);
                            return;
                        }
                    }
                    if (answer.Contains("women") && answer.Contains(b[i]))
                    {
                        app.apptwomenwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("child") && answer.Contains(b[i]))
                    {
                        app.apptcutchildwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("keratin") && answer.Contains(b[i]))
                    {
                        app.apptcutrelaxerkeratinwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("brazil") && answer.Contains(b[i]))
                    {
                        app.apptcutrelaxerbrazilwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("relaxer") && answer.Contains(b[i]))
                    {
                        app.apptcutrelaxerwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("condition") && answer.Contains(b[i]))
                    {
                        app.apptcutconditioningwcity(a, b[i]);
                        return;
                    }
                    if ((answer.Contains("special") || (answer.Contains("up-do"))) && (answer.Contains(b[i])))
                    {
                        app.apptspecialwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("consult") && answer.Contains(b[i]))
                    {
                        app.apptextensionconsultwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("implement") && answer.Contains(b[i]))
                    {
                        app.apptextensionimplementwcity(a, b[i]);
                        return;
                    }
                    if ((answer.Contains("extension") || (answer.Contains("weaving"))) && (answer.Contains(b[i])))
                    {
                        app.apptextensionwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("cut") && answer.Contains(b[i]))
                    {
                        app.apptcutwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("touch") && answer.Contains(b[i]))
                    {
                        app.appttouchwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("color") && !(answer.Contains("system")) && answer.Contains(b[i]))
                    {
                        app.apptcolorwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("partial") && answer.Contains(b[i]))
                    {
                        app.apptpartialwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("highlight") && !(answer.Contains("partial")) && answer.Contains(b[i]))
                    {
                        app.appthighlightwcity(a, b[i]);
                        return;
                    }
                    if ((answer.Contains("analysis") || (answer.Contains("instruction"))) && answer.Contains(b[i]))
                    {
                        app.apptmakeupanalysiswcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("application") && answer.Contains(b[i]))
                    {
                        app.apptmakeupapplicationwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("wedding") && answer.Contains(b[i]))
                    {
                        app.apptmakeupweddingwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("makeup") && answer.Contains(b[i]))
                    {
                        app.apptmakeupwcity(a, b[i]);
                        return;
                    }
                    for (int k = 0; k < e.Length; k++)
                    {
                        if (answer.Contains(e[k]) && answer.Contains(b[i]))
                        {
                            app.apptreplaceservicewcity(a, b[i], e[k]);
                            return;
                        }
                    }
                    if (answer.Contains("hair replace") && answer.Contains(b[i]))
                    {
                        app.apptreplacewcity(a, b[i], e);
                        return;
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        for (int l = 0; l < m.Length; l++)
                        {
                            if ((answer.Contains(g[k])) && (answer.Contains(m[l])) && (answer.Contains(b[i])))
                            {
                                app.apptnailchoosewcity(a, b[i], g[k], m[l]);
                                Console.ReadLine();
                                return;
                            }
                        }
                    }
                    for (int k = 0; k < g.Length; k++)
                    {
                        if ((answer.Contains(g[k])) && (answer.Contains(b[i])))
                        {
                            app.apptnailchoosemaniwcity(a, b[i], g[k]);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (answer.Contains("nail") && answer.Contains(b[i]))
                    {
                        app.apptnailwcity(a, b[i]);
                        return;
                    }
                    for (int k = 0; k < f.Length; k++)
                    {
                        if (answer.Contains(f[k]) && answer.Contains(b[i]))
                        {
                            app.apptmassageservicewcity(a, b[i], f[k], c);
                            return;
                        }
                    }
                    if (answer.Contains("massage") && answer.Contains(b[i]))
                    {
                        app.apptmassagewcity(a, b[i], c);
                        return;
                    }
                    for (int k = 0; k < d.Length; k++)
                    {
                        if (answer.Contains(d[k]) && answer.Contains(b[i]))
                        {
                            app.apptskinexfolservicewcity(a, b[i], d[k]);
                            return;
                        }
                    }
                    if (answer.Contains("exfol") && answer.Contains(b[i]))
                    {
                        app.apptskinexfolwcity(a, b[i], d);
                        return;
                    }
                    if (answer.Contains("back facial") && answer.Contains(b[i]))
                    {
                        app.apptbackfacialwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("microderm") && answer.Contains(b[i]))
                    {
                        app.apptskinfacialmicrodermwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("facial") && (answer.Contains("extract")) && answer.Contains(b[i]))
                    {
                        app.apptskinfacialextractwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("facial") && answer.Contains(b[i]))
                    {
                        app.apptskinfacialwcity(a, b[i]);
                        return;
                    }
                    if (answer.Contains("skin") && answer.Contains(b[i]))
                    {
                        app.apptskinwcity(a, b[i], d);
                        return;
                    }
                    if (answer.Contains("tan") && answer.Contains(b[i]))
                    {
                        app.appttanwcity(a, b[i]);
                        return;
                    }
                    if ((answer.Contains("appoint") || answer.Contains("schedule") || answer.Contains("book")) && answer.Contains(b[i]))
                    {
                        app.apptwcity(a, b[i], c, d, e);
                        return;
                    }
                }
                for (int k = 0; k < n.Length; k++)
                {
                    if (answer.Contains(n[k]))
                    {
                        app.service(a, b, n[k]);
                        return;
                    }
                }
                if (answer.Contains("women"))
                {
                    app.apptwomen(a, b);
                    return;
                }
                if (answer.Contains("child"))
                {
                    app.apptcutchild(a, b);
                    return;
                }
                if (answer.Contains("keratin"))
                {
                    app.apptcutrelaxerkeratin(a, b);
                    return;
                }
                if (answer.Contains("brazil"))
                {
                    app.apptcutrelaxerbrazil(a, b);
                    return;
                }
                if (answer.Contains("relaxer"))
                {
                    app.apptcutrelaxer(a, b);
                    return;
                }
                if (answer.Contains("condition"))
                {
                    app.apptcutconditioning(a, b);
                    return;
                }
                if (answer.Contains("special") || (answer.Contains("up-do")))
                {
                    app.apptspecial(a, b);
                    return;
                }
                if (answer.Contains("consult"))
                {
                    app.apptextensionconsult(a, b);
                    return;
                }
                if (answer.Contains("implement"))
                {
                    app.apptextensionimplement(a, b);
                    return;
                }
                if (answer.Contains("extension") || answer.Contains("weaving"))
                {
                    app.apptextension(a, b);
                    return;
                }
                if (answer.Contains("cut"))
                {
                    app.apptcut(a, b);
                    return;
                }
                if (answer.Contains("touch"))
                {
                    app.appttouch(a, b);
                    return;
                }
                if (answer.Contains("color") && !(answer.Contains("system")))
                {
                    app.apptcolor(a, b);
                    return;
                }
                if (answer.Contains("partial"))
                {
                    app.apptpartial(a, b);
                    return;
                }
                if (answer.Contains("highlight") && !(answer.Contains("partial")))
                {
                    app.appthighlight(a, b);
                    return;
                }
                if (answer.Contains("analysis") || (answer.Contains("instruction")))
                {
                    app.apptmakeupanalysis(a, b);
                    return;
                }
                if (answer.Contains("application"))
                {
                    app.apptmakeupapplication(a, b);
                    return;
                }
                if (answer.Contains("wedding"))
                {
                    app.apptmakeupwedding(a, b);
                    return;
                }
                if (answer.Contains("makeup"))
                {
                    app.apptmakeup(a, b);
                    return;
                }
                for (int k = 0; k < e.Length; k++)
                {
                    if (answer.Contains(e[k]))
                    {
                        app.apptreplaceservice(a, b, e[k]);
                        return;
                    }
                }
                if (answer.Contains("hair replace"))
                {
                    app.apptreplace(a, b, e);
                    return;
                }
                for (int k = 0; k < g.Length; k++)
                {
                    for (int l = 0; l < m.Length; l++)
                    {
                        if ((answer.Contains(g[k])) && (answer.Contains(m[l])))
                        {
                            app.apptnailchoose(a, b, g[k], m[l]);
                            Console.ReadLine();
                            return;
                        }
                    }
                }
                for (int k = 0; k < g.Length; k++)
                {
                        if ((answer.Contains(g[k])))
                        {
                            app.apptnailchoosemani(a, b, g[k]);
                            Console.ReadLine();
                            return;
                        }
                }
                if (answer.Contains("nail"))
                {
                    app.apptnail(a, b);
                    return;
                }
                for (int k = 0; k < f.Length; k++)
                {
                    if (answer.Contains(f[k]))
                    {
                        app.apptmassageservice(a, b, f[k], c);
                        return;
                    }
                }
                if (answer.Contains("massage"))
                {
                    app.apptmassage(a, b, c);
                    return;
                }
                for (int k = 0; k < d.Length; k++)
                {
                    if (answer.Contains(d[k]))
                    {
                        app.apptskinexfolservice(a, b, d[k]);
                        return;
                    }
                }
                if (answer.Contains("exfol"))
                {
                    app.apptskinexfol(a, b, d);
                    return;
                }
                if (answer.Contains("back facial"))
                {
                    app.apptbackfacial(a, b);
                    return;
                }
                if (answer.Contains("microderm"))
                {
                    app.apptskinfacialmicroderm(a, b);
                    return;
                }
                if (answer.Contains("facial") && (answer.Contains("extract")))
                {
                    app.apptskinfacialextract(a, b);
                    return;
                }
                if (answer.Contains("facial"))
                {
                    app.apptskinfacial(a, b);
                    return;
                }
                if (answer.Contains("skin"))
                {
                    app.apptskin(a, b, d);
                    return;
                }
                if (answer.Contains("tan"))
                {
                    app.appttan(a, b);
                    return;
                }
                if (answer.Contains("appoint") || answer.Contains("schedule") || (answer.Contains("book")))
                {
                    app.appt(a, b, c, d, e);
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
                        app.appt(a, b, c, d, e);
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