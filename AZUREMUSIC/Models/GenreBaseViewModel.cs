﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AZUREMUSIC.Models
{
    public class GenreBaseViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
    }
}