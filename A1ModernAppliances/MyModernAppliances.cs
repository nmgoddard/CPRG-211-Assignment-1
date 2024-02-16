using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.Diagnostics;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "

            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number

            long itemNumber;

            // Get user input as string and assign to variable.

            string userInput = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.

            itemNumber = Convert.ToInt64(userInput);

            // Create 'foundAppliance' variable to hold appliance with item number

            Appliance foundAppliance;

            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)

            foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)
            foreach (var appliance in Appliances)
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            if (foundAppliance == null)
            {
                Console.WriteLine($"No appliances found with that item number");
            }
            else
            {
                Console.WriteLine("Appliance Found");
                if (foundAppliance.Quantity > 0)
                {
                    Console.WriteLine("Appliance has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
            Console.WriteLine();


                    // Write "Appliance has been checked out."
                // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"

            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brand = Console.ReadLine();
            Console.WriteLine();

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list
            foreach (var appliance in Appliances) 
            {
                if (appliance.Brand == brand) 
                {
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "

            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors

            int doorNumber;

            // Get user input as string and assign to variable

            string userInput = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.

            doorNumber = Convert.ToInt32(userInput);

			// Create list to hold found Appliance objects

			List<Appliance> foundRefrigerators = new List<Appliance>();

			// Iterate/loop through Appliances
			// Test that current appliance is a refrigerator
			// Down cast Appliance to Refrigerator
			// Refrigerator refrigerator = (Refrigerator) appliance;

			foreach (var appliance in Appliances)
			{
                if (appliance.GetType().Name == "Refrigerator")
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
					if (doorNumber == 0 || refrigerator.Doors == doorNumber) 
                    {
                        foundRefrigerators.Add(refrigerator);
                    }
                }
				
			}

			// Test user entered 0 or refrigerator doors equals what user entered.
			// Add current appliance in list to found list

			// Display found appliances
			DisplayAppliancesFromList(foundRefrigerators, 0);
		}

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

			// Write "0 - Any"
			// Write "1 - Residential"
			// Write "2 - Commercial"

            // Write "Enter grade:"

            // Get user input as string and assign to variable

            string grade;

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            while (true)
            {
				Console.WriteLine("Possible options: ");
				Console.WriteLine("0 - Any");
				Console.WriteLine("1 - Residential");
				Console.WriteLine("2 - Commercial");
				Console.WriteLine("Enter grade: ");
                string userInput = Console.ReadLine();

                if (userInput == "0")
                {
                    grade = "Any";
                    break;
                }
                else if (userInput == "1")
                {
                    grade = "Residential";
                    break;
                }
                else if (userInput == "2")
                {
                    grade = "Commercial";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"

            // Get user input as string
            // Create variable to hold voltage

            int voltage;

			while (true)
			{
				Console.WriteLine("Possible options: ");
				Console.WriteLine("0 - Any");
				Console.WriteLine("1 - 18 Volt");
				Console.WriteLine("2 - 24 Volt");
				Console.WriteLine("Enter voltage: ");
				string userInput = Console.ReadLine();

				if (userInput == "0")
				{
					voltage = 0;
					break;
				}
				else if (userInput == "1")
				{
					voltage = 18;
					break;
				}
				else if (userInput == "2")
				{
					voltage = 24;
					break;
				}
				else
				{
					Console.WriteLine("Invalid Option");
				}
			}

			// Test input is "0"
			// Assign 0 to voltage
			// Test input is "1"
			// Assign 18 to voltage
			// Test input is "2"
			// Assign 24 to voltage
			// Otherwise
			// Write "Invalid option."
			// Return to calling (previous) method
			// return;

			// Create found variable to hold list of found appliances.

            List<Appliance> foundVacuums = new List<Appliance>();

			// Loop through Appliances
			// Check if current appliance is vacuum
			// Down cast current Appliance to Vacuum object
			// Vacuum vacuum = (Vacuum)appliance;

			foreach (var appliance in Appliances)
			{
				if (appliance.GetType().Name == "Vacuum")
				{
					Vacuum vacuum = (Vacuum)appliance;
					if (grade == "Any" || grade == vacuum.Grade)
					{
						if (voltage == 0 || voltage == vacuum.BatteryVoltage) 
                        {
                            foundVacuums.Add(vacuum); 
                        }    
                        
					}
				}

			}

			// Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
			// Add current appliance in list to found list

			// Display found appliances

			 DisplayAppliancesFromList(foundVacuums, 0);
		}

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

            char roomType;

			while (true)
			{
				Console.WriteLine("Possible options: ");
				Console.WriteLine("0 - Any");
				Console.WriteLine("1 - Kitchen");
				Console.WriteLine("2 - Work");
				Console.WriteLine("Enter room type: ");
				string userInput = Console.ReadLine();

				if (userInput == "0")
				{
					roomType = 'A';
					break;
				}
				else if (userInput == "1")
				{
					roomType = 'K';
					break;
				}
				else if (userInput == "2")
				{
					roomType = 'W';
					break;
				}
				else
				{
					Console.WriteLine("Invalid Option");
				}
			}

			// Test input is "0"
			// Assign 'A' to room type variable
			// Test input is "1"
			// Assign 'K' to room type variable
			// Test input is "2"
			// Assign 'W' to room type variable
			// Otherwise (input is something else)
			// Write "Invalid option."
			// Return to calling method
			// return;

			// Create variable that holds list of 'found' appliances

            List<Appliance> foundMicrowaves = new List<Appliance>();

			// Loop through Appliances
			// Test current appliance is Microwave
			// Down cast Appliance to Microwave

			foreach (var appliance in Appliances)
			{
				if (appliance.GetType().Name == "Microwave")
				{
					Microwave microwave = (Microwave)appliance;
					if (roomType == 'A' || microwave.RoomType == roomType)
					{
						foundMicrowaves.Add(microwave);
					}
				}

			}

			// Test room type equals 'A' or microwave room type
			// Add current appliance in list to found list

			// Display found appliances
			DisplayAppliancesFromList(foundMicrowaves, 0);
		}

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            string soundRating;

			while (true)
			{
				Console.WriteLine("Possible options: ");
				Console.WriteLine("0 - Any");
				Console.WriteLine("1 - Quietest");
				Console.WriteLine("2 - Quieter");
				Console.WriteLine("3 - Quiet");
				Console.WriteLine("4 - Moderate");
				Console.WriteLine("Enter sound rating: ");
				string userInput = Console.ReadLine();

				if (userInput == "0")
				{
					soundRating = "Any";
					break;
				}
				else if (userInput == "1")
				{
					soundRating = "Qt";
					break;
				}
				else if (userInput == "2")
				{
					soundRating = "Qr";
					break;
				}
				else if (userInput == "3")
				{
					soundRating = "Qu";
					break;
				}
				else if (userInput == "4")
				{
					soundRating = "M";
					break;
				}
				else
				{
					Console.WriteLine("Invalid Option");
				}
			}

			// Test input is "0"
			// Assign "Any" to sound rating variable
			// Test input is "1"
			// Assign "Qt" to sound rating variable
			// Test input is "2"
			// Assign "Qr" to sound rating variable
			// Test input is "3"
			// Assign "Qu" to sound rating variable
			// Test input is "4"
			// Assign "M" to sound rating variable
			// Otherwise (input is something else)
			// Write "Invalid option."
			// Return to calling method

			// Create variable that holds list of found appliances

            List<Appliance> foundDishwashers = new List<Appliance>();

			// Loop through Appliances
			// Test if current appliance is dishwasher
			// Down cast current Appliance to Dishwasher

			foreach (var appliance in Appliances)
			{
				if (appliance.GetType().Name == "Dishwasher")
				{
					Dishwasher dishwasher = (Dishwasher)appliance;
					if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
					{
						foundDishwashers.Add(dishwasher);
					}
				}

			}

			// Test sound rating is "Any" or equals soundrating for current dishwasher
			// Add current appliance in list to found list
			// Display found appliances (up to max. number inputted)
			DisplayAppliancesFromList(foundDishwashers, 0);
		}

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
			// Write "Appliance Types"

			// Write "0 - Any"
			// Write "1 – Refrigerators"
			// Write "2 – Vacuums"
			// Write "3 – Microwaves"
			// Write "4 – Dishwashers"

			// Write "Enter type of appliance:"

			// Get user input as string and assign to appliance type variable
			Console.WriteLine("Appliance Types");
			Console.WriteLine("0 - Any");
			Console.WriteLine("1 - Refrigerators");
			Console.WriteLine("2 - Vacuums");
			Console.WriteLine("3 - Microwaves");
			Console.WriteLine("4 - Dishwashers");
			Console.WriteLine("Enter type of appliance: ");
			string applianceType = Console.ReadLine();

			// Write "Enter number of appliances: "

			Console.WriteLine("Enter number of appliances: ");
			string numberInput = Console.ReadLine();
			int applianceNumber = Convert.ToInt32(numberInput);

			// Get user input as string and assign to variable

			// Convert user input from string to int

			// Create variable to hold list of found appliances

			List<Appliance> randomAppliances = new List<Appliance>();

			// Loop through appliances
			// Test inputted appliance type is "0"
			// Add current appliance in list to found list
			// Test inputted appliance type is "1"
			// Test current appliance type is Refrigerator
			// Add current appliance in list to found list
			// Test inputted appliance type is "2"
			// Test current appliance type is Vacuum
			// Add current appliance in list to found list
			// Test inputted appliance type is "3"
			// Test current appliance type is Microwave
			// Add current appliance in list to found list
			// Test inputted appliance type is "4"
			// Test current appliance type is Dishwasher
			// Add current appliance in list to found list

			foreach (var appliance in Appliances)
			{
				if (applianceType == "0") 
				{
					randomAppliances.Add(appliance);
				}
				else if (applianceType == "1" && appliance.GetType().Name == "Refrigerator")
				{
					randomAppliances.Add(appliance);	
				}
				else if (applianceType == "2" && appliance.GetType().Name == "Vacuum")
				{
					randomAppliances.Add(appliance);
				}
				else if (applianceType == "3" && appliance.GetType().Name == "Microwave")
				{
					randomAppliances.Add(appliance);
				}
				else if (applianceType == "4" && appliance.GetType().Name == "Dishwasher")
				{
					randomAppliances.Add(appliance);
				}
			}

			// Randomize list of found appliances
			// found.Sort(new RandomComparer());

			randomAppliances.Sort(new RandomComparer());

			// Display found appliances (up to max. number inputted)
			// DisplayAppliancesFromList(found, num);

			DisplayAppliancesFromList(randomAppliances, applianceNumber);
		}
	}
}
