/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package randomnumbers;

import java.util.Random;

/**
 *
 * @author mccaulcd
 */
public class RandomNumbers {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
    public static int getRN(int min, int max) {
        Random rng = new Random();
        int answer = rng.nextInt((max - min + 1) + min);
        return answer;
    }
    
}
