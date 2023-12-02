using System;
namespace AuthorandBookManagementSystem
{
	public class Author
	{

		string authorName;
		int birthYear;
		string nationality;
		private Book[] books = new Book[3] ;

		public Author() { }

		public Author(string name, int birthYear, string nationality)
		{
			this.authorName = name;
			this.birthYear = birthYear;
			this.nationality = nationality;
		}

		public string AuthorName
		{
			get { return authorName; }
		}
        public int BirthYear
        {
            get { return birthYear; }
        }
        public string Nationality
        {
            get { return nationality; }
        }

        public Book[] Books
        {
            get { return books; }
			set { this.books = value; }
        }

        public string displayAouthorInfo()=> $"Aouther name : {this.authorName} \n " +
											$"Year of Birth: {this.birthYear} \n " +
											$"Nationality : {this.nationality}";
		

		public void addBooks(string title, int year, string genre)
		{
			for (int i = 0; i < books.Length; i++)
			{
				if (books[i] == null)
				{
					books[i] = new Book(title, year, genre);
				}
			}
        }

		public string displaybookForAuthor()
		{
			for (int i = 0; i < books.Length; i++)
			{
				if (books[i] != null )
					return $"{books[i].displayBookInfo()}";
			}
			return " ";
		}


    }
}

