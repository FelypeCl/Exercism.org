class Lasagna
{
    const int EXPECTED_OVEN_TIME = 40;
    const int TIME_PER_LAYER = 2;
    
    public int ExpectedMinutesInOven(){
        return EXPECTED_OVEN_TIME;
    }

    public int RemainingMinutesInOven(int cookingTime){
        return ExpectedMinutesInOven() - cookingTime;
    }

    public int PreparationTimeInMinutes(int lasagnaLayers){
        return lasagnaLayers * TIME_PER_LAYER;
    }

    public int ElapsedTimeInMinutes(int lasagnaLayers, int cookingTime){
        var timeInPreparation = PreparationTimeInMinutes(lasagnaLayers);
        return timeInPreparation + cookingTime;
    }
}
