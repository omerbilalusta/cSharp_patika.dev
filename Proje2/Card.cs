namespace Proje2
{
    class Card
    {
        private string title;               //card nesnelerini burada tanımladım ve kapsülleme işlemine tabii tuttum
        private string content;
        private Boyut boyut;
        private string kisiName;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public Boyut Boyut { get => boyut; set => boyut = value; }
        public string KisiName { get => kisiName; set => kisiName = value; }

        public Card (string title, string content, Boyut boyut, string kisiName){
            this.title = title;
            this.content = content;
            this.boyut = Boyut;
            this.kisiName = kisiName;
        }
    }
}