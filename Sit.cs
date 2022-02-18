using mis321_exam1_ectew1.Interfaces;

namespace mis321_exam1_ectew1
{
    public class Sit : ITrain
    {
        public void Train()
        {
            System.Console.WriteLine("I'm teaching the dog to sit.");
        }
    }
}