

namespace day2
{

    class student
    {
        int ssn;
        string name;
        int age;
        string phone;
        public void getdata(int Ssn, string Name, int Age, string Phone = "")
        {
            ssn = Ssn;
            name = Name;
            age = Age;
            phone = Phone;
        }
        public void print()
        {
            Console.WriteLine($"{ssn}-{name}-{age}-{phone}");
        }


    }

    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            student farah = new student();
            farah.getdata(11, "farah", 20, "012222222");
            farah.print();

        }


    }
}

