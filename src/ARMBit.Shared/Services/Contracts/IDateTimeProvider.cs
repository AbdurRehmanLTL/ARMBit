﻿namespace ARMBit.Shared.Services.Contracts;

public interface IDateTimeProvider
{
    DateTimeOffset GetCurrentDateTime();
}
