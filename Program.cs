using System;
using mis321_exam1_ectew1.Interfaces;

namespace mis321_exam1_ectew1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITrain sitting = new Sit(); //creating temp object of ITrain interface
            ITrain staying = new Stay();
            ITrain shaking = new Shake(); 

            Trainer myTrainer = new Trainer(); //creating the Trainer object to access the ITrain trainBehavior property under

            myTrainer.trainBehavior.Train(); //the default trainBehavior is to sit in the Trainer class

            myTrainer.SetTrainBehavior(staying); //to make the trainer teach the dog to stay, must set the behavior to Stay behavior
            myTrainer.trainBehavior.Train();

            myTrainer.SetTrainBehavior(shaking); //same as above but now setting it to shake 
            myTrainer.trainBehavior.Train();

            /*the trainBehavior is now set on shaking, so it will cont to teach the dog to shake
            unless set to do something else*/

            /*this design makes it easy for the client to add other tricks in the future because 
            they can just add another class that implements ITrain, make a distinct behavior under the Train method, create another 
            ITrain object in Main and then use the same Trainer object myTrainer and it's Set method to interchange the behaviors*/
            
            /*for example, I added another behavior Sleep and it took like 5 lines of code*/
            System.Console.WriteLine("\nAnd just for fun...");
            ITrain sleeping = new Sleep();
            myTrainer.SetTrainBehavior(sleeping);
            myTrainer.trainBehavior.Train();
        }
    }
}
