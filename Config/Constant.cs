using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHealth.Config
{
   

    public static class Constant
    {
        public static int PagLoadTim = 30;
        public static string Browser = "Chrome";
        public static string SleepIoUrl = "https://onboarding.sleepio.com/sleepio/big-health";
        public static string HomePageContent = "Discover your Sleep Score and how to improve it";
    }

    public static class SecondPageDetails
    {
       
        public static string Option1 = "Get to sleep more easily";
        public static string Option2 = "Sleep right through the night without waking up";
        public static string Option3 = "Stop waking up too early";
        public static string Option4 = "Wake up feeling refreshed";
        public static string Option5 = "None of the above";
        public static string Continue = "Continue";
    }

    public static class ThirdPageDetails
    {
        
        public static string Option1 = "I don't have a problem";
        public static string Option2 = "A week or less";
        public static string Option3 = "2-4 weeks";
        public static string Option4 = "1-2 months";
        public static string Option5 = "3-6 months";
        public static string Option6 = "7-12 months";
        public static string Option7 = "1-2 years";
        public static string Option8 = "3-5 years";
        public static string Option9 = "6-10 years";
        public static string Option10 = "11 or more years";
        public static string Continue = "Continue";
    }

    public static class Titles
    {
       public  static List<string> titles { get; } = new List<string>()
    {
        "",
        "How would you like to improve your sleep?",
        "How long have you had a problem with your sleep?",
        "Which of the following stops you from sleeping most often?",
        "To what extent has sleep troubled you in general?",
        "How many nights a week have you had a problem with your sleep?",
        "How often have you felt that you were unable to control the important things in your life?",
        "How likely is it that you would fall asleep during the day without intending to, or that you would struggle to stay awake while you were doing things?",
        "How would you describe your gender?",
        "What is your date of birth?",
        "What is your employment status?",
        "How much did poor sleep affect your productivity while you were working?",
        "How many hours did you miss from your work per week because of problems associated with your sleep?",
        "Which of the following expert guides might be of interest to you?",
        "Sign up to get your Sleep Score and learn effective ways to address even the most stubborn sleep problems."

    };

       
    }

    public static class SignUpErrorMessages
    {
        public static string WorkingHoursError = "Please enter a value between 0 and 50";
        public static string InvalidEmailAddress = "Please enter a valid email";
        public static string InvalidPasswordFormat = "Please enter a valid password";
        public static string ExistingEmailAddress = "Your account could not be created; please contact hello@sleepio.com for support.";
    }

    
    public static class SignUpDetails
    {
        public static string FirstName = "first_name";
        public static string lastName = "last_name";
        public static string Email = "email";
        public static string Password = "password";
    }

    public static class SleepIoMainScreen
    {
        public static string Score = "YOUR SLEEP SCORE";
        public static string Logout = "Log Out";
    }

    public static class UserSignInDetails
    {
        public static string Email = "qa19329812@test.com";
        public static string Password = "Test@1234";
        public static string ErrorMessage = "Incorrect email address or password. Please try again.";
        public static string NonExisitingEmail = "test@test.com";
    }
}
  
