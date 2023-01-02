using SerieDLL.Model;

namespace SerieDLL.Interface
{
    internal interface ISerieDAO
    {
        List<Serie> GetByTxt(string txt);
    }
}
