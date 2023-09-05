/*
Difference between Factory Method and Abstract Factory.

Factory Method is a single method, and Abstract Factory is an abstract object.


*/


var buildMiniCarInIndia = CarFactory.BuildCar(Locations.INDIA, CarTypes.MINI);

var buildLuxuryCarInGermany = CarFactory.BuildCar(Locations.GERMANY, CarTypes.LUXURY);

var buildMicroCarInChina = CarFactory.BuildCar(Locations.CHINA, CarTypes.MICRO);
