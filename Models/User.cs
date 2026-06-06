namespace proyectoWebPrueba.Models;

public class User
{
    // Representar un usuarion dentro del sistema
    //Esta clase es lo que vamos a guardar en fs
    
    public string Id { get; set; } = string.Empty;
    public string Fullname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    
    //La contraseña siempre va "incriptada" haschada
    public string PasswordHash { get; set; } = string.Empty;
    
    // Por defecto cada usuario nuevo sera solo user
    public string Role { get; set; } = "user";
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}