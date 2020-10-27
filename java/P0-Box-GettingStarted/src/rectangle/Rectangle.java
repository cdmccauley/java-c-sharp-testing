package rectangle;

import java.util.Scanner;

public class Rectangle {

    public static void main(String[] args) {
        System.out.println("First Unit Test\n");

        Scanner stdIn = new Scanner(System.in);
        int length, width, height, area, perimeter, volume;
        
        System.out.print("What is the length: ");
        length = Integer.parseInt(stdIn.nextLine());
        System.out.print("What is the width: ");
        width = Integer.parseInt(stdIn.nextLine());
        System.out.print("What is the height: ");
        height = Integer.parseInt(stdIn.nextLine());
        
        Box myPaper = new Box(length, width, height);
        
        area = myPaper.area();
        perimeter = myPaper.perimeter();
        volume = myPaper.volume();
        
        System.out.println("\nArea = " + area);
        System.out.println("Perimeter = " + perimeter);
        System.out.println("Volume = " + volume);
    }    
}


