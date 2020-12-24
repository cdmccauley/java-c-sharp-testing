/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package checkdigits;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

/**
 *
 * @author mccaulcd
 */
@RunWith(Suite.class)
@Suite.SuiteClasses({
    checkdigits.GetSmallestTest.class, 
    checkdigits.GetTotalTest.class, 
    checkdigits.GetAverageTest.class, 
    checkdigits.GetLargestTest.class
})

public class CheckDigitsTestSuite {
    
}
