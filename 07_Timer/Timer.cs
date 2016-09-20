using System;
namespace _07_Timer
{
    public class Timer
    {
        public int Minutes;
        public int Hours;
        private int seconds;
        /*private string StringSeconds;
        private string StringMinutes;
        private string StringHours;*/
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
            //AddZeroes();
            return (Padded(Hours) + ":" + Padded(Minutes) + ":" + Padded(Seconds));
        }
        public string Padded(int s)
        {
            return string.Format("{0:00}", s);
        }

        private void GetHoursMinutesSeconds()
        {
            while (Seconds > 60)
            {
                Seconds = Seconds - 60;
                Minutes++;
            }
            while (Minutes > 60)
            {
                Minutes = Minutes - 60;
                Hours++;
            }
        }

        /*private void AddZeroes()
        {
            if (Seconds < 10)
                StringSeconds = ("0" + Seconds);
            else
                StringSeconds = ("" + Seconds);

            if (Minutes < 10)
                StringMinutes = ("0" + Minutes);
            else
                StringMinutes = (""+ Minutes);

            if (Hours < 10)
                StringHours = ("0" + Hours);
            else
                StringHours = ("" + Hours);
        }*/
    }
}