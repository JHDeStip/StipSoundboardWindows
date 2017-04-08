using StipSoundboard.Models;
using System;
using System.Collections.Generic;

namespace StipSoundboard.Helpers
{
    public class SoundHelper
    {
        private readonly Uri _appBaseUri;

        public SoundHelper(Uri appBaseUri)
        {
            _appBaseUri = appBaseUri;
        }

        public List<Sound> GetSounds()
        {
            return new List<Sound>
            {
                new Sound("Doe is normaal!", "doeIsNormaal"),
                new Sound("Heey daar is die lens jom!", "heeyDaarIsDieLensJom"),
                new Sound("Flipse papegaai", "flipsePapegaai"),
                new Sound("Ik zen hiejelemaal eweg", "ikZenHiejelemaalEweg"),
                new Sound("Flipse awel jom…", "flipseAwelJom"),
                new Sound("Hey matekes", "heyMatekes"),
                new Sound("Geflitsth", "geflitsth"),
                new Sound("Kop tegen schilderij", "kopTegenSchilderij"),
                new Sound("Ozze papa hoert da nie", "ozzePapaHoertDaNie"),
                new Sound("Papaa!", "papaa"),
                new Sound("Pussycat", "pussycat"),
                new Sound("Stannie is porno", "stannieIsPorno"),
                new Sound("De miekes", "deMiekes"),
                new Sound("Zwijgeeeeuh", "zwijgeeeeuh"),
                new Sound("Annalisa leren", "annalisaLeren"),
                new Sound("Vlieger", "vlieger")
            };
        }
    }
}
