package rectangle;

import java.util.Scanner;

public class Rectangle {

    public static void main(String[] args) {
        System.out.println("First Unit Test\n");

        Scanner stdIn = new Scanner(System.in);
        int length, width, area, perimeter;
        
        System.out.print("What is the length: ");
        length = Integer.parseInt(stdIn.nextLine());
        System.out.print("What is the width: ");
        width = Integer.parseInt(stdIn.nextLine());
        
        Box myPaper = new Box(length, width);
        
        area = myPaper.area();
        perimeter = myPaper.perimeter();
        
        System.out.println("\nArea = " + area);
        System.out.println("Perimeter = " + perimeter);
    }    
}


