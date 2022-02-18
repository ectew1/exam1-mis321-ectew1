using mis321_exam1_ectew1.Interfaces;

namespace mis321_exam1_ectew1
{
    public class Trainer
    {
        public ITrain trainBehavior { get; set;}

        public Trainer()
        {
            trainBehavior = new Sit();
        }

        public void SetTrainBehavior(ITrain trainBehavior)
        {
            this.trainBehavior = trainBehavior;
        }
    }
}