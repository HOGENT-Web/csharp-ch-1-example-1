using System;

namespace Domain;
public class Bicycle
{
    private int gear = 5;
    public void Brake(){
        System.Console.WriteLine("I'm braking in gear: " + gear);
    }
}
