namespace votingUygulamasi
{
    class user
    {
        private int id;
        private string name;
        private string e_mail;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }

        public user (int id, string name, string e_mail){
            this.id = id;
            this.name = name;
            this.e_mail = e_mail;
        }
    }
}