/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package leapyear;

import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author mccaulcd
 */
public class LeapYearTest {
    
    public LeapYearTest() {
    }
    
    // isLeapYear
    // numFebDays
    
    @Test
    public void testIsLeapYear() {
        assertEquals(28, LeapYear.numFebDays(2007));
        
        assertEquals(29, LeapYear.numFebDays(2000));
        assertEquals(28, LeapYear.numFebDays(2001));
        assertEquals(29, LeapYear.numFebDays(1904));
        assertEquals(28, LeapYear.numFebDays(1900));
        assertEquals(29, LeapYear.numFebDays(2020));
        assertEquals(28, LeapYear.numFebDays(2015));
        assertEquals(29, LeapYear.numFebDays(2012));
        assertEquals(28, LeapYear.numFebDays(1950));
        assertEquals(29, LeapYear.numFebDays(2004));
        assertEquals(28, LeapYear.numFebDays(2100));
    }
    
    @Test
    public void testNumFebDays() {
        assertFalse(LeapYear.isLeapYear(2007));

        assertTrue(LeapYear.isLeapYear(2000));
        assertTrue(LeapYear.isLeapYear(1904));
        assertTrue(LeapYear.isLeapYear(2020));
        assertTrue(LeapYear.isLeapYear(2012));
        assertTrue(LeapYear.isLeapYear(2004));
        assertFalse(LeapYear.isLeapYear(2001));
        assertFalse(LeapYear.isLeapYear(1900));
        assertFalse(LeapYear.isLeapYear(2015));
        assertFalse(LeapYear.isLeapYear(1950));
        assertFalse(LeapYear.isLeapYear(2100));
    }
}
