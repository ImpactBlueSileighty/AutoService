namespace AutoService.EF
{
    using System;
    using System.Collections.Generic;

    public partial class Service
    {
        public string DataCost
        {
            get
            {
                return Cost.ToString("0.00") + " rub";
            }
        }
    }
}