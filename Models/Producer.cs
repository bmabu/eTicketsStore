﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsStore.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relastionships
        public List<Movie> Movies { get; set; }
    }
}
