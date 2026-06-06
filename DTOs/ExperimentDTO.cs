namespace proyectoWebPrueba.DTOs;

//lo que el frontnetd guarda cuando se crea un experimento
//el UsurID lo vamos a obtener del token (.JNT)
public class ExperimentDTO
{
    public string Title { get; set; } = string.Empty;
    public string Result { get; set; } = string.Empty;
    public bool Success { get; set; } = false;
}