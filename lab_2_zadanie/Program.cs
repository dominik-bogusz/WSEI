using System;
using System.Collections.Generic;

namespace lab_2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller treacher = new Seller("Jan Kowalski", 50);

            Buyer buyer1 = new Buyer("Jaś Fasola 1", 25);
            Buyer buyer2 = new Buyer("Jaś Fasola 2", 21);
            Buyer buyer3 = new Buyer("Jaś Fasola 3", 23);

            buyer1.AddProduct(new Fruit("Apple", 6));
            buyer1.AddProduct(new Meat("Fish", 0.5));

            Person[] persons = { treacher, buyer1, buyer2, buyer3 };

            Product[] products = {
                new Fruit("Apple", 1000),
                new Fruit("Banana", 700),
                new Fruit("Orange", 500),
                new Meat("Fish", 100.0),
                new Meat("Beef", 75.0)
            };

            Shop shop = new Shop("Super Market", persons, products);

            shop.Print();
        }

        public interface IThing
        {
            string Name { get; }
        }

        public abstract class Person : IThing
        {
            protected string name;
            protected int age;
            public string Name { get => name; }
            public int Age { get => age; }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public virtual void Print(string prefix)
            {
                Console.WriteLine($"{prefix}");
            }
        }

        public class Buyer : Person
        {
            List<Product> tasks = new List<Product>();
            public Buyer(string name, int age) : base(name, age)
            {
                this.name = name;
                this.age = age;
            }
            public void AddProduct(Product product)
            {
                tasks.Add(product);
            }
            public void RemoveProduct(int index)
            {
                tasks.RemoveAt(index);
            }
            public override void Print(string prefix)
            {
                Console.WriteLine($"{prefix}: {name} ({age} y.o.)");
            }
        }

        public class Seller : Person
        {
            public Seller(string name, int age) : base(name, age)
            {
                this.name = name;
                this.age = age;
            }
            public override void Print(string prefix)
            {
                Console.WriteLine($"{prefix}: {name} ({age} y.o.)");
            }
        }

        public abstract class Product : IThing
        {
            protected string name;
            public string Name { get => name; }
            public Product(string name)
            {
                this.name = name;
            }
            public virtual void Print(string prefix)
            {
                Console.WriteLine($"{name}");
            }
        }

        public class Fruit : Product
        {
            protected int count;
            public int Count { get => count; }
            public Fruit(string name, int count) : base(name)
            {
                this.name = name;
                this.count = count;
            }
            public override void Print(string prefix)
            {
                Console.WriteLine($"{prefix}{name} ({count} fruits)");
            }
        }

        public class Meat : Product
        {
            protected double weight;
            public double Weight { get => weight; }
            public Meat(string name, double weight) : base(name)
            {
                this.name = name;
                this.weight = weight;
            }
            public override void Print(string prefix)
            {
                Console.WriteLine($"{prefix}{name} ({weight} kg)");
            }
        }

        public class Shop
        {
            protected string name;
            protected Person[] people;
            protected Product[] products;
            public string Name { get => name; }
            public Shop(string name, Person[] people, Product[] products)
            {
                this.name = name;
                this.people = people;
                this.products = products;
            }
            public void Print()
            {
                Console.WriteLine($"Shop: {name}");
                Console.WriteLine("-- People: --");
                for(int i = 0; i < people.Length; i++)
                {
                    Console.Write("         ");
                    if(people[i] is Buyer)
                    {
                        people[i].Print("Buyer");
                    }
                    else if(people[i] is Seller)
                    {
                        people[i].Print("Seller");
                    }
                }
                Console.WriteLine("-- Products: --");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.Write("         ");
                    products[i].Print("");
                }
            }
        }

    }
}
