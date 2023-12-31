﻿using DigitalBanking.Common.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.DataModels;

/// <summary>Customer Security Model</summary>
[Table("CustomerSecurity", Schema = "Customer")]
public class CustomerSecurity : AuditableEntity<int>
{
    /// <summary>Gets or sets the customer identifier.</summary>
    /// <value>The customer identifier.</value>
    [ForeignKey("CustomerInformation")]
    public int CustomerId { get; set; }

    /// <summary>Gets or sets the customer information.</summary>
    /// <value>The customer information.</value>
    public CustomerInformation CustomerInformation { get; set; }

    /// <summary>Gets or sets the name of the user.</summary>
    /// <value>The name of the user.</value>
    public string UserName { get; set; }

    /// <summary>Gets or sets the password.</summary>
    /// <value>The password.</value>
    public string Password { get; set; }

    /// <summary>Gets or sets the password salt.</summary>
    /// <value>The password salt.</value>
    public string PasswordSalt { get; set; }

    /// <summary>Gets or sets the security question.</summary>
    /// <value>The security question.</value>
    public string SecurityQuestion { get; set; }

    /// <summary>Gets or sets the security answer.</summary>
    /// <value>The security answer.</value>
    public string SecurityAnswer { get; set; }    

    /// <summary>Gets or sets the last login date time.</summary>
    /// <value>The last login date time.</value>
    public DateTime? LastLoginDateTime { get; set; }

    /// <summary>Gets or sets the failed login attempts.</summary>
    /// <value>The failed login attempts.</value>
    public int FailedLoginAttempts { get; set; }

    /// <summary>Gets or sets the last password changed date time.</summary>
    /// <value>The last password changed date time.</value>
    public DateTime? LastPasswordChangedDateTime { get; set; }

    /// <summary>Gets or sets the last updated date time.</summary>
    /// <value>The last updated date time.</value>
    public DateTime? LastUpdatedDateTime { get; set; }
}
