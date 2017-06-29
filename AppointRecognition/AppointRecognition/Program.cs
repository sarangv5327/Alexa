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
            String[] a = { "9", "10", "11", "12", "1", "2", "3", "4", "5", "6" };
            String[] b = { "san francisco", "san jose", "santa clara", "oakland", "fremont", "cupertino", "dublin", "pleasanton", "san ramon", "livermore", "sunnyvale" };
            String[] c = { "15", "30", "45", "60", "75", "90", "120" };
            String[] d = { "jessner", "peptide", "lactic", "glycolic", "hydrating", "vitamin c", "pumpkin", "salicylic", "tca peels", "retinol treatments" };
            String[] e = { "consultation", "hair system", "system service and color", "system service", "system coloring", "system styling", "system repair", "cut-in personal system" };
            String[] f = { "swedish", "reflexology", "ashiatsu oriental bar", "shiatsu", "therapeutic", "sport", "medical", "hot stone" };
            Appointment app = new Appointment();
            Console.WriteLine("What can I do for you?");
            String answer = (Console.ReadLine().ToLower());
            for (int g = 0; g < 11; g++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
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
                        if (answer.Contains("replace") && answer.Contains(a[i]) && answer.Contains(b[j]))
                        {
                            app.apptreplacewcitywtime(a[i], b[j], e);
                            return;
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
                    if (answer.Contains("replace") && answer.Contains(a[i]))
                    {
                        app.apptreplacewtime(a[i], b, e);
                        return;
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
                    if (answer.Contains("replace") && answer.Contains(b[i]))
                    {
                        app.apptreplacewcity(a, b[i], e);
                        return;
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
                if (answer.Contains("replace"))
                {
                    app.apptreplace(a, b, e);
                    return;
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
                if (answer.Contains("exit") || (answer.Contains("end") || (answer.Contains("terminate")) || (answer.Contains("suspend"))))
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
                    if (answer2.Contains("exit") || (answer2.Contains("end") || (answer2.Contains("terminate")) || (answer2.Contains("suspend"))))
                    {
                        return;
                    }
                }
            }
        }
    }
}