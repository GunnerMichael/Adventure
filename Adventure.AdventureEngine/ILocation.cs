﻿namespace AdventureEngine
{
    public interface ILocation
    {
        string LocationDescription { get; }

        void Look();
    }
}