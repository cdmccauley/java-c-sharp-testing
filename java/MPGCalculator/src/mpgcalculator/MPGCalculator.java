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
public class MPGCalculator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        MPG trip1 = new MPG(320, 29);
        MPG trip2 = new MPG(325.8, 32.1);
        MPG trip3 = new MPG(412.5, 35);
        MPG trip4 = new MPG(345, 32.6);

        trip1.displayCurrentMPG();
        trip2.displayCurrentMPG();
        trip3.displayCurrentMPG();
        trip4.displayCurrentMPG();

        MPG.displayTotalMPG();
    }
    
}
