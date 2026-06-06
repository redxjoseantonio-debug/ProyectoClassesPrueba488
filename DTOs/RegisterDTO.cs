namespace proyectoWebPrueba.DTOs;

public class RegisterDTO
{
    // lo que el fronttend o el usuario desde una interfaz va enviar
    // cuando se quiera registrar
    
    public string Fullname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    
    
}