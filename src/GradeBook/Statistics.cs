namespace GradeBook
{
    public class Statistics
    {
        public double Low;

        public double High;

        public double Average;

        public char Letter;

        public void DefineAverageLetter()
        {
            switch(this.Average)
            {
                case var average when average > 9.0:
                    this.Letter = 'A';
                    break;
                case var average when average > 8.0:
                    this.Letter = 'B';;
                    break;
                case var average when average > 7.0:
                    this.Letter = 'C';
                    break;
                case var average when average > 6.0:
                    this.Letter = 'D';
                    break;
                default:
                    this.Letter = 'E';
                    break;
            }
        }
    }
}