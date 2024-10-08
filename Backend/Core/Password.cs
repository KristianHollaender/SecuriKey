﻿namespace Backend.Core;
public class Password
{
    public Guid Id { get; set; }
    public string EncryptedName { get; set; }
    public string EncryptedPassword { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? Note { get; set; }
    public User? User { get; set; }
    public string UserId { get; set; }
}