/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package checkdigits;

import java.util.ArrayList;

/**
 *
 * @author mccaulcd
 */
public class CheckDigits {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("안녕하세요!");
    }
    
    public static double getTotal(ArrayList<Double> numbers) {
        double total = 0.0;
        for (double number : numbers) {
            total += number;
        }
        return total;
    }
    
    public static double getAverage(ArrayList<Double> numbers) {
        double total = 0.0;
        for (double number : numbers) {
            total += number;
        }
        return total / Double.valueOf(numbers.size());
    }
    
    public static double getLargest(ArrayList<Double> numbers) {
        double largest = Double.MIN_VALUE;
        for (double number : numbers) {
            if (number > largest) {
                largest = number;
            }
        }
        return largest;
    }
    
    public static double getSmallest(ArrayList<Double> numbers) {
        double smallest = Double.MAX_VALUE;
        for (double number : numbers) {
            if (number < smallest) {
                smallest = number;
            }
        }
        return smallest;
    }
    
}
