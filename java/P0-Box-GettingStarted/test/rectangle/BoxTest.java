package rectangle;

import org.junit.Test;
import static org.junit.Assert.*;

public class BoxTest {
    
    public BoxTest() {
    }

    @Test
    public void testPerimeter() {
        System.out.println("perimeter");
        Box instance = new Box(12, 8);
        int expResult = 40;
        int result = instance.perimeter();
        assertEquals(expResult, result);
        
    }

    @Test
    public void testArea() {
        System.out.println("area");
        Box instance = new Box(12, 8);
        int expResult = 96;
        int result = instance.area();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testVolume() {
        System.out.println("volume");
        Box instance = new Box(12, 8, 10);
        int expResult = 960;
        int result = instance.volume();
        assertEquals(expResult, result);
    }
    
}
