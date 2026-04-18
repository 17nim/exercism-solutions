class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    internal int ExpectedMinutesInOven() {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    internal int RemainingMinutesInOven(int minutesInOven) {
        return ExpectedMinutesInOven() - minutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    internal int PreparationTimeInMinutes(int layerNumber) {
        return layerNumber * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    internal int ElapsedTimeInMinutes(int layerNumber, int minutesInOven) {
        return PreparationTimeInMinutes(layerNumber) + minutesInOven;
    }
}
