namespace ExceptionDemo060624
{
    class calculator
    {
        int q;// instance variable OR member variable
        public void sum(int x, int y)
        {
            int p=0;//local variable
            Console.WriteLine(p+q);
            int z = x + y;
            Console.WriteLine("result=" + z);
        }
        public void div(int x,int y)
        {
            int z = x / y;
            Console.WriteLine("result="+z);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n1=0, n2=0;
            Console.WriteLine("*********start of main method************");
            calculator cl = new calculator();
            Console.WriteLine("enter two numbers");
            try
            {
                n1 = int.Parse("20");
                 n2 = int.Parse("10");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.StackTrace);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine("this is finally block#############");
                //con.close();
            }



            cl.sum(n1, n2);


            Console.WriteLine("*********end of main method************");
        }
    }
}
