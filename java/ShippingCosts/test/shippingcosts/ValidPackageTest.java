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
public class ValidPackageTest {
    
    public static double DELTA = 0.00;
    
    @Parameterized.Parameter(0)
    public Double distance;
    @Parameterized.Parameter(1)
    public Double expectedDistanceFactor;
    @Parameterized.Parameter(2)
    public Double weight;
    @Parameterized.Parameter(3)
    public Double expectedWeightFactor;
    @Parameterized.Parameter(4)
    public Double expectedCost;
    
    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] {
            { 99.9, 2.0, 9.9, 2.5, 5.0 },
            { 499.9, 5.0, 9.9, 2.5, 12.50 },
            { 500.0, 10.0, 9.9, 2.5, 25.0 },
            { 99.9, 2.0, 24.9, 10.0, 20.0 },
            { 499.9, 5.0, 24.9, 10.0, 50.0 },
            { 500.0, 10.0, 24.9, 10.0, 100.0 },
            { 99.9, 2.0, 25.0, 25.0, 50.0 },
            { 499.9, 5.0, 25.0, 25.0, 125.0 },
            { 500.0, 10.0, 25.0, 25.0, 250.0 },
        };
    return Arrays.asList(data);
    };
    
    public ValidPackageTest() {
        // construct
    }
    
    @Test
    public void ItSetsValidPropertiesToNumber() {
        Package testPackage = new Package(distance, weight);
        assertEquals(distance, testPackage.getDistance(), DELTA);
        assertEquals(weight, testPackage.getWeight(), DELTA);
    }
    
    @Test
    public void ItIsValid() {
        Package testPackage = new Package(distance, weight);
        assertTrue(testPackage.isValid());
    }
    
    @Test
    public void ItReturnsCorrectDistanceFactor() {
        Package testPackage = new Package(distance, weight);
        assertEquals(expectedDistanceFactor, testPackage.getDistanceFactor(), DELTA);
    }
    
    @Test
    public void ItReturnsCorrectWeightFactor() {
        Package testPackage = new Package(distance, weight);
        assertEquals(expectedWeightFactor, testPackage.getWeightFactor(), DELTA);
    }
    
    @Test
    public void ItReturnsCorrectCost() throws Package.InvalidPackageException {
        Package testPackage = new Package(distance, weight);
        assertEquals(expectedCost, testPackage.cost(), DELTA);
    }
    
}
