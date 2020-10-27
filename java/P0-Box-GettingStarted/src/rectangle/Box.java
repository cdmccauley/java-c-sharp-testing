package rectangle;

public class Box {
    
    private int length, width, height;
    
    public Box(int len, int wid) {
        length = len;
        width = wid;
        this.height = 0;
    }
    
    public Box(int len, int wid, int height) {
        length = len;
        width = wid;
        this.height = height;
    }
    
    public int perimeter() {
        int perim = (2 * length) + (2 * width);
        return perim;
    }
    
    public int area() {
        int area = length * width;
        return area;
    }
    
    public int volume() {
        int volume = this.length * this.width * this.height;
        return volume;
    }
    
}
