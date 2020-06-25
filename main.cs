using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine ("How many cars?");
  int totalCars = Convert.ToInt32(Console.ReadLine());
  totalCars = totalCars + 1;
  int i = 1;
  double speed = 0;
  double totalspeed = 0;
  while(i<totalCars)
  {
    Console.WriteLine ("Enter the distance covered by car#"+ i);
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter the time taken by car#"+ i);
    double time = Convert.ToDouble(Console.ReadLine());
    speed = distance/time;
    Console.WriteLine ("The speed of this car is "+ speed + " miles per hour");
    totalspeed = totalspeed + speed;

    i++;
  }
  i = i - 1;
  Console.WriteLine ("Average speed of the cars is "+ totalspeed / i);
  }
}