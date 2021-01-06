/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculator;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

/**
 *
 * @author mccaulcd
 */
@RunWith(Suite.class)
@Suite.SuiteClasses({
    calculator.OperationsTest.class, 
    calculator.OpsAddDoubleTest.class, 
    calculator.OpsSubtractDoubleTest.class, 
    calculator.OpsMultiplyDoubleTest.class, 
    calculator.OpsDivideDoubleTest.class, 
    calculator.OpsSubtractIntTest.class, 
    calculator.OpsMultiplyIntTest.class, 
    calculator.OpsAddIntTest.class, 
    calculator.OpsDivideIntTest.class
})
public class OperationsTestSuite {
    
}
