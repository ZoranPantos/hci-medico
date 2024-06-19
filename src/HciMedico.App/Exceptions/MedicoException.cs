namespace HciMedico.App.Exceptions;

public class MedicoException : Exception
{
    public MedicoException()
    {
    }

    public MedicoException(string message) : base(message)
    {
    }

    public MedicoException(string message, Exception inner) : base(message, inner)
    {
    }
}
