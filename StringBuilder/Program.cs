using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(DateTime.Parse("15/06/2020 11:13:44"),
                                              "Traveling to new Zealand",
                                              "I'm going to visit this wonderful country",12
                                              );
            // Adicionando os dois comentario no Post:
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good noght");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(DateTime.Parse("16/06/2020 11:28:02"),
                               "Good night guys",
                               "See you tomorow",5
                               );
            p2.AddComment(c3);
            p2.AddComment(c4);

            // Imprimir o conteudo na tela de cada post com os comentarios:

            Console.WriteLine(p1);
            Console.WriteLine(p2);




        }
    }
}
