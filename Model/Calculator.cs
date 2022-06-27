using System.ComponentModel.DataAnnotations;

namespace ProgrammingExercise.Model
{
    public class Calculator
    {
        [Required]
        public double Num1 { get; set; }

        [Required]
        public Pages.Index.operation op { get; set; }

        [Required]
        public double Num2 { get; set; }
    }
}
