﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AZUREMUSIC.Models
{
    public class TrackEditViewModels
    {
        public int Id { get; set; }

        [Required]
        public HttpPostedFileBase AudioUpload { get; set; }
    }
}