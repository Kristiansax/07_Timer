using System;
namespace _07_Timer
{
    public class Timer
    {
        public int Minutes;
        public int Hours;
        private int seconds;
        private string StringSeconds;
        private string StringMinutes;
        private string StringHours;
        public int Seconds
        {
            set
            {
                seconds = value;
            }
            get
            {
                return seconds;
            }
        }
        public override string ToString()
        {
            GetHoursMinutesSeconds();
            AddZeroes();

            return (StringHours + ":" + StringMinutes + ":" + StringSeconds);
        }

        private void GetHoursMinutesSeconds()
        {
            while (Seconds > 60)
            {
                //Seconds = Seconds - 60;
                Minutes++;
            }
            while (Minutes > 60)
            {
                //Minutes = Minutes - 60;
                Hours++;
            }
        }

        private void AddZeroes()
        {
            if (Seconds < 10)
                StringSeconds = Convert.ToString("0" + Seconds);
            else
                StringSeconds = Convert.ToString(Seconds);

            if (Minutes < 10)
                StringMinutes = Convert.ToString("0" + Minutes);
            else
                StringMinutes = Convert.ToString(Minutes);

            if (Hours < 10)
                StringHours = Convert.ToString("0" + Hours);
            else
                StringHours = Convert.ToString(Hours);
        }
    }
}