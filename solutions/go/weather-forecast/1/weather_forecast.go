// Package weather provides a program that can forecast the current weather condition of various cities in Goblinocus.
package weather

var (
    // CurrentCondition represents blah blah blah.
	CurrentCondition string
    
    // CurrentLocation represents blah blah blah.
	CurrentLocation  string
)

// Forecast returns blah blah blah.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
