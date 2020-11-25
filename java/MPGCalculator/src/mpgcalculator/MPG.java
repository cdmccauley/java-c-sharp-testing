/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mpgcalculator;

/**
 *
 * @author mccaulcd
 */
public class MPG {

    
// class declarations
    public static double totalMiles;
    public static double totalGallons;
    public static double totalMPG;
    public static int numTrips;

    // instance declarations
    public double miles;
    public double gallons;
    public double mpg;

    // constructor
    public MPG(double miles, double gallons)
    {
        this.miles = miles;
        this.gallons = gallons;
        this.mpg = this.miles / this.gallons;

        MPG.totalGallons += gallons;
        MPG.numTrips++;
        MPG.totalMiles += miles;
        MPG.totalMPG = totalMiles / totalGallons;
    }
    
    // getters
    public static double getTotalMiles() {
        return totalMiles;
    }

    public static double getTotalGallons() {
        return totalGallons;
    }

    public static double getTotalMPG() {
        return totalMPG;
    }

    public static int getNumTrips() {
        return numTrips;
    }

    public double getMiles() {
        return miles;
    }

    public double getGallons() {
        return gallons;
    }

    public double getMpg() {
        return mpg;
    }

    // functions
    public void displayCurrentMPG()
    {
        System.out.printf("\nThis trip = %.2f", mpg);
    }

    public static void displayTotalMPG()
    {
        System.out.printf("\nFor %d trips, total MPG = %.2f", numTrips, totalMPG);
    }
    
}
