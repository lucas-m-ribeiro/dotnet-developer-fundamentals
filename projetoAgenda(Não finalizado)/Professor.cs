class Professor : Pessoa
{
    private int _numeroRegistro;
    private string _lecionaMateria;

    public int getNumeroRegistro()
    {
        return _numeroRegistro;
    }

    public void setNumeroRegistro(int numeroRegistro)
    {
        this._numeroRegistro = numeroRegistro;
    }
    public string getLecionaMateria()
    {
        return _lecionaMateria;
    }

    public void setLecionaMateria(string lecionaMateria)
    {
        this._lecionaMateria = lecionaMateria;
    }
}