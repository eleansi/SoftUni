using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo", 5, "male"),
                new Cat("Hello Kitty", 12, "female"),
                new Cat("Kitty", 2, "female"),
                new Frog("Kormorana", 1, "female"),
                new Kitten("Kotence", 5),
                new Tomcat("Marok", 7),
                new Dog("Bucky", 4, "male"),
                new Kitten("Sladurka", 2),
                new Tomcat("Buckle", 7),
                new Frog("Frogcho", 2, "female"),
                new Cat("Maiorka", 2, "female"),
                new Dog("Bary", 8, "male"),
                new Dog("Kiko", 1, "male"),
                new Cat("Mimka", 12, "female"),
                new Cat("Stamat", 1, "male"),
                new Frog("Skoklivka", 5, "female"),
                new Kitten("Melani", 5),
                new Tomcat("Kitodar", 8),
                new Dog("Tuscho", 4, "male"),
                new Kitten("Karamela", 2),
                new Tomcat("Kosio", 7),
                new Frog("Jabka", 2, "female"),
                new Cat("Pantera", 1, "female"),
                new Dog("Maino", 8, "male")

            };

            var dogsCount = animals.FindAll(x => x is Dog).Count;
            var catsCount = animals.FindAll(x => x is Cat).Count;
            var frogsCount = animals.FindAll(x => x is Frog).Count;
            var kittensCount = animals.FindAll(x => x is Kitten).Count;
            var tomcatsCount = animals.FindAll(x => x is Tomcat).Count;

            // Dogs average
            var dogsAge =
                from animal in animals
                    where animal is Dog
                    select animal.Age;
            int dogsTotalAge = dogsAge.Sum();
            double dogsAverageAge = (double) dogsTotalAge/dogsCount;

            // Cats average
            var catsAge =
                from animal in animals
                where animal is Cat
                select animal.Age;
            int catsTotalAge = catsAge.Sum();
            double catsAverageAge = (double)catsTotalAge / catsCount;

            // Frogs average
            var frogsAge =
                from animal in animals
                where animal is Frog
                select animal.Age;
            int frogsTotalAge = frogsAge.Sum();
            double frogsAverageAge = (double)frogsTotalAge / frogsCount;

            // Kittens average
            var kittensAge =
               from animal in animals
               where animal is Kitten
               select animal.Age;
            int kittensTotalAge = kittensAge.Sum();
            double kittensAverageAge = (double)kittensTotalAge / kittensCount;

            // Tomcats average
            var tomcatsAge =
               from animal in animals
               where animal is Tomcat
               select animal.Age;
            int tomcatsTotalAge = tomcatsAge.Sum();
            double tomcatsAverageAge = (double)tomcatsTotalAge / tomcatsCount;

            // Printing
            Console.WriteLine("Number of dogs: {0}, Average years: {1} years", dogsCount, dogsAverageAge);
            Console.WriteLine("Number of cats: {0}, Average years: {1} years", catsCount, catsAverageAge);
            Console.WriteLine("Number of frogs: {0}, Average years: {1} years", frogsCount, frogsAverageAge);
            Console.WriteLine("Number of kittens: {0}, Average years: {1} years", kittensCount, kittensAverageAge);
            Console.WriteLine("Number of tomcats: {0}, Average years: {1} years", tomcatsCount, tomcatsAverageAge);

        }
    }
}
