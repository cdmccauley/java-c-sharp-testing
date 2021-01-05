/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package temperatureconverter;

import org.junit.Test;
import static org.junit.Assert.*;
import org.junit.runners.Parameterized;
import org.junit.runner.RunWith;
import static org.junit.runners.Parameterized.*;

import java.util.Collection;
import java.util.Arrays;

/**
 *
 * @author mccaulcd
 */
@RunWith(Parameterized.class)
public class CToFTest {
    
    public static double DELTA = 0.00;
    
    @Parameterized.Parameter(0)
    public double expected;
    @Parameterized.Parameter(1)
    public double initial;
    @Parameterized.Parameter(2)
    public double deltaParam;
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            { 32.0, 0.0, DELTA },
            { 212.0, 100.0, DELTA },
            { 98.6, 37.0, DELTA },
        };
    return Arrays.asList(data);
    };
    
    public CToFTest() {
    }
    
    @Test
    public void testCToF() {
        assertEquals(expected, TemperatureConverter.CToF(initial), deltaParam);
    }
    
}
