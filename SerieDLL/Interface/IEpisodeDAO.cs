using SerieDLL.Model;

namespace SerieDLL.Interface
{
    public interface IEpisodeDAO
    {
        List<Episode> GetEpisodes(int id);
    }
}
