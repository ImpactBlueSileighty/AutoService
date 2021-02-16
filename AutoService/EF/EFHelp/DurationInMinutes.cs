namespace AutoService.EF
{
    using System;
    using System.Collections.Generic;

    public partial class Service
    {
        public string DisplayDuration
        {
            get
            {
                if (DurationInSeconds < 60)
                {
                    return $"{DurationInSeconds} seconds";
                }
                else
                {
                    return $"{DurationInMinutes} minutes";
                }
            }
        }
        public int DurationInMinutes
        {
            get
            {
                return DurationInSeconds / 60;
            }
        }
    }
}