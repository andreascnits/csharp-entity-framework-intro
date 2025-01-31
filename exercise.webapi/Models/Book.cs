﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<Author> Authors { get; set; }
        public Publisher Publisher { get; set; }
    }
}
