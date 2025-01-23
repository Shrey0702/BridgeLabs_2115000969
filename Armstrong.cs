using System;  
class Armstrong{
     static void Main(string[] args)  
      {  
	//initialize variables
       int  n,r,sum=0,temp;
	// user input
       Console.Write("Enter the Number= ");      
       n= int.Parse(Console.ReadLine());     
       temp=n;      
       while(n>0)      
       {      
	// finding last digit
        r=n%10;      
	//cube the digit and add it to sum
        sum=sum+(r*r*r);      
        n=n/10;      
       }      
	//Check if the sum of cubes is equal to the original number
       if(temp==sum)      
        Console.Write("Armstrong Number.");      
       else      
        Console.Write("Not Armstrong Number.");      
      }  
  }  