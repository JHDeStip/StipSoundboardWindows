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
                new Sound("Vlieger", "vlieger"),
                new Sound("Tis gedaan", "tisGedaan"),
                new Sound("Geregeld", "geregeld"),
                new Sound("Alle hoere moete zwijge", "alleHoereMoeteZwijge"),
                new Sound("Jeroen pauw", "jeroenPauw"),
                new Sound("Daar gaat ie weer", "daarGaatIeWeer"),
                new Sound("Hatsikideej", "hatsikideej"),
                new Sound("Grootgebracht met melk", "grootgebrachtMetMelk"),
                new Sound("Belachelijk", "belachelijk"),
                new Sound("Deux bouteilles de vino", "deuxBouteillesDeVino"),
                new Sound("Goesting om te kappen", "goestingOmTeKappen"),
                new Sound("Hoerenzoonnn", "hoerenzoonnn"),
                new Sound("Ik haat sossen", "ikHaatSossen"),
                new Sound("Kakken en zwijgen", "kakkenEnZwijgen"),
                new Sound("Leuvense janetten", "leuvenseJanetten"),
                new Sound("BMI van 30", "bmiVan30"),
                new Sound("Alle venten zijn homo", "alleVentenZijnHomo")
            };
        }
    }
}
