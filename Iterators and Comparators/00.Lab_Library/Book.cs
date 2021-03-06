﻿using System;
using System.Collections.Generic;

public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public int Year { get; set; }
    public IReadOnlyList<string> Authors { get; set; }

    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = new List<string>(authors);
    }

    public int CompareTo(Book other)
    {
        return new BookComparator().Compare(this, other);
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }

    
}
