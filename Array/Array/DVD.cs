
namespace Array
{
    public class DVD
    {
        public string Name;
        public int ReleaseYear;
        public string Director;

        public DVD(string name, int releaseYear, string director)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Director = director;
        }

        public string ToString()
        {
            return Name + ", directed by " + Director + ", released in " + ReleaseYear;
        }
    }
}
