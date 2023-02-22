using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AZUREMUSIC.Models
{
    public class ArtistWithMediaInfoViewModels : ArtistWithDetailViewModels
    {
        public ArtistWithMediaInfoViewModels()
        {
            MediaItems = new List<MediaItemBaseViewModels>();
        }


        public IEnumerable<MediaItemBaseViewModels> MediaItems { get; set; }
    }
}