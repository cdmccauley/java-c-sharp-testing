/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mpgcalculator;

import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author mccaulcd
 */
public class MPGTest {
    
    @Test
    public void testMPGInstance() {
        // arrange
        MPG instanceOne = new MPG(300, 10);
        MPG instanceTwo = new MPG(400, 20);

        // act and assert
        assertEquals(300, instanceOne.getMiles(), .00);
        assertEquals(10, instanceOne.getGallons(), .00);
        assertEquals(30, instanceOne.getMpg(), .00);

        assertEquals(400, instanceTwo.getMiles(), .00);
        assertEquals(20, instanceTwo.getGallons(), .00);
        assertEquals(20, instanceTwo.getMpg(), .00);

        assertEquals(700, MPG.getTotalMiles(), .00);
        assertEquals(30, MPG.getTotalGallons(), .00);
        assertEquals(23.33, MPG.getTotalMPG(), .01);
        assertEquals(2, MPG.getNumTrips());
    }
    
}
