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
        public string ResultToString(int? pointsPlayer1, int? pointsPlayer2)
        {
            if( ! IsValid(pointsPlayer1) || ! IsValid(pointsPlayer2) )
            {
                throw new InvalidInputException("Input not valid");
            }
            int points1 = (int)pointsPlayer1;
            int points2 = (int)pointsPlayer2;
            if(pointsPlayer1 <= 3 && pointsPlayer2 <= 3)
            {
                if (points1 == 3 && points2 == 3)
                    return "Deuce";
                else return $"{PointsToStringName(points1)}-{PointsToStringName(points2)}";
            }
            if (Math.Abs(points2 - points1) <= 1)
            {
                if (points1 == points2)
                    return "Deuce";
                if (points1 > points2)
                    return $"Advantage for {Player1}";
                if (points1 < points2)
                    return $"Advantage for {Player2}";
            }
            else throw new ImpossibleGameException("That result cannot exist");
            return "error";
        }
        private string PointsToStringName(int points)
        {
            switch (points)
            {
                case 0: return "Love";
                case 1: return "Fifteen";
                case 2: return "Thirty";
                case 3: return "Forty";
                default: throw new InvalidInputException("Cannot find a name for these points!");
            } 
        }
        private bool IsValid(int? points)
        {
            return points >= 0 && points != null;
        }
        
    }
}