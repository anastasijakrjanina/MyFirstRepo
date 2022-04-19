namespace ClassObject3
{
    public class Car
    {
        //properties
        public string Brand { get; set; }

        //metode
        public void BeepBeep()
        {
            Console.WriteLine($"{Brand} beep beep");
        }
    }
}
