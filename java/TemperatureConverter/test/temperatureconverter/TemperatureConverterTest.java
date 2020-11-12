/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package temperatureconverter;

import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author mccaulcd
 */
public class TemperatureConverterTest {
    
    public TemperatureConverterTest() {
    }

    @Test
    public void TestFToC()
    {
        assertEquals(0.0, TemperatureConverter.FToC(32.0), 0.00);
        assertEquals(100.0, TemperatureConverter.FToC(212.0), 0.00);
        assertEquals(37.0, TemperatureConverter.FToC(98.6), 0.00);
    }

    @Test
    public void TestCToF()
    {
        assertEquals(32.0, TemperatureConverter.CToF(0.0), 0.00);
        assertEquals(212.0, TemperatureConverter.CToF(100.0), 0.00);
        assertEquals(98.6, TemperatureConverter.CToF(37.0), 0.00);
    }
    
}
