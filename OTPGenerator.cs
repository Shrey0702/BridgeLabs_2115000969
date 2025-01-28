using System;

class OTPGenerator
{
    // Create a single instance of Random to avoid repeated seeding
    private static Random random = new Random();

    public static void Main()
    {
        int[] otps = new int[10];

        // Generate 10 OTPs
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("Generated OTP " + (i + 1) + ": " + otps[i]);
        }

        // Check if all OTPs are unique
        bool areUnique = AreOTPsUnique(otps);
        Console.WriteLine("Are all OTPs unique? " + (areUnique ? "Yes" : "No"));
    }

    // Method to generate a 6-digit OTP number using Math.Random()
    public static int GenerateOTP()
    {
        return random.Next(100000, 1000000);  // Generates a number between 100000 and 999999
    }

    // Method to check if OTP numbers are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false; // If any OTP is repeated, return false
                }
            }
        }
        return true; // If no OTP is repeated, return true
    }
}
