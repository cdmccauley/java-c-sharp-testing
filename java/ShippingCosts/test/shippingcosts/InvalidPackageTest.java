/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shippingcosts;

import org.junit.Test;
import static org.junit.Assert.*;
import org.junit.runners.Parameterized;
import org.junit.runner.RunWith;

import java.util.Collection;
import java.util.Arrays;

/**
 *
 * @author mccaulcd
 */
@RunWith(Parameterized.class)
public class InvalidPackageTest {
    
    @Parameterized.Parameter(0)
    public Package invalidPackage;
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            { new Package(-1.0, -1.0) },
            { new Package(0, 0) },
            { new Package(-0.01, -0.01) },
        };
    return Arrays.asList(data);
    };
    
    public InvalidPackageTest() {
        // construct
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
