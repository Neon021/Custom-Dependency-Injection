﻿namespace DI_Container
{
    public interface IRandomGuidGenerator
    {
        Guid randomguid { get; }
    }

    public class RandomGuidGenerator: IRandomGuidGenerator
    {
        public Guid randomguid { get; } = Guid.NewGuid();
    }
}