using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Name = "victus";
            notebook1.BrandName = "Hp";
            notebook1.Price = 3000;
            Console.WriteLine($"{notebook1.Name} {notebook1.BrandName} {notebook1.Price}");



            Notebook[] NoteBooks = new Notebook[3];

            NoteBooks[0] = notebook1;

            NoteBooks[1] = new Notebook()
            {
                Name = "TafDash",
                BrandName = "Asus",
                Price = 2300,
            };

            NoteBooks[2] = new Notebook();
            NoteBooks[2].Name = "IdeaPad";
            NoteBooks[2].BrandName = "Lenovo";
            NoteBooks[2].Price = 2400;



            Console.WriteLine("minprice daxil edin: ");
            string minpriceStr = Console.ReadLine();
            double minprice = double.Parse(minpriceStr);

            Console.WriteLine("maxprice daxil edin: ");
            string maxpriceStr = Console.ReadLine();
            double maxprice = double.Parse(maxpriceStr);


            
            string Name = null;
            for (int i = 0; i <NoteBooks.Length; i++)
            { 
                if (NoteBooks[i].Price>minprice && NoteBooks[i].Price<maxprice )
                {
                    
                    
                        Name+=NoteBooks[i].Name;    
                    
                    
                }
                

                
            }
            Console.WriteLine("_______________");
            Console.WriteLine($"{Name} ");

            foreach (var item in Name)
            {

            }


        }
    }
}
