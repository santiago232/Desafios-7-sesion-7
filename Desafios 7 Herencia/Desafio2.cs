using System;

public interface INotificable
{
    void Notificar();
}

public class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public NotificacionEmail(string direccionCorreo)
    {
        DireccionCorreo = direccionCorreo;
    }

    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por correo electrónico a: {DireccionCorreo}");
    }
}

public class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; set; }

    public NotificacionWhatsapp(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por WhatsApp al número: {NumeroTelefono}");
    }
}

public class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public NotificacionSMS(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por SMS al número: {NumeroTelefono}");
    }
}

class Program
{
    static void Main()
    {
        string correoUsuario = "juan.perez@gmail.com";
        NotificacionEmail notificacionEmail = new NotificacionEmail(correoUsuario);
        notificacionEmail.Notificar();

        string numeroWhatsapp = "+1234567890";
        NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp(numeroWhatsapp);
        notificacionWhatsapp.Notificar();

        string numeroSMS = "+0987654321";
        NotificacionSMS notificacionSMS = new NotificacionSMS(numeroSMS);
        notificacionSMS.Notificar();
    }
}
