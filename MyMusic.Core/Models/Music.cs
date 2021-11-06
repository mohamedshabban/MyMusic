using System;

namespace MyMusic.Core.Models
{

    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }//ArtistResource
        public Artist Artist { get; set; }//ArtistResource
    }
}