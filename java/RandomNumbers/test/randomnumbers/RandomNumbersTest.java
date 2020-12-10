/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package randomnumbers;

import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author mccaulcd
 */
public class RandomNumbersTest {
    
    public RandomNumbersTest() {
    }

    @Test
    public void testGetRN() {
        int min = 20;
        int max = 29;
        boolean minBound = false;
        boolean maxBound = false;
        for (int i = 0; i < 5000; i++) {
            int testValue = RandomNumbers.getRN(min, max);
            if (!minBound && testValue == min) {
                minBound = true;
            }
            if (!maxBound && testValue == max) {
                maxBound = true;
            }
            assertTrue(String.format("testValue is %s", testValue), testValue >= 20 && testValue <= 29);
        }
        assertTrue("minBound was reached", minBound);
        assertTrue("maxBound was reached", maxBound);
    }
    
    @Test
    public void testGetRNMinBound() {
        for (int i = 0; i < 5000; i++) {
            int testValue = RandomNumbers.getRN(20, 20);
            assertEquals(String.format("Min boundary, testValue is %s", testValue), 20, testValue);
        }
    }
    
    @Test
    public void testGetRNMaxBound() {
        for (int i = 0; i < 5000; i++) {
            int testValue = RandomNumbers.getRN(29, 29);
            assertEquals(String.format("Min boundary, testValue is %s", testValue), 29, testValue);
        }
    }
}
