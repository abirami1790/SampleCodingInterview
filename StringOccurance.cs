using System;

public class HelloWorld
{
//StringOccurance
    public static void Main(string[] args)
    {
      string str="welcome world";
     // Console.Write("String:"+ str);
       
      while(str.Length>0){
        Console.Write(str[0] +"=");
         int count=0;
          for(int i=0;i<str.Length;i++)
          {
              if(str[0]==str[i])
              {
                  count++;
              }
          }
          Console.WriteLine(count);
      str=str.Replace(str[0].ToString(),string.Empty);
      }
      
    }
}
