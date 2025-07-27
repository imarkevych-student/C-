namespace _15_Dictionary_Homework
{
    class Program
    {
        static void Main()
        {
            Phonebook book = new Phonebook();

            book.AddContact("Іван", "0971234567");
            book.AddContact("Олена", "0667654321");
            book.SearchContact("Іван");
            book.UpdateContact("Іван", "0980000000");
            book.DeleteContact("Олена");
            book.DisplayContacts();
        }
    }

}
