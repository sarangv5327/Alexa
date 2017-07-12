using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointRecognition.Domain
{
    public class Appointment
    {
        public void service(String[] appointimes, String[] locations, String service, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + service + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your " + service + "?");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your " + service + "?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a " + service + " in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void servicewdate(String[] appointimes, String[] locations, String service, String date)
        {
            Console.WriteLine("Ok. What time would you want your " + service + "?");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + service + "?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a " + service + " in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void servicewtime(String time, String[] locations, String service, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + service + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + service + "?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a " + service + " in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void servicewtimewdate(String time, String[] locations, String service, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your " + service + "?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a " + service + " in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void servicewcity(String[] appointimes, String place, String service, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + service + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your " + service + "?");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a " + service + " in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void servicewcitywdate(String[] appointimes, String place, String service, String date)
        {
            Console.WriteLine("Ok. What time would you want your " + service + "?");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a " + service + " in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void servicewcitywtime(String time, String place, String service, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + service + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a " + service + " in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void servicewcitywtimewdate(String time, String place, String service, String date)
        {
            Console.WriteLine("Thank you. You have a " + service + " in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void appt(String[] appointimes, String[] locations, String[] massagetime, String[] exfol, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
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
                                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (women.Contains("curl"))
                                            {
                                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (women.Contains("cut"))
                                            {
                                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                                String womencut = (Console.ReadLine().ToLower());
                                                if (womencut.Contains("blow"))
                                                {
                                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                    Console.ReadLine();
                                                }
                                                if (womencut.Contains("curl"))
                                                {
                                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                    Console.ReadLine();
                                                }
                                                if (womencut.Contains("thermal"))
                                                {
                                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                    Console.ReadLine();
                                                }
                                            }
                                        }
                                        if (cut.Contains("child"))
                                        {
                                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (cut.Contains("relaxer"))
                                        {
                                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                            String relaxer = (Console.ReadLine().ToLower());
                                            if (relaxer.Contains("keratin"))
                                            {
                                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (relaxer.Contains("brazil"))
                                            {
                                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (cut.Contains("condition"))
                                        {
                                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (cut.Contains("special") || cut.Contains("up"))
                                        {
                                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (cut.Contains("extension") || cut.Contains("weaving"))
                                        {
                                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                            String extension = (Console.ReadLine().ToLower());
                                            if (extension.Contains("consultation"))
                                            {
                                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (extension.Contains("implementation"))
                                            {
                                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (touchup.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (touchup.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (touchup.Contains("cut"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                            String touchupcut = (Console.ReadLine().ToLower());
                                            if (touchupcut.Contains("blow"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (touchupcut.Contains("curl"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (touchupcut.Contains("thermal"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (color.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (color.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (color.Contains("cut"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                            String colorcut = (Console.ReadLine().ToLower());
                                            if (colorcut.Contains("blow"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (colorcut.Contains("curl"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (colorcut.Contains("thermal"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (partial.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (partial.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (partial.Contains("cut"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                            String partialcut = (Console.ReadLine().ToLower());
                                            if (partialcut.Contains("blow"))
                                            {
                                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (partialcut.Contains("curl"))
                                            {
                                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (partialcut.Contains("thermal"))
                                            {
                                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (full.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (full.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (full.Contains("cut"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                            String fullcut = (Console.ReadLine().ToLower());
                                            if (fullcut.Contains("blow"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (fullcut.Contains("curl"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (fullcut.Contains("thermal"))
                                            {
                                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (makeup.Contains("app"))
                                        {
                                            Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (makeup.Contains("wedding"))
                                        {
                                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                                Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                                Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (manipedi.Contains("spa"))
                                            {
                                                Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("mani") && !(nail.Contains("pedi")))
                                        {
                                            Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                            String mani = (Console.ReadLine().ToLower());
                                            if (mani.Contains("french"))
                                            {
                                                Console.WriteLine("Thank you. You have a French Manicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (mani.Contains("spa"))
                                            {
                                                Console.WriteLine("Thank you. You have a Spa Manicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("pedi") && !(nail.Contains("mani")))
                                        {
                                            Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                            String pedi = (Console.ReadLine().ToLower());
                                            if (pedi.Contains("french"))
                                            {
                                                Console.WriteLine("Thank you. You have a French Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (pedi.Contains("spa"))
                                            {
                                                Console.WriteLine("Thank you. You have a Spa Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("polish"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                            String polish = (Console.ReadLine().ToLower());
                                            if (polish.Contains("hands") && polish.Contains("feet"))
                                            {
                                                Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (polish.Contains("hands") && !(polish.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Polish Change on Hands in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (polish.Contains("feet") && !(polish.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Polish Change on Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("full") && (nail.Contains("acrylic")))
                                        {
                                            Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                            String acrylicfull = (Console.ReadLine().ToLower());
                                            if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                            {
                                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                            {
                                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("acrylic") && (nail.Contains("fill")))
                                        {
                                            Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                            String acrylicfill = (Console.ReadLine().ToLower());
                                            if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                            {
                                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                            {
                                                Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("pink") || nail.Contains("white"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                            String pinkwhite = (Console.ReadLine().ToLower());
                                            if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                            {
                                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                            {
                                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (nail.Contains("replace"))
                                        {
                                            Console.WriteLine("Thank you. You have a Nail Replacement in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (nail.Contains("gel"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                            String gel = (Console.ReadLine().ToLower());
                                            if (gel.Contains("hands") && gel.Contains("feet"))
                                            {
                                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (gel.Contains("hands") && !(gel.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (gel.Contains("feet") && !(gel.Contains("hands")))
                                            {
                                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }

                                        }
                                        if (nail.Contains("silk"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                            String silk = (Console.ReadLine().ToLower());
                                            if (silk.Contains("hands") && silk.Contains("feet"))
                                            {
                                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (silk.Contains("hands") && !(silk.Contains("feet")))
                                            {
                                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (silk.Contains("feet") && !(silk.Contains("hands")))
                                            {
                                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }

                                        }
                                        if (nail.Contains("french") && nail.Contains("full"))
                                        {
                                            Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (nail.Contains("french") && !(nail.Contains("full")))
                                        {
                                            Console.WriteLine("Thank you. You have a French Fill Nail Care in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
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
                                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                                Console.WriteLine("Thank you. You have a Facial With Extraction in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (facial.Contains("back"))
                                            {
                                                Console.WriteLine("Thank you. You have a Back Facial in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (facial.Contains("micro"))
                                            {
                                                Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                        return;
                                    }
                                    if (service.Contains("tan"))
                                    {
                                        Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwdate(String[] appointimes, String[] locations, String[] massagetime, String[] exfol, String[] replacement, String date)
        {
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
                                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("cut"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                        String womencut = (Console.ReadLine().ToLower());
                                        if (womencut.Contains("blow"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                if (cut.Contains("child"))
                                {
                                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("relaxer"))
                                {
                                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                    String relaxer = (Console.ReadLine().ToLower());
                                    if (relaxer.Contains("keratin"))
                                    {
                                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (relaxer.Contains("brazil"))
                                    {
                                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (cut.Contains("condition"))
                                {
                                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("special") || cut.Contains("up"))
                                {
                                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("extension") || cut.Contains("weaving"))
                                {
                                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                    String extension = (Console.ReadLine().ToLower());
                                    if (extension.Contains("consultation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (extension.Contains("implementation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String touchupcut = (Console.ReadLine().ToLower());
                                    if (touchupcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String colorcut = (Console.ReadLine().ToLower());
                                    if (colorcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String partialcut = (Console.ReadLine().ToLower());
                                    if (partialcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String fullcut = (Console.ReadLine().ToLower());
                                    if (fullcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("app"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("wedding"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (manipedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("mani") && !(nail.Contains("pedi")))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                    String mani = (Console.ReadLine().ToLower());
                                    if (mani.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Manicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (mani.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pedi") && !(nail.Contains("mani")))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                    String pedi = (Console.ReadLine().ToLower());
                                    if (pedi.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("polish"))
                                {
                                    Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                    String polish = (Console.ReadLine().ToLower());
                                    if (polish.Contains("hands") && polish.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("hands") && !(polish.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("feet") && !(polish.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("full") && (nail.Contains("acrylic")))
                                {
                                    Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                    String acrylicfull = (Console.ReadLine().ToLower());
                                    if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("acrylic") && (nail.Contains("fill")))
                                {
                                    Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                    String acrylicfill = (Console.ReadLine().ToLower());
                                    if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pink") || nail.Contains("white"))
                                {
                                    Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                    String pinkwhite = (Console.ReadLine().ToLower());
                                    if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("replace"))
                                {
                                    Console.WriteLine("Thank you. You have a Nail Replacement in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("gel"))
                                {
                                    Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String gel = (Console.ReadLine().ToLower());
                                    if (gel.Contains("hands") && gel.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("hands") && !(gel.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("feet") && !(gel.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("silk"))
                                {
                                    Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String silk = (Console.ReadLine().ToLower());
                                    if (silk.Contains("hands") && silk.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("hands") && !(silk.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("feet") && !(silk.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("french") && nail.Contains("full"))
                                {
                                    Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("french") && !(nail.Contains("full")))
                                {
                                    Console.WriteLine("Thank you. You have a French Fill Nail Care in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + appointimes[i] + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
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
                                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a Facial With Extraction in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("back"))
                                    {
                                        Console.WriteLine("Thank you. You have a Back Facial in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("micro"))
                                    {
                                        Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("tan"))
                            {
                                Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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



        public void apptwcity(String[] appointimes, String place, String[] massagetime, String[] exfol, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
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
                                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("cut"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                        String womencut = (Console.ReadLine().ToLower());
                                        if (womencut.Contains("blow"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                if (cut.Contains("child"))
                                {
                                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("relaxer"))
                                {
                                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                    String relaxer = (Console.ReadLine().ToLower());
                                    if (relaxer.Contains("keratin"))
                                    {
                                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (relaxer.Contains("brazil"))
                                    {
                                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (cut.Contains("condition"))
                                {
                                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("special") || cut.Contains("up"))
                                {
                                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("extension") || cut.Contains("weaving"))
                                {
                                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                    String extension = (Console.ReadLine().ToLower());
                                    if (extension.Contains("consultation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (extension.Contains("implementation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String touchupcut = (Console.ReadLine().ToLower());
                                    if (touchupcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String colorcut = (Console.ReadLine().ToLower());
                                    if (colorcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String partialcut = (Console.ReadLine().ToLower());
                                    if (partialcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String fullcut = (Console.ReadLine().ToLower());
                                    if (fullcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("app"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("wedding"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (manipedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("mani") && !(nail.Contains("pedi")))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                    String mani = (Console.ReadLine().ToLower());
                                    if (mani.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (mani.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pedi") && !(nail.Contains("mani")))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                    String pedi = (Console.ReadLine().ToLower());
                                    if (pedi.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("polish"))
                                {
                                    Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                    String polish = (Console.ReadLine().ToLower());
                                    if (polish.Contains("hands") && polish.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("hands") && !(polish.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("feet") && !(polish.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("full") && (nail.Contains("acrylic")))
                                {
                                    Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                    String acrylicfull = (Console.ReadLine().ToLower());
                                    if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("acrylic") && (nail.Contains("fill")))
                                {
                                    Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                    String acrylicfill = (Console.ReadLine().ToLower());
                                    if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pink") || nail.Contains("white"))
                                {
                                    Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                    String pinkwhite = (Console.ReadLine().ToLower());
                                    if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("replace"))
                                {
                                    Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("gel"))
                                {
                                    Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String gel = (Console.ReadLine().ToLower());
                                    if (gel.Contains("hands") && gel.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("hands") && !(gel.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("feet") && !(gel.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("silk"))
                                {
                                    Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String silk = (Console.ReadLine().ToLower());
                                    if (silk.Contains("hands") && silk.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("hands") && !(silk.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("feet") && !(silk.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("french") && nail.Contains("full"))
                                {
                                    Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("french") && !(nail.Contains("full")))
                                {
                                    Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + appointimes[i] + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
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
                                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("back"))
                                    {
                                        Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("micro"))
                                    {
                                        Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("tan"))
                            {
                                Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwcitywdate(String[] appointimes, String place, String[] massagetime, String[] exfol, String[] replacement, String date)
        {
            Console.WriteLine("Ok. What time would you want your appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
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
                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String womencut = (Console.ReadLine().ToLower());
                                if (womencut.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                        }
                        if (cut.Contains("child"))
                        {
                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("relaxer"))
                        {
                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                            String relaxer = (Console.ReadLine().ToLower());
                            if (relaxer.Contains("keratin"))
                            {
                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (relaxer.Contains("brazil"))
                            {
                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (cut.Contains("condition"))
                        {
                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("special") || cut.Contains("up"))
                        {
                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("extension") || cut.Contains("weaving"))
                        {
                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                            String extension = (Console.ReadLine().ToLower());
                            if (extension.Contains("consultation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (extension.Contains("implementation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String touchupcut = (Console.ReadLine().ToLower());
                            if (touchupcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (touchupcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (touchupcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String colorcut = (Console.ReadLine().ToLower());
                            if (colorcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (colorcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (colorcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String partialcut = (Console.ReadLine().ToLower());
                            if (partialcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (partialcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (partialcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String fullcut = (Console.ReadLine().ToLower());
                            if (fullcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (fullcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (fullcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (makeup.Contains("app"))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (makeup.Contains("wedding"))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (manipedi.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("mani") && !(nail.Contains("pedi")))
                        {
                            Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                            String mani = (Console.ReadLine().ToLower());
                            if (mani.Contains("french"))
                            {
                                Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (mani.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("pedi") && !(nail.Contains("mani")))
                        {
                            Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                            String pedi = (Console.ReadLine().ToLower());
                            if (pedi.Contains("french"))
                            {
                                Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pedi.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("polish"))
                        {
                            Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                            String polish = (Console.ReadLine().ToLower());
                            if (polish.Contains("hands") && polish.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (polish.Contains("hands") && !(polish.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (polish.Contains("feet") && !(polish.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("full") && (nail.Contains("acrylic")))
                        {
                            Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                            String acrylicfull = (Console.ReadLine().ToLower());
                            if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("acrylic") && (nail.Contains("fill")))
                        {
                            Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                            String acrylicfill = (Console.ReadLine().ToLower());
                            if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("pink") || nail.Contains("white"))
                        {
                            Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                            String pinkwhite = (Console.ReadLine().ToLower());
                            if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("replace"))
                        {
                            Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (nail.Contains("gel"))
                        {
                            Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                            String gel = (Console.ReadLine().ToLower());
                            if (gel.Contains("hands") && gel.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (gel.Contains("hands") && !(gel.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (gel.Contains("feet") && !(gel.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }

                        }
                        if (nail.Contains("silk"))
                        {
                            Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                            String silk = (Console.ReadLine().ToLower());
                            if (silk.Contains("hands") && silk.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (silk.Contains("hands") && !(silk.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (silk.Contains("feet") && !(silk.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }

                        }
                        if (nail.Contains("french") && nail.Contains("full"))
                        {
                            Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (nail.Contains("french") && !(nail.Contains("full")))
                        {
                            Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + appointimes[i] + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
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
                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (facial.Contains("back"))
                            {
                                Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (facial.Contains("micro"))
                            {
                                Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        return;
                    }
                    if (service.Contains("tan"))
                    {
                        Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwtime(String time, String[] locations, String[] massagetime, String[] exfol, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
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
                                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("cut"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                        String womencut = (Console.ReadLine().ToLower());
                                        if (womencut.Contains("blow"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                if (cut.Contains("child"))
                                {
                                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("relaxer"))
                                {
                                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                    String relaxer = (Console.ReadLine().ToLower());
                                    if (relaxer.Contains("keratin"))
                                    {
                                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (relaxer.Contains("brazil"))
                                    {
                                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (cut.Contains("condition"))
                                {
                                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("special") || cut.Contains("up"))
                                {
                                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (cut.Contains("extension") || cut.Contains("weaving"))
                                {
                                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                    String extension = (Console.ReadLine().ToLower());
                                    if (extension.Contains("consultation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (extension.Contains("implementation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (touchup.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String touchupcut = (Console.ReadLine().ToLower());
                                    if (touchupcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (touchupcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (color.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String colorcut = (Console.ReadLine().ToLower());
                                    if (colorcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (colorcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (partial.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String partialcut = (Console.ReadLine().ToLower());
                                    if (partialcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (partialcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (full.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String fullcut = (Console.ReadLine().ToLower());
                                    if (fullcut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (fullcut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("app"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (makeup.Contains("wedding"))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (manipedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("mani") && !(nail.Contains("pedi")))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                    String mani = (Console.ReadLine().ToLower());
                                    if (mani.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Manicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (mani.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Manicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pedi") && !(nail.Contains("mani")))
                                {
                                    Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                    String pedi = (Console.ReadLine().ToLower());
                                    if (pedi.Contains("french"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pedi.Contains("spa"))
                                    {
                                        Console.WriteLine("Thank you. You have a Spa Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("polish"))
                                {
                                    Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                    String polish = (Console.ReadLine().ToLower());
                                    if (polish.Contains("hands") && polish.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("hands") && !(polish.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (polish.Contains("feet") && !(polish.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Polish Change on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("full") && (nail.Contains("acrylic")))
                                {
                                    Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                    String acrylicfull = (Console.ReadLine().ToLower());
                                    if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("acrylic") && (nail.Contains("fill")))
                                {
                                    Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                    String acrylicfill = (Console.ReadLine().ToLower());
                                    if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("pink") || nail.Contains("white"))
                                {
                                    Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                    String pinkwhite = (Console.ReadLine().ToLower());
                                    if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                if (nail.Contains("replace"))
                                {
                                    Console.WriteLine("Thank you. You have a Nail Replacement in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("gel"))
                                {
                                    Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String gel = (Console.ReadLine().ToLower());
                                    if (gel.Contains("hands") && gel.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("hands") && !(gel.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (gel.Contains("feet") && !(gel.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("silk"))
                                {
                                    Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                    String silk = (Console.ReadLine().ToLower());
                                    if (silk.Contains("hands") && silk.Contains("feet"))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("hands") && !(silk.Contains("feet")))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (silk.Contains("feet") && !(silk.Contains("hands")))
                                    {
                                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }

                                }
                                if (nail.Contains("french") && nail.Contains("full"))
                                {
                                    Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (nail.Contains("french") && !(nail.Contains("full")))
                                {
                                    Console.WriteLine("Thank you. You have a French Fill Nail Care in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + time + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
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
                                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                        Console.WriteLine("Thank you. You have a Facial With Extraction in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("back"))
                                    {
                                        Console.WriteLine("Thank you. You have a Back Facial in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (facial.Contains("micro"))
                                    {
                                        Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                                return;
                            }
                            if (service.Contains("tan"))
                            {
                                Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwtimewdate(String time, String[] locations, String[] massagetime, String[] exfol, String[] replacement, String date)
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
                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String womencut = (Console.ReadLine().ToLower());
                                if (womencut.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                        }
                        if (cut.Contains("child"))
                        {
                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("relaxer"))
                        {
                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                            String relaxer = (Console.ReadLine().ToLower());
                            if (relaxer.Contains("keratin"))
                            {
                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (relaxer.Contains("brazil"))
                            {
                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (cut.Contains("condition"))
                        {
                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("special") || cut.Contains("up"))
                        {
                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("extension") || cut.Contains("weaving"))
                        {
                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                            String extension = (Console.ReadLine().ToLower());
                            if (extension.Contains("consultation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (extension.Contains("implementation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String touchupcut = (Console.ReadLine().ToLower());
                            if (touchupcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (touchupcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (touchupcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String colorcut = (Console.ReadLine().ToLower());
                            if (colorcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (colorcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (colorcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String partialcut = (Console.ReadLine().ToLower());
                            if (partialcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (partialcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (partialcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String fullcut = (Console.ReadLine().ToLower());
                            if (fullcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (fullcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (fullcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (makeup.Contains("app"))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (makeup.Contains("wedding"))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (manipedi.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("mani") && !(nail.Contains("pedi")))
                        {
                            Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                            String mani = (Console.ReadLine().ToLower());
                            if (mani.Contains("french"))
                            {
                                Console.WriteLine("Thank you. You have a French Manicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (mani.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Manicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("pedi") && !(nail.Contains("mani")))
                        {
                            Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                            String pedi = (Console.ReadLine().ToLower());
                            if (pedi.Contains("french"))
                            {
                                Console.WriteLine("Thank you. You have a French Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pedi.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("polish"))
                        {
                            Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                            String polish = (Console.ReadLine().ToLower());
                            if (polish.Contains("hands") && polish.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (polish.Contains("hands") && !(polish.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (polish.Contains("feet") && !(polish.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("full") && (nail.Contains("acrylic")))
                        {
                            Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                            String acrylicfull = (Console.ReadLine().ToLower());
                            if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("acrylic") && (nail.Contains("fill")))
                        {
                            Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                            String acrylicfill = (Console.ReadLine().ToLower());
                            if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("pink") || nail.Contains("white"))
                        {
                            Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                            String pinkwhite = (Console.ReadLine().ToLower());
                            if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("replace"))
                        {
                            Console.WriteLine("Thank you. You have a Nail Replacement in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (nail.Contains("gel"))
                        {
                            Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                            String gel = (Console.ReadLine().ToLower());
                            if (gel.Contains("hands") && gel.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (gel.Contains("hands") && !(gel.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (gel.Contains("feet") && !(gel.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }

                        }
                        if (nail.Contains("silk"))
                        {
                            Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                            String silk = (Console.ReadLine().ToLower());
                            if (silk.Contains("hands") && silk.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (silk.Contains("hands") && !(silk.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (silk.Contains("feet") && !(silk.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }

                        }
                        if (nail.Contains("french") && nail.Contains("full"))
                        {
                            Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (nail.Contains("french") && !(nail.Contains("full")))
                        {
                            Console.WriteLine("Thank you. You have a French Fill Nail Care in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
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
                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a Facial With Extraction in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (facial.Contains("back"))
                            {
                                Console.WriteLine("Thank you. You have a Back Facial in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (facial.Contains("micro"))
                            {
                                Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        return;
                    }
                    if (service.Contains("tan"))
                    {
                        Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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



        public void apptwcitywtime(String time, String place, String[] massagetime, String[] exfol, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
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
                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String womencut = (Console.ReadLine().ToLower());
                                if (womencut.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                        }
                        if (cut.Contains("child"))
                        {
                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("relaxer"))
                        {
                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                            String relaxer = (Console.ReadLine().ToLower());
                            if (relaxer.Contains("keratin"))
                            {
                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (relaxer.Contains("brazil"))
                            {
                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (cut.Contains("condition"))
                        {
                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("special") || cut.Contains("up"))
                        {
                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (cut.Contains("extension") || cut.Contains("weaving"))
                        {
                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                            String extension = (Console.ReadLine().ToLower());
                            if (extension.Contains("consultation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (extension.Contains("implementation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Touchup and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Touchup and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Touchup and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (touchup.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String touchupcut = (Console.ReadLine().ToLower());
                            if (touchupcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (touchupcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (touchupcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Touchup and Haircut with Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Coloring and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Coloring and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Coloring and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (color.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Coloring and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String colorcut = (Console.ReadLine().ToLower());
                            if (colorcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (colorcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (colorcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Coloring and Haircut with Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Partial Highlight and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Partial Highlight and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Partial Highlight and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (partial.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Partial Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String partialcut = (Console.ReadLine().ToLower());
                            if (partialcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (partialcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (partialcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Partial Highlight and Haircut with Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Hair Highlight and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Highlight and Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Hair Highlight and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (full.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Hair Highlight and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String fullcut = (Console.ReadLine().ToLower());
                            if (fullcut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (fullcut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (fullcut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Hair Highlight and Haircut with Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (makeup.Contains("app"))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (makeup.Contains("wedding"))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (manipedi.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("mani") && !(nail.Contains("pedi")))
                        {
                            Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                            String mani = (Console.ReadLine().ToLower());
                            if (mani.Contains("french"))
                            {
                                Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (mani.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("pedi") && !(nail.Contains("mani")))
                        {
                            Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                            String pedi = (Console.ReadLine().ToLower());
                            if (pedi.Contains("french"))
                            {
                                Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pedi.Contains("spa"))
                            {
                                Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("polish"))
                        {
                            Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                            String polish = (Console.ReadLine().ToLower());
                            if (polish.Contains("hands") && polish.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (polish.Contains("hands") && !(polish.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (polish.Contains("feet") && !(polish.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("full") && (nail.Contains("acrylic")))
                        {
                            Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                            String acrylicfull = (Console.ReadLine().ToLower());
                            if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("acrylic") && (nail.Contains("fill")))
                        {
                            Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                            String acrylicfill = (Console.ReadLine().ToLower());
                            if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("pink") || nail.Contains("white"))
                        {
                            Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                            String pinkwhite = (Console.ReadLine().ToLower());
                            if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        if (nail.Contains("replace"))
                        {
                            Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (nail.Contains("gel"))
                        {
                            Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                            String gel = (Console.ReadLine().ToLower());
                            if (gel.Contains("hands") && gel.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (gel.Contains("hands") && !(gel.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (gel.Contains("feet") && !(gel.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }

                        }
                        if (nail.Contains("silk"))
                        {
                            Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                            String silk = (Console.ReadLine().ToLower());
                            if (silk.Contains("hands") && silk.Contains("feet"))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (silk.Contains("hands") && !(silk.Contains("feet")))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (silk.Contains("feet") && !(silk.Contains("hands")))
                            {
                                Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }

                        }
                        if (nail.Contains("french") && nail.Contains("full"))
                        {
                            Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (nail.Contains("french") && !(nail.Contains("full")))
                        {
                            Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + time + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
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
                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (facial.Contains("back"))
                            {
                                Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (facial.Contains("micro"))
                            {
                                Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                        return;
                    }
                    if (service.Contains("tan"))
                    {
                        Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwcitywtimewdate(String time, String place, String[] massagetime, String[] exfol, String[] replacement, String date)
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
                    Console.WriteLine("Ok. Would you like the Hair Touchup and Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
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
                if (nail.Contains("mani") && !(nail.Contains("pedi")))
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
                if (nail.Contains("pedi") && !(nail.Contains("mani")))
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
                    if (polish.Contains("hands") && !(polish.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (polish.Contains("feet") && !(polish.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                }
                if (nail.Contains("full") && (nail.Contains("acrylic")))
                {
                    Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                    String acrylicfull = (Console.ReadLine().ToLower());
                    if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                    {
                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                    {
                        Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                }
                if (nail.Contains("acrylic") && (nail.Contains("fill")))
                {
                    Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                    String acrylicfill = (Console.ReadLine().ToLower());
                    if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                    {
                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
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
                    if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
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
                    if (gel.Contains("hands") && !(gel.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (gel.Contains("feet") && !(gel.Contains("hands")))
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
                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (silk.Contains("hands") && !(silk.Contains("feet")))
                    {
                        Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (silk.Contains("feet") && !(silk.Contains("hands")))
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
                if (nail.Contains("french") && !(nail.Contains("full")))
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
                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
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



        public void apptcut(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your haircut? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your haircut?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                                    String cut = (Console.ReadLine().ToLower());
                                    if (cut.Contains("women"))
                                    {
                                        Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                                        String women = (Console.ReadLine().ToLower());
                                        if (women.Contains("blow"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (women.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (women.Contains("cut"))
                                        {
                                            Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                            String womencut = (Console.ReadLine().ToLower());
                                            if (womencut.Contains("no"))
                                            {
                                                Console.WriteLine("Thank you. You have a Women's Haircut in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (womencut.Contains("blow"))
                                            {
                                                Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (womencut.Contains("curl"))
                                            {
                                                Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                            if (womencut.Contains("thermal"))
                                            {
                                                Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                    }
                                    if (cut.Contains("child"))
                                    {
                                        Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (cut.Contains("relaxer"))
                                    {
                                        Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                        String relaxer = (Console.ReadLine().ToLower());
                                        if (relaxer.Contains("keratin"))
                                        {
                                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (relaxer.Contains("brazil"))
                                        {
                                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (cut.Contains("condition"))
                                    {
                                        Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (cut.Contains("special") || cut.Contains("up"))
                                    {
                                        Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (cut.Contains("extension") || cut.Contains("weaving"))
                                    {
                                        Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                        String extension = (Console.ReadLine().ToLower());
                                        if (extension.Contains("consultation"))
                                        {
                                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (extension.Contains("implementation"))
                                        {
                                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your haircut? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your haircut?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                            String cut = (Console.ReadLine().ToLower());
                            if (cut.Contains("women"))
                            {
                                Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                                String women = (Console.ReadLine().ToLower());
                                if (women.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (women.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (women.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String womencut = (Console.ReadLine().ToLower());
                                    if (womencut.Contains("no"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            if (cut.Contains("child"))
                            {
                                Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("relaxer"))
                            {
                                Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                String relaxer = (Console.ReadLine().ToLower());
                                if (relaxer.Contains("keratin"))
                                {
                                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (relaxer.Contains("brazil"))
                                {
                                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (cut.Contains("condition"))
                            {
                                Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("special") || cut.Contains("up"))
                            {
                                Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("extension") || cut.Contains("weaving"))
                            {
                                Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                String extension = (Console.ReadLine().ToLower());
                                if (extension.Contains("consultation"))
                                {
                                    Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (extension.Contains("implementation"))
                                {
                                    Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
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



        public void apptcutwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your haircut?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                            String cut = (Console.ReadLine().ToLower());
                            if (cut.Contains("women"))
                            {
                                Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                                String women = (Console.ReadLine().ToLower());
                                if (women.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (women.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (women.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String womencut = (Console.ReadLine().ToLower());
                                    if (womencut.Contains("no"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            if (cut.Contains("child"))
                            {
                                Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("relaxer"))
                            {
                                Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                String relaxer = (Console.ReadLine().ToLower());
                                if (relaxer.Contains("keratin"))
                                {
                                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (relaxer.Contains("brazil"))
                                {
                                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (cut.Contains("condition"))
                            {
                                Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("special") || cut.Contains("up"))
                            {
                                Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("extension") || cut.Contains("weaving"))
                            {
                                Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                String extension = (Console.ReadLine().ToLower());
                                if (extension.Contains("consultation"))
                                {
                                    Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (extension.Contains("implementation"))
                                {
                                    Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your haircut?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                    String cut = (Console.ReadLine().ToLower());
                    if (cut.Contains("women"))
                    {
                        Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                        String women = (Console.ReadLine().ToLower());
                        if (women.Contains("blow"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (women.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (women.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String womencut = (Console.ReadLine().ToLower());
                            if (womencut.Contains("no"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                    }
                    if (cut.Contains("child"))
                    {
                        Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("relaxer"))
                    {
                        Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                        String relaxer = (Console.ReadLine().ToLower());
                        if (relaxer.Contains("keratin"))
                        {
                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (relaxer.Contains("brazil"))
                        {
                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (cut.Contains("condition"))
                    {
                        Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("special") || cut.Contains("up"))
                    {
                        Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("extension") || cut.Contains("weaving"))
                    {
                        Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                        String extension = (Console.ReadLine().ToLower());
                        if (extension.Contains("consultation"))
                        {
                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (extension.Contains("implementation"))
                        {
                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your haircut? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                            String cut = (Console.ReadLine().ToLower());
                            if (cut.Contains("women"))
                            {
                                Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                                String women = (Console.ReadLine().ToLower());
                                if (women.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (women.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (women.Contains("cut"))
                                {
                                    Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                    String womencut = (Console.ReadLine().ToLower());
                                    if (womencut.Contains("no"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (womencut.Contains("thermal"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            if (cut.Contains("child"))
                            {
                                Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("relaxer"))
                            {
                                Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                String relaxer = (Console.ReadLine().ToLower());
                                if (relaxer.Contains("keratin"))
                                {
                                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (relaxer.Contains("brazil"))
                                {
                                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (cut.Contains("condition"))
                            {
                                Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("special") || cut.Contains("up"))
                            {
                                Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (cut.Contains("extension") || cut.Contains("weaving"))
                            {
                                Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                String extension = (Console.ReadLine().ToLower());
                                if (extension.Contains("consultation"))
                                {
                                    Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (extension.Contains("implementation"))
                                {
                                    Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your haircut? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                    String cut = (Console.ReadLine().ToLower());
                    if (cut.Contains("women"))
                    {
                        Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                        String women = (Console.ReadLine().ToLower());
                        if (women.Contains("blow"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (women.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (women.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String womencut = (Console.ReadLine().ToLower());
                            if (womencut.Contains("no"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                    }
                    if (cut.Contains("child"))
                    {
                        Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("relaxer"))
                    {
                        Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                        String relaxer = (Console.ReadLine().ToLower());
                        if (relaxer.Contains("keratin"))
                        {
                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (relaxer.Contains("brazil"))
                        {
                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (cut.Contains("condition"))
                    {
                        Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("special") || cut.Contains("up"))
                    {
                        Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("extension") || cut.Contains("weaving"))
                    {
                        Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                        String extension = (Console.ReadLine().ToLower());
                        if (extension.Contains("consultation"))
                        {
                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (extension.Contains("implementation"))
                        {
                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Do you want a Women's cut, Child's cut and style, Relaxer, Conditioning Treatment, Special Occasions/Up-Dos, or Extension/Weaving?");
                    String cut = (Console.ReadLine().ToLower());
                    if (cut.Contains("women"))
                    {
                        Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                        String women = (Console.ReadLine().ToLower());
                        if (women.Contains("blow"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (women.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (women.Contains("cut"))
                        {
                            Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                            String womencut = (Console.ReadLine().ToLower());
                            if (womencut.Contains("no"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (womencut.Contains("thermal"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                        }
                    }
                    if (cut.Contains("child"))
                    {
                        Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("relaxer"))
                    {
                        Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                        String relaxer = (Console.ReadLine().ToLower());
                        if (relaxer.Contains("keratin"))
                        {
                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (relaxer.Contains("brazil"))
                        {
                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (cut.Contains("condition"))
                    {
                        Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("special") || cut.Contains("up"))
                    {
                        Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (cut.Contains("extension") || cut.Contains("weaving"))
                    {
                        Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                        String extension = (Console.ReadLine().ToLower());
                        if (extension.Contains("consultation"))
                        {
                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (extension.Contains("implementation"))
                        {
                            Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutwcitywtimewdate(String time, String place, String date)
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
                    if (womencut.Contains("no"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Haircut in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
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



        public void apptwomen(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
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
                                    Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                                    String women = (Console.ReadLine().ToLower());
                                    if (women.Contains("blow"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("curl"))
                                    {
                                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (women.Contains("cut"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                        String womencut = (Console.ReadLine().ToLower());
                                        if (womencut.Contains("blow"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("curl"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (womencut.Contains("thermal"))
                                        {
                                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwomenwdate(String[] appointimes, String[] locations, String date)
        {
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
                            Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                            String women = (Console.ReadLine().ToLower());
                            if (women.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String womencut = (Console.ReadLine().ToLower());
                                if (womencut.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
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



        public void apptwomenwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                            String women = (Console.ReadLine().ToLower());
                            if (women.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String womencut = (Console.ReadLine().ToLower());
                                if (womencut.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwomenwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                    String women = (Console.ReadLine().ToLower());
                    if (women.Contains("blow"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (women.Contains("curl"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (women.Contains("cut"))
                    {
                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                        String womencut = (Console.ReadLine().ToLower());
                        if (womencut.Contains("blow"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (womencut.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (womencut.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptwomenwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                            String women = (Console.ReadLine().ToLower());
                            if (women.Contains("blow"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("curl"))
                            {
                                Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (women.Contains("cut"))
                            {
                                Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                                String womencut = (Console.ReadLine().ToLower());
                                if (womencut.Contains("blow"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("curl"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (womencut.Contains("thermal"))
                                {
                                    Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwomenwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                    String women = (Console.ReadLine().ToLower());
                    if (women.Contains("blow"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (women.Contains("curl"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (women.Contains("cut"))
                    {
                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                        String womencut = (Console.ReadLine().ToLower());
                        if (womencut.Contains("blow"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (womencut.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (womencut.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwomenwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Do you want a Women's Blow-Dry, Styling With Flat-Curling Iron, or Haircut");
                    String women = (Console.ReadLine().ToLower());
                    if (women.Contains("blow"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (women.Contains("curl"))
                    {
                        Console.WriteLine("Thank you. You have a Women's Styling With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (women.Contains("cut"))
                    {
                        Console.WriteLine("Ok. Would you like the Women's Haircut with Blow-Dry, Styling With Flat-Curling Iron, or Thermal Press?");
                        String womencut = (Console.ReadLine().ToLower());
                        if (womencut.Contains("blow"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut and Blow-Dry in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (womencut.Contains("curl"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut With Flat-Curling Iron in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (womencut.Contains("thermal"))
                        {
                            Console.WriteLine("Thank you. You have a Women's Haircut and Thermal Press in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptwomenwcitywtimewdate(String time, String place, String date)
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
            return;
        }



        public void apptcutchild(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your haircut? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your haircut?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutchildwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your haircut? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your haircut?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptcutchildwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your haircut?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutchildwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your haircut?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutchildwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your haircut? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutchildwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your haircut? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutchildwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your haircut? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutchildwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Child's Haircut and Style in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxer(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your relaxer appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your relaxer appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                                    String relaxer = (Console.ReadLine().ToLower());
                                    if (relaxer.Contains("keratin"))
                                    {
                                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (relaxer.Contains("brazil"))
                                    {
                                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your relaxer appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your relaxer appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                            String relaxer = (Console.ReadLine().ToLower());
                            if (relaxer.Contains("keratin"))
                            {
                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (relaxer.Contains("brazil"))
                            {
                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
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



        public void apptcutrelaxerwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your relaxer appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                            String relaxer = (Console.ReadLine().ToLower());
                            if (relaxer.Contains("keratin"))
                            {
                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (relaxer.Contains("brazil"))
                            {
                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your relaxer appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                    String relaxer = (Console.ReadLine().ToLower());
                    if (relaxer.Contains("keratin"))
                    {
                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (relaxer.Contains("brazil"))
                    {
                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your relaxer appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                            String relaxer = (Console.ReadLine().ToLower());
                            if (relaxer.Contains("keratin"))
                            {
                                Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (relaxer.Contains("brazil"))
                            {
                                Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your relaxer appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                    String relaxer = (Console.ReadLine().ToLower());
                    if (relaxer.Contains("keratin"))
                    {
                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (relaxer.Contains("brazil"))
                    {
                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Would you like a Keratin Treatment or Brazilian Blowout?");
                    String relaxer = (Console.ReadLine().ToLower());
                    if (relaxer.Contains("keratin"))
                    {
                        Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (relaxer.Contains("brazil"))
                    {
                        Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerwcitywtimewdate(String time, String place, String date)
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
            return;
        }



        public void apptcutrelaxerkeratin(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your keratin relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your keratin relaxer appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your keratin relaxer appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerkeratinwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your keratin relaxer appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your keratin relaxer appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptcutrelaxerkeratinwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your keratin relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your keratin relaxer appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerkeratinwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your keratin relaxer appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerkeratinwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your keratin relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your keratin relaxer appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerkeratinwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your keratin relaxer appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerkeratinwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your keratin relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerkeratinwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Keratin Treatment Relaxer in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazil(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your brazillian blowout relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your brazillian blowout relaxer appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your brazillian blowout relaxer appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazilwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your brazillian blowout relaxer appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your brazillian blowout relaxer appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptcutrelaxerbrazilwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your brazillian blowout relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your brazillian blowout relaxer appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazilwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your brazillian blowout relaxer appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazilwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your brazillian blowout relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your brazillian blowout relaxer appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazilwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your brazillian blowout relaxer appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazilwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your brazillian blowout relaxer appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutrelaxerbrazilwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Brazilian Blowout Relaxer in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioning(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your conditioning treatment appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your conditioning treatment appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your conditioning treatment appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();

                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioningwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your conditioning treatment appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your conditioning treatment appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptcutconditioningwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your conditioning treatment appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your conditioning treatment appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();

                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioningwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your conditioning treatment appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioningwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your conditioning treatment appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your conditioning treatment appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioningwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your conditioning treatment appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioningwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your conditioning treatment appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptcutconditioningwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Conditioning Treatment in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptspecial(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your Special Occasions / Up-Dos? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your Special Occasions / Up-Dos? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your Special Occasions / Up-Dos?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptspecialwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your Special Occasions / Up-Dos? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your Special Occasions / Up-Dos?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptspecialwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your Special Occasions / Up-Dos? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your Special Occasions / Up-Dos?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptspecialwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your Special Occasions / Up-Dos?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptspecialwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your Special Occasions / Up-Dos? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your Special Occasions / Up-Dos? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptspecialwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your Special Occasions / Up-Dos? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptspecialwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your Special Occasions / Up-Dos? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptspecialwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Special Occasions / Up-Dos in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptextension(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your extensions/weaving appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your extensions/weaving appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your extensions/weaving appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                                    String extension = (Console.ReadLine().ToLower());
                                    if (extension.Contains("consultation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (extension.Contains("implementation"))
                                    {
                                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptextensionwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your extensions/weaving appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your extensions/weaving appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                            String extension = (Console.ReadLine().ToLower());
                            if (extension.Contains("consultation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (extension.Contains("implementation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
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



        public void apptextensionwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your extensions/weaving appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your extensions/weaving appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                            String extension = (Console.ReadLine().ToLower());
                            if (extension.Contains("consultation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (extension.Contains("implementation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptextensionwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your extensions/weaving appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                    String extension = (Console.ReadLine().ToLower());
                    if (extension.Contains("consultation"))
                    {
                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (extension.Contains("implementation"))
                    {
                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptextensionwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your extensions/weaving appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your extensions/weaving appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                            String extension = (Console.ReadLine().ToLower());
                            if (extension.Contains("consultation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (extension.Contains("implementation"))
                            {
                                Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptextensionwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your extensions/weaving appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                    String extension = (Console.ReadLine().ToLower());
                    if (extension.Contains("consultation"))
                    {
                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (extension.Contains("implementation"))
                    {
                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptextensionwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your extensions/weaving appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Would you like a Consultation or Implementation?");
                    String extension = (Console.ReadLine().ToLower());
                    if (extension.Contains("consultation"))
                    {
                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Consultation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (extension.Contains("implementation"))
                    {
                        Console.WriteLine("Thank you. You have a Extensions/Weaving with Implementation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptextensionwcitywtimewdate(String time, String place, String date)
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
            return;
        }



        public void apptmakeup(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your makeup appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                                    String makeup = (Console.ReadLine().ToLower());
                                    if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                                    {
                                        Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (makeup.Contains("app"))
                                    {
                                        Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (makeup.Contains("wedding"))
                                    {
                                        Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                            String makeup = (Console.ReadLine().ToLower());
                            if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (makeup.Contains("app"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            if (makeup.Contains("wedding"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
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



        public void apptmakeupwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                            String makeup = (Console.ReadLine().ToLower());
                            if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (makeup.Contains("app"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (makeup.Contains("wedding"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your makeup appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                    String makeup = (Console.ReadLine().ToLower());
                    if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (makeup.Contains("app"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (makeup.Contains("wedding"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                            String makeup = (Console.ReadLine().ToLower());
                            if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (makeup.Contains("app"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (makeup.Contains("wedding"))
                            {
                                Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                    String makeup = (Console.ReadLine().ToLower());
                    if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (makeup.Contains("app"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (makeup.Contains("wedding"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Would you like a Makeup Analysis and Instruction, Application, or Wedding?");
                    String makeup = (Console.ReadLine().ToLower());
                    if (makeup.Contains("analysis") || makeup.Contains("Instruction"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (makeup.Contains("app"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (makeup.Contains("wedding"))
                    {
                        Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwcitywtimewdate(String time, String place, String date)
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



        public void apptmakeupanalysis(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup analysis and instruction appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup analysis and instruction appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your makeup analysis and instruction appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupanalysiswdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup analysis and instruction appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup analysis and instruction appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptmakeupanalysiswtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup analysis and instruction appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup analysis and instruction appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupanalysiswtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your makeup analysis and instruction appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptmakeupanalysiswcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup analysis and instruction appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup analysis and instruction appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupanalysiswcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup analysis and instruction appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupanalysiswcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup analysis and instruction appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupanalysiswcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Makeup Analysis and Instruction in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplication(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup application appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup application appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your makeup application appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {

                                    Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplicationwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup application appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup application appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {

                            Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptmakeupapplicationwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup application appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup application appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {

                            Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplicationwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your makeup application appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {

                    Console.WriteLine("Thank you. You have a Makeup Application in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplicationwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup application appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup application appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplicationwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup application appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplicationwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup application appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupapplicationwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Makeup Application in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptmakeupwedding(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your makeup appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupweddingwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
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



        public void apptmakeupweddingwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup wedding appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your makeup wedding appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupweddingwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your makeup wedding appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptmakeupweddingwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup wedding appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your makeup wedding appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupweddingwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your makeup wedding appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupweddingwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your makeup wedding appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmakeupweddingwcitywtimewdate(String time, String place, String date)
        {
            Console.WriteLine("Thank you. You have a Makeup Wedding in " + place + " at " + time + " on " + date + ". See you then!");
            Console.ReadLine();
            return;
        }



        public void apptreplace(String[] appointimes, String[] locations, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your hair replacement appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your hair replacement appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your hair replacement appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                                    String replace = (Console.ReadLine().ToLower());
                                    for (int l = 0; l < replacement.Length; l++)
                                        if (replace.Contains(replacement[l]))
                                        {
                                            Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptreplacewdate(String[] appointimes, String[] locations, String[] replacement, String date)
        {
            Console.WriteLine("Ok. What time would you want your hair replacement appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your hair replacement appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                            String replace = (Console.ReadLine().ToLower());
                            for (int l = 0; l < replacement.Length; l++)
                                if (replace.Contains(replacement[l]))
                                {
                                    Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            return;
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



        public void apptreplacewtime(String time, String[] locations, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your hair replacement appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your hair replacement appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                            String replace = (Console.ReadLine().ToLower());
                            for (int l = 0; l < replacement.Length; l++)
                                if (replace.Contains(replacement[l]))
                                {
                                    Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptreplacewtimewdate(String time, String[] locations, String[] replacement, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your hair replacement appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                    String replace = (Console.ReadLine().ToLower());
                    for (int l = 0; l < replacement.Length; l++)
                        if (replace.Contains(replacement[l]))
                        {
                            Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
        }



        public void apptreplacewcity(String[] appointimes, String place, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your hair replacement appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your hair replacement appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                            String replace = (Console.ReadLine().ToLower());
                            for (int l = 0; l < replacement.Length; l++)
                                if (replace.Contains(replacement[l]))
                                {
                                    Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptreplacewcitywdate(String[] appointimes, String place, String[] replacement, String date)
        {
            Console.WriteLine("Ok. What time would you want your hair replacement appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                    String replace = (Console.ReadLine().ToLower());
                    for (int l = 0; l < replacement.Length; l++)
                        if (replace.Contains(replacement[l]))
                        {
                            Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptreplacewcitywtime(String time, String place, String[] replacement, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your hair replacement appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. For your hair replacement would you like Consultation, Hair System, System Service, System Coloring, System Service and Coloring, System Styling, System Repair, or Cut-In Personal System?");
                    String replace = (Console.ReadLine().ToLower());
                    for (int l = 0; l < replacement.Length; l++)
                        if (replace.Contains(replacement[l]))
                        {
                            Console.WriteLine("Thank you. You have a " + replace + " hair replacement in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptreplacewcitywtimewdate(String time, String place, String[] replacement, String date)
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



        public void apptnail(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your nail care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your nail care appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your nail care appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                                    String nail = (Console.ReadLine().ToLower());
                                    if (nail.Contains("mani") && nail.Contains("pedi"))
                                    {
                                        Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                                        String manipedi = (Console.ReadLine().ToLower());
                                        if (manipedi.Contains("french"))
                                        {
                                            Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (manipedi.Contains("spa"))
                                        {
                                            Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("mani") && !(nail.Contains("pedi")))
                                    {
                                        Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                        String mani = (Console.ReadLine().ToLower());
                                        if (mani.Contains("french"))
                                        {
                                            Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (mani.Contains("spa"))
                                        {
                                            Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("pedi") && !(nail.Contains("mani")))
                                    {
                                        Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                        String pedi = (Console.ReadLine().ToLower());
                                        if (pedi.Contains("french"))
                                        {
                                            Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (pedi.Contains("spa"))
                                        {
                                            Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("polish"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                        String polish = (Console.ReadLine().ToLower());
                                        if (polish.Contains("hands") && polish.Contains("feet"))
                                        {
                                            Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (polish.Contains("hands") && !(polish.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (polish.Contains("feet") && !(polish.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("full") && (nail.Contains("acrylic")))
                                    {
                                        Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                        String acrylicfull = (Console.ReadLine().ToLower());
                                        if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                        {
                                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                        {
                                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("acrylic") && (nail.Contains("fill")))
                                    {
                                        Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                        String acrylicfill = (Console.ReadLine().ToLower());
                                        if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                        {
                                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                        {
                                            Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("pink") || nail.Contains("white"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                        String pinkwhite = (Console.ReadLine().ToLower());
                                        if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                        {
                                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                        {
                                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    if (nail.Contains("replace"))
                                    {
                                        Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (nail.Contains("gel"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                        String gel = (Console.ReadLine().ToLower());
                                        if (gel.Contains("hands") && gel.Contains("feet"))
                                        {
                                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (gel.Contains("hands") && !(gel.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (gel.Contains("feet") && !(gel.Contains("hands")))
                                        {
                                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }

                                    }
                                    if (nail.Contains("silk"))
                                    {
                                        Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                        String silk = (Console.ReadLine().ToLower());
                                        if (silk.Contains("hands") && silk.Contains("feet"))
                                        {
                                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (silk.Contains("hands") && !(silk.Contains("feet")))
                                        {
                                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (silk.Contains("feet") && !(silk.Contains("hands")))
                                        {
                                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }

                                    }
                                    if (nail.Contains("french") && nail.Contains("full"))
                                    {
                                        Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    if (nail.Contains("french") && !(nail.Contains("full")))
                                    {
                                        Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                        Console.ReadLine();
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailwdate(String[] appointimes, String[] locations, String date)
        {
            Console.WriteLine("Ok. What time would you want your nail care appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your nail care appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                            String nail = (Console.ReadLine().ToLower());
                            if (nail.Contains("mani") && nail.Contains("pedi"))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                                String manipedi = (Console.ReadLine().ToLower());
                                if (manipedi.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (manipedi.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("mani") && !(nail.Contains("pedi")))
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
                            if (nail.Contains("pedi") && !(nail.Contains("mani")))
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
                                if (polish.Contains("hands") && !(polish.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (polish.Contains("feet") && !(polish.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("full") && (nail.Contains("acrylic")))
                            {
                                Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                String acrylicfull = (Console.ReadLine().ToLower());
                                if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("acrylic") && (nail.Contains("fill")))
                            {
                                Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                String acrylicfill = (Console.ReadLine().ToLower());
                                if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
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
                                if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
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
                                if (gel.Contains("hands") && !(gel.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (gel.Contains("feet") && !(gel.Contains("hands")))
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
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (silk.Contains("hands") && !(silk.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (silk.Contains("feet") && !(silk.Contains("hands")))
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
                            if (nail.Contains("french") && !(nail.Contains("full")))
                            {
                                Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + date + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
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



        public void apptnailwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your nail care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your nail care appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                            String nail = (Console.ReadLine().ToLower());
                            if (nail.Contains("mani") && nail.Contains("pedi"))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                                String manipedi = (Console.ReadLine().ToLower());
                                if (manipedi.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (manipedi.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("mani") && !(nail.Contains("pedi")))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                String mani = (Console.ReadLine().ToLower());
                                if (mani.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Manicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (mani.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Manicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("pedi") && !(nail.Contains("mani")))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                String pedi = (Console.ReadLine().ToLower());
                                if (pedi.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pedi.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Pedicure in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("polish"))
                            {
                                Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                String polish = (Console.ReadLine().ToLower());
                                if (polish.Contains("hands") && polish.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (polish.Contains("hands") && !(polish.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (polish.Contains("feet") && !(polish.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("full") && (nail.Contains("acrylic")))
                            {
                                Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                String acrylicfull = (Console.ReadLine().ToLower());
                                if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("acrylic") && (nail.Contains("fill")))
                            {
                                Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                String acrylicfill = (Console.ReadLine().ToLower());
                                if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("pink") || nail.Contains("white"))
                            {
                                Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                String pinkwhite = (Console.ReadLine().ToLower());
                                if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("replace"))
                            {
                                Console.WriteLine("Thank you. You have a Nail Replacement in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (nail.Contains("gel"))
                            {
                                Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                String gel = (Console.ReadLine().ToLower());
                                if (gel.Contains("hands") && gel.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (gel.Contains("hands") && !(gel.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (gel.Contains("feet") && !(gel.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }

                            }
                            if (nail.Contains("silk"))
                            {
                                Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                String silk = (Console.ReadLine().ToLower());
                                if (silk.Contains("hands") && silk.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (silk.Contains("hands") && !(silk.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (silk.Contains("feet") && !(silk.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }

                            }
                            if (nail.Contains("french") && nail.Contains("full"))
                            {
                                Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (nail.Contains("french") && !(nail.Contains("full")))
                            {
                                Console.WriteLine("Thank you. You have a French Fill Nail Care in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailwtimewdate(String time, String[] locations, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your nail care appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                    String nail = (Console.ReadLine().ToLower());
                    if (nail.Contains("mani") && nail.Contains("pedi"))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                        String manipedi = (Console.ReadLine().ToLower());
                        if (manipedi.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (manipedi.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("mani") && !(nail.Contains("pedi")))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                        String mani = (Console.ReadLine().ToLower());
                        if (mani.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Manicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (mani.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Manicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("pedi") && !(nail.Contains("mani")))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                        String pedi = (Console.ReadLine().ToLower());
                        if (pedi.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pedi.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Pedicure in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("polish"))
                    {
                        Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                        String polish = (Console.ReadLine().ToLower());
                        if (polish.Contains("hands") && polish.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (polish.Contains("hands") && !(polish.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (polish.Contains("feet") && !(polish.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("full") && (nail.Contains("acrylic")))
                    {
                        Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                        String acrylicfull = (Console.ReadLine().ToLower());
                        if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("acrylic") && (nail.Contains("fill")))
                    {
                        Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                        String acrylicfill = (Console.ReadLine().ToLower());
                        if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("pink") || nail.Contains("white"))
                    {
                        Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                        String pinkwhite = (Console.ReadLine().ToLower());
                        if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("replace"))
                    {
                        Console.WriteLine("Thank you. You have a Nail Replacement in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (nail.Contains("gel"))
                    {
                        Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                        String gel = (Console.ReadLine().ToLower());
                        if (gel.Contains("hands") && gel.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (gel.Contains("hands") && !(gel.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (gel.Contains("feet") && !(gel.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }

                    }
                    if (nail.Contains("silk"))
                    {
                        Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                        String silk = (Console.ReadLine().ToLower());
                        if (silk.Contains("hands") && silk.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (silk.Contains("hands") && !(silk.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (silk.Contains("feet") && !(silk.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }

                    }
                    if (nail.Contains("french") && nail.Contains("full"))
                    {
                        Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    if (nail.Contains("french") && !(nail.Contains("full")))
                    {
                        Console.WriteLine("Thank you. You have a French Fill Nail Care in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptnailwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your nail care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your nail care appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                            String nail = (Console.ReadLine().ToLower());
                            if (nail.Contains("mani") && nail.Contains("pedi"))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                                String manipedi = (Console.ReadLine().ToLower());
                                if (manipedi.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (manipedi.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("mani") && !(nail.Contains("pedi")))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                                String mani = (Console.ReadLine().ToLower());
                                if (mani.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (mani.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("pedi") && !(nail.Contains("mani")))
                            {
                                Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                                String pedi = (Console.ReadLine().ToLower());
                                if (pedi.Contains("french"))
                                {
                                    Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pedi.Contains("spa"))
                                {
                                    Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("polish"))
                            {
                                Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                                String polish = (Console.ReadLine().ToLower());
                                if (polish.Contains("hands") && polish.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (polish.Contains("hands") && !(polish.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (polish.Contains("feet") && !(polish.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("full") && (nail.Contains("acrylic")))
                            {
                                Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                                String acrylicfull = (Console.ReadLine().ToLower());
                                if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("acrylic") && (nail.Contains("fill")))
                            {
                                Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                                String acrylicfill = (Console.ReadLine().ToLower());
                                if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("pink") || nail.Contains("white"))
                            {
                                Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                                String pinkwhite = (Console.ReadLine().ToLower());
                                if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            if (nail.Contains("replace"))
                            {
                                Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (nail.Contains("gel"))
                            {
                                Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                                String gel = (Console.ReadLine().ToLower());
                                if (gel.Contains("hands") && gel.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (gel.Contains("hands") && !(gel.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (gel.Contains("feet") && !(gel.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }

                            }
                            if (nail.Contains("silk"))
                            {
                                Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                                String silk = (Console.ReadLine().ToLower());
                                if (silk.Contains("hands") && silk.Contains("feet"))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (silk.Contains("hands") && !(silk.Contains("feet")))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (silk.Contains("feet") && !(silk.Contains("hands")))
                                {
                                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }

                            }
                            if (nail.Contains("french") && nail.Contains("full"))
                            {
                                Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            if (nail.Contains("french") && !(nail.Contains("full")))
                            {
                                Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                Console.ReadLine();
                            }
                            return;
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



        public void apptnailwcitywdate(String[] appointimes, String place, String date)
        {
            Console.WriteLine("Ok. What time would you want your nail care appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                    String nail = (Console.ReadLine().ToLower());
                    if (nail.Contains("mani") && nail.Contains("pedi"))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                        String manipedi = (Console.ReadLine().ToLower());
                        if (manipedi.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (manipedi.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("mani") && !(nail.Contains("pedi")))
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
                    if (nail.Contains("pedi") && !(nail.Contains("mani")))
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
                        if (polish.Contains("hands") && !(polish.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (polish.Contains("feet") && !(polish.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("full") && (nail.Contains("acrylic")))
                    {
                        Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                        String acrylicfull = (Console.ReadLine().ToLower());
                        if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("acrylic") && (nail.Contains("fill")))
                    {
                        Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                        String acrylicfill = (Console.ReadLine().ToLower());
                        if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
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
                        if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
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
                        if (gel.Contains("hands") && !(gel.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (gel.Contains("feet") && !(gel.Contains("hands")))
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
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (silk.Contains("hands") && !(silk.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                        if (silk.Contains("feet") && !(silk.Contains("hands")))
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
                    if (nail.Contains("french") && !(nail.Contains("full")))
                    {
                        Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + date + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your nail care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Would you like a Manicure, Pedicure, Manicure and Pedicure, Polish Change, Full Set Acrylic, Acrylic Fill, Pink and White Full Set, Nail Replacement, Gel Nails Full Set, Silk Nails Full Set, French Fill, French Full Set?");
                    String nail = (Console.ReadLine().ToLower());
                    if (nail.Contains("mani") && nail.Contains("pedi"))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Manicure and Pedicure?");
                        String manipedi = (Console.ReadLine().ToLower());
                        if (manipedi.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Manicure and Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (manipedi.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Manicure and Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("mani") && !(nail.Contains("pedi")))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Manicure?");
                        String mani = (Console.ReadLine().ToLower());
                        if (mani.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (mani.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Manicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("pedi") && !(nail.Contains("mani")))
                    {
                        Console.WriteLine("Ok. Would you like a French or Spa Pedicure?");
                        String pedi = (Console.ReadLine().ToLower());
                        if (pedi.Contains("french"))
                        {
                            Console.WriteLine("Thank you. You have a French Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pedi.Contains("spa"))
                        {
                            Console.WriteLine("Thank you. You have a Spa Pedicure in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("polish"))
                    {
                        Console.WriteLine("Ok. Would you like the Polish Change on Hands, Feet, or Hands and Feet?");
                        String polish = (Console.ReadLine().ToLower());
                        if (polish.Contains("hands") && polish.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (polish.Contains("hands") && !(polish.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (polish.Contains("feet") && !(polish.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("full") && (nail.Contains("acrylic")))
                    {
                        Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                        String acrylicfull = (Console.ReadLine().ToLower());
                        if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("acrylic") && (nail.Contains("fill")))
                    {
                        Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                        String acrylicfill = (Console.ReadLine().ToLower());
                        if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Acrylic Fill on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("pink") || nail.Contains("white"))
                    {
                        Console.WriteLine("Ok. Would you like the Pink and White Full Set on Hands, Feet, or Hands and Feet?");
                        String pinkwhite = (Console.ReadLine().ToLower());
                        if (pinkwhite.Contains("hands") && pinkwhite.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Pink and White Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    if (nail.Contains("replace"))
                    {
                        Console.WriteLine("Thank you. You have a Nail Replacement in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (nail.Contains("gel"))
                    {
                        Console.WriteLine("Ok. Would you like the Gel Nails Full Set on Hands, Feet, or Hands and Feet?");
                        String gel = (Console.ReadLine().ToLower());
                        if (gel.Contains("hands") && gel.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (gel.Contains("hands") && !(gel.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (gel.Contains("feet") && !(gel.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Gel Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }

                    }
                    if (nail.Contains("silk"))
                    {
                        Console.WriteLine("Ok. Would you like the Silk Nails Full Set on Hands, Feet, or Hands and Feet?");
                        String silk = (Console.ReadLine().ToLower());
                        if (silk.Contains("hands") && silk.Contains("feet"))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (silk.Contains("hands") && !(silk.Contains("feet")))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (silk.Contains("feet") && !(silk.Contains("hands")))
                        {
                            Console.WriteLine("Thank you. You have a Silk Nails Full Set on Feet in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }

                    }
                    if (nail.Contains("french") && nail.Contains("full"))
                    {
                        Console.WriteLine("Thank you. You have a French Full Set Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    if (nail.Contains("french") && !(nail.Contains("full")))
                    {
                        Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                        Console.ReadLine();
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailwcitywtimewdate(String time, String place, String date)
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
            if (nail.Contains("mani") && !(nail.Contains("pedi")))
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
            if (nail.Contains("pedi") && !(nail.Contains("mani")))
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
                if (polish.Contains("hands") && !(polish.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Polish Change on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (polish.Contains("feet") && !(polish.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Polish Change on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
            }
            if (nail.Contains("full") && (nail.Contains("acrylic")))
            {
                Console.WriteLine("Ok. Would you like the Full Set Acrylic on Hands, Feet, or Hands and Feet?");
                String acrylicfull = (Console.ReadLine().ToLower());
                if (acrylicfull.Contains("hands") && acrylicfull.Contains("feet"))
                {
                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (acrylicfull.Contains("hands") && !(acrylicfull.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (acrylicfull.Contains("feet") && !(acrylicfull.Contains("hands")))
                {
                    Console.WriteLine("Thank you. You have a Full Set Acrylic on Feet in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
            }
            if (nail.Contains("acrylic") && (nail.Contains("fill")))
            {
                Console.WriteLine("Ok. Would you like the Acrylic Fill on Hands, Feet, or Hands and Feet?");
                String acrylicfill = (Console.ReadLine().ToLower());
                if (acrylicfill.Contains("hands") && acrylicfill.Contains("feet"))
                {
                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (acrylicfill.Contains("hands") && !(acrylicfill.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Acrylic Fill on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (acrylicfill.Contains("feet") & !(acrylicfill.Contains("hands")))
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
                if (pinkwhite.Contains("hands") && !(pinkwhite.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Pink and White Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (pinkwhite.Contains("feet") && !(pinkwhite.Contains("hands")))
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
                if (gel.Contains("hands") && !(gel.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Gel Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (gel.Contains("feet") && !(gel.Contains("hands")))
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
                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands and Feet in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (silk.Contains("hands") && !(silk.Contains("feet")))
                {
                    Console.WriteLine("Thank you. You have a Silk Nails Full Set on Hands in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                }
                if (silk.Contains("feet") && !(silk.Contains("hands")))
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
            if (nail.Contains("french") && !(nail.Contains("full")))
            {
                Console.WriteLine("Thank you. You have a French Fill Nail Care in " + place + " at " + time + " on " + date + ". See you then!");
                Console.ReadLine();
            }
            return;
        }



        public void apptnailchoose(String[] appointimes, String[] locations, String nailtype, String body, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + " on " + body + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you " + nailtype + " on " + body + "?");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your " + nailtype + " on " + body + "?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosewdate(String[] appointimes, String[] locations, String nailtype, String body, String date)
        {
            Console.WriteLine("Ok. What time would you " + nailtype + " on " + body + "?");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + nailtype + " on " + body + "?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            return;
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



        public void apptnailchoosewtime(String time, String[] locations, String nailtype, String body, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + " on " + body + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + nailtype + " on " + body + "?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosewtimewdate(String time, String[] locations, String nailtype, String body, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your " + nailtype + " on " + body + "?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosewcity(String[] appointimes, String place, String nailtype, String body, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + " on " + body + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you " + nailtype + " on " + body + "?");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosewcitywdate(String[] appointimes, String place, String nailtype, String body, String date)
        {
            Console.WriteLine("Ok. What time would you " + nailtype + " on " + body + "?");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosewcitywtime(String time, String place, String nailtype, String body, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + " on " + body + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosewcitywtimewdate(String time, String place, String nailtype, String body, String date)
        {
            Console.WriteLine("Thank you. You have a " + nailtype + " on " + body + " in " + place + " at " + time + " on " + date + ". See you then!");
            return;
        }



        public void apptnailchoosemani(String[] appointimes, String[] locations, String nailtype, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you " + nailtype + "?");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your " + nailtype + "?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a " + nailtype + " in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosemaniwdate(String[] appointimes, String[] locations, String nailtype, String date)
        {
            Console.WriteLine("Ok. What time would you " + nailtype + "?");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + nailtype + "?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a " + nailtype + " in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                            return;
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



        public void apptnailchoosemaniwtime(String time, String[] locations, String nailtype, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + nailtype + "?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a " + nailtype + " in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosemaniwtimewdate(String time, String[] locations, String nailtype, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your " + nailtype + "?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Thank you. You have a " + nailtype + " in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosemaniwcity(String[] appointimes, String place, String nailtype, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you " + nailtype + "?");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a " + nailtype + " in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosemaniwcitywdate(String[] appointimes, String place, String nailtype, String date)
        {
            Console.WriteLine("Ok. What time would you " + nailtype + "?");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Thank you. You have a " + nailtype + " in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosemaniwcitywtime(String time, String place, String nailtype, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + nailtype + "?");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a " + nailtype + " in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptnailchoosemaniwcitywtimewdate(String time, String place, String nailtype, String date)
        {
            Console.WriteLine("Thank you. You have a " + nailtype + " in " + place + " at " + time + " on " + date + ". See you then!");
            return;
        }



        public void apptmassage(String[] appointimes, String[] locations, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your massage? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your massage?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
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
                                                Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                                Console.ReadLine();
                                            }
                                        }
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassagewdate(String[] appointimes, String[] locations, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. What time would you want your massage? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your massage?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
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
                                        Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + appointimes[i] + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            return;
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



        public void apptmassagewtime(String time, String[] locations, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your massage?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
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
                                        Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + time + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassagewtimewdate(String time, String[] locations, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your massage?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
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
                                Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                                Console.ReadLine();
                            }
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptmassagewcity(String[] appointimes, String place, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your massage? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
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
                                        Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + appointimes[i] + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassagewcitywdate(String[] appointimes, String place, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. What time would you want your massage? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
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
                                Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + appointimes[i] + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                                Console.ReadLine();
                            }
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassagewcitywtime(String time, String place, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
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
                                Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + time + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                Console.ReadLine();
                            }
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassagewcitywtimewdate(String time, String place, String[] massagetime, String date)
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
                        Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                        Console.ReadLine();
                    }
                }
            }
            return;
        }



        public void apptmassageservice(String[] appointimes, String[] locations, String massage, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + massage + " massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your " + massage + " massage? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your " + massage + " massage?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                                    String timemassage = (Console.ReadLine().ToLower());
                                    for (int k = 0; k < massagetime.Length; k++)
                                    {
                                        if (timemassage.Contains(massagetime[k]))
                                        {
                                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassageservicewdate(String[] appointimes, String[] locations, String massage, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. What time would you want your " + massage + " massage? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + massage + " massage?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                            String timemassage = (Console.ReadLine().ToLower());
                            for (int k = 0; k < massagetime.Length; k++)
                            {
                                if (timemassage.Contains(massagetime[k]))
                                {
                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + appointimes[i] + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
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



        public void apptmassageservicewtime(String time, String[] locations, String massage, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + massage + " massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your " + massage + " massage?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                            String timemassage = (Console.ReadLine().ToLower());
                            for (int k = 0; k < massagetime.Length; k++)
                            {
                                if (timemassage.Contains(massagetime[k]))
                                {
                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + time + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassageservicewtimewdate(String time, String[] locations, String massage, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your " + massage + " massage?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                    String timemassage = (Console.ReadLine().ToLower());
                    for (int k = 0; k < massagetime.Length; k++)
                    {
                        if (timemassage.Contains(massagetime[k]))
                        {
                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + locations[j] + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptmassageservicewcity(String[] appointimes, String place, String massage, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + massage + " massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your " + massage + " massage? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                            String timemassage = (Console.ReadLine().ToLower());
                            for (int k = 0; k < massagetime.Length; k++)
                            {
                                if (timemassage.Contains(massagetime[k]))
                                {
                                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + appointimes[i] + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassageservicewcitywdate(String[] appointimes, String place, String massage, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. What time would you want your " + massage + " massage? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                    String timemassage = (Console.ReadLine().ToLower());
                    for (int k = 0; k < massagetime.Length; k++)
                    {
                        if (timemassage.Contains(massagetime[k]))
                        {
                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + appointimes[i] + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassageservicewcitywtime(String time, String place, String massage, String[] massagetime, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your " + massage + " massage? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
                    String timemassage = (Console.ReadLine().ToLower());
                    for (int k = 0; k < massagetime.Length; k++)
                    {
                        if (timemassage.Contains(massagetime[k]))
                        {
                            Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + time + " on " + datetimes[z] + " for " + massagetime[k] + " minutes. See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptmassageservicewcitywtimewdate(String time, String place, String massage, String[] massagetime, String date)
        {
            Console.WriteLine("Ok. Would you like your massage " + massage + " to be 15, 30, 45, 60, 75, 90, or 120 minutes?");
            String timemassage = (Console.ReadLine().ToLower());
            for (int k = 0; k < massagetime.Length; k++)
            {
                if (timemassage.Contains(massagetime[k]))
                {
                    Console.WriteLine("Thank you. You have a " + massage + " massage in " + place + " at " + time + " on " + date + " for " + massagetime[k] + " minutes. See you then!");
                    Console.ReadLine();
                }
            }
            return;
        }



        public void apptskin(String[] appointimes, String[] locations, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your skin care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your skin care appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your skin care appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
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
                                                Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                            Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (facial.Contains("back"))
                                        {
                                            Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                        if (facial.Contains("micro"))
                                        {
                                            Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinwdate(String[] appointimes, String[] locations, String[] exfol, String date)
        {
            Console.WriteLine("Ok. What time would you want your skin care appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your skin care appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
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
                                        Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
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



        public void apptskinwtime(String time, String[] locations, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your skin care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your skin care appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
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
                                        Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (facial.Contains("back"))
                                {
                                    Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (facial.Contains("micro"))
                                {
                                    Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinwtimewdate(String time, String[] locations, String[] exfol, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your skin care appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
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
                                Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
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
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptskinwcity(String[] appointimes, String place, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your skin care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your skin care appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
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
                                        Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
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
                                    Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (facial.Contains("back"))
                                {
                                    Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                                if (facial.Contains("micro"))
                                {
                                    Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinwcitywdate(String[] appointimes, String place, String[] exfol, String date)
        {
            Console.WriteLine("Ok. What time would you want your skin care appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
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
                                Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
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
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinwcitywtime(String time, String place, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your skin care appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
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
                                Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
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
                            Console.WriteLine("Thank you. You have a Facial With Extraction in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (facial.Contains("back"))
                        {
                            Console.WriteLine("Thank you. You have a Back Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                        if (facial.Contains("micro"))
                        {
                            Console.WriteLine("Thank you. You have a Microdermabrasion Facial in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinwcitywtimewdate(String time, String place, String[] exfol, String date)
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



        public void apptskinexfol(String[] appointimes, String[] locations, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your exfoliation appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your exfoliation appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your exfoliation appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                                    String exfoli = (Console.ReadLine().ToLower());
                                    for (int m = 0; m < exfol.Length; m++)
                                    {
                                        if (exfoli.Contains(exfol[m]))
                                        {
                                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                            Console.ReadLine();
                                        }
                                    }
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinexfolwdate(String[] appointimes, String[] locations, String[] exfol, String date)
        {
            Console.WriteLine("Ok. What time would you want your exfoliation appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your exfoliation appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                            String exfoli = (Console.ReadLine().ToLower());
                            for (int m = 0; m < exfol.Length; m++)
                            {
                                if (exfoli.Contains(exfol[m]))
                                {
                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
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



        public void apptskinexfolwtime(String time, String[] locations, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your exfoliation appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your exfoliation appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                            String exfoli = (Console.ReadLine().ToLower());
                            for (int m = 0; m < exfol.Length; m++)
                            {
                                if (exfoli.Contains(exfol[m]))
                                {
                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinexfolwtimewdate(String time, String[] locations, String[] exfol, String date)
        {
            Console.WriteLine("Ok. Where do you want to hold your exfoliation appointment?");
            String place = (Console.ReadLine().ToLower());
            for (int j = 0; j < locations.Length; j++)
            {
                if (place.Contains(locations[j]))
                {
                    Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                    String exfoli = (Console.ReadLine().ToLower());
                    for (int m = 0; m < exfol.Length; m++)
                    {
                        if (exfoli.Contains(exfol[m]))
                        {
                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
            Console.ReadLine();
            return;
        }



        public void apptskinexfolwcity(String[] appointimes, String place, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your exfoliation appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your exfoliation appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                            String exfoli = (Console.ReadLine().ToLower());
                            for (int m = 0; m < exfol.Length; m++)
                            {
                                if (exfoli.Contains(exfol[m]))
                                {
                                    Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                }
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinexfolwcitywdate(String[] appointimes, String place, String[] exfol, String date)
        {
            Console.WriteLine("Ok. What time would you want your exfoliation appointment? ");
            String time = (Console.ReadLine());
            for (int i = 0; i < appointimes.Length; i++)
            {
                if (time.Contains(appointimes[i]))
                {
                    Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                    String exfoli = (Console.ReadLine().ToLower());
                    for (int m = 0; m < exfol.Length; m++)
                    {
                        if (exfoli.Contains(exfol[m]))
                        {
                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that time is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinexfolwcitywtime(String time, String place, String[] exfol, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your exfoliation appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Would you like a Jessner, Peptide, Lactic, Glycolic, Hydrating, Vitamin C, Pumpkin, Salicylic, TCA peels, or Retinol Treatment Exfoliation?");
                    String exfoli = (Console.ReadLine().ToLower());
                    for (int m = 0; m < exfol.Length; m++)
                    {
                        if (exfoli.Contains(exfol[m]))
                        {
                            Console.WriteLine("Thank you. You have a " + exfoli + " exfoliation in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void apptskinexfolwcitywtimewdate(String time, String place, String[] exfol, String date)
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
            return;
        }



        public void appttan(String[] appointimes, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your tanning appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your tanning appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your tanning appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                                    Console.ReadLine();
                                    return;
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
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void appttanwdate(String[] appointimes, String[] locations, String date)
        {
                    Console.WriteLine("Ok. What time would you want your tanning appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Ok. Where do you want to hold your tanning appointment?");
                            String place = (Console.ReadLine().ToLower());
                            for (int j = 0; j < locations.Length; j++)
                            {
                                if (place.Contains(locations[j]))
                                {
                                    Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + appointimes[i] + " on " + date + ". See you then!");
                                    Console.ReadLine();
                                    return;
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



        public void appttanwtime(String time, String[] locations, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your tanning appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. Where do you want to hold your tanning appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + time + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void appttanwtimewdate(String time, String[] locations, String date)
        {
                    Console.WriteLine("Ok. Where do you want to hold your tanning appointment?");
                    String place = (Console.ReadLine().ToLower());
                    for (int j = 0; j < locations.Length; j++)
                    {
                        if (place.Contains(locations[j]))
                        {
                            Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + locations[j] + " at " + time + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, I do not offer appointments at " + place + ".");
                    Console.ReadLine();
                    return;
        }



        public void appttanwcity(String[] appointimes, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your tanning appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Ok. What time would you want your tanning appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + appointimes[i] + " on " + datetimes[z] + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void appttanwcitywdate(String[] appointimes, String place, String date)
        {
                    Console.WriteLine("Ok. What time would you want your tanning appointment? ");
                    String time = (Console.ReadLine());
                    for (int i = 0; i < appointimes.Length; i++)
                    {
                        if (time.Contains(appointimes[i]))
                        {
                            Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + appointimes[i] + " on " + date + ". See you then!");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Sorry, that time is not available.");
                    Console.ReadLine();
                    return;
        }



        public void appttanwcitywtime(String time, String place, String[] datetimes)
        {
            Console.WriteLine("Ok. What is the date you want your tanning appointment? ");
            String date = (Console.ReadLine());
            for (int z = datetimes.Length - 1; z >= 0; z--)
            {
                if (date.Contains(datetimes[z]))
                {
                    Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + time + " on " + datetimes[z] + ". See you then!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Sorry, that date is not available.");
            Console.ReadLine();
            return;
        }



        public void appttanwcitywtimewdate(String time, String place, String date)
        {
                    Console.WriteLine("Thank you. You have a Air Brush Spray Tan in " + place + " at " + time + " on " + date + ". See you then!");
                    Console.ReadLine();
                    return;
        }

    }
}