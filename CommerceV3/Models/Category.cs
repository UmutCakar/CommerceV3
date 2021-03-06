﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Category
    {
		public string Id { get; set; }
        [StringLength(200)]
        [Display(Name = "Kategori Adı")]
		public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
	}
}
