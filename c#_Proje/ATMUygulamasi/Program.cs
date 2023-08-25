using System.IO;

namespace ATMUygulamasi
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            List<User> userList = new List<User>();
            userList.Add(new User(5353,"Ömer","1903"));
            userList.Add(new User(5334,"Yavuz","1903"));
            User loggedUser = new User();
            Console.WriteLine("Hesap numaranızı giriniz: ");
            int accountNo = Int32.Parse(Console.ReadLine());
            User logginUser = UserManagement.logIn(accountNo, userList);
            if(logginUser.AccountNo == 0){
                loggedUser = UserManagement.userRegister();
                userList.Add(loggedUser);
            }
            else
                loggedUser = logginUser;
            
            do
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("Para Yatırma  *************(1)");
                Console.WriteLine("Para Çekme    *************(2)");
                Console.WriteLine("Para Gönderme ************(3)");
                Console.WriteLine("Hesabınızdan çıış yapmak için 9'u tuşlayınız.");
                int choice = Int32.Parse(Console.ReadLine());

                if(choice==1){
                    userList.Remove(loggedUser);
                    loggedUser = UserManagement.depositMoney(loggedUser);
                    userList.Add(loggedUser);
                }
                else if(choice==2){
                    userList.Remove(loggedUser);
                    loggedUser = UserManagement.withdrawalMoney(loggedUser);
                    userList.Add(loggedUser);
                }
                else if(choice==3)
                    userList = UserManagement.remitMoney(loggedUser, userList);
                else{
                    Console.WriteLine("Çıkış başarılı. İyi günler dileriz!");
                    break;
                }
                    
                    
            } while (true);

            userList.ForEach(x=> Console.WriteLine(x.AccountNo + " " + x.Name + " " + x.Balance));
            
        }

    }
}