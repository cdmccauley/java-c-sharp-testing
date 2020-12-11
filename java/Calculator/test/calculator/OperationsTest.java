/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculator;

import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author mccaulcd
 */
public class OperationsTest {
    
    public OperationsTest() {
    }

    @Test
    public void testAddition() {
        assertEquals(0.0, Operations.Addition(0.0, 0.0), 0.0);
        assertEquals(15.0, Operations.Addition(10.0, 5.0), 0.0);
        assertEquals(17.0, Operations.Addition(12.0, 5.0), 0.0);
    }

    @Test
    public void testSubtraction() {
        assertEquals(-0.0, Operations.Subtraction(0.0, 0.0), 0.0);
        assertEquals(5.0, Operations.Subtraction(10.0, 5.0), 0.0);
        assertEquals(7.0, Operations.Subtraction(12.0, 5.0), 0.0);
    }

    @Test
    public void testMultiplication() {
        assertEquals(0.0, Operations.Multiplication(0.0, 0.0), 0.0);
        assertEquals(100.0, Operations.Multiplication(10.0, 10.0), 0.0);
        assertEquals(60.0, Operations.Multiplication(12.0, 5.0), 0.0);
    }

    @Test
    public void testDivision() {
        assertEquals(Double.NaN, Operations.Division(0.0, 0.0), 0.0);
        assertEquals(0.0, Operations.Division(0.0, 80.0), 0.0);
        assertEquals(2.4, Operations.Division(12.0, 5.0), 0.0);
    }
    
}
