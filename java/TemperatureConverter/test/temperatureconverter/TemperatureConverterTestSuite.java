/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package temperatureconverter;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

/**
 *
 * @author mccaulcd
 */
@RunWith(Suite.class)
@Suite.SuiteClasses(
        {temperatureconverter.FToCTest.class, 
            temperatureconverter.TemperatureConverterTest.class, 
            temperatureconverter.CToFTest.class
        })
public class TemperatureConverterTestSuite {
    
}
