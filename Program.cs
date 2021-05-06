using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>()
            {
                new XSClubPromoter("Jon", "Jones", 987655554),
                new OmniaClubPromoter("Rab", "Nesbitt", 555567655),
                new OmniaClubPromoter("Che", "Forbes", 555567655)
            };

            foreach (var promoter in promoters)
            {
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>()
            {
                new BookWriter("Jon", "Jones"),
                new BookWriter("Rab", "Nesbitt"),
                new BlogWriter("Che", "Forbes")
            };

            foreach (var writer in writers)
            {
                writer.Write();
                // writer.Vlog();
            }

            List<IBodyBuilder> bodybuilders = new List<IBodyBuilder>()
            {
                new XSClubPromoter("Jon", "Jones", 987655554),
                new XSClubPromoter("Rab", "Nesbitt", 555567655),
            };

            foreach (var bodybuilder in bodybuilders)
            {
                bodybuilder.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>()
            {
                new XSClubPromoter("Jon", "Jones", 987655554),
                new BookWriter("Rab", "Nesbitt"),
            };

            foreach (var vlogger in vloggers)
            {
                vlogger.Vlog();
            }
        }
    }
}
