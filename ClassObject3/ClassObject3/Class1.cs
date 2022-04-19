namespace ClassObject3
{
    internal class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {

        }

        public string Name { get; set; }



        //public int Age { get; set; } //korotkaja komanda

        //iekapsulesana
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    

        public Car Car { get; set; }


        public bool isFemale { get; set; }

        public bool isAdult
        {
            get
            {
                return Age >= 18;
            }
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello, my name is: {Name} and I am {Age} years old.");
        }

        public bool GetIsAdult()
        {
            return Age >= 18;
        }

    }
}
