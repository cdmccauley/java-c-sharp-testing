package rectangle;

import org.junit.Test;
import static org.junit.Assert.*;

public class BoxTest {
    
    public BoxTest() {
    }

    @Test
    public void testPerimeter() {
        System.out.println("perimeter");
        
        assertEquals(40, new Box(12, 8).perimeter());
        assertEquals(30, new Box(5, 10).perimeter());
        assertEquals(44, new Box(12, 10).perimeter());
        assertEquals(60, new Box(10, 20).perimeter());
    }

    @Test
    public void testArea() {
        System.out.println("area");
        
        assertEquals(96, new Box(12, 8).area());
        assertEquals(50, new Box(5, 10).area());
        assertEquals(120, new Box(12, 10).area());
        assertEquals(200, new Box(10, 20).area());
    }
    
    @Test
    public void testVolume() {
        System.out.println("volume");
        
        assertEquals(960, new Box(12, 8, 10).volume());
        assertEquals(750, new Box(5, 10, 15).volume());
        assertEquals(1080, new Box(12, 10, 9).volume());
        assertEquals(6000, new Box(10, 20, 30).volume());
    }
    
}
