using System;
namespace AuthorandBookManagementSystem
{
	public class Book
	{
		public string title;
		public int publishYear;
		public string genre;


		public Book() { }

		public Book(string title, int year, string genre)
		{
			this.title = title;
			this.publishYear = year;
			this.genre = genre;
		}

		public string displayBookInfo()
		{
            return $"Book Title : {this.title} \n" +
                $"Year of publish: {this.publishYear} \n" +
                $"genre : {this.genre}";
        }
    }
}

