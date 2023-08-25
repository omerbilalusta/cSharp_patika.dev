using System.IO;

namespace ATMUygulamasi
{
    class User
    {
        private int accountNo;
        private string name;
        private double balance;
        private string password;
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Password { get => password; set => password = value; }

        public User(int accountNo, string name, string password){
            this.accountNo = accountNo;
            this.name = name;
            this.balance = 0;
            this.password = password;
        }
        public User(){
            this.accountNo=0;
            this.name="";
            this.balance=0;
            this.password="";
        }
    }
    class UserManagement
    {
        public static User logIn(int accountNo, List<User> userList){
            StreamWriter sw = new StreamWriter("F:/Kodlar/c#/c#_Proje/ATMUygulamasi/"+String.Format("{0:dd-MM-yyyy}", DateTime.Today)+".txt", true);
            foreach (var item in userList)
            {
                if(item.AccountNo == accountNo){
                    Console.WriteLine("{0} Hoşgeldiniz! \nŞifrenizi giriniz", item.Name);
                    string inputPassword = Console.ReadLine();
                    if(item.Password == inputPassword){
                        Console.WriteLine("Giriş Başarılı!");
                        sw.WriteLine("{0}: {1} hesap nolu kullanıcı giriş yaptı.", DateTime.Now, accountNo);
                        sw.Close();
                        return item;
                    }
                    else{
                        sw.WriteLine("{0}: {1} hesap nolu kullanıcı hatalı parola girdi. ", DateTime.Now, accountNo);
                        sw.Close();
                        Console.WriteLine("Hatalı parola! Lütfen tekrar deneyiniz.");
                        logIn(accountNo, userList);
                        return item;
                    }
                }
            }
            sw.Close();
            return(new User(0,"null","null"));
        }
        public static User userRegister(){
            StreamWriter sw = new StreamWriter("F:/Kodlar/c#/c#_Proje/ATMUygulamasi/"+String.Format("{0:dd-MM-yyyy}", DateTime.Today)+".txt", true);
            Random random = new Random();
            Console.WriteLine("Hesabınız bulunamadı. Adınıza hesap açılabilmesi için isminizi giriniz: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Şifre giriniz: ");
            string inputPassword = Console.ReadLine();
            int newAccountNo = random.Next(1000,10000);
            Console.WriteLine("Hesabınız {0} hesap no ile başarıyla oluşturuldu, {1} !", newAccountNo,inputName);
            sw.WriteLine("{0}: {1} hesap no ile yeni kullanıcı oluşturuldu.", DateTime.Now, newAccountNo);
            sw.Close();
            return new User(newAccountNo, inputName, inputPassword);
        }
        public static User depositMoney(User user){
            StreamWriter sw = new StreamWriter("F:/Kodlar/c#/c#_Proje/ATMUygulamasi/"+String.Format("{0:dd-MM-yyyy}", DateTime.Today)+".txt", true);
            Console.WriteLine("Yatırmak istediğiniz para miktarını giriniz: ");
            int inputDepositMoney = Int32.Parse(Console.ReadLine());
            user.Balance += inputDepositMoney;
            Console.WriteLine("{0} miktar hesabınıza başarıyla yatırıldı. Yeni hesap bakiyeniz: {1}", inputDepositMoney, user.Balance);
            sw.WriteLine("{0}: {1} hesap nolu kullanıcı hesabına {2} miktar para yatırdı.", DateTime.Now, user.AccountNo, inputDepositMoney);
            sw.Close();
            return user;
        }
        public static User withdrawalMoney(User user){
            StreamWriter sw = new StreamWriter("F:/Kodlar/c#/c#_Proje/ATMUygulamasi/"+String.Format("{0:dd-MM-yyyy}", DateTime.Today)+".txt", true);
            Console.WriteLine("\nÇekmek istediğiniz miktarı giriniz: ");
            int inputWithdrawalMoney = Int32.Parse(Console.ReadLine());
            if(user.Balance >= inputWithdrawalMoney){
                user.Balance-=inputWithdrawalMoney;
                Console.WriteLine("{0} miktarı hesabınızdan başarıyla çektiniz. Yeni hesap bakiyeniz: {1}", inputWithdrawalMoney, user.Balance);
                sw.WriteLine("{0}: {1} hesap nolu kullanıcı hesabından {2} miktar para çekti.", DateTime.Now, user.AccountNo, inputWithdrawalMoney);
                sw.Close();
            }
            else{
                Console.WriteLine("Hesabınızdaki bakiye bu işlem için yeterli değildir.\nBakiyeniz {0}\nSizi ana menüye aktarıyorum.", user.Balance);
                sw.WriteLine("{0}: {1} hesap nolu kullanıcı tarafından {2} miktar büyüklüğünde başarısız para çekme işlemi.", DateTime.Now, user.AccountNo, inputWithdrawalMoney);
                sw.Close();
            }   
            return user;
        }
        public static List<User> remitMoney(User user, List<User> userList){
            StreamWriter sw = new StreamWriter("F:/Kodlar/c#/c#_Proje/ATMUygulamasi/"+String.Format("{0:dd-MM-yyyy}", DateTime.Today)+".txt", true);
            Console.WriteLine("Havale yapmak istediğiniz kişinin hesap numarasını giriniz:");
            int inputAccountNo = Int32.Parse(Console.ReadLine());
            User receivingUser = userCheck(inputAccountNo, userList);
            if(receivingUser.AccountNo != 0){
                Console.WriteLine("Göndermek istediğiniz tutarı giriniz.");
                int input_remitMoney = Int32.Parse(Console.ReadLine());
                if(user.Balance >= input_remitMoney){
                    userList.Remove(user);
                    userList.Remove(receivingUser);
                    user.Balance -= input_remitMoney;
                    receivingUser.Balance += input_remitMoney;
                    Console.WriteLine("Havale işlemi başarılı!\n{0} kullanıcısına hesabınızdan {1} miktar havale yapıldı. Güncel hesap bakiyeniz: {2}", receivingUser.Name, input_remitMoney, user.Balance);
                    userList.Add(user);
                    userList.Add(receivingUser);
                    sw.WriteLine("{0}: {1} hesap nolu kullanıcı {2} nolu hesaba {3} miktarında havale yaptı.", DateTime.Now, user.AccountNo, receivingUser.AccountNo, input_remitMoney);
                    sw.Close();
                    return userList;
                }
                else
                {
                    Console.WriteLine("Havale işlemi başarısız! Hesabınızda {0} miktarında bakiye bulunmamaktadır.");
                    sw.WriteLine("{0}: {1} hesap nolu kullanıcı tarafından {2} değerinde başarısız havale denemesi", DateTime.Now, user.AccountNo, input_remitMoney);
                }
            }
            else{
                Console.WriteLine("{0} ile eşleşen kullanıcı bulunamadı.\nTekrar deneyiniz.", inputAccountNo);
                sw.WriteLine("{0}: {1} hesap nolu kullanıcı tarafından başarısız havale denemesi", DateTime.Now, user.AccountNo);
                sw.Close();
                remitMoney(user, userList);
            }
            sw.Close();
            return userList;
        }
        public static User userCheck(int accountNo, List<User> userList){
            foreach (var item in userList)
            {
                if(item.AccountNo == accountNo)
                    return item;
            }
            return new User(0,"","");
        }
    }
}