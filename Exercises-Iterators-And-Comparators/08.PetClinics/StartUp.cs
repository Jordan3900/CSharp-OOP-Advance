using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var pets = new List<Pet>();
        var clinics = new List<Clinic>();
        int commandCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandCount; i++)
        {
            string[] commandInput = Console.ReadLine().Split();
            string cmd = commandInput[0];

            switch (cmd)
            {
                case "Create":
                    string typeOfCreation = commandInput[1];
                    if (typeOfCreation == "Pet")
                    {
                        int age = int.Parse(commandInput[3]);
                        Pet pett = new Pet(commandInput[2], age, commandInput[4]);
                       pets.Add(pett);
                    }
                    else
                    {
                        try
                        {
                            int roomCount = int.Parse(commandInput[3]);
                            var clinic = new Clinic(commandInput[2], roomCount);
                            clinics.Add(clinic);
                        }
                        catch (ArgumentException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                    }
                    break;
                case "Add":
                    Pet pet = pets.FirstOrDefault(p => p.Name == commandInput[1]);
                    Clinic clinicToAdd = clinics.FirstOrDefault(c => c.Name == commandInput[2]);
                    Console.WriteLine(clinicToAdd.Add(pet)); 
                    break;
                case "Release":
                    Clinic clinicToRelease = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                    Console.WriteLine(clinicToRelease.Release()); 
                    break;
                case "HasEmptyRooms":
                    Clinic clinicToCheck = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                    Console.WriteLine(clinicToCheck.HasEmptyRooms);
                    break;
                case "Print":
                    Clinic clinicToPrint = clinics.FirstOrDefault(c => c.Name == commandInput[1]);

                    if (commandInput.Length == 3)
                    {
                        int roomNumber = int.Parse(commandInput[2]);
                        Console.WriteLine(clinicToPrint.Print(roomNumber));
                    }
                    else
                    {
                        Console.WriteLine(clinicToPrint.PrintAll());
                    }
                    break;
                default:
                    break;
            }
        }
     
    }
}

