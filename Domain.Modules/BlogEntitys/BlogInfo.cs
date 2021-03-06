﻿using System;
using Domain.Seedwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Modules.BlogEntitys
{
    /// <summary>
    /// A blog is the main instance in this API. I contains a list of posts.
    /// </summary>
    public class BlogInfo : EntityGuid, IValidatableObject
    {
        /// <summary>
        /// 博客名
        /// </summary>
        [Column(TypeName = "varchar(128)")]
        public string BlogName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public Guid UserId { get; set; }

        public virtual BlogUser User { get; set; }

        public virtual List<BlogClass> Classes { get; set; }

        public virtual List<BlogArticle> Articles { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //var resources = LocalizationFactory.CreateLocalResources();
            var validationResults = new List<ValidationResult>();

            //if (string.IsNullOrEmpty(Name))
            //    validationResults.Add(new ValidationResult(string.Format(resources.GetStringResource(LocalizationKeys.Domain.validation_PropertyIsEmptyOrNull), "Name", "Blog"), new string[] { "Name" }));

            //if (string.IsNullOrEmpty(Url))
            //    validationResults.Add(new ValidationResult(string.Format(resources.GetStringResource(LocalizationKeys.Domain.validation_PropertyIsEmptyOrNull), "Url", "Blog"), new string[] { "Url" }));

            //if (Rating < 0 && Rating > 5)
            //    validationResults.Add(new ValidationResult(string.Format(resources.GetStringResource(LocalizationKeys.Domain.validation_PropertyOutOfRange), "Rating", "Blog", "-1", "5"), new string[] { "Rating" }));

            return validationResults;
        }
    }
}
