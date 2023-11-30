using PhoneBook.Models;
using PhoneBook.Services;
using PhoneBook.Domain;
using PhoneBook.Domain.Enums;


var db = new ApplicationContext();

var userRepo=new UserRepository(db);
var userService = new UserService();
var phoneNumberRepo = new PhoneNumbersRepository();
var phoneNumberService = new PhoneNumberService();
var json=new JsonContext();
userRepo.RepoEventHadler += ConsoleHelper.ForEvent;

List<User> phoneBook=new List<User>();

bool IsEnd=false;
bool inputOver=false;

while (IsEnd != true)
{
    int choice = ConsoleHelper.MainMenu();
    Console.ReadKey();
    switch (choice)
    {
        case 0:
            IsEnd = true;
            break;
        case 1:
            string name = ConsoleHelper.InputName();
            int numb = ConsoleHelper.InputCategory();
            var user=userService.Create(name, numb);
            while(inputOver!=true)
            {
                
                int choice1=ConsoleHelper.NumberInputMenu();
                switch(choice1)
                {
                    case 0:
                        inputOver = true;
                        break;
                     case 1:
                        string number=ConsoleHelper.InputNumber();
                        int numbSp = ConsoleHelper.InputSpecies();
                        var phoneNumber=phoneNumberService.Create(number, numbSp);
                        user.phoneNumbers.Add(phoneNumber);
                        break;
                        
                }
            }
            userRepo.Add(user);
            break;
        case 2:
            userRepo.Delete(userService.Get(ConsoleHelper.InputName(),userRepo.GetAll()));
            break;
         case 3:
            var user1 =userService.Get(ConsoleHelper.InputName(),userRepo.GetAll());
            user1.Showuser();
            int changeChoice = ConsoleHelper.ChangeMenu();
            switch (changeChoice)
            {
                case 0:
                    IsEnd=true; break;
                case 1:
                    string value = ConsoleHelper.InputNumber();
                    var phoneNumb = phoneNumberService.Get(value, user1.phoneNumbers.AsQueryable());
                    phoneNumberRepo.user = user1;
                    phoneNumberRepo.Delete(phoneNumb);
                    userRepo.Update(user1);
                    break;
                 case 2:
                    int number2 = ConsoleHelper.InputCategory();
                    user1.Category = (Category)number2;
                    userRepo.Update(user1);
                    break;
                 case 3:
                    string value1=ConsoleHelper.InputName();
                    user1.Name=value1;
                    userRepo.Update(user1);
                    break;
                  case 4:
                    value=ConsoleHelper.InputNumber();
                    phoneNumberRepo.Add(phoneNumberService.Get(value,user1.phoneNumbers.AsQueryable()));
                    userRepo.Update(user1);
                    break;

            }
            break;
        case 4:
            var user2 = userService.Get(ConsoleHelper.InputName(), userRepo.GetAll());
            user2.Showuser();
            userService.ShowAllUser(userRepo.GetAll());
            break;
        case 5:
           json.Export(userRepo.GetAll().ToList());
            break;
         case 6:
            var list = json.Import();
            userService.ShowAllUser(list.AsQueryable());
            break;
         case 7:
            int number3=ConsoleHelper.InputCategory();
            var list1=userService.GetAllCategory((Category)number3,userRepo.GetAll()).ToList();
            userService.ShowAllUser(list1.AsQueryable());
            break;

    }
}