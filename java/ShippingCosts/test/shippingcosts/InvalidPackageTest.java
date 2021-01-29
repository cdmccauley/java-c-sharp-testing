/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shippingcosts;

import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author mccaulcd
 */

public class InvalidPackageTest {
    
    Package invalidPackage;
    
    public InvalidPackageTest() {
        invalidPackage = new Package(-1.0, -1.0);
    }
    
    @Test
    public void ItSetsInvalidPropertiesToNull() {
        assertNull(invalidPackage.getDistance());
        assertNull(invalidPackage.getWeight());
    }
    
    @Test
    public void ItIsInvalid() {
        assertFalse(invalidPackage.isValid());
    }
    
    @Test(expected = Package.InvalidPackageException.class)
    public void ItThrowsWhenInvalidCost() throws Package.InvalidPackageException {
        invalidPackage.cost();
    }
    
}
