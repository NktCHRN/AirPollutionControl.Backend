﻿namespace AccountService.Domain.Models;
public sealed class RefreshToken
{
    public Guid Id { get; set; }

    public string Token { get; set; } = string.Empty;

    public DateTimeOffset ExpiryTime { get; set; }
}