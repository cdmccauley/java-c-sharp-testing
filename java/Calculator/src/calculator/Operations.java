/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculator;

/**
 *
 * @author mccaulcd
 */
public class Operations {
    
    public static double Addition(double left, double right) {
        return left + right;
    }
    
    public static double Subtraction(double left, double right) {
        return left - right;
    }
    
    public static double Multiplication(double left, double right) {
        return left * right;
    }
    
    public static double Division(double left, double right) {
        return right != 0 ? left / right : Double.NaN;
    }
    
}
