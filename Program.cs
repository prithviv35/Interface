﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Vehicle
    {
        // all are the abstract methods.
        void changeGear(int a);
        void speedUp(int a);
        void applyBrakes(int a);
    }

    // class implements interface
    class Bicycle : Vehicle
    {

        int speed;
        int gear;

        // to change gear
        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed + " gear: " + gear);
        }
    }

    // class implements interface
    class Bike : Vehicle
    {

        int speed;
        int gear;

        // to change gear
        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +" gear: " + gear);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of Bicycle 
            // doing some operations 
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrakes(1);

            Console.WriteLine("Bicycle present state :");
            bicycle.printStates();

            // creating instance of bike.
            Bike bike = new Bike();
            bike.changeGear(1);
            bike.speedUp(4);
            bike.applyBrakes(3);

            Console.WriteLine("Bike present state :");
            bike.printStates();
            Console.ReadLine();
        }
    }
}
