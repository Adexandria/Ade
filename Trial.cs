class Trial {
 static void main (String[] args) {
string Firstname = "";
string Lastname =  "";
DateTime Birtdate;
string Addresssline = "";
string City="";
string State="";
int Zipcode= 0;
string Nation="";
int Age=0;

  
  
  Firstname="Adeoloa";
  Lastname ="Aderibigbe";
Birtdate =  new DateTime(1999,12,11);
  Addressline= "Rumuodara";
  City ="Port-harcourt";
  State =" Rivers";
  Zipcode="50092";
  Nation = "Nigeria";
  Age=18;
  
  
  
  
  
  
  
  
Console.WriteLine(Lastname,Firstname);
Console.WriteLine("[0] years old",Age);
Console.WriteLine(State + ","+  City + "," + Nation);
Console.WriteLine($"Born on{Birthdate}");
                }
}
     
