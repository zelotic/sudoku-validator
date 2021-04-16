namespace Domain
{
    public class Board
    {
        public Board() 
        {
            Squares = new int[9, 9];
        }

        public bool IsValid { get; set; }
        public int[,] Squares { get; set; }
    }
}
