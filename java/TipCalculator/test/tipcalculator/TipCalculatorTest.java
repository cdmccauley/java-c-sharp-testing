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
    
    public TipCalculatorTest() {
    }
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            // test values below
            { 0, 0 },
            { 0, 0 }, 
        };
    return Arrays.asList(data);
    };

    @Test
    public void testMain() {
    }
    
}
