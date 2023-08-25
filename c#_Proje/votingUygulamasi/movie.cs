namespace votingUygulamasi
{
    class movie
    {
        private int movieId;
        private string movieName;
        private int voteCount;

        public int MovieId { get => movieId; set => movieId = value; }
        public string MovieName { get => movieName; set => movieName = value; }
        public int VoteCount {get => voteCount; set => voteCount = value; }

        public movie(int movieId, string movieName){
            this.movieId = movieId;
            this.movieName = movieName;
            this.voteCount = 0;
        }
        public void vote(){
            voteCount++;
        }
    }
}