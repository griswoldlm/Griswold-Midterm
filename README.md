# WCTC-Net-DB-Midterm
WCTC Midterm application to be modified by the students

## Instructions
1. Add an implementation that makes use of the existing RaceCar() abstract class (*create your own new car*)
    1. Write your own methods in your own new class that implements both StartEngine() and Brake()
2. Add an implementation that makes use of the existing Driver() abstract class (*create your own new driver*)

#### **Extra Credit!**
1. Create a new method **in the RaceCar()** abstract class called **StopEngine()** that will be **called from RaceTrack.cs** using the code below.
    1. Replace the method in RaceTrack.cs with the code below.  Do not modify the code below for extra credit.  Simply copy over the existing method in RaceTrack.cs
    
```c
        public void EndRace()
        {
            foreach (var driver in Drivers)
            {
                driver.Stop();
                driver.StopEngine();
            }
            Thread.Sleep(1000);
        }
```
