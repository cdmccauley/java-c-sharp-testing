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
public class FToCTest {
    
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
            { 0.0, 32.0, DELTA },
            { 100.0, 212.0, DELTA },
            { 37.0, 98.6, DELTA },
        };
    return Arrays.asList(data);
    };
    
    public FToCTest() {
        
    }
    
    @Test
    public void testFToC() {
        assertEquals(expected, TemperatureConverter.FToC(initial), deltaParam);
    }
    
}
