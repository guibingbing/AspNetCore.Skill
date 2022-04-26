﻿namespace AspNetCore6.Options.Models
{
    public class MyOptions
    {
        public MyOptions()
        {
            Option1 = "Value set in constructor";
        }
        public string Option1 { get; set; }

        public int Option2 { get; set; } = 5;
    
    }
}
