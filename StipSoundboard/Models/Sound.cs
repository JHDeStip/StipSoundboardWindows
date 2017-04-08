namespace StipSoundboard.Models
{
    public class Sound
    {
        public string Name { get; private set; }
        public string FileName { get; private set; }

        public Sound(string name, string fileName)
        {
            Name = name;
            FileName = fileName;
        }
    }
}
