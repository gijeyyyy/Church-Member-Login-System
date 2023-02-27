using System;
using System.Collections.Generic;
namespace Panganiban
{
    class Program
    {	
		static string userInput;
        static void Main(string[] args)
        {
			
			ShowMainProgram();
			userInput = GetUserInput();
			
			switch(userInput) {
				
				case "1":
				Console.Write("Username: ");
				string username1 = Console.ReadLine();
				Console.Write("Password: ");
				string password1 = Console.ReadLine();
				Console.WriteLine("-----Successfully login!-----");
				ShowSchedule();
				userInput = GetUserInput();
				
				if(userInput == "1"){
					ShowOptionOneAdmin();
					
					Console.WriteLine("\nEnter 2 to Check Church Sunday Service Schedule");
					Console.WriteLine("Enter any key to Logout");
					userInput = GetUserInput();
					
					if(userInput == "2"){
						ShowOptionTwoAdmin();
						ShowKeyToLogout();
					}
					else{
						Console.WriteLine("-----Logout successfully!-----");
					}
				}
				else if(userInput == "2"){
					ShowOptionTwoAdmin();
					
					if(userInput == "1"){
						Console.WriteLine("\nEnter 1 to to Check Church Activities");
					Console.WriteLine("Enter any key to Logout");
					userInput = GetUserInput();
					}
					else{
						Console.WriteLine("-----Logout successfully!-----");
					}
				}
				else{
					Console.WriteLine("-----Logout successfully!-----");
				}
				break;
				
				case "2":
				Console.Write("Username: ");
				string username2 = Console.ReadLine();
				Console.Write("Password: ");
				string password2 = Console.ReadLine();
				Console.WriteLine("-----Successfully login!-----");
				ShowSchedule();
				userInput = GetUserInput();
				
				if(userInput == "1"){
					ShowOptionOneMember();
					
					Console.WriteLine("\nEnter 2 to Check Church Sunday Service Schedule");
					Console.WriteLine("Enter any key to Logout");
					userInput = GetUserInput();
					
					if(userInput == "2"){
						ShowOptionTwoMember();
						ShowKeyToLogout();
					}
					else {
						Console.WriteLine("-----Logout successfully!-----");
					}
				}
				else if(userInput == "2"){
					ShowOptionTwoMember();
					
					Console.WriteLine("\nEnter 1 to to Check Church Activities");
					Console.WriteLine("Enter any key to Logout");
					userInput = GetUserInput();
					
					if(userInput == "1"){
						ShowOptionOneMember();
						ShowKeyToLogout();
					}
					else {
						Console.WriteLine("-----Logout successfully!-----");
					}
				}
				else{
					Console.WriteLine("-----Logout successfully!-----");
				}
				break;
				
				
			}
			
			static void ShowMainProgram() 
			{
				Console.WriteLine("---------Welcome to Biñan Evalengical Church----------");
				Console.WriteLine("Enter 1 to Login (if Admin)");
				Console.WriteLine("Enter 2 to Login (if Member)");
			}
			static string GetUserInput()
			{
				Console.Write(">> ");
				string user = Console.ReadLine();
				return user;
			}
			static void ShowSchedule()
			{
				Console.WriteLine("\nEnter 1 to Check Church Activities");
				Console.WriteLine("Enter 2 to Check Church Sunday Service Schedule");
				Console.WriteLine("Enter any key to Logout");
			}
			static void ShowOptionOneAdmin()
			{
				Console.WriteLine("\n\t-CHURCH ACTIVITIES-");
					var activities = new List<string>();
					activities.Add("Communicant Class Every Sunday @2PM.");
					activities.Add("Midweek Service Every Wednesday @6PM.");
					activities.Add("February 12, CYF LOVE FELLOWSHIP.");
					activities.Add("February 22, ASH WEDNESDAY.");
					activities.Add("April - Holy Week Service.");
					
					foreach (var activity in activities) {
						Console.WriteLine(activity);
					}	
					Console.WriteLine("\nDo you want to update schedule? You can only update two important details [Y/N].");
					userInput = GetUserInput().ToUpper();
					if(userInput == "Y"){
						Console.WriteLine("Type to add/update:");
						activities.Add(Console.ReadLine());
						Console.WriteLine("\nDo you want to update again? [Y/N].");
						userInput = GetUserInput().ToUpper();
						
						if(userInput == "Y"){
							Console.WriteLine("Type to add/update:");
							activities.Add(Console.ReadLine());
						}
						Console.WriteLine("\n\t-UPDATED CHURCH ACTIVITIES- ");
						
						foreach (var activity in activities) {
							Console.WriteLine("*" + activity);
						}

					}else {
						//do nothing
					}
			}
			static void ShowOptionTwoAdmin()
			{
				
				Console.WriteLine("\n\t-CHURCH SUNDAY SERVICE SCHEDULE-");
					var schedules = new List<string>();
					schedules.Add("Sunday School for all organizations, 9:00 AM.");
					schedules.Add("Sound System Soundcheck, 9:45 AM.");
					schedules.Add("Sunday Weekly Service, 10:00 AM.");
					schedules.Add("Choir Vocalization, 9:30 AM, 3rd floor.");
					
					foreach (var schedule in schedules) {
						Console.WriteLine("*" + schedule);
					}
					Console.WriteLine("\nDo you want to update schedule? You can only update two important details [Y/N].");
					userInput = GetUserInput().ToUpper();
					if(userInput == "Y"){
						Console.WriteLine("Type to add/update:");
						schedules.Add(Console.ReadLine());
						Console.WriteLine("\nDo you want to update again? [Y/N].");
						userInput = GetUserInput().ToUpper();
						
						if(userInput == "Y"){
							Console.WriteLine("Type to add/update:");
							schedules.Add(Console.ReadLine());
						}
						Console.WriteLine("\n\t-UPDATED CHURCH ACTIVITIES- ");
						
						foreach (var schedule in schedules) {
							Console.WriteLine("*" + schedule);
						}

					}else {
						//do nothing
					}
			}
			static void ShowOptionOneMember()
			{
				Console.WriteLine("\n\t-CHURCH ACTIVITIES-");
					var activities = new List<string>();
					activities.Add("Communicant Class Every Sunday @2PM.");
					activities.Add("Midweek Service Every Wednesday @6PM.");
					activities.Add("February 12, CYF LOVE FELLOWSHIP.");
					activities.Add("February 22, ASH WEDNESDAY.");
					activities.Add("April - Holy Week Service.");
					
					foreach (var activity in activities) {
						Console.WriteLine(activity);
					}
			}
			static void ShowOptionTwoMember()
			{
				
				Console.WriteLine("\n\t-CHURCH SUNDAY SERVICE SCHEDULE-");
					var schedules = new List<string>();
					schedules.Add("Sunday School for all organizations, 9:00 AM.");
					schedules.Add("Sound System Soundcheck, 9:45 AM.");
					schedules.Add("Sunday Weekly Service, 10:00 AM.");
					schedules.Add("Choir Vocalization, 9:30 AM, 3rd floor.");
					
					foreach (var schedule in schedules) {
						Console.WriteLine("*" + schedule);
					}
			}
			static void ShowKeyToLogout()
			{
				Console.WriteLine("\nYou can now logout your account! [Press any key].");
				userInput = GetUserInput();
			}
		} 
    }
}