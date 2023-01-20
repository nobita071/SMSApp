namespace BusinessLayer
{
    public class SampleCls
    {
        internal protected string Message { get; set; } = "Welcome to Sample class BL";

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }
    }
}