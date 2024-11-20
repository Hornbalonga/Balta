using Balta.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO", "orientacao-obletos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet")); 

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses  = new List<Course>();  
            var courseOOP = new Course("Fundamentos OPP", "fundamentos-opp");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-c#");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-asp.net");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Carrer>();
            var careerDotnet = new Career("Especiallista em .NET", "especialista-dotnet");
            var careerItem = new CarrerItem(1,"Comece por aqui","", null);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var course in careerItem.Items) {
                    Console.WriteLine($"{careerItem.Order}, {careerItem.Title}");
            }
        }
    }
}
