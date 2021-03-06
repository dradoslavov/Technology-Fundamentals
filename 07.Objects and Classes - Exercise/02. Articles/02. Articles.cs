﻿using System;


namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] articleProps = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries);
            string title = articleProps[0];
            string content = articleProps[1];
            string author = articleProps[2];
            Article article = new Article(title,content,author);
            int comandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < comandCount; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                string command = input[0] ;
                if (command == "Edit")
                {
                    string newContent = input[1];
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = input[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command=="Rename")
                {
                    string newTitle = input[1];
                    article.Rename(newTitle);
                }
                
            }
            Console.WriteLine(article);



        }
    }
    class Article
    {
        
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string  Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public  void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
            
        }
    }
}
