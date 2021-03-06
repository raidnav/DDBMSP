﻿using System;
using System.Collections.Generic;
using DDBMSP.Entities.User.Components;

namespace DDBMSP.Entities.Article.Components
{
    [Serializable]
    public class ArticleSummary
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public List<string> Tags { get; set; }
        public UserSummary Author { get; set; }
        public Uri Image { get; set; }

        public ArticleSummary() { }

        public ArticleSummary(ArticleState articleState)
        {
            Id = articleState.Id;
            CreationDate = articleState.CreationDate;
            Title = articleState.Title;
            Abstract = articleState.Abstract;
            Tags = articleState.Tags;
            Author = articleState.Author;
            Image = articleState.Image;
        }
    }
}