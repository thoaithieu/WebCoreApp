﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Data.Interfaces;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Product()
        {

        }

        public Product(string name, int categoryId, int authorId, int publisherId, string Image,
            decimal price, decimal? promotionPrice,
            string description, string content, bool? homeFlag, bool? hotFlag,
           Status status, string seoAlias, int viewCount, float width, float height, int totalPage)
        {
            Name = name;
            CategoryId = categoryId;
            AuthorId = authorId;
            PublisherId = publisherId;
            this.Image = Image;
            Price = price;
            PromotionPrice = promotionPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Status = status;
            SeoAlias = seoAlias;
            ViewCount = viewCount;
            Width = width;
            Height = height;
            TotalPage = totalPage;
        }

        public Product(int id, string name, int categoryId, int authorId, int publisherId, string Image,
             decimal price, decimal? promotionPrice,
             string description, string content, bool? homeFlag, bool? hotFlag,
             Status status, string seoAlias, DateTime dateCreated,
             float width, float height, int totalPage)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            AuthorId = authorId;
            PublisherId = publisherId;
            this.Image = Image;
            Price = price;
            PromotionPrice = promotionPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Status = status;
            SeoAlias = seoAlias;
            DateCreated = dateCreated;
            DateModified = DateTime.Now;
            Width = width;
            Height = height;
            TotalPage = totalPage;

        }
        #region Property
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public float Height { get; set; }

        [Required]
        public float Width { get; set; }

        [Required]
        public int TotalPage { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { set; get; }

        [Required]
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { set; get; }

        public string Image { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int ViewCount { get; set; }

        public string Votes { get; set; }

        [StringLength(255)]
        public string SeoAlias { set; get; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public Status Status { set; get; }
        # endregion
    }
}
