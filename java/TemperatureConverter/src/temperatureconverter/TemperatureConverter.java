/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package temperatureconverter;

/**
 *
 * @author mccaulcd
 */
public class TemperatureConverter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
    public static double FToC(double f)
    {
        return (f - 32) * 5.0 / 9.0;
    }

    public static double CToF(double c)
    {
        return (c * 9.0 / 5.0) + 32;
    }
    
}
