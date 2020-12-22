/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tipcalculator;

import org.junit.Test;
import static org.junit.Assert.*;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;
import org.junit.runners.Parameterized.Parameters;
import java.util.Arrays;
import java.util.Collection;
import static org.junit.runners.Parameterized.*;

/**
 *
 * @author mccaulcd
 */
public class CalcTotalTest {
    
    @Parameterized.Parameter(0)
    public double cost;
    @Parameterized.Parameter(1)
    public double tipTotal;
    @Parameterized.Parameter(2)
    public double expected;
    
    public CalcTotalTest() {
    }
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            // test values below
            { 30.0, 4.50, 34.50 },
            { 30.0, 5.40, 35.40 }, 
            { 30.0, 6.00, 36.00 }, 
            { 30.0, 6.60, 36.60 }, 
            { 30.0, 7.50, 37.50 }, 
        };
    return Arrays.asList(data);
    };
    
    @Test
    public void calcTotalTest() {
        assertEquals(expected, TipCalculator.calcTotal(cost, tipTotal), 0.00);
    }
    
}
