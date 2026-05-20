
using System.Net.Security;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Strings
{
    class Program
    {

        static void Main (string[] args)
        {
            // ConcatinationString 
            Console.WriteLine("Введите строку 1 и 2");

            string str_ConcatinationString_1 = Console.ReadLine () ?? " ";
            string str_ConcatinationString_2 = Console.ReadLine () ?? " ";
            string result_ConcatinationString = ConcatinationString(str_ConcatinationString_1, str_ConcatinationString_2);
            Console.WriteLine(result_ConcatinationString);
            // ConcatinationString 



            Console.WriteLine("-----------------------");



            //GreetUser
            Console.WriteLine("Введите имя:");
            string name_GreetUser = Console.ReadLine() ?? " ";

            Console.WriteLine("Введите возраст:");
            string time_GreetUser = Console.ReadLine() ?? " ";

            int number_GreetUser;

            if (int.TryParse(time_GreetUser, out number_GreetUser))
            {
                Console.WriteLine(GreetUser(name_GreetUser, number_GreetUser));
            }
            else
            {
                Console.WriteLine("Ошибка! Возраст должен быть числом.");
            }
            //GreetUser



            Console.WriteLine("-----------------------");



            //MethodString
            Console.WriteLine("Введите строку");

            string str_MethodString = Console.ReadLine() ?? " ";
            Console.WriteLine(MethodString(str_MethodString));
            //MethodString



            Console.WriteLine("-----------------------");



            //OneFiveCharToString
            Console.WriteLine("Введите строку");

            string str_OneFiveCharToString = Console.ReadLine() ?? " ";

            Console.WriteLine("введиет число, которое будет означать откуда начать отчет символов. Если нужно с самого начала введите 0");

            string temp_OneFiveCharToString_1 = Console.ReadLine() ?? " ";
            if (int.TryParse(temp_OneFiveCharToString_1, out int startIndex))
            {
            }

            Console.WriteLine("Ввердите число количества выводимых символов строки");

            string temp_OneFiveCharToString_2 = Console.ReadLine() ?? " ";
            if (int.TryParse(temp_OneFiveCharToString_2, out int length))
            {  
            }

            Console.WriteLine(OneFiveCharToString(str_OneFiveCharToString, startIndex, length));
            //OneFiveCharToString




            Console.WriteLine("-----------------------");




            //StringToBilder

            Console.WriteLine("Сколько слов вы хотите ввести?");
            string temp_StringToBilder = Console.ReadLine() ?? " ";
            if (int.TryParse(temp_StringToBilder, out int count)){}


            string[] array = new string[count];
            Console.WriteLine("введите слова через Enter");
            for (int i = 0; i < count; i++)
            {
               
                array[i] = Console.ReadLine() ?? "";
            }

            StringBuilder bilder_result = StringToBilder(array);
            Console.WriteLine(bilder_result);
            //StringToBilder




            Console.WriteLine("-----------------------");



            //ReplaceWords
            Console.WriteLine("Введите строку");
            string str_ReplaceWords = Console.ReadLine() ?? " ";
            Console.WriteLine("Введите поисковый тригер");
            string poisk_ReplaceWords = Console.ReadLine() ?? " ";
            Console.WriteLine("Введите то на что нужно поменять найденные участки");
            string replese_ReplaceWords = Console.ReadLine() ?? " ";

            Console.WriteLine(ReplaceWords(str_ReplaceWords, poisk_ReplaceWords, replese_ReplaceWords));
            //ReplaceWords

        }






        // методы
        public static string ConcatinationString(string str_1, string  str_2 )
        {

            return (str_1 + " " + str_2);
        }



        public static string GreetUser (string name, int number)
        {
            return ("Hello, "+ name + "!\n" + "Yor are " + number +" years old");
        }

        
        public static string MethodString (string str)
        {
            int str_length = str.Length;
            string str_ToUpper = str.ToUpper();
            string str_ToLower = str.ToLower();
            return ("Количество символов в строке: " + str_length + ".\n" + 
                "Строка в верхнем регистре: " + str_ToUpper + ".\n" + 
                "Строка в нижнем регистре: " + str_ToLower + ".");
        }


        public static string OneFiveCharToString(string str, int startIndex, int length)
        {
            string CharToString = str.Substring(startIndex, length);
            return "Символы строки с позиции: " + startIndex + ".\n" +
                "Количесво выводимых символов: " + length + ".\n" +
                "новая строка = " + CharToString;
        }


        public static StringBuilder StringToBilder(string[] ArrayString)
        {

            StringBuilder Bilder = new StringBuilder();

            foreach (string str in ArrayString) 
            {
                Bilder.Append(str);
                Bilder.Append(" ");
            }
            // Удаление последнего пробела
            if (Bilder.Length > 0)
                Bilder.Length--;
            return Bilder; 
        }


        public static string ReplaceWords(string inputString, string WordsToReplace, string replesmentWords)
        {
            string newText = inputString.Replace(WordsToReplace, replesmentWords);
            return newText;
        }






        
        



       
    }


}        















