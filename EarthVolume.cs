using System;

public class EarthVolume{

	public static void VolumeCalculator(int radiusKm){
		float radiusMiles = radiusKm * 0.621371f;
		double volumeCubicKm = (4.0/3.0) * Math.PI * Math.Pow(radiusKm, 3); //changed 4/3 beacause if we take integers then we may loss some data
		double volumtCubicMiles = (4.0/3.0) * Math.PI * Math.Pow(radiusMiles, 3);
		Console.WriteLine(string.Format("The volume of earth in cubic kilometers is {0} and cubic miles is {1}", volumeCubicKm, volumtCubicMiles));
	}
	
	public static void Main(){
		VolumeCalculator(6378); // called static method without using class name
	}
}