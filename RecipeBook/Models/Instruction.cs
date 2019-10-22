namespace RecipeBook.Models
{
    public class Instruction
    {
        public int InstructionId {get;set;}
        public string Step { get; set; }
        public double Time { get; set; }

        public int RecipeID {get;set;}    
    }
}