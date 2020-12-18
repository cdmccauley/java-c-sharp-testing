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
@RunWith(Parameterized.class)
public class TipCalculatorTest {
    
    @Parameterized.Parameter(0)
    public double cost;
    @Parameterized.Parameter(1)
    public double tipPct;
    @Parameterized.Parameter(2)
    public double expected;
    
    public TipCalculatorTest() {
    }
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            // test values below
            { 30.0, 15.0, 4.50 },
            { 30.0, 18.0, 5.40 }, 
            { 30.0, 20.0, 6.00 }, 
            { 30.0, 22.0, 6.60 }, 
            { 30.0, 25.0, 7.50 }, 
        };
    return Arrays.asList(data);
    };

    @Test
    public void calcTipTest() {
        assertEquals(expected, TipCalculator.calcTip(cost, tipPct), 0.001); // unsure of delta for monetary value
    }
    
}
