using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Bluegrass,
            Country,
            Jazz,
            Pop,
            Rap
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre= genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;  
            }
            public string Display()
            { 
                return "Title:" + Title + "\nArtist:" + Artist + "\nAlbum:" + Album + "\nLength:" + Length + "\nGenre:" + Genre ; 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle=Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist=Console.ReadLine() ;
            Console.WriteLine("What is the Album?");
            string tempAlbum=Console.ReadLine() ;
            Console.WriteLine("What is the length of the song?");
            string tempLength=Console.ReadLine() ;
            Console.WriteLine("What is the genre?");
            Console.WriteLine("B - bluegrass\nC - country\nJ - jazz\nP- pop\nR- rap");
            Genre tempGenre = Genre.Bluegrass;
            char m = char.Parse(Console.ReadLine());
            switch (m)
            {
                case 'B':
                    tempGenre = Genre.Bluegrass; 
                    break;
                case 'C':
                    tempGenre = Genre.Country; 
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
            }
       
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music moreMusic = music;
            moreMusic.setTitle("New Moon");
            moreMusic.setLength("4.3");
            Console.WriteLine("Here's music #1");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine();
            Console.WriteLine("Here is music #2");
            Console.WriteLine($"{moreMusic.Display()}");
        }

    }
}