// using System;

// // ================= ABSTRACT CLASS =================
// abstract class LibraryItem
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public int ItemID { get; set; }

//     public LibraryItem(string title, string author, int itemid)
//     {
//         Title = title;
//         Author = author;
//         ItemID = itemid;
//     }

//     public abstract void DisplayItem();
//     public abstract double LateFee(int days);
// }

// // ================= BOOK CLASS =================
// class Book : LibraryItem, IReservable, INotifiable
// {
//     public Book(string title, string author, int itemid)
//         : base(title, author, itemid) { }

//     public override void DisplayItem()
//     {
//         Console.WriteLine("Item Type: Book");
//         Console.WriteLine($"Title: {Title}");
//         Console.WriteLine($"Author: {Author}");
//         Console.WriteLine($"Item ID: {ItemID}");
//     }

//     public override double LateFee(int days)
//     {
//         return days * 1.0;
//     }
    
//     public void ReserveItem()
//     {
//         Console.WriteLine("Book reserved successfully.");
//     }
//     public void acceptMessage(string message)
//     {
//         Console.WriteLine($"Notification sent: {message}");
//     }

// }

// // ================= MAGAZINE CLASS =================
// class Magazine : LibraryItem
// {
//     public Magazine(string title, string author, int itemid)
//         : base(title, author, itemid) { }

//     public override void DisplayItem()
//     {
//         Console.WriteLine("Item Type: Magazine");
//         Console.WriteLine($"Title: {Title}");
//         Console.WriteLine($"Author: {Author}");
//         Console.WriteLine($"Item ID: {ItemID}");
//     }

//     public override double LateFee(int days)
//     {
//         return days * 0.5;
//     }
// }



// interface IReservable
// {
//     void ReserveItem();
// }
// interface INotifiable
// {
//     void acceptMessage(string message);
// }

// LibraryItem[] items ={books,magazines};
// foreach(LibraryItem item in items)
// {
//     item.DisplayItem();
//     Console.WriteLine($"Late Fee for 5 days: {item.LateFee(5)}");
//     Console.WriteLine("method selections happens at runtime");
// }
// IReservable reservableBook = books;
// INotifiable notifiableBook = books;
// reservableBook.ReserveItem();
// notifiableBook.acceptMessage("Your book is due soon!");