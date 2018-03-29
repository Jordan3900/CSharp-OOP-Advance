using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Clinic
{
    private int rooms;


    public Clinic(string name, int rooms)
    {
        this.Name = name;
        this.Rooms = rooms;
        this.ClinicRooms = new Pet[rooms];
    }

    public Pet[] ClinicRooms { get; set; }



    public int Rooms
    {
        get { return rooms; }
        set
        {
            if (value % 2 == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            rooms = value;
        }
    }

    public bool HasEmptyRooms => this.ClinicRooms.Any(p => p == null);

    private int Center => ClinicRooms.Length / 2;

    public string Name { get; set; }

    public bool Add(Pet pet)
    {
        int currentRoom = this.Center;

        for (int i = 0; i < this.ClinicRooms.Length; i++)
        {
            if (i % 2  != 0)
            {
                currentRoom -= i;
            }
            else
            {
                currentRoom += i;
            }
            if (this.ClinicRooms[currentRoom] == null)
            {
                this.ClinicRooms[currentRoom] = pet;
                return true;
            }
        }
        return false;
    }

    public bool Release()
    {
        for (int i = 0; i < this.ClinicRooms.Length; i++)
        {
            int index = (this.Center + i) % this.ClinicRooms.Length;

            if (this.ClinicRooms[index] != null)
            {
                this.ClinicRooms[index] = null;
                return true;
            }
        }

        return false;
    }

    public string Print(int roomNum)
    {
        return this.ClinicRooms[roomNum - 1]?.ToString() ?? "Room empty";
    }

    public string  PrintAll()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= this.ClinicRooms.Length; i++)
        {
            sb.AppendLine(this.Print(i));
        }
        string result = sb.ToString().TrimEnd();
        return result;
    }
}

