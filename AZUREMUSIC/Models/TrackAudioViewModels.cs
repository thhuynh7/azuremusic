using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AZUREMUSIC.Models
{
    public class TrackAudioViewModels
    {
        public int Id { get; set; }

        public byte[] Audio { get; set; }

        public string AudioContentType { get; set; }
    }
}