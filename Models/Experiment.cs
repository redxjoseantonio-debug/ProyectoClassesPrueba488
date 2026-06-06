namespace proyectoWebPrueba.Models;

// representa un experimiento de prueba que el usuario realiso
public class Experiment
{
    public string Id { get; set; } = string.Empty;
    
    // titulo con nombre para el experimento
    public string Title { get; set; } = string.Empty;
    
    //resultado o resumen del experimento
    public string Result { get; set; } = string.Empty;
    
    //guardamos el id del usuario que creo el experimento o prueba
    public string UserId { get; set; } = string.Empty;
    
    // Resultado, funciono o no
    public bool Success { get; set; } = false;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
}