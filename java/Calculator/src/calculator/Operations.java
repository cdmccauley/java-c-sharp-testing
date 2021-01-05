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
    
    public static int Addition(int left, int right) {
        return left + right;
    }
    
    public static double Addition(double left, double right) {
        return left + right;
    }
    
    public static int Subtraction(int left, int right) {
        return left - right;
    }
    
    public static double Subtraction(double left, double right) {
        return left - right;
    }
    
    public static int Multiplication(int left, int right) {
        return left * right;
    }
    
    public static double Multiplication(double left, double right) {
        return left * right;
    }
    
    public static int Division(int left, int right) {
        return right != 0 ? left / right : (int)Double.NaN;
    }
    
    public static double Division(double left, double right) {
        return right != 0 ? left / right : Double.NaN;
    }
    
}
