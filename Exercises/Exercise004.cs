using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {

            const double GIGA_SECOND = 1E9;
            DateTime addedGigaSeconds;
			addedGigaSeconds = dateTime.AddSeconds(GIGA_SECOND);
            return addedGigaSeconds;
        }
    }
}
