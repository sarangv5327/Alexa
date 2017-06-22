using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointRecognition.Domain
{
    public class Appointment
    {
        public void appt(String[] appointimes, String[] locations, String[] massagetime, String[] exfol, String[] replacement)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            Console.WriteLine("Ok. What time would you want your appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Which of the following services is this appointment for : Haircuts, Hair Touchup, Hair Color, Hair Partial Highlight, Hair Highlight, Makeup, Hair Replacement, Nail Care, Massage, Skin Care, or Tanning?");
                            String service = (Console.ReadLine().ToLower());
                            if (service.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                                String cut = (Console.ReadLine().ToLower());
                                if (cut.Contains("women"))
                                {
                                    Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                                    String women = (Console.ReadLine().ToLower());
                                    if (women.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("cut"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                        String womencut = (Console.ReadLine().ToLower());
                                        if (womencut.Contains("blow"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                if (cut.Contains("child"))
                                {
                                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("relaxer"))
                                {
                                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                    String relaxer = (Console.ReadLine().ToLower());
                                    if (relaxer.Contains("keratin"))
                                    {
                                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (relaxer.Contains("brazil"))
                                    {
                                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (cut.Contains("condition"))
                                {
                                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("special") || cut.Contains("up"))
                                {
                                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("extension") || cut.Contains("weaving"))
                                {
                                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                    String extension = (Console.ReadLine().ToLower());
                                    if (extension.Contains("consultation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (extension.Contains("implementation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("touch"))
                            {
                                Console.WriteLine("Ok. Would you like the touch-up with a Cut, Blow-Dry, Flat/Curling Iron, or Thermal Press?");
                                String touchup = (Console.ReadLine().ToLower());
                                if (touchup.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String touchupcut = (Console.ReadLine().ToLower());
                                    if (touchupcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("color"))
                            {
                                Console.WriteLine("Ok. Would you like the Hair Coloring with a Haircut, Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String color = (Console.ReadLine().ToLower());
                                if (color.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String colorcut = (Console.ReadLine().ToLower());
                                    if (colorcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("partial"))
                            {
                                Console.WriteLine("Ok. Would you like the Partial Highlight with a Haircut, Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String partial = (Console.ReadLine().ToLower());
                                if (partial.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String partialcut = (Console.ReadLine().ToLower());
                                    if (partialcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("highlight"))
                            {
                                Console.WriteLine("Ok. Would you like the Hair Highlight with a Haircut, Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String full = (Console.ReadLine().ToLower());
                                if (full.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String fullcut = (Console.ReadLine().ToLower());
                                    if (fullcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("makeup"))
                            {
                                Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                                String makeup = (Console.ReadLine().ToLower());
                                if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("app"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("wedding"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                return;
                            }
                            if (service.Contains("replace"))
                            {
                                Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                                String replace = (Console.ReadLine().ToLower());
                                for (int l = 0; l < replacement.Length; l++)
                                    if (replace.Contains(replacement[l]))
                                    {
                                        Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                return;
                            }
                            if (service.Contains("nail"))
                            {
                                Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                                String nail = (Console.ReadLine().ToLower());
                                if (nail.Contains("mani") && nail.Contains("pedi"))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                                    String manipedi = (Console.ReadLine().ToLower());
                                    if (manipedi.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (manipedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("mani"))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                    String mani = (Console.ReadLine().ToLower());
                                    if (mani.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (mani.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pedi"))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                    String pedi = (Console.ReadLine().ToLower());
                                    if (pedi.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("polish"))
                                {
                                    Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                    String polish = (Console.ReadLine().ToLower());
                                    if (polish.Contains("hands") && polish.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("hands"))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("full"))
                                {
                                    Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                    String acrylicfull = (Console.ReadLine().ToLower());
                                    if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("hands"))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("acrylic"))
                                {
                                    Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                    String acrylicfill = (Console.ReadLine().ToLower());
                                    if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("hands"))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pink") || nail.Contains("white"))
                                {
                                    Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                    String pinkwhite = (Console.ReadLine().ToLower());
                                    if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("hands"))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("replace"))
                                {
                                    Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("gel"))
                                {
                                    Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String gel = (Console.ReadLine().ToLower());
                                    if (gel.Contains("hands") && gel.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("hands"))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("silk"))
                                {
                                    Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String silk = (Console.ReadLine().ToLower());
                                    if (silk.Contains("hands") && silk.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a SIlk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("hands"))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("french") && nail.Contains("full"))
                                {
                                    Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                return;
                            }
                            if (service.Contains("massage"))
                            {
                                Console.WriteLine("Ok. Would you like a Swedish, Reflexology, Shiatsu, Therapeutic, Sport, Medical, Hot Stone, or Ashiatsu Oriental Bar Massage?");
                                String massage = (Console.ReadLine().ToLower());
                                if (massage.Contains("swed") || massage.Contains("reflex") || massage.Contains("shiatsu") || massage.Contains("therap") || massage.Contains("sport") || massage.Contains("medi") || massage.Contains("hot") || massage.Contains("ashiatsu"))
                                {
                                    Console.WriteLine("Ok. Would you like your massage to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                                    String timemassage = (Console.ReadLine().ToLower());
                                    for (int k = 0; k < massagetime.Length; k++)
                                    {
                                        if (timemassage.Contains(massagetime[k]))
                                        {
                                            Console.WriteLine("Thank you. You have a " + massage + " in " + place + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                return;
                            }
                            if (service.Contains("skin"))
                            {
                                Console.WriteLine("Ok. Would you like an Advanced Exfoliation or Facial?");
                                String skin = (Console.ReadLine().ToLower());
                                if (skin.Contains("exfol"))
                                {
                                    Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                                    String exfoli = (Console.ReadLine().ToLower());
                                    for (int m = 0; m < exfol.Length; m++)
                                    {
                                        if (exfoli.Contains(exfol[m]))
                                        {
                                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + time + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                if (skin.Contains("facial"))
                                {
                                    Console.WriteLine("Ok. Would you like a Facial With Extraction, Back Facial, or Microdermabrasion");
                                    String facial = (Console.ReadLine().ToLower());
                                    if (facial.Contains("extraction"))
                                    {
                                        Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("back"))
                                    {
                                        Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("micro"))
                                    {
                                        Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + time + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("tan"))
                            {
                                Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, I do not offer that service.");
                                Console.ReadLine();
                            return;
                            }
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }
    }
}