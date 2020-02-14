using System;

namespace csharp
{
    public enum Gender {Male, Female};
    class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        public Dog(string name1, string owner1, int age1, Gender gen)
        {
            name = name1;
            owner = owner1;
            age = age1;
            gender = gen;

        }

        public void Bark(int times){
            int i = 1;
            while (i<= times){
                Console.WriteLine("Woof!");
                i++;
            }
        }
       
        public void GetTag(){
            Console.Write("If lost, call " + owner + ". ");

            if(gender == 0){
                Console.Write("His name is "+ name + " and he is ");
            } else {
                Console.Write("Her name is "+ name + " and she is ");
            }

            if(age <= 1){
                Console.Write(age + " year old.");
            } else {
                Console.Write(age + " years old.");
            }
        }
    }

    class Program{
        static void Main(string[] args){
            Dog d = new Dog("James", "John", 1, Gender.Female);
            d.Bark(5);
            d.GetTag();
        }
    }
}