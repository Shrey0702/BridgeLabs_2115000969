using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using Newtonsoft.Json; 
namespace JSONassignment

{ 
 class Person  { 


 public string Name { get; set; } 
 public int Age { get; set; } 
 } 
 internal class ObjListToJsonArray 
 { 
 static void Main() 
 { 
 List<Person> people = new List<Person> 
 { 
 new Person { Name = "Batman", Age = 30 }, 
 new Person { Name = "Joker", Age = 55 } 
 }; 
 string json = JsonConvert.SerializeObject(people, Formatting.Indented); 
 Console.WriteLine(json); 
 } 
 } 
} 
