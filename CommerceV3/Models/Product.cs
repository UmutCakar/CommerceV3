﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Product
    {
		public string Id { get; set; }
        [StringLength(200)]
        [Display(Name = "Ürün Fotoğrafı")]
        public string Photo { get; set; }
        [StringLength(100)]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [StringLength(100)]
        [Display(Name = "Bağlantı")]
		public string Slug { get; set; }
        [StringLength(750)]
        [Display(Name = "Açıklama")]
		public string Description { get; set; }
		[Display(Name = "Eski Fiyatı")]
		public decimal OldPrice { get; set; }
		[Display(Name = "Fiyat")]
		public decimal Price { get; set; }
		[Display(Name = "Adet")]
		public int Quantity { get; set; }
		[Display(Name = "Stokta Var Mı ?")]
		public bool IsInStock { get; set; }
		[Display(Name = "Yayında Mı ?")]
		public bool IsPublished { get; set; }
		[Display(Name = "Yeni Mi ?")]
		public bool IsNew { get; set; }
		[Display(Name = "Kargo Ücreti(Şehir)")]
		public decimal ShippingPriceInCityWide { get; set; }
		[Display(Name = "Kargo Ücreti(Ülke)")]
		public decimal ShippingPriceInCountryWide { get; set; }
		[Display(Name = "Kargo Ücreti(Dünya)")]
		public decimal ShippingPriceInWorldWide { get; set; }

        [Display(Name = "Tedarikçi")]
        public string SupplierId { get; set; }
        [Display(Name = "Tedarikçi")]
        [ForeignKey("SupplierId")]
		public Supplier Supplier{ get; set; }

        [Display(Name = "Marka")]
        public string BrandId { get; set; }
        [Display(Name = "Marka")]
        [ForeignKey("BrandId")]
		public Brand Brand { get; set; }

        [Display(Name = "Kategori")]
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [Display(Name = "Kategori")]
        public Category Category { get; set; }

        [StringLength(100)]
        [Display(Name = "Oluşturan Kullanıcı")]
		public string CreatedBy { get; set; }
		[Display(Name = "Oluşturulma Tarihi")]
		public DateTime CreateDate { get; set; }
        [StringLength(100)]
        [Display(Name = "Güncelleyen Kullanıcı")]
		public string UpdatedBy { get; set; }
		[Display(Name = "Güncellenme Tarihi")]
		public DateTime UpdateDate { get; set; }

		public virtual ICollection<CartItem> CartItems { get; set; }
	}
}
