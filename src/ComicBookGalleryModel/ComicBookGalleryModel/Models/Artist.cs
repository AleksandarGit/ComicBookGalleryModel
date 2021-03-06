﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ComicBookGalleryModel.Models
{
    
    public class Artist
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public ICollection <ComicBookArtist> ComicBooks { get; set; }

        

        public Artist()
        {
            ComicBooks = new List<ComicBookArtist>();
        }

    }
}
