using System;

public class StudentCanVoteOrNot{
    
    public static bool CanStudentVote(int age){
        // check for negative age
        if (age < 0)
        {
            return false;
        }

        // check if age is 18 or above
        else if(age >= 18){
			return true;
		}
		else{
			return false;
		}
    }
	
	static void Main(){
        int[] studentAges = new int[10];

        for (int i = 0; i < studentAges.Length; i++){
            Console.Write("enter the age of student {0}: ", i + 1);
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < studentAges.Length; i++){
            bool canVote = CanStudentVote(studentAges[i]);
            if (canVote == true){
                Console.WriteLine("student {0} age {1} can vote", i + 1, studentAges[i]);
            }
			// single else condition is enough for both the false cases
            else{
                Console.WriteLine("student {0} age {1} cannot vote", i + 1, studentAges[i]);
            }
        }
    }
}


