using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp18
//{
//    class Program
//    {
//        public static void DrawSquare(int size, char symbol)
//        {
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    Console.Write(symbol);
//                }
//                Console.WriteLine();
//            }
//        }

//        public static bool IsPalindrome(int number)
//        {

//            string strNumber = number.ToString();


//            string reversed = "";

//            for (int i = strNumber.Length - 1; i >= 0; i--)
//            {
//                reversed += strNumber[i];
//            }


//            return strNumber == reversed;
//        }

//        public static T[] FilterOut<T>(T[] originalArray, T[] filterArray)
//        {
//            HashSet<T> filterSet = new HashSet<T>(filterArray);
//            List<T> resultList = new List<T>();

//            foreach (T item in originalArray)
//            {
//                if (!filterSet.Contains(item))
//                {
//                    resultList.Add(item);
//                }
//            }

//            return resultList.ToArray();
//        }

//        static void Main()
//        {
//            DrawSquare(5, '#');

//            Console.WriteLine(IsPalindrome(1221)); 
//            Console.WriteLine(IsPalindrome(3443));
//            Console.WriteLine(IsPalindrome(7854));


//            int[] original = { 1, 2, 3, 4, 5, 6 };
//            int[] filterData = { 2, 4, 6 };

//            int[] filtered = FilterOut(original, filterData);

//            Console.WriteLine("Массив после фильтрации:");
//            foreach (int item in filtered)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

//namespace WebSiteNamespace
//{
//    class WebSite
//    {
//        private string name;        
//        private string path;      
//        private string description;
//        private string ipAddress;  

//        public WebSite()
//        {
//            name = "";
//            path = "";
//            description = "";
//            ipAddress = "";
//        }

//        public void InputData()
//        {
//            Console.Write("Введите название сайта: ");
//            name = Console.ReadLine();

//            Console.Write("Введите путь к сайту: ");
//            path = Console.ReadLine();

//            Console.Write("Введите описание сайта: ");
//            description = Console.ReadLine();

//            Console.Write("Введите IP адрес сайта: ");
//            ipAddress = Console.ReadLine();
//        }

//        public void DisplayData()
//        {
//            Console.WriteLine("Информация о сайте:");
//            Console.WriteLine($"Название: {name}");
//            Console.WriteLine($"Путь: {path}");
//            Console.WriteLine($"Описание: {description}");
//            Console.WriteLine($"IP адрес: {ipAddress}");
//        }

//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        public string Path
//        {
//            get { return path; }
//            set { path = value; }
//        }

//        public string Description
//        {
//            get { return description; }
//            set { description = value; }
//        }

//        public string IpAddress
//        {
//            get { return ipAddress; }
//            set { ipAddress = value; }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WebSite site = new WebSite();

//            site.InputData();

//            site.DisplayData();

//            site.Name = "Новый сайт";
//            site.IpAddress = "192.168.1.1";

//            Console.WriteLine("\nОбновленная информация:");
//            site.DisplayData();

//            Console.ReadLine();
//        }
//    }
//}

//namespace JournalExample
//{
//    class Journal
//    {
//        private string title;           
//        private int yearFounded;        
//        private string description;     
//        private string contactPhone;   
//        private string contactEmail;   

//        public void InputData()
//        {
//            Console.Write("Введите название журнала: ");
//            title = Console.ReadLine();

//            Console.Write("Введите год основания: ");
//            while (!int.TryParse(Console.ReadLine(), out yearFounded))
//            {
//                Console.Write("Некорректный ввод. Пожалуйста, введите год (число): ");
//            }

//            Console.Write("Введите описание журнала: ");
//            description = Console.ReadLine();

//            Console.Write("Введите контактный телефон: ");
//            contactPhone = Console.ReadLine();

//            Console.Write("Введите контактный e-mail: ");
//            contactEmail = Console.ReadLine();
//        }

//        public void DisplayData()
//        {
//            Console.WriteLine("\nИнформация о журнале:");
//            Console.WriteLine($"Название: {title}");
//            Console.WriteLine($"Год основания: {yearFounded}");
//            Console.WriteLine($"Описание: {description}");
//            Console.WriteLine($"Контактный телефон: {contactPhone}");
//            Console.WriteLine($"Контактный e-mail: {contactEmail}");
//        }

//        public string GetTitle() => title;
//        public void SetTitle(string value) => title = value;

//        public int GetYearFounded() => yearFounded;
//        public void SetYearFounded(int value) => yearFounded = value;

//        public string GetDescription() => description;
//        public void SetDescription(string value) => description = value;

//        public string GetContactPhone() => contactPhone;
//        public void SetContactPhone(string value) => contactPhone = value;

//        public string GetContactEmail() => contactEmail;
//        public void SetContactEmail(string value) => contactEmail = value;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Journal journal = new Journal();

//            journal.InputData();

//            journal.DisplayData();

//            journal.SetTitle("Новый журнал");
//            journal.SetContactEmail("newemail@example.com");

//            Console.WriteLine("\nОбновленная информация:");
//            journal.DisplayData();
//        }
//    }
//}

namespace StoreExample
{
    class Store
    {
        private string name;             
        private string address;          
        private string profileDescription; 
        private string contactPhone;   
        private string contactEmail;    

        public void InputData()
        {
            Console.Write("Введите название магазина: ");
            name = Console.ReadLine();

            Console.Write("Введите адрес: ");
            address = Console.ReadLine();

            Console.Write("Введите описание профиля магазина: ");
            profileDescription = Console.ReadLine();

            Console.Write("Введите контактный телефон: ");
            contactPhone = Console.ReadLine();

            Console.Write("Введите контактный e-mail: ");
            contactEmail = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nИнформация о магазине:");
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Описание профиля: {profileDescription}");
            Console.WriteLine($"Контактный телефон: {contactPhone}");
            Console.WriteLine($"Контактный e-mail: {contactEmail}");
        }

        public string GetName() => name;
        public void SetName(string value) => name = value;

        public string GetAddress() => address;
        public void SetAddress(string value) => address = value;

        public string GetProfileDescription() => profileDescription;
        public void SetProfileDescription(string value) => profileDescription = value;

        public string GetContactPhone() => contactPhone;
        public void SetContactPhone(string value) => contactPhone = value;

        public string GetContactEmail() => contactEmail;
        public void SetContactEmail(string value) => contactEmail = value;
    }

    class Program
    {
        static void Main()
        {
            Store store = new Store();

            store.InputData();

            store.DisplayData();

            store.SetName("Магазин «Лучший выбор»");
            store.SetContactEmail("info@bestchoice.com");

            Console.WriteLine("\nОбновленная информация:");
            store.DisplayData();

        }
    }
}
