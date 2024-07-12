namespace Delegates_Class
{

    internal class Program
    {
        //defining the delegate
        public delegate void AddDelegate(int a, int b);
        public delegate string ShowDelegate(string str);
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string Show(string name)
        {
            return "Hey" + name;

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddNums(100, 200);
            string str = Program.Show(" "+"Vaishnavi");
            Console.WriteLine(str);

            //------------------------------------------------

            AddDelegate ad = new AddDelegate(program.AddNums);//non static method
            ad(10, 20);
            ad.Invoke(30, 30);
            ShowDelegate shd = new ShowDelegate(Program.Show);// static method
            shd.Invoke("Vaish");
            string st = shd(" Vighneshwar ");
           
            Console.WriteLine(st);
            //static members can directly access under static class
            //within the class and outside class using class name 

        }
    }

    
}
