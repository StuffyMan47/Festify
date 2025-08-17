namespace StoreWeb.Infrastructure.SecurityHeaders;

public class SecurityHeaderSettings
{
    public bool Enable { get; set; }
    public SecurityHeadersList Headers { get; set; } = default!;
}
