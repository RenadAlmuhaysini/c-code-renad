# c-code-renadusing System;
public class Test
{
    public static void Main(String [] args)
    { //question 1
        string firstName = "Renad";
        int age = 19;
        double favoriteNumber = 7.0;

        Console.WriteLine("Hello, my name is" + firstName + "I am" + age + "years old, and my favorite number is "+ favoriteNumber);

//question 2
        int [] arr = new int [5];
        int num;
        for (int i=0 ; i<= arr.Length ;i++){
          Console.WriteLine("write a number to enter in the array");
           num = Convert.ToInt32(Console.ReadLine);
        arr [i] = num;
        }
        for (int j=0 ; j<= arr.Length ;j++){
        Console.WriteLine(arr [j]);
        }
//question 3
        int number = 2;
       IsEven(number); 
//question 4
       Console.WriteLine("write your age:");
           int userAge = Convert.ToInt32(Console.ReadLine);
           if (userAge<12){
Console.WriteLine("You are a child");
           }else if (userAge>=12 || userAge<=17 ){
Console.WriteLine("You are a teenager");
           }else if (userAge>=18){
Console.WriteLine("You are an adult");
           }else {
            Console.WriteLine("Invalid number");
           }

           //question 5
             Console.WriteLine("write your a number between 1 to 12:");
           int number2 = Convert.ToInt32(Console.ReadLine) ;
           switch (number2){
            case 1:
            Console.WriteLine("Januarey");
            break;
            case 2:
            Console.WriteLine("February");
            break;
            case 3:
            Console.WriteLine("March");
            break;
            case 4:
            Console.WriteLine("April");
            break;
            case 5:
            Console.WriteLine("May");
            break;
            case 6:
            Console.WriteLine("June");
            break;
            case 7:
            Console.WriteLine("July");
            break;
            case 8:
            Console.WriteLine("August");
            break;
            case 9:
            Console.WriteLine("October");
            break;
            case 10:
            Console.WriteLine("September");
            break;
            case 11:
            Console.WriteLine("November");
            break;
            case 12:
            Console.WriteLine("December");
            break;
           }
           //question 6
Book b1 = new Book("darkness","Renad",56.8);
Book b2 = new Book("yourvalue","khalid",65.6);
Book b3 = new Book("deserve it","asma",34.9);
b1.PrintDetails();
b2.PrintDetails();
b3.PrintDetails();
}
   public static bool IsEven(int number){
    if (number % 2 == 0){
        return true;
    }else return false;
}
}
class Book {
    private string title;
    private string author;
    private double price;
    public Book (string title,string author,double price){
        this.title = title;
        this.author=author;
        this.price=price;
    
    }
    public void PrintDetails(){
        Console.WriteLine("Title:" +title+", Author:"+author+", Price:" +price);

    }
}