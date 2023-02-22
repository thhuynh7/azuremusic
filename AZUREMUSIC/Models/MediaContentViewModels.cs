using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AZUREMUSIC.Models
{
    public class MediaContentViewModels
    {
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public string ContentType { get; set; }

    }
}