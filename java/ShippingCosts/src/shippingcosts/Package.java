/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shippingcosts;

/**
 *
 * @author mccaulcd
 */
public class Package {
    private Double distance;
    private Double weight;

    public Package(double distance, double weight) {
        // initialize distance
        if (distance > 0) {
            this.distance = distance;
        } else {
            this.distance = null; }
        // initialize weight
        if (weight > 0) {
            this.weight = weight;
        } else {
            this.weight = null; }
    }
    
    public void setDistance(double value) {
        if (value > 0)
            distance = value;
        else
            distance = null;
    }
    
    public void setWeight(double value) {
        if (value > 0.0)
            weight = value;
        else
            weight = null;
    }
    
    public Double getDistance() {
        return distance;
    }
    
    public Double getWeight() {
        return weight;
    }

    public double getWeightFactor() {
        if (getWeight() < 10.0)
            return 2.5;
        else if (getWeight() < 25.0)
            return 10.0;
        else
            return 25.0;
    }

    public double getDistanceFactor() {
        if (getDistance() < 100.0)
            return 2.0;
        else if (getDistance() < 500.0)
            return 5.0;
        else
            return 10.0;
    }

    public boolean isValid() {
        return !(distance == null) || !(weight == null);
    }

    public double cost() throws InvalidPackageException {
        if (isValid())
            return getWeightFactor() * getDistanceFactor();
        else
            throw new InvalidPackageException(String.valueOf(distance), String.valueOf(weight));
    }

    public class InvalidPackageException extends Exception {
        public InvalidPackageException(String distance, String weight) {
            super(String.format("Invalid package properties, distance: %s, weight: %s.", distance, weight));
        }
    }
}
