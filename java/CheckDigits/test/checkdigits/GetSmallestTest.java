/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package checkdigits;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import org.junit.Test;
import static org.junit.Assert.*;
import org.junit.runners.Parameterized;
import org.junit.runner.RunWith;
import static org.junit.runners.Parameterized.*;

/**
 *
 * @author mccaulcd
 */
@RunWith(Parameterized.class)
public class GetSmallestTest {
    
    @Parameterized.Parameter(0)
    public ArrayList<Double> testNumbers;
    @Parameterized.Parameter(1)
    public double expected;
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            { new ArrayList<Double>(Arrays.asList(1.0, 2.0)), 1.0 },
            { new ArrayList<Double>(Arrays.asList(3.0, 4.0)), 3.0 },
            { new ArrayList<Double>(Arrays.asList(5.0, 6.0)), 5.0 },
            { new ArrayList<Double>(Arrays.asList(12.3, -51.7, 89.4, 27.0)), -51.7 },
        };
    return Arrays.asList(data);
    };
    
    public GetSmallestTest() {
    }
    
    @Test
    public void testGetSmallest() {
        assertEquals(expected, CheckDigits.getSmallest(testNumbers), 0.0);
    }
    
}
