using Domain;

namespace Service.Interfaces
{
    public interface IBoardService
    {
        Board ReadBoard();
        bool ValidateBoard();
    }
}
