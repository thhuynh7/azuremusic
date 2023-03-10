using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AZUREMUSIC.Models
{
    public class TrackEditFormViewModels : TrackEditViewModels
    {
        public string Name { get; set; }

        [Required, Display(Name = "Clip"), DataType(DataType.Upload)]
        public string AudioUpload { get; set; }
    }
}