/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculator;

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
public class OpsDivideDoubleTest {
    
    public static double DELTA = 0.00;
    
    @Parameterized.Parameter(0)
    public double expected;
    @Parameterized.Parameter(1)
    public double left;
    @Parameterized.Parameter(2)
    public double right;
    @Parameterized.Parameter(3)
    public double d;
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            { Double.NaN, 0.0, 0.0, DELTA },
            { 0.0, 0.0, 80.0, DELTA },
            { 2.4, 12.0, 5.0, DELTA },
        };
    return Arrays.asList(data);
    };
    
    public OpsDivideDoubleTest() {
    }
    
    @Test
    public void testDoubleDivision() {
        assertEquals(expected, Operations.Division(left, right), d);
    }
    
}
