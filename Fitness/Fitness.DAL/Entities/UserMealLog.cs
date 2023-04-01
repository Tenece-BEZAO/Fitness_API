namespace Fitness.DAL.Entities
{
    public class UserMealLog : MealLog
    {
        public string FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }

    }


}
