/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package leapyear;

/**
 *
 * @author mccaulcd
 */
public class LeapYear {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
    public static int numFebDays(int year) {
        int days;

        if (year % 100 == 0)
        {
            if (year % 400 == 0)
                days = 29;
            else
                days = 28;
        }
        else if (year % 4 == 0)
            days = 29;
        else
            days = 28;

        return days;
    }
    
    public static boolean isLeapYear(int year) {
        boolean theAnswer;

        if (year % 100 == 0)
        {
            if (year % 400 == 0)
                theAnswer = true;
            else
                theAnswer = false;
        }
        else if (year % 4 == 0)
            theAnswer = true;
        else
            theAnswer = false;

        return theAnswer;
    }
    
}
