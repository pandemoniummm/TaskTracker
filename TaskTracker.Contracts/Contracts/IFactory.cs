﻿namespace TaskTracker.Contracts.Contracts
{
    public interface IFactory<out T>
    {
        T Create();
    }
}
