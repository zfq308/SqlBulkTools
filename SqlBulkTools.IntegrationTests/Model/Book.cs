﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlBulkTools.IntegrationTests.Model
{
    public class Book
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public int? WarehouseId { get; set; }

        [MaxLength(13)]
        [Index]
        public string ISBN { get; set; }

        [MaxLength(256)]
        [Index]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public DateTime? PublishDate { get; set; }

        [Required]
        [Index]
        public decimal? Price { get; set; }

        public float? TestFloat { get; set; }

        public object InvalidType { get; set; }

        public int? TestNullableInt { get; set; }

        public bool? BestSeller { get; set; }

        public DateTime? CreatedAt { get; set; } // nullable because it only references a few tests.

        public DateTime? ModifiedAt { get; set; } // nullable because it only references a few tests.
    }

}
