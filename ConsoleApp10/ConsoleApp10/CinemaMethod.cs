namespace ConsoleApp10
{
    public class CinemaMethod
    {
        private string movieTitle;
        private readonly decimal ticketPrice;
        private int audienceCount;
        private string hall;

        public CinemaMethod(string movieTitle, decimal ticketPrice, string hall)
        {
            this.movieTitle = movieTitle;
            this.ticketPrice = ticketPrice;
            this.hall = hall;
        }

        public string GetMovieTitle()
        {
            return movieTitle;
        }

        public void SetMovieTitle(string value)
        {
            movieTitle = value;
        }

        public decimal GetTicketPrice()
        {
            return ticketPrice;
        }

        public string GetHall()
        {
            return hall;
        }

        public string GetInformation()
        {
            return $"Фильм: {GetMovieTitle()}, Стоимость билета: {GetTicketPrice():C}, Зал: {GetHall()}, Количество зрителей: {audienceCount}";
        }
    }
}