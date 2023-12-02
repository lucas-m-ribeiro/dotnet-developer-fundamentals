class Aluno : Pessoa
{
    private string _RegistroMatricula;  
    private string _Curso;

    public string getRegistroMatricula()
    {
        return _RegistroMatricula;
    }

    public void setRegistroMatricula(string registroMatricula)
    {
        this._RegistroMatricula = registroMatricula;
    }

    public string getCurso()
    {
        return _Curso;
    }
    public void setCurso(string curso)
    {
        this._Curso = curso;
    }
}