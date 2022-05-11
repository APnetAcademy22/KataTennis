namespace TennisKata
{
    public class Game
    {
        private string Player1 { get; set; }
        private string Player2 { get; set; }
        public Game ( string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        public string ResultToString(int pointsPlayer1, int pointsPlayer2)
        {
            throw new NotImplementedException();
        }
    }
}