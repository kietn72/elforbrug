﻿namespace Library
{
    public class Measurement
    {
        public int MeterId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public float Value { get; set; }

        public override string ToString()
        {
            return $"{MeterId};{From};{To};{Value}";
        }
    }
}