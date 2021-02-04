/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shippingcosts;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

/**
 *
 * @author mccaulcd
 */
@RunWith(Suite.class)
@Suite.SuiteClasses({
    shippingcosts.ValidPackageTest.class, 
    shippingcosts.InvalidPackageTest.class
})

public class PackageTestSuite {
    
}
