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
    public void testgetRN() {
        for (int i = 0; i < 5000; i++) {
            int testValue = RandomNumbers.getRN(20, 29);
            assertTrue(String.format("testValue is %s", testValue), testValue >= 20 && testValue <= 29);
        }
    }
    
}
