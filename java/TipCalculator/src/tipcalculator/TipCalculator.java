/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tipcalculator;



/**
 *
 * @author mccaulcd
 */
public class TipCalculator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
    public static double calcTip(double cost, double tipPct) {
        return cost * (tipPct / 100);
    }

    public static double calcTotal(double cost, double tipAmt) {
        return cost + tipAmt;
    }
}
