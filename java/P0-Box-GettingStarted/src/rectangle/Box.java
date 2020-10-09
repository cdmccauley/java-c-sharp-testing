package rectangle;

public class Box {
    
    private int length, width;
    
    public Box(int len, int wid) {
        length = len;
        width = wid;
    }
    
    public int perimeter() {
        int perim = (2 * length) + (2 * width);
        return perim;
    }
    
    public int area() {
        int area = length * width;
        return area;
    }
    
}
