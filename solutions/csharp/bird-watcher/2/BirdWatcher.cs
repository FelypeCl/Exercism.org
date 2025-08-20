class BirdCount
{
    private int[] birdsPerDay;
    private static int[] birds = {0, 2, 5, 3, 7, 8, 4};

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => birds;

    public int Today()
    {
        var result = 0;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] == birdsPerDay[birdsPerDay.Length - 1]){
                result = birdsPerDay[i];
            }
        }

        return result;
    }

    public void IncrementTodaysCount()
    {
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] == birdsPerDay[birdsPerDay.Length - 1]){
                birdsPerDay[i] = this.Today() + 1;
            }
        }
    }

    public bool HasDayWithoutBirds()
    {
        var result = false;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] == 0){
                result = true;
                break;
            }
        }

        return result;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var result = 0;
        for(int i = 0; i < numberOfDays; i++){
            result += birdsPerDay[i];
        }

        return result;
    }

    public int BusyDays()
    {
        var result = 0;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] >= 5){
                result++;
            }
        }

        return result;
    }
}
